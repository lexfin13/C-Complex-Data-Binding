using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace KomplexVeriBaglama
{
    public partial class Form1 : Form
    {
        ArrayList kaynakVeri = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var kitap = new
            {
                KitapAdi = txtKitapAdi.Text,
                KitapYazari=txtKitapYazari.Text,
                KitapTuru=txtKitapTuru.Text
            };
            kaynakVeri.Add(kitap);
            listeVeri.DataSource=kaynakVeri;
            listeVeri.DisplayMember = "";
            
        }

       
    }
}
