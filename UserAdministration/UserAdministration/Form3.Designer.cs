namespace UserAdministration
{
    partial class FormDelete
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
            this.lblDeleteUser = new System.Windows.Forms.Label();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lblDeleteUserId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDeleteUser
            // 
            this.lblDeleteUser.AutoSize = true;
            this.lblDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDeleteUser.Location = new System.Drawing.Point(118, 35);
            this.lblDeleteUser.Name = "lblDeleteUser";
            this.lblDeleteUser.Size = new System.Drawing.Size(147, 24);
            this.lblDeleteUser.TabIndex = 0;
            this.lblDeleteUser.Text = "Obriši korisnika?";
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Location = new System.Drawing.Point(28, 107);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(126, 54);
            this.btnCloseForm.TabIndex = 1;
            this.btnCloseForm.Text = "ZATVORI";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(219, 107);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(126, 54);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "OBRIŠI";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // lblDeleteUserId
            // 
            this.lblDeleteUserId.AutoSize = true;
            this.lblDeleteUserId.Location = new System.Drawing.Point(165, 59);
            this.lblDeleteUserId.Name = "lblDeleteUserId";
            this.lblDeleteUserId.Size = new System.Drawing.Size(46, 13);
            this.lblDeleteUserId.TabIndex = 3;
            this.lblDeleteUserId.Text = "User_ID";
            this.lblDeleteUserId.Visible = false;
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 218);
            this.Controls.Add(this.lblDeleteUserId);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnCloseForm);
            this.Controls.Add(this.lblDeleteUser);
            this.Name = "FormDelete";
            this.Text = "Brisanje korisnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteUser;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnDeleteUser;
        public System.Windows.Forms.Label lblDeleteUserId;
    }
}