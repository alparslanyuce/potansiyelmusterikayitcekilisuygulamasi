using promosyonTakip.Core.businessLogicService;
using promosyonTakip.Core.entities;
using promosyonTakip.Core.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace promosyonTakip.UI.Musteri
{
    public partial class anaEkran : Form
    {
        potansiyelMusteri data;

        public anaEkran()
        {
            InitializeComponent();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
          GroupBox musteriBilgileri = (GroupBox)  this.Controls["gpMusteriBilgileri"];
            foreach(Control item in musteriBilgileri.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = string.Empty;
                }
                else if(item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            potansiyelMusteriServis servisPotansiyelMusteri = new potansiyelMusteriServis();
            int tcKontrol = servisPotansiyelMusteri.TCSorgula(txtTcKimlikNo.Text);
            if(tcKontrol > 0)
            {
                MessageBox.Show("daha önce kayıt oldunuz", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                data = new potansiyelMusteri();
                data.tcKimlikNumara = txtTcKimlikNo.Text;
                data.isim = txtIsim.Text;
                data.soyisim = txtSoyisim.Text;
                data.dogumTarih = txtDogumTarih.Value;
                data.cinsiyet = ((cinsiyet)cmbCinsiyet.SelectedItem).id;
                data.meslek = txtMeslek.Text;
                data.emailAdres = txtEmail.Text;
                data.emailBildirimOnay = chkepostaOnay.Checked;
                data.telefon = txtTelefon.Text;
                data.telefonBildirimOnay = chkSmsOnay.Checked;
                data.olusturmaTarih = DateTime.Now;
                data.olusturmaMagaza = staticFieldList.magazaID;


                int MusteriKayit = servisPotansiyelMusteri.kayitYeni(data);
                if(MusteriKayit > 0)
                {
                    MessageBox.Show("kayıt işlemi başarılı", "lütfen hediye seçimi yapınız", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    HediyeSecimHazirla();
                }
                else
                {
                    MessageBox.Show("sistemsel hata", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void HediyeSecimHazirla()
        {
            List<promosyonUrun> hediyeUrunListesi = new List<promosyonUrun>();
            promosyonUrunServis servisPromosyon = new promosyonUrunServis();
            hediyeUrunListesi = servisPromosyon.urunListeGetir();
            if(hediyeUrunListesi != null && hediyeUrunListesi.Count > 0)
            {
                for(int i=0; i<hediyeUrunListesi.Count; i++)
                {
                    
                    PictureBox pctBox = new PictureBox();
                    pctBox.Width = 62;
                    pctBox.Height = 67;

                    pctBox.Image = Image.FromFile(@"C:\Users\ASUS\Desktop\csharpprogramlama\Gift-Box-Gold-icon.png");
                    pctBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pctBox.Tag = hediyeUrunListesi[i];
                    pctBox.Click += PctBox_Click;
                    hediyepanel.Controls.Add(pctBox);
                }
            }

            else
            {
                MessageBox.Show("kampanya bitti", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PctBox_Click(object sender, EventArgs e)
        {
            PictureBox secilenHediye = (PictureBox)sender;
            promosyonUrun kazanilanUrun = (promosyonUrun)secilenHediye.Tag;
           
            if(kazanilanUrun != null && kazanilanUrun.id > 0)
            {
                katilimciPromosyonServis servisKatilimci = new katilimciPromosyonServis();
                promosyonUrunServis servisPromosyon = new promosyonUrunServis();
                potansiyelMusteriServis servisPotansiyelMusteri = new potansiyelMusteriServis();

                servisPromosyon.urunKullanildiIsaretle(kazanilanUrun.id);
                servisKatilimci.kayitYeni(new katilimciPromosyon()
                {
                    magazaId = staticFieldList.magazaID,
                    olusturmaTarih = DateTime.Now,
                    promosyonUrunId = kazanilanUrun.id,
                    potansiyelMusteriId = servisPotansiyelMusteri.TCSorgula(txtTcKimlikNo.Text),



                });

                hediyeGoster hediyeGosterFrm = new hediyeGoster(kazanilanUrun);
                hediyeGosterFrm.ShowDialog();


            }

            else
            {
                MessageBox.Show("kampanya bitmiştir", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void anaEkran_Load(object sender, EventArgs e)
        {
            cmbCinsiyet.DataSource = staticFieldList.cinsiyetYukle();
        }
    }
}
