namespace UserAdministration
{
    public partial class FormAddUser
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
            this.lblAddUser = new System.Windows.Forms.Label();
            this.lblAddUserUsername = new System.Windows.Forms.Label();
            this.lblAddUserPassword = new System.Windows.Forms.Label();
            this.lblAddUserName = new System.Windows.Forms.Label();
            this.lblAddUserSurname = new System.Windows.Forms.Label();
            this.inptAddUserUsername = new System.Windows.Forms.TextBox();
            this.inptAddUserPassword = new System.Windows.Forms.TextBox();
            this.inptAddUserName = new System.Windows.Forms.TextBox();
            this.inptAddUserSurname = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.Location = new System.Drawing.Point(102, 29);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(178, 24);
            this.lblAddUser.TabIndex = 0;
            this.lblAddUser.Text = "Dodavanje korisnika";
            // 
            // lblAddUserUsername
            // 
            this.lblAddUserUsername.AutoSize = true;
            this.lblAddUserUsername.Location = new System.Drawing.Point(9, 82);
            this.lblAddUserUsername.Name = "lblAddUserUsername";
            this.lblAddUserUsername.Size = new System.Drawing.Size(55, 13);
            this.lblAddUserUsername.TabIndex = 2;
            this.lblAddUserUsername.Text = "Username";
            // 
            // lblAddUserPassword
            // 
            this.lblAddUserPassword.AutoSize = true;
            this.lblAddUserPassword.Location = new System.Drawing.Point(11, 129);
            this.lblAddUserPassword.Name = "lblAddUserPassword";
            this.lblAddUserPassword.Size = new System.Drawing.Size(53, 13);
            this.lblAddUserPassword.TabIndex = 3;
            this.lblAddUserPassword.Text = "Password";
            // 
            // lblAddUserName
            // 
            this.lblAddUserName.AutoSize = true;
            this.lblAddUserName.Location = new System.Drawing.Point(29, 181);
            this.lblAddUserName.Name = "lblAddUserName";
            this.lblAddUserName.Size = new System.Drawing.Size(35, 13);
            this.lblAddUserName.TabIndex = 4;
            this.lblAddUserName.Text = "Name";
            // 
            // lblAddUserSurname
            // 
            this.lblAddUserSurname.AutoSize = true;
            this.lblAddUserSurname.Location = new System.Drawing.Point(15, 220);
            this.lblAddUserSurname.Name = "lblAddUserSurname";
            this.lblAddUserSurname.Size = new System.Drawing.Size(49, 13);
            this.lblAddUserSurname.TabIndex = 5;
            this.lblAddUserSurname.Text = "Surname";
            // 
            // inptAddUserUsername
            // 
            this.inptAddUserUsername.Location = new System.Drawing.Point(136, 82);
            this.inptAddUserUsername.Name = "inptAddUserUsername";
            this.inptAddUserUsername.Size = new System.Drawing.Size(160, 20);
            this.inptAddUserUsername.TabIndex = 6;
            // 
            // inptAddUserPassword
            // 
            this.inptAddUserPassword.Location = new System.Drawing.Point(136, 129);
            this.inptAddUserPassword.Name = "inptAddUserPassword";
            this.inptAddUserPassword.Size = new System.Drawing.Size(160, 20);
            this.inptAddUserPassword.TabIndex = 7;
            // 
            // inptAddUserName
            // 
            this.inptAddUserName.Location = new System.Drawing.Point(136, 178);
            this.inptAddUserName.Name = "inptAddUserName";
            this.inptAddUserName.Size = new System.Drawing.Size(160, 20);
            this.inptAddUserName.TabIndex = 8;
            // 
            // inptAddUserSurname
            // 
            this.inptAddUserSurname.Location = new System.Drawing.Point(136, 220);
            this.inptAddUserSurname.Name = "inptAddUserSurname";
            this.inptAddUserSurname.Size = new System.Drawing.Size(160, 20);
            this.inptAddUserSurname.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(302, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 91);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 307);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inptAddUserSurname);
            this.Controls.Add(this.inptAddUserName);
            this.Controls.Add(this.inptAddUserPassword);
            this.Controls.Add(this.inptAddUserUsername);
            this.Controls.Add(this.lblAddUserSurname);
            this.Controls.Add(this.lblAddUserName);
            this.Controls.Add(this.lblAddUserPassword);
            this.Controls.Add(this.lblAddUserUsername);
            this.Controls.Add(this.lblAddUser);
            this.Name = "FormAddUser";
            this.Text = "Dodavanje korisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.Label lblAddUserUsername;
        private System.Windows.Forms.Label lblAddUserPassword;
        private System.Windows.Forms.Label lblAddUserName;
        private System.Windows.Forms.Label lblAddUserSurname;
        private System.Windows.Forms.TextBox inptAddUserUsername;
        private System.Windows.Forms.TextBox inptAddUserPassword;
        private System.Windows.Forms.TextBox inptAddUserName;
        private System.Windows.Forms.TextBox inptAddUserSurname;
        private System.Windows.Forms.Button btnAdd;
    }
}