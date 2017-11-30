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

namespace UserAdministration
{
    public partial class FormAddUser : Form
    {
        private readonly Form1 FormUserList;
        public FormAddUser(Form1 FormUser)
        {
            FormUserList = FormUser;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User oUser = new User();
            oUser.sUserName = inptAddUserName.Text;
            oUser.sUserPassword = inptAddUserPassword.Text;
            oUser.sUserFirstName = inptAddUserName.Text;
            oUser.sUserLastName = inptAddUserSurname.Text;
            Crud oCrud = new Crud();
            oCrud.AddUser(oUser);

            this.FormUserList.DataGridViewUsers.DataSource = oCrud.GetUsers();
            this.Hide();
        }
    }
}
