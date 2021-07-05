using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garantiTakip
{
    public partial class GarantiRaporForm : Form
    {
        public GarantiRaporForm()
        {
            InitializeComponent();
        }

       
        private void GarantiRaporForm_Load_1(object sender, EventArgs e)
        {
            GarantiDurumFrm form = new GarantiDurumFrm();


            foreach (var item in form.Getir3())
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
