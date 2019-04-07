namespace BilgeAdam.DirectoryManagement
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.trvDirectory = new System.Windows.Forms.TreeView();
            this.imlIcons = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnNewGroup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelectedMember = new System.Windows.Forms.TextBox();
            this.prgInfo = new System.Windows.Forms.PropertyGrid();
            this.erpValidation = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpValidation)).BeginInit();
            this.SuspendLayout();
            // 
            // trvDirectory
            // 
            this.trvDirectory.ImageIndex = 0;
            this.trvDirectory.ImageList = this.imlIcons;
            this.trvDirectory.Location = new System.Drawing.Point(18, 19);
            this.trvDirectory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trvDirectory.Name = "trvDirectory";
            this.trvDirectory.SelectedImageIndex = 0;
            this.trvDirectory.Size = new System.Drawing.Size(241, 428);
            this.trvDirectory.TabIndex = 0;
            this.trvDirectory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDirectory_AfterSelect);
            // 
            // imlIcons
            // 
            this.imlIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlIcons.ImageStream")));
            this.imlIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlIcons.Images.SetKeyName(0, "home.png");
            this.imlIcons.Images.SetKeyName(1, "user.png");
            this.imlIcons.Images.SetKeyName(2, "group.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSelectedMember);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNewGroup);
            this.groupBox1.Controls.Add(this.btnNewUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Location = new System.Drawing.Point(267, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(389, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Üye Ekle";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(108, 71);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(247, 29);
            this.txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(107, 110);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(112, 61);
            this.btnNewUser.TabIndex = 2;
            this.btnNewUser.Text = "Yeni Kullanıcı";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnNewGroup
            // 
            this.btnNewGroup.Location = new System.Drawing.Point(243, 110);
            this.btnNewGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewGroup.Name = "btnNewGroup";
            this.btnNewGroup.Size = new System.Drawing.Size(112, 61);
            this.btnNewGroup.TabIndex = 3;
            this.btnNewGroup.Text = "Yeni Grup";
            this.btnNewGroup.UseVisualStyleBackColor = true;
            this.btnNewGroup.Click += new System.EventHandler(this.btnNewGroup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seçili Öğe";
            // 
            // txtSelectedMember
            // 
            this.txtSelectedMember.Location = new System.Drawing.Point(108, 32);
            this.txtSelectedMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSelectedMember.Name = "txtSelectedMember";
            this.txtSelectedMember.ReadOnly = true;
            this.txtSelectedMember.Size = new System.Drawing.Size(247, 29);
            this.txtSelectedMember.TabIndex = 5;
            // 
            // prgInfo
            // 
            this.prgInfo.Location = new System.Drawing.Point(267, 213);
            this.prgInfo.Name = "prgInfo";
            this.prgInfo.Size = new System.Drawing.Size(389, 234);
            this.prgInfo.TabIndex = 2;
            // 
            // erpValidation
            // 
            this.erpValidation.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(553, 453);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(455, 453);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(92, 39);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Aç";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 504);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.prgInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.trvDirectory);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Dizin Yöneticisi";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpValidation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvDirectory;
        private System.Windows.Forms.ImageList imlIcons;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNewGroup;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtSelectedMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PropertyGrid prgInfo;
        private System.Windows.Forms.ErrorProvider erpValidation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
    }
}

