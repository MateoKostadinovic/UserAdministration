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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Crud Crud = new Crud();//objekt tipa Crud
            List<User> lUsers = Crud.GetUsers();//lista User
            DataGridViewUsers.DataSource = lUsers;//Popunjavanje data grida   

            //DODAVANJE NOVIH KOLONA
            //Button za uredivanje
            DataGridViewImageColumn oEditButton = new DataGridViewImageColumn();//nova kolona tipa Image
            oEditButton.Image = Image.FromFile("C:\\Fakultet\\Programiranje u .NET okolini\\if_pencil_1608787.png");
            oEditButton.Width = 20;
            oEditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewUsers.Columns.Add(oEditButton);

            //Button za brisanje
            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();//nova kolona tipa Image
            oDeleteButton.Image = Image.FromFile("C:\\Fakultet\\Programiranje u .NET okolini\\if_ic_delete_48px_352303.png");
            oDeleteButton.Width = 20;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewUsers.Columns.Add(oDeleteButton);

            DataGridViewUsers.AutoGenerateColumns = false;//program nece sam stvoriti sve kolone, lijepo ce se posloziti
        }

        private void DataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Pozdrav");
            DataGridViewUsers.Rows[e.RowIndex].Selected = true;//zapamti na kojem smo retku kliknuli gumbic = selektiran
            if (DataGridViewUsers.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                FormEditUser FormEditUser = new FormEditUser(this);//kreira novu formu koja prima objekt tipa Form1 sa pokazivacem this
                //FormEditUser.Show(); prikazat ce formu, ali praznu
                FormEditUser.lblEditUserID.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormEditUser.lblEditUserName.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormEditUser.inptEditPassword.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormEditUser.inptEditName.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                FormEditUser.inptEditSurname.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                FormEditUser.Show();
            }
            if (DataGridViewUsers.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                FormDelete FormDeleteUser = new FormDelete(this);
                FormDeleteUser.lblDeleteUserId.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormDeleteUser.Show();
            }
        }
    }
}
