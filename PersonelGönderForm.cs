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
    public partial class PersonelGönderForm : Form
    {
        stajyerEntities3 db = new stajyerEntities3();

        GarantiDurumFrm Form;
        public PersonelGönderForm(GarantiDurumFrm frm)
        {
            Form = frm;
            InitializeComponent();
        }

        private void PersonelGönderForm_Load(object sender, EventArgs e)
        {
            //garantirapordaki seçilen firmanın adı getirildi textboxa
            int id = Form.Getir2();
            tbl_cari cari = db.tbl_cari.Find(id);
            txtFirma.Text = cari.FIRMAADI;

            
            foreach (var personel in db.tbl_personel)
            {
                if (personel.PERSONELDURUM == false)
                {
                    comboPersoneller.Items.Add(personel.PERSONELAD + " " + personel.PERSONELSOYAD);

                }
                
            }

            
        }

        private void btnPersonelGönder_Click(object sender, EventArgs e)
        {
            int id = Form.Getir2();
            tbl_cari cari = db.tbl_cari.Find(id);
            tbl_personel personel = db.tbl_personel.Where(x => (x.PERSONELAD + " " + x.PERSONELSOYAD) == comboPersoneller.Text).FirstOrDefault();
            int a = personel.IND;

          //  int personelId = Convert.ToInt16(PersonelId.Text);
            



            cari.PERSONELNO = personel.IND;
            db.SaveChanges();
            MessageBox.Show("Personel " + cari.FIRMAADI + " Adlı Firmaya Atandı");
        }
    }
}
