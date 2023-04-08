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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            if (surnameBox.Text == "" || nameBox.Text == "" || loginBox.Text == "" || passBox.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                Random rnd = new Random();
                int schet = rnd.Next(1000, 9999);
                DB db = new DB();
                SqlCommand command = new SqlCommand("INSERT INTO Provider (Familiya, Imya, Tarif, Schet,Money,Login,Password ) VALUES (@fam, @name,@tar,@schet,@mon,@login,@pass)", db.getConnection());

                command.Parameters.Add("@fam", SqlDbType.VarChar).Value = surnameBox.Text;
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = nameBox.Text;
                command.Parameters.Add("@schet", SqlDbType.Int).Value = schet;
                command.Parameters.Add("@login", SqlDbType.VarChar).Value = loginBox.Text;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = passBox.Text;
                command.Parameters.Add("@mon", SqlDbType.VarChar).Value = 0; 
                command.Parameters.Add("@tar", SqlDbType.VarChar).Value = "Не выбран";


                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show($"Аккаунт был создан, ваш номер счёта: {schet}");
                    Avt form = new Avt();
                    this.Hide();
                    form.Show();
                }
                else
                    MessageBox.Show("Аккаунт не был создан");

                db.closeConnection();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Avt form = new Avt();
            this.Hide();
            form.Show();
        }
    }
}
