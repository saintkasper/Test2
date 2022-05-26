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
using System.IO;

namespace ОбувьДэмоУП
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            MainDgw.Rows.Clear();
            DataBank.myConnection.Open();

            SqlCommand command = new SqlCommand("Select * From Product", DataBank.myConnection);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[13]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
                data[data.Count - 1][7] = reader[7].ToString();
                data[data.Count - 1][8] = reader[8].ToString();
                data[data.Count - 1][9] = reader[9].ToString();
                data[data.Count - 1][10] = reader[10].ToString();
                data[data.Count - 1][11] = reader[11].ToString();
                data[data.Count - 1][12] = reader[12].ToString();

            }

            reader.Close();
            DataBank.myConnection.Close();
            foreach (string[] s in data)
            {
                MainDgw.Rows.Add(s);
            }
            populateItems();
        }
        public void populateItems()
        {
            Listitem listitem = new Listitem();
            List<string> pic = new List<string>();
            flowLayoutPanel1.Controls.Clear();
            Listitem[] listitems = new Listitem[MainDgw.RowCount];
            for (int i = 0; i < listitems.Length; i++)
            {
                listitems[i] = new Listitem();
                listitems[i].Title = MainDgw.Rows[i].Cells[1].Value.ToString();
                listitems[i].Description = MainDgw.Rows[i].Cells[2].Value.ToString();
                listitems[i].Manufacturer = MainDgw.Rows[i].Cells[5].Value.ToString();
                listitems[i].Cost = $"Мин. стоимость для агента: {MainDgw.Rows[i].Cells[6].Value.ToString()}";
                listitems[i].Discount = "Скидка: " + MainDgw.Rows[i].Cells[7].Value.ToString() + "%";
                listitems[i].ID = MainDgw.Rows[i].Cells[0].Value.ToString();

                if (MainDgw.Rows[i].Cells[4].Value.ToString().Length == 0)
                {
                    listitems[i].Icon = Image.FromFile(@"..\..\products\picture.png");
                    //listitems[i].Icon = Image.FromFile(@"C:\Users\furuh\source\repos\ОбувьДэмоУП\ОбувьДэмоУП\products\picture.png");
                }
                else if (MainDgw.Rows[i].Cells[4].Value.ToString().Length != 0)
                {
                    listitems[i].Icon = Image.FromFile(@"..\..\products\" + MainDgw.Rows[i].Cells[4].Value.ToString());
                    //listitems[i].Icon = Image.FromFile(@"C:\Users\furuh\source\repos\ОбувьДэмоУП\ОбувьДэмоУП\products\" + MainDgw.Rows[i].Cells[4].Value.ToString());
                }

                if (int.Parse(MainDgw.Rows[i].Cells[7].Value.ToString()) > 15)
                {
                    listitems[i].Color = Color.Chartreuse;
                }
                flowLayoutPanel1.Controls.Add(listitems[i]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                LoadData();
                label2.Text = $"{MainDgw.RowCount} из 30";
                if (radioButton2.Checked)
                {
                    radioButton2_CheckedChanged(sender, e);
                    label2.Text = $"{MainDgw.RowCount} из 30";
                }
                else if (radioButton3.Checked)
                {
                    radioButton3_CheckedChanged(sender, e);
                    label2.Text = $"{MainDgw.RowCount} из 30";
                }
            }
            else
            {
                string[] typetitles = new string[comboBox1.Items.Count];
                for (int i = 0; i < typetitles.Length; i++)
                {
                    typetitles[i] = comboBox1.Items[i].ToString();
                }
                if (comboBox1.SelectedIndex == 0)
                {
                    MainDgw.Rows.Clear();
                    DataBank.myConnection.Open();

                    string query = $"Select * From Product Where ProductDescription Like '%{textBox1.Text}%'";
                    SqlCommand command = new SqlCommand(query, DataBank.myConnection);
                    SqlDataReader reader = command.ExecuteReader();

                    List<string[]> data = new List<string[]>();

                    while (reader.Read())
                    {
                        data.Add(new string[13]);

                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                        data[data.Count - 1][6] = reader[6].ToString();
                        data[data.Count - 1][7] = reader[7].ToString();
                        data[data.Count - 1][8] = reader[8].ToString();
                        data[data.Count - 1][9] = reader[9].ToString();
                        data[data.Count - 1][10] = reader[10].ToString();
                        data[data.Count - 1][11] = reader[11].ToString();
                        data[data.Count - 1][12] = reader[12].ToString();
                    }

                    reader.Close();
                    DataBank.myConnection.Close();
                    foreach (string[] s in data)
                    {
                        MainDgw.Rows.Add(s);
                    }
                    label2.Text = $"{MainDgw.RowCount} из 30";
                    populateItems();
                    if (radioButton2.Checked)
                    {
                        radioButton2_CheckedChanged(sender, e);
                        label2.Text = $"{MainDgw.RowCount} из 30";
                    }
                    else if (radioButton3.Checked)
                    {
                        radioButton3_CheckedChanged(sender, e);
                        label2.Text = $"{MainDgw.RowCount} из 30";
                    }
                }
                else
                {
                    for (int i = 1; i < 8; i++)
                    {
                        if (comboBox1.SelectedIndex == i)
                        {
                            MainDgw.Rows.Clear();
                            DataBank.myConnection.Open();

                            string query = $"Select * From Product Where ProductName = '{typetitles[i]}' and ProductDescription Like '%{textBox1.Text}%'";
                            SqlCommand command = new SqlCommand(query, DataBank.myConnection);
                            SqlDataReader reader = command.ExecuteReader();

                            List<string[]> data = new List<string[]>();

                            while (reader.Read())
                            {
                                data.Add(new string[13]);

                                data[data.Count - 1][0] = reader[0].ToString();
                                data[data.Count - 1][1] = reader[1].ToString();
                                data[data.Count - 1][2] = reader[2].ToString();
                                data[data.Count - 1][3] = reader[3].ToString();
                                data[data.Count - 1][4] = reader[4].ToString();
                                data[data.Count - 1][5] = reader[5].ToString();
                                data[data.Count - 1][6] = reader[6].ToString();
                                data[data.Count - 1][7] = reader[7].ToString();
                                data[data.Count - 1][8] = reader[8].ToString();
                                data[data.Count - 1][9] = reader[9].ToString();
                                data[data.Count - 1][10] = reader[10].ToString();
                                data[data.Count - 1][11] = reader[11].ToString();
                                data[data.Count - 1][12] = reader[12].ToString();
                            }

                            reader.Close();
                            DataBank.myConnection.Close();
                            foreach (string[] s in data)
                            {
                                MainDgw.Rows.Add(s);
                            }
                            label2.Text = $"{MainDgw.RowCount} из 30";
                            populateItems();
                            if (radioButton2.Checked)
                            {
                                radioButton2_CheckedChanged(sender, e);
                                label2.Text = $"{MainDgw.RowCount} из 30";
                            }
                            else if (radioButton3.Checked)
                            {
                                radioButton3_CheckedChanged(sender, e);
                                label2.Text = $"{MainDgw.RowCount} из 30";
                            }
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] typetitles = new string[comboBox1.Items.Count];
            for (int i = 0; i < typetitles.Length; i++)
            {
                typetitles[i] = comboBox1.Items[i].ToString();
            }
            if (comboBox1.SelectedIndex == 0)
            {
                MainDgw.Rows.Clear();
                LoadData();
                label2.Text = $"{MainDgw.RowCount} из 30";
                if (radioButton2.Checked)
                {
                    radioButton2_CheckedChanged(sender, e);
                    label2.Text = $"{MainDgw.RowCount} из 30";
                }
                else if (radioButton3.Checked)
                {
                    radioButton3_CheckedChanged(sender, e);
                    label2.Text = $"{MainDgw.RowCount} из 30";
                }
            }
            else
            {
                for (int i = 1; i < 8; i++)
                {
                    if (comboBox1.SelectedIndex == i)
                    {
                        string text = textBox1.Text;
                        MainDgw.Rows.Clear();
                        DataBank.myConnection.Open();

                        string query = $"Select * From Product Where ProductName = '{typetitles[i]}' and ProductDescription Like '%{text}%'";

                        SqlCommand command = new SqlCommand(query, DataBank.myConnection);
                        SqlDataReader reader = command.ExecuteReader();

                        List<string[]> data = new List<string[]>();

                        while (reader.Read())
                        {
                            data.Add(new string[13]);

                            data[data.Count - 1][0] = reader[0].ToString();
                            data[data.Count - 1][1] = reader[1].ToString();
                            data[data.Count - 1][2] = reader[2].ToString();
                            data[data.Count - 1][3] = reader[3].ToString();
                            data[data.Count - 1][4] = reader[4].ToString();
                            data[data.Count - 1][5] = reader[5].ToString();
                            data[data.Count - 1][6] = reader[6].ToString();
                            data[data.Count - 1][7] = reader[7].ToString();
                            data[data.Count - 1][8] = reader[8].ToString();
                            data[data.Count - 1][9] = reader[9].ToString();
                            data[data.Count - 1][10] = reader[10].ToString();
                            data[data.Count - 1][11] = reader[11].ToString();
                            data[data.Count - 1][12] = reader[12].ToString();
                        }

                        reader.Close();
                        DataBank.myConnection.Close();
                        foreach (string[] s in data)
                        {
                            MainDgw.Rows.Add(s);
                        }
                        label2.Text = $"{MainDgw.RowCount} из 30";
                        populateItems();
                        if (radioButton2.Checked)
                        {
                            radioButton2_CheckedChanged(sender, e);
                            label2.Text = $"{MainDgw.RowCount} из 30";
                        }
                        else if (radioButton3.Checked)
                        {
                            radioButton3_CheckedChanged(sender, e);
                            label2.Text = $"{MainDgw.RowCount} из 30";
                        }
                        break;
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                string text = textBox1.Text;
                string[] typetitles = new string[comboBox1.Items.Count];
                for (int i = 0; i < typetitles.Length; i++)
                {
                    typetitles[i] = comboBox1.Items[i].ToString();
                }

                for (int i = 1; i < 8; i++)
                {
                    if (comboBox1.SelectedIndex == i)
                    {
                        MainDgw.Rows.Clear();
                        DataBank.myConnection.Open();

                        string query = $"Select * From Product Where ProductName = '{typetitles[i]}' and ProductDescription Like '%{text}%'";
                        SqlCommand command = new SqlCommand(query, DataBank.myConnection);
                        SqlDataReader reader = command.ExecuteReader();

                        List<string[]> data = new List<string[]>();

                        while (reader.Read())
                        {
                            data.Add(new string[13]);

                            data[data.Count - 1][0] = reader[0].ToString();
                            data[data.Count - 1][1] = reader[1].ToString();
                            data[data.Count - 1][2] = reader[2].ToString();
                            data[data.Count - 1][3] = reader[3].ToString();
                            data[data.Count - 1][4] = reader[4].ToString();
                            data[data.Count - 1][5] = reader[5].ToString();
                            data[data.Count - 1][6] = reader[6].ToString();
                            data[data.Count - 1][7] = reader[7].ToString();
                            data[data.Count - 1][8] = reader[8].ToString();
                            data[data.Count - 1][9] = reader[9].ToString();
                            data[data.Count - 1][10] = reader[10].ToString();
                            data[data.Count - 1][11] = reader[11].ToString();
                            data[data.Count - 1][12] = reader[12].ToString();
                        }

                        reader.Close();
                        DataBank.myConnection.Close();
                        foreach (string[] s in data)
                        {
                            MainDgw.Rows.Add(s);
                        }
                        label2.Text = $"{MainDgw.RowCount} из 30";
                        populateItems();
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                string text = textBox1.Text;

                MainDgw.Rows.Clear();
                DataBank.myConnection.Open();

                string query = $"Select * From Product Where ProductDescription Like '%{text}%'";
                SqlCommand command = new SqlCommand(query, DataBank.myConnection);
                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[13]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                    data[data.Count - 1][9] = reader[9].ToString();
                    data[data.Count - 1][10] = reader[10].ToString();
                    data[data.Count - 1][11] = reader[11].ToString();
                    data[data.Count - 1][12] = reader[12].ToString();
                }

                reader.Close();
                DataBank.myConnection.Close();
                foreach (string[] s in data)
                {
                    MainDgw.Rows.Add(s);
                }
                label2.Text = $"{MainDgw.RowCount} из 30";
                populateItems();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                string text = textBox1.Text;
                string[] typetitles = new string[comboBox1.Items.Count];
                for (int i = 0; i < typetitles.Length; i++)
                {
                    typetitles[i] = comboBox1.Items[i].ToString();
                }

                for (int i = 1; i < 8; i++)
                {
                    if (comboBox1.SelectedIndex == i)
                    {
                        MainDgw.Rows.Clear();
                        DataBank.myConnection.Open();

                        string query = $"Select * From Product Where ProductName = '{typetitles[i]}' and ProductDescription Like '%{text}%'";
                        SqlCommand command = new SqlCommand(query, DataBank.myConnection);
                        SqlDataReader reader = command.ExecuteReader();

                        List<string[]> data = new List<string[]>();

                        while (reader.Read())
                        {
                            data.Add(new string[13]);

                            data[data.Count - 1][0] = reader[0].ToString();
                            data[data.Count - 1][1] = reader[1].ToString();
                            data[data.Count - 1][2] = reader[2].ToString();
                            data[data.Count - 1][3] = reader[3].ToString();
                            data[data.Count - 1][4] = reader[4].ToString();
                            data[data.Count - 1][5] = reader[5].ToString();
                            data[data.Count - 1][6] = reader[6].ToString();
                            data[data.Count - 1][7] = reader[7].ToString();
                            data[data.Count - 1][8] = reader[8].ToString();
                            data[data.Count - 1][9] = reader[9].ToString();
                            data[data.Count - 1][10] = reader[10].ToString();
                            data[data.Count - 1][11] = reader[11].ToString();
                            data[data.Count - 1][12] = reader[12].ToString();
                        }

                        reader.Close();
                        DataBank.myConnection.Close();
                        foreach (string[] s in data)
                        {
                            MainDgw.Rows.Add(s);
                        }
                        MainDgw.Sort(MainDgw.Columns[2], ListSortDirection.Ascending);
                        label2.Text = $"{MainDgw.RowCount} из 30";
                        populateItems();
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                string text = textBox1.Text;

                MainDgw.Rows.Clear();
                DataBank.myConnection.Open();

                string query = $"Select * From Product Where ProductDescription Like '%{text}%'";
                SqlCommand command = new SqlCommand(query, DataBank.myConnection);
                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[13]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                    data[data.Count - 1][9] = reader[9].ToString();
                    data[data.Count - 1][10] = reader[10].ToString();
                    data[data.Count - 1][11] = reader[11].ToString();
                    data[data.Count - 1][12] = reader[12].ToString();
                }

                reader.Close();
                DataBank.myConnection.Close();
                foreach (string[] s in data)
                {
                    MainDgw.Rows.Add(s);
                }
                MainDgw.Sort(MainDgw.Columns[2], ListSortDirection.Ascending);
                label2.Text = $"{MainDgw.RowCount} из 30";
                populateItems();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                string text = textBox1.Text;
                string[] typetitles = new string[comboBox1.Items.Count];
                for (int i = 0; i < typetitles.Length; i++)
                {
                    typetitles[i] = comboBox1.Items[i].ToString();
                }

                for (int i = 1; i < 8; i++)
                {
                    if (comboBox1.SelectedIndex == i)
                    {
                        MainDgw.Rows.Clear();
                        DataBank.myConnection.Open();

                        string query = $"Select * From Product Where ProductName = '{typetitles[i]}' and ProductDescription Like '%{text}%'";
                        SqlCommand command = new SqlCommand(query, DataBank.myConnection);
                        SqlDataReader reader = command.ExecuteReader();

                        List<string[]> data = new List<string[]>();

                        while (reader.Read())
                        {
                            data.Add(new string[13]);

                            data[data.Count - 1][0] = reader[0].ToString();
                            data[data.Count - 1][1] = reader[1].ToString();
                            data[data.Count - 1][2] = reader[2].ToString();
                            data[data.Count - 1][3] = reader[3].ToString();
                            data[data.Count - 1][4] = reader[4].ToString();
                            data[data.Count - 1][5] = reader[5].ToString();
                            data[data.Count - 1][6] = reader[6].ToString();
                            data[data.Count - 1][7] = reader[7].ToString();
                            data[data.Count - 1][8] = reader[8].ToString();
                            data[data.Count - 1][9] = reader[9].ToString();
                            data[data.Count - 1][10] = reader[10].ToString();
                            data[data.Count - 1][11] = reader[11].ToString();
                            data[data.Count - 1][12] = reader[12].ToString();
                        }

                        reader.Close();
                        DataBank.myConnection.Close();
                        foreach (string[] s in data)
                        {
                            MainDgw.Rows.Add(s);
                        }
                        MainDgw.Sort(MainDgw.Columns[2], ListSortDirection.Descending);
                        label2.Text = $"{MainDgw.RowCount} из 30";
                        populateItems();
                    }
                }
            }
            else if (comboBox1.SelectedIndex == 0)
            {
                string text = textBox1.Text;

                MainDgw.Rows.Clear();
                DataBank.myConnection.Open();

                string query = $"Select * From Product Where ProductDescription Like '%{text}%'";
                SqlCommand command = new SqlCommand(query, DataBank.myConnection);
                SqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[13]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                    data[data.Count - 1][7] = reader[7].ToString();
                    data[data.Count - 1][8] = reader[8].ToString();
                    data[data.Count - 1][9] = reader[9].ToString();
                    data[data.Count - 1][10] = reader[10].ToString();
                    data[data.Count - 1][11] = reader[11].ToString();
                    data[data.Count - 1][12] = reader[12].ToString();
                }

                reader.Close();
                DataBank.myConnection.Close();
                foreach (string[] s in data)
                {
                    MainDgw.Rows.Add(s);
                }
                MainDgw.Sort(MainDgw.Columns[2], ListSortDirection.Descending);
                label2.Text = $"{MainDgw.RowCount} из 30";
                populateItems();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            Close();
            authorization.Show();
        }
    }
}
