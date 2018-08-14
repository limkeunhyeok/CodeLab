using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeLab5
{
    public partial class Form1 : Form
    {
        private UserManager manager = new UserManager();

        public Form1()
        {
            InitializeComponent();

            gridView_users.ColumnCount = 5;
            gridView_users.Columns[0].Name = "UserId";
            gridView_users.Columns[1].Name = "Name";
            gridView_users.Columns[2].Name = "Age";
            gridView_users.Columns[3].Name = "UserCode";
            gridView_users.Columns[4].Name = "Email";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User[] users = manager.GetAllUsers();
            for (int i = 0; i < users.Length; i++)
            {
                DataGridViewRow row = (DataGridViewRow)gridView_users.RowTemplate.Clone();
                row.Cells[0].Value = users[i].UserId;
                row.Cells[1].Value = users[i].Name;
                row.Cells[2].Value = users[i].Age;
                row.Cells[3].Value = users[i].UserCode;
                row.Cells[4].Value = users[i].Email;

                gridView_users.Rows.Add(row);

                MessageBox.Show(i.ToString());
            }
        }
    }
}