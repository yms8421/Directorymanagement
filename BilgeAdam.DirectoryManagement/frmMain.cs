using BilgeAdam.DirectoryManagement.Contracts;
using BilgeAdam.DirectoryManagement.Enums;
using BilgeAdam.DirectoryManagement.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;
using BizimDirectory = BilgeAdam.DirectoryManagement.Models.Directory;

namespace BilgeAdam.DirectoryManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Root = new BizimDirectory("Bilge Adam");
        }
        public BizimDirectory Root { get; set; }
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

            if (trvDirectory.SelectedNode.Tag is IContainer)
            {
                (trvDirectory.SelectedNode.Tag as IContainer).Members.Add(member);
            }
            else
            {
                Root.Members.Add(member);
            }
            
            var node = new TreeNode
            {
                Text = member.UserName,
                ImageIndex = (int)type,
                SelectedImageIndex = (int)type,
                Tag = member
            };
            trvDirectory.SelectedNode.Nodes.Add(node);
            txtUserName.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //var json = JsonConvert.SerializeObject(Root);
            var json = JsonConvert.SerializeObject(Root, Formatting.Indented);
            //File.WriteAllText(@"C:\Code\Bilgeadam.json", json);
            File.WriteAllText(@"Bilgeadam.json", json);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var content = File.ReadAllText("BilgeAdam.json");
            //Root = JsonConvert.DeserializeObject<BizimDirectory>(content);
        }
    }
}
