using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkovljeviProcesi
{
    public partial class PrognoziranjeBrojaKorisnikaForm : Form
    {
        private List<BrojKorisnika> listaBrojaKorisnika = new List<BrojKorisnika>();
        public PrognoziranjeBrojaKorisnikaForm()
        {
            InitializeComponent();
            cmbRazdoblje.Items.Add("2. razdoblje");
            cmbRazdoblje.Items.Add("3. razdoblje");
            cmbRazdoblje.Items.Add("4. razdoblje");
            cmbRazdoblje.Items.Add("5. razdoblje");
            cmbRazdoblje.Items.Add("6. razdoblje");
            cmbRazdoblje.Items.Add("7. razdoblje");
            cmbRazdoblje.Items.Add("8. razdoblje");
            cmbRazdoblje.Items.Add("9. razdoblje");
            cmbRazdoblje.Items.Add("10. razdoblje");

            grbBrojKorisnika.Hide();
            this.Size= new Size(914, 295);
        }
        private void popuniPolja(TextBox prvi, TextBox drugi)
        {
            if (prvi.Text != "")
            {
                if (Int32.TryParse(prvi.Text, out int broj))
                {
                    drugi.Text = prvi.Text;
                }
                else
                {
                    prvi.Text = "";
                    MessageBox.Show("Unijeli ste znak koji nije broj!!!", "Greška kod unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


        private void provjeriIspravnostUnosa(TextBox provjera)
        {
            if (provjera.Text != "")
            {
                int broj;
                if (!Int32.TryParse(provjera.Text, out broj))
                {
                    provjera.Text = "";
                    MessageBox.Show("Unijeli ste znak koji nije broj!!!", "Greška kod unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (broj < 0) {
                    MessageBox.Show("Unijeli ste broj manji od 0!!!", "Greška kod unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void txtNekorisnikaPostaloKorisnici_TextChanged(object sender, EventArgs e)
        {
            provjeriPopunjenostPolja();
            popuniPolja(txtNekorisnikaPostaloKorisnici, txtMatricaNK);
        }

        private void txtNeorisnikaOstaloNekorisnici_TextChanged(object sender, EventArgs e)
        {
            provjeriPopunjenostPolja();
            popuniPolja(txtNeorisnikaOstaloNekorisnici, txtMatricaNN);
        }

        private void txtKorisnikaOstaloKorisnici_TextChanged(object sender, EventArgs e)
        {
            provjeriPopunjenostPolja();
            popuniPolja(txtKorisnikaOstaloKorisnici, txtMatricaKK);
        }

        private void txtKorisnikaPostalNeorisnici_TextChanged(object sender, EventArgs e)
        {
            provjeriPopunjenostPolja();
            popuniPolja(txtKorisnikaPostalNeorisnici, txtMatricaKN);
        }

        private void btnIzracunajMatricuPrijelaznihVrijednosti_Click(object sender, EventArgs e)
        {
            if (txtMatricaKK.Text != "" && txtMatricaKN.Text != "" && txtMatricaNK.Text != "" && txtMatricaNN.Text != "" && txtBrojKorisnika.Text != "" && txtBrojNekorisnika.Text != "") {
                txtMatricaPrijelaznihVrijednostiNN.Text = Math.Round((Double.Parse(txtMatricaNN.Text) / Int32.Parse(txtBrojNekorisnika.Text)), 3).ToString();
                txtMatricaPrijelaznihVrijednostiNK.Text = Math.Round((Double.Parse(txtMatricaNK.Text) / Int32.Parse(txtBrojNekorisnika.Text)), 3).ToString();
                txtMatricaPrijelaznihVrijednostiKN.Text = Math.Round((Double.Parse(txtMatricaKN.Text) / Int32.Parse(txtBrojKorisnika.Text)), 3).ToString();
                txtMatricaPrijelaznihVrijednostiKK.Text = Math.Round((Double.Parse(txtMatricaKK.Text) / Int32.Parse(txtBrojKorisnika.Text)), 3).ToString();
                btnPrognozirajBrojKupaca.Enabled = true;
            }
        }

        private void btnPrognozirajBrojKupaca_Click(object sender, EventArgs e)
        {
            if (txtBrojPotencijalnihKorisnika.Text != "")
            {
                BrojKorisnika brojKorisnika = new BrojKorisnika();
                brojKorisnika.setBrojNekorisnika = Convert.ToInt32((Double.Parse(txtMatricaPrijelaznihVrijednostiNN.Text) * Double.Parse(txtBrojPotencijalnihKorisnika.Text)) + (Double.Parse(txtMatricaPrijelaznihVrijednostiKN.Text) * 0));
                brojKorisnika.setBrojKorisnika = Convert.ToInt32((Double.Parse(txtMatricaPrijelaznihVrijednostiNK.Text) * Double.Parse(txtBrojPotencijalnihKorisnika.Text)) + (Double.Parse(txtMatricaPrijelaznihVrijednostiKK.Text) * 0));
                listaBrojaKorisnika.Add(brojKorisnika);

                for (int i = 0; i < 8; i++) {
                    BrojKorisnika brojKorisnikaNovi = new BrojKorisnika();
                    brojKorisnikaNovi.setBrojKorisnika = Convert.ToInt32((Math.Round(Double.Parse(txtMatricaPrijelaznihVrijednostiNN.Text),3) * listaBrojaKorisnika[i].setBrojNekorisnika) + (Math.Round(Double.Parse(txtMatricaPrijelaznihVrijednostiKN.Text),3) * listaBrojaKorisnika[i].setBrojKorisnika));
                    brojKorisnikaNovi.setBrojNekorisnika = Convert.ToInt32((Math.Round(Double.Parse(txtMatricaPrijelaznihVrijednostiNK.Text),3) * listaBrojaKorisnika[i].setBrojNekorisnika) + (Math.Round(Double.Parse(txtMatricaPrijelaznihVrijednostiKK.Text),3) * listaBrojaKorisnika[i].setBrojKorisnika));
                    listaBrojaKorisnika.Add(brojKorisnikaNovi);
                }
            }
            cmbRazdoblje.SelectedIndex = 0;
            this.Size = new Size(914, 750);
            grbBrojKorisnika.Show();
        }

        private void btnPopuniPodatke_Click(object sender, EventArgs e)
        {
            txtBrojKorisnika.Text = "700";
            txtBrojNekorisnika.Text = "1200";
            txtKorisnikaOstaloKorisnici.Text = "534";
            txtKorisnikaPostalNeorisnici.Text = "166";
            txtNeorisnikaOstaloNekorisnici.Text = "913";
            txtNekorisnikaPostaloKorisnici.Text = "287";
            txtBrojPotencijalnihKorisnika.Text = "12000";
        }

        private void cmbRazdoblje_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNekorisnici.Text = listaBrojaKorisnika[cmbRazdoblje.SelectedIndex].setBrojNekorisnika.ToString();
            txtKorisnici.Text = listaBrojaKorisnika[cmbRazdoblje.SelectedIndex].setBrojKorisnika.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InterpretacijaForm interpretacija = new InterpretacijaForm();
            interpretacija.Text = "Intepretacija";
            RichTextBox richTextBox = (RichTextBox)interpretacija.Controls.Find("rxtIntepretacija", true)[0];
            richTextBox.Clear();
            richTextBox.Text = "Intepretacija za "+cmbRazdoblje.Text+":\n\n";
            richTextBox.Text += "Od potencijalnih "+txtBrojPotencijalnihKorisnika.Text+" korisnika, njih "+txtNekorisnici.Text+" će postati korisnici, dok će preostalih "+txtKorisnici.Text+" ostati nekorisnici  \n\n";
            interpretacija.ShowDialog();
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            txtBrojKorisnika.Text = "";
            txtBrojNekorisnika.Text = "";
            txtBrojPotencijalnihKorisnika.Text = "";

            txtKorisnikaOstaloKorisnici.Text = "";
            txtKorisnikaPostalNeorisnici.Text = "";
            txtNekorisnikaPostaloKorisnici.Text = "";
            txtNeorisnikaOstaloNekorisnici.Text = "";

            txtMatricaKK.Text = "";
            txtMatricaKN.Text = "";
            txtMatricaNK.Text = "";
            txtMatricaNN.Text = "";

            txtMatricaPrijelaznihVrijednostiKK.Text = "";
            txtMatricaPrijelaznihVrijednostiKN.Text = "";
            txtMatricaPrijelaznihVrijednostiNK.Text = "";
            txtMatricaPrijelaznihVrijednostiNN.Text = "";

            txtNekorisnici.Text = "";
            txtKorisnici.Text = "";

            this.Size = new Size(914, 295);
        }

        private void provjeriPopunjenostPolja()
        {
            if (txtBrojKorisnika.Text != "" && txtBrojPotencijalnihKorisnika.Text != "" && txtKorisnikaOstaloKorisnici.Text != ""
             && txtKorisnikaPostalNeorisnici.Text != "" && txtNekorisnikaPostaloKorisnici.Text != "" && txtNeorisnikaOstaloNekorisnici.Text != "") {
                this.Size = new Size(914, 521);
            }
        }

        private void txtBrojKorisnika_TextChanged(object sender, EventArgs e)
        {
            provjeriPopunjenostPolja();
            provjeriIspravnostUnosa(txtBrojKorisnika);
        }

        private void txtBrojNekorisnika_TextChanged(object sender, EventArgs e)
        {
            provjeriPopunjenostPolja();
            provjeriIspravnostUnosa(txtBrojNekorisnika);
        }

        private void txtBrojPotencijalnihKorisnika_TextChanged(object sender, EventArgs e)
        {
            provjeriPopunjenostPolja();
            provjeriIspravnostUnosa(txtBrojPotencijalnihKorisnika);
        }

        private void PrognoziranjeBrojaKorisnikaForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                InterpretacijaForm pomoc = new InterpretacijaForm();
                pomoc.Size = new Size(600, 400);
                pomoc.Text = "Pomoć";
                RichTextBox richTextBox = (RichTextBox)pomoc.Controls.Find("rxtIntepretacija", true)[0];
                richTextBox.Size = new Size(565, 340);
                richTextBox.Clear();

                richTextBox.Text = "Help Center\n\n";
                richTextBox.Text += "Nalazite se u prozoru za prognoziranje broja korisnika, imate 7 mogućnosti:\n\n";
                richTextBox.Text += "1. Klikom na gumb 'Popuni podatke' ispunjavaju se polja sa testnim podacaima\n\n";
                richTextBox.Text += "2. Klikom na gumb 'Očisti polja' brišu se podaci iz svih polja\n\n";
                richTextBox.Text += "3. Unosom svih obaveznih vrijednosti prikazuje se matrica prijelaznih vrijednosti\n\n";
                richTextBox.Text += "4. Klikom na gumb 'Izračunaj matricu prijelaznih vrijednosti' izračunava se matrica prijelaznih vrijednosti\n\n";
                richTextBox.Text += "5. Klikom na gumb 'Prognoziraj broj korinsika' prognozira se broj korisnika za nekoliko sljedećih razdoblja\n\n";
                richTextBox.Text += "6. Klikom na gumb 'Interpretacija' otvara se prozor sa interpretacijom vrijednosti u odabranom razdoblju\n\n";
                richTextBox.Text += "7. Odabirom razdoblja iz padajućeg izbornika prikazuje se prognoza korisnika u tom razdoblju\n\n";


                pomoc.ShowDialog();
            }
        }
    }
}
