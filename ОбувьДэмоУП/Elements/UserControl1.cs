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
    public partial class Listitem : UserControl
    {
        #region Properties
        private string _lid;
        private string _title;
        private string _descritpion;
        private string _manufacturer;
        private string _cost;
        private string _discount;
        private Image _icon;
        private Color _color;

        public Color Color
        {
            get { return _color; }
            set { _color = value; panel1.BackColor = value; }
        }

        public string ID
        {
            get { return _lid; }
            set { _lid = value; lId.Text = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; lTitle.Text = value; }
        }

        public string Description
        {
            get { return _descritpion; }
            set { _descritpion = value; lDescription.Text = value; }
        }
        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; lManufacturer.Text = value; }
        }

        public string Cost
        {
            get { return _cost; }
            set { _cost = value; lCost.Text = value; }
        }

        public string Discount
        {
            get { return _discount ; }
            set { _discount = value; lDiscount.Text = value; }
        }
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }
        #endregion
        public Listitem()
        {
            InitializeComponent();
        }
    }
}
