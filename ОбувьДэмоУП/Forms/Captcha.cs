using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОбувьДэмоУП
{
    public partial class Captcha : Form
    {
        public Captcha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            C1.Text = Convert.ToChar(rnd.Next(65, 91)).ToString();
            C2.Text = Convert.ToChar(rnd.Next(65, 91)).ToString();
            C3.Text = Convert.ToChar(rnd.Next(65, 91)).ToString();
            C4.Text = Convert.ToChar(rnd.Next(65, 91)).ToString();

            label1.Text = C1.Text + C2.Text + C3.Text + C4.Text;

            C1.Font = new Font("Times New Roman", rnd.Next(10, 16), FontStyle.Italic);
            C2.Font = new Font("Times New Roman", rnd.Next(10, 16), FontStyle.Strikeout);
            C3.Font = new Font("Times New Roman", rnd.Next(10, 16), FontStyle.Underline);
            C4.Font = new Font("Times New Roman", rnd.Next(10, 16), FontStyle.Strikeout);

            C1.Location = new Point(115, rnd.Next(54, 83));
            C2.Location = new Point(162, rnd.Next(54, 83));
            C3.Location = new Point(185, rnd.Next(54, 83));
            C4.Location = new Point(232, rnd.Next(54, 83));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToUpper() == label1.Text)
            {
                Authorization authorization = new Authorization();
                Hide();
                authorization.Show();
            }
            else
            {
                MessageBox.Show("Неправильно");
                button1_Click(sender, e);
            }
        }

        private void Capthca_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void Capthca_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
