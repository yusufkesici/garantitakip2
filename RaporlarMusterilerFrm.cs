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
    public partial class RaporlarMusterilerFrm : Form
    {
        public RaporlarMusterilerFrm()
        {
            InitializeComponent();
        }
        stajyerEntities3 db = new stajyerEntities3();
        private void RaporlarMusterilerFrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_Yetkili.Select(x => new
            {
                x.IND,
                x.AD,
                x.SOYAD,
               
                x.TELEFON,
                x.MAIL,
                x.DGMTARİH
            }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adsoyad = textBox1.Text;
            dataGridView1.DataSource = db.tbl_Yetkili.Select(x => new
            {
                x.IND,
                x.AD,
                x.SOYAD,
                x.TELEFON,
                x.MAIL,
                x.DGMTARİH
            }).Where(x =>(x.AD+ " "+x.SOYAD).Contains(adsoyad)).ToList();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbl_Yetkili yetkili = new tbl_Yetkili();
            int id = Convert.ToInt16(txtSil.Text);
            yetkili = db.tbl_Yetkili.Find(id);

            if (yetkili != null)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Yetkili Silinsin mi?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    db.tbl_Yetkili.Remove(yetkili);
                    db.SaveChanges();
                    RaporlarMusterilerFrm_Load(sender, e);
                }
                else
                {
                }
            }
            else
            {
                MessageBox.Show("İd Bulunamadı");
            }
        }
    }
}

