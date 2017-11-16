using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseService;
using System.Diagnostics;

namespace UserAdministration
{
    public partial class FormEditUser : Form
    {
        private readonly Form1 FormUserList;//objekt tipa Form1
        public FormEditUser(Form1 FormUsers)//kontstruktor Form2 sa parametrom objekt iz Form1
        {
            FormUserList = FormUsers;//konstruktor atributi
            InitializeComponent();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            Trace.WriteLine(inptEditName.Text);
            User oUser = new User();
            oUser.nUserID = Int32.Parse(lblEditUserID.Text);
            oUser.sUserFirstName = inptEditName.Text;
            oUser.sUserLastName = inptEditSurname.Text;
            oUser.sUserPassword = inptEditPassword.Text;
            oUser.sUserName = lblEditUserName.Text;
            Crud Crud = new Crud();
            Crud.UpdateUser(oUser);

            this.FormUserList.DataGridViewUsers.DataSource = Crud.GetUsers();
            this.Hide();

        }
    }
}
