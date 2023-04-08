using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Интернет_провайдер
{
    public partial class Avt : Form
    {
        public Avt()
        {
            InitializeComponent();
        }

        private void avtBox_Click(object sender, EventArgs e)
        {
            if (loginBox.Text == "" || passBox.Text == "")
            {
                MessageBox.Show("Заполните поля");
            }
            else
            {


                DB db = new DB();

                DataTable table = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter();
                Program.chet = Convert.ToInt32(loginBox.Text);

                SqlCommand command = new SqlCommand("SELECT * FROM Provider WHERE Schet = @login AND Password = @pass", db.getConnection());
                command.Parameters.Add("@login", SqlDbType.VarChar).Value = Program.chet;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = passBox.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    Main f = new Main();
                    f.Show();
                }

                else
                    MessageBox.Show("Неверный номер счёта или пин-код");
            }
        }
    }
}
