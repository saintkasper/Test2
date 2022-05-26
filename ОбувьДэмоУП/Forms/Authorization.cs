using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОбувьДэмоУП
{
    public partial class Authorization : Form
    {
        int d = 0;
        DataTable Table = new DataTable();
        public Authorization()
        {
            InitializeComponent();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT [UserID], [UserLogin], [UserPassword], [UserRole] FROM [User]", DataBank.myConnection);
            Adapter.Fill(Table);
        }

        private void button1_Click(object sender, EventArgs e) // Войти
        {
            for (int i = 0; i < Table.Rows.Count; i++)
            {
                if (textBox1.Text == Table.Rows[i][1].ToString() && textBox2.Text == Table.Rows[i][2].ToString())
                {
                    if (Table.Rows[i][3].ToString() == "1")
                    {
                        Main form1 = new Main();
                        Listitem listitem1 = new Listitem();
                        listitem1.contextMenuStrip1.Visible = true;
                        form1.btnAdd.Visible = true;
                        form1.btnEdit.Visible = true;
                        form1.btnDelete.Visible = true;
                        textBox1.Text = "";
                        textBox2.Text = "";
                        Hide();
                        form1.Show();
                        break;
                    }
                    else if (Table.Rows[i][3].ToString() == "2")
                    {
                        MessageBox.Show("Вы менеджер");
                        break;
                    }
                    else if (Table.Rows[i][3].ToString() == "3")
                    {
                        MessageBox.Show("Вы клиент");
                        break;
                    }
                }
                if (d == 2)
                {
                    Captcha captcha = new Captcha();
                    Hide();
                    captcha.Show();
                    break;
                }
                if (i == Table.Rows.Count - 1)
                {
                    MessageBox.Show("Что-то не то!");
                    d++;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e) // Войти как гость
        {
            Main form1 = new Main();
            DataBank.ContextMen = 1;
            Hide();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e) // Быстрый вход
        {
            Main form1 = new Main();
            Listitem listitem1 = new Listitem();
            listitem1.contextMenuStrip1.Visible = true;
            form1.btnAdd.Visible = true;
            form1.btnEdit.Visible = true;
            form1.btnDelete.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            Hide();
            form1.Show();
        }
    }
}
