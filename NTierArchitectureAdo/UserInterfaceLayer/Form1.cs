using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using EntityLayer;

namespace UserInterfaceLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Cars c = new Cars();
            c.Brand = txtBrand.Text;
            c.Model = txtModel.Text;
            c.KapiSayisi = Convert.ToInt32(txtKapiSayisi.Text);

            CarRepository cr = new CarRepository();
            cr.InsertCar(c);
        }
    }
}
