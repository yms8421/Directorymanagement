using BilgeAdam.DirectoryManagement.Contracts;
using BilgeAdam.DirectoryManagement.Enums;
using BilgeAdam.DirectoryManagement.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SelfDirectory = BilgeAdam.DirectoryManagement.Models.Directory;

namespace BilgeAdam.DirectoryManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Root = new SelfDirectory("Bilge Adam");
        }
        public SelfDirectory Root { get; set; }
        private void frmMain_Load(object sender, EventArgs e)
        {
            var root = new TreeNode
            {
                Text = Root.Title,
                Tag = Root
            };
            trvDirectory.Nodes.Add(root);
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            CreateMember<User>(PrincipleType.User);
        }

        private void btnNewGroup_Click(object sender, EventArgs e)
        {
            CreateMember<Group>(PrincipleType.Group);
        }

        private void trvDirectory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtSelectedMember.Text = e.Node.Text;
            prgInfo.SelectedObject = e.Node.Tag;
            if (!(e.Node.Tag is IContainer))
            {
                btnNewUser.Enabled = false;
                btnNewGroup.Enabled = false;
            }
            else
            {
                btnNewUser.Enabled = true;
                btnNewGroup.Enabled = true;
            }
        }

        private void CreateMember<T>(PrincipleType type) where T: IPrinciple
        {
            erpValidation.Clear();
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                erpValidation.SetError(txtUserName, "Kullanıcı adı zorunludur");
                return;
            }
            var member = Activator.CreateInstance<T>();
            member.UserName = txtUserName.Text;
            var node = new TreeNode
            {
                Text = member.UserName,
                ImageIndex = (int)type,
                SelectedImageIndex = (int)type,
                Tag = member
            };

            if (trvDirectory.SelectedNode.Tag is IContainer)
            {
                (trvDirectory.SelectedNode.Tag as IContainer).Members.Add(member);
                trvDirectory.SelectedNode.Nodes.Add(node);
            }
            else
            {
                Root.Members.Add(member);
                trvDirectory.Nodes.Add(node);
            }
            txtUserName.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                NullValueHandling = NullValueHandling.Ignore,
                //Formatting = Formatting.Indented
            };
            var json = JsonConvert.SerializeObject(Root, settings);
            //File.WriteAllText(@"C:\Code\can.json", json);
            //File.WriteAllText(@"bilgeadam.json", json, Encoding.GetEncoding(1055));

            File.WriteAllText(@"bilgeadam.json", json);
            //Encoding Nedir?

            MessageBox.Show("Veriler Kaydedildi", "Bildirim Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var json = File.ReadAllText("bilgeadam.json");
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.Indented
            };
            Root = JsonConvert.DeserializeObject<SelfDirectory>(json, settings);
            MapRootToControl();
        }

        private void MapRootToControl()
        {
            trvDirectory.Nodes.Clear();
            var root = new TreeNode
            {
                Text = Root.Title,
                ImageIndex = (int)PrincipleType.Root,
                Tag = Root
            };
            trvDirectory.Nodes.Add(root);
            MapNodes(root);
            trvDirectory.ExpandAll();
        }

        private void MapNodes(TreeNode parent)
        {
            if (parent.Tag is IContainer)
            {
                var p = (parent.Tag as IContainer);
                foreach (var c in p.Members)
                {
                    var childNode = new TreeNode
                    {
                        Text = c.UserName,
                        Tag = c
                    };
                    if (c is IContainer)
                    {
                        childNode.ImageIndex = (int)PrincipleType.Group;
                        childNode.SelectedImageIndex = (int)PrincipleType.Group;
                        MapNodes(childNode);
                    }
                    else 
                    {
                        childNode.ImageIndex = (int)PrincipleType.User;
                        childNode.SelectedImageIndex = (int)PrincipleType.User;
                    }
                    parent.Nodes.Add(childNode);
                }
            }
        }
    }
}
