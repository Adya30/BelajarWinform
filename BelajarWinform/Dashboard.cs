using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BelajarWinform
{
    public partial class Dashboard : Form
    {
        private string username;
        private List<User> listUser;
        public Dashboard(string username)
        {
            InitializeComponent();
            this.username = username;
            LabelDashboard.Text += $" {this.username}";
            this.StartPosition = FormStartPosition.CenterScreen;
            DgUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.listUser = generateData(); //untuk inisial bahwa variable listUser akan ditaruh di method generateData
            DgUser.DataSource = listUser; //untuk menyimpan data dari listUser ke tampilan data gridview
        }

        public List<User> generateData() //method list untuk datagridview
        {
            List<User> listUser = new List<User>();
            for (int i=0; i < 5; i++)
            {
                User user = new User($"Adya {i}", 20, "Banyuwangi");
                listUser.Add(user);
            }
            return listUser;
        }
    }
}
