using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XodimlarBazasi.Models;

namespace XodimlarBazasi
{
    public partial class Xodimlar : Form
    {
        AppDbContext Baza;
        public Xodimlar()
        {
            InitializeComponent();
            Baza = new AppDbContext();
            //GridBaza.Columns[0].Width = 12;
            /*
            Xodim xodim = new Xodim()
            {
                Fio = "Azizov Aziz Azizovich",
                Passport = "AB1234567",
                TugilganSana = new DateTime(1985, 12, 10),
                Malumoti = "Oliy",
                Mutaxasssislik = "Iqtisodchi",
                Manzil = "Toshkent sh, Chilonzor t, 19-mavze, 4/5",
                KirganSana = new DateTime(2015, 4, 18)
            };

            Baza.Xodimlar.Add(xodim);
            Baza.SaveChanges();*/
            GetAllData();
        }

        public async void GetAllData()
        {
            GridBaza.DataSource = await Baza.Xodimlar.ToListAsync();
        }

        private void UpdateCheckBox_Click(object sender, EventArgs e)
        {
            if (UpdateCheckBox.Checked)
            {
                IdOlish.Enabled = true;
                OlishBtn.Enabled = true;
                TahrirlashBtn.Enabled = true;
                OchirishBtn.Enabled = true;
                QoshishBtn.Enabled = false;
            }
            else
            {
                IdOlish.Enabled = false;
                OlishBtn.Enabled = false;
                TahrirlashBtn.Enabled = false;
                OchirishBtn.Enabled = false;
                QoshishBtn.Enabled = true;
            }
        }

        private void QoshishBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Xodim xodim = new Xodim()
                {
                    Fio = (Fio.Text).ToString(),
                    Manzil = (Manzil.Text).ToString(),
                    Passport = (Passport.Text).ToString(),
                    KirganSana = KirganSana.Value,
                    Mutaxasssislik = (Mutaxassislik.Text).ToString(),
                    Malumoti = (Malumoti.Text).ToString(),
                    TugilganSana = TugilganSana.Value,
                };

                Baza.Xodimlar.Add(xodim);
                Baza.SaveChanges();

                Fio.Text = string.Empty;
                Manzil.Text = string.Empty;
                Passport.Text = string.Empty;
                Mutaxassislik.Text = string.Empty;
                Malumoti.Text = string.Empty;
                KirganSana.Text = string.Empty;
                TugilganSana.Text = string.Empty;
                GetAllData();
            }
            catch (Exception) { }
        }

        private async void OlishBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(IdOlish.Text);
                var xodim = await Baza.Xodimlar.FirstOrDefaultAsync(p => p.Id == Id);
                Fio.Text = xodim.Fio;
                Manzil.Text = xodim.Manzil;
                TugilganSana.Value = xodim.TugilganSana;
                Mutaxassislik.Text = xodim.Mutaxasssislik;
                Malumoti.Text = xodim.Malumoti;
                Passport.Text = xodim.Passport;
                KirganSana.Value = xodim.KirganSana;
            }
            catch (Exception) { }
        }

        private async void TahrirlashBtn_Click(object sender, EventArgs e)
        {
            Xodim xodim = new Xodim()
            {
                Id = int.Parse(IdOlish.Text), 
                Fio = (Fio.Text).ToString(),
                Manzil = (Manzil.Text).ToString(),
                Passport = (Passport.Text).ToString(),
                KirganSana = KirganSana.Value,
                Mutaxasssislik = (Mutaxassislik.Text).ToString(),
                Malumoti = (Malumoti.Text).ToString(),
                TugilganSana = TugilganSana.Value,
            };

            var uxodim = await Baza.Xodimlar.FirstOrDefaultAsync(p => p.Id == xodim.Id);
            Baza.Entry(uxodim).CurrentValues.SetValues(xodim);
            await Baza.SaveChangesAsync();
            GetAllData();

            IdOlish.Text = String.Empty;
            Fio.Text = string.Empty;
            Manzil.Text = string.Empty;
            Passport.Text = string.Empty;
            Mutaxassislik.Text = string.Empty;
            Malumoti.Text = string.Empty;
            KirganSana.Text = string.Empty;
            TugilganSana.Text = string.Empty;
        }

        private async void OchirishBtn_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(IdOlish.Text);
            var xodim = await Baza.Xodimlar.FirstOrDefaultAsync(p => p.Id == Id);
            Baza.Xodimlar.Remove(xodim);
            await Baza.SaveChangesAsync();
            GetAllData();

            IdOlish.Text = string.Empty;
            Fio.Text = string.Empty;
            Manzil.Text = string.Empty;
            Passport.Text = string.Empty;
            Mutaxassislik.Text = string.Empty;
            Malumoti.Text = string.Empty;
            KirganSana.Text = string.Empty;
            TugilganSana.Text = string.Empty;
        }

        private async void QidirishBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fio = QidirishTxtBox.Text;
                var natija = await Baza.Xodimlar.Where(p => p.Fio.Contains(fio)).ToListAsync();
                GridBaza.DataSource = natija;
            }
            catch (Exception) { }
        }

        private void Yangilash_Click(object sender, EventArgs e)
        {
            QidirishTxtBox.Text = string.Empty;
            GetAllData();
        }
    }
}
