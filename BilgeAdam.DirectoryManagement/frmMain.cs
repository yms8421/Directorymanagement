using BilgeAdam.DirectoryManagement.Contracts;
using BilgeAdam.DirectoryManagement.Enums;
using BilgeAdam.DirectoryManagement.Models;
using System;
using System.Windows.Forms;

namespace BilgeAdam.DirectoryManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Root = new Directory("Bilge Adam");
        }
        public Directory Root { get; set; }
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
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
        }
    }
}
