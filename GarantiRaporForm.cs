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
        MDIParent1 Form;
        public GarantiRaporForm(MDIParent1 frm)
        {
            Form = frm;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            

            
            Form.garantiVeHizmetToolStripMenuItem_Click(sender, e);

            this.Hide();
        }
    }
}
