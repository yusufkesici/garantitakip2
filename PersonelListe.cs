﻿using System;
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
    public partial class PersonelListe : Form
    {
        public PersonelListe()
        {
            InitializeComponent();
        }
        stajyerEntities3 db = new stajyerEntities3();
        private void PersonelListe_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_cari.Select(x => new
            {
                x.FIRMAADI,
                x.PERSONELNO,
                x.tbl_personel.PERSONELAD,
                x.tbl_personel.PERSONELSOYAD,
                x.tbl_personel.PERSONELTEL,
                x.tbl_personel.PERSONELMAİL,
                x.tbl_personel.PERSONELDURUM, 
                x.tbl_yorum.YORUM
            }).ToList();

        }
    }
}
