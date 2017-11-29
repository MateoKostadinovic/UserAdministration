using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DatabaseService;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;

namespace UserAdministration
{
    public partial class FormDelete : Form
    {
        private readonly Form1 FormUserList;
        public FormDelete(Form1 FormUsers)
        {
            FormUserList = FormUsers;
            InitializeComponent();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int nId = Int32.Parse(lblDeleteUserId.Text);
            Trace.WriteLine(nId);
            Crud oCrud = new Crud();
            //oCrud.DeleteUser(nId);
            

            this.FormUserList.DataGridViewUsers.DataSource = oCrud.GetUsers();
            this.Hide();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
