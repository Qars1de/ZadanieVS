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
    public partial class Tarifi : Form
    {
        public Tarifi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (tarifiBox.Text == "Выберите тариф")
            {
                MessageBox.Show("Тариф выбран неверно");
            }
            else
            {


                if (tarifiBox.Text == "Интернет")
                {
                    if (tarifiBox.Text == Program.tarifName)
                    {
                        MessageBox.Show("Вы ужеподключены к данному тарифу");
                        DialogResult = DialogResult.Cancel;
                    }
                    else if (Program.kolvo < Program.TarifInet)
                    {
                        MessageBox.Show("Недостаточно средств на счету");
                        DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        DB db = new DB();

                        DataTable table = new DataTable();
                        SqlCommand command = new SqlCommand("update Provider set Money = Money - '" + Program.TarifInet + "' where  Schet='" + Program.chet + "'", db.getConnection());


                        db.openConnection();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        command.ExecuteNonQuery();
                        DialogResult = DialogResult.OK;
                    }
                }
                if (tarifiBox.Text == "ТВ")
                {
                    if (tarifiBox.Text == Program.tarifName)
                    {
                        MessageBox.Show("Вы ужеподключены к данному тарифу");
                        DialogResult = DialogResult.Cancel;
                    }
                    else if (Program.kolvo < Program.tarifTV)
                    {
                        MessageBox.Show("Недостаточно средств на счету");
                        DialogResult = DialogResult.Cancel;
                    }
                    else
                    {

                        DB db = new DB();

                        DataTable table = new DataTable();
                        SqlCommand command = new SqlCommand("update Provider set Money = Money - '" + Program.tarifTV + "' where  Schet='" + Program.chet + "'", db.getConnection());


                        db.openConnection();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        command.ExecuteNonQuery();
                        DialogResult = DialogResult.OK;
                    }
                }
                if (tarifiBox.Text == "Интернет+ТВ")
                {
                    if (tarifiBox.Text == Program.tarifName)
                    {
                        MessageBox.Show("Вы ужеподключены к данному тарифу");
                        DialogResult = DialogResult.Cancel;
                    }
                    else if (Program.kolvo < Program.TarifTvInet)
                    {
                        MessageBox.Show("Недостаточно средств на счету");
                        DialogResult = DialogResult.Cancel;
                    }
                    else
                    {
                        DB db = new DB();

                        DataTable table = new DataTable();
                        SqlCommand command = new SqlCommand("update Provider set Money = Money - '" + Program.TarifTvInet + "' where  Schet='" + Program.chet + "'", db.getConnection());


                        db.openConnection();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        command.ExecuteNonQuery();
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tarifiBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
