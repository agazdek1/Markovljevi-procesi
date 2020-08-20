using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarkovljeviProcesi
{
    public partial class PredvidanjeKoristenjaUslugaForm : Form
    {
        public PredvidanjeKoristenjaUslugaForm()
        {
            InitializeComponent();
            cmbRazdoblja.Items.Add("1. razdoblje");
            cmbRazdoblja.Items.Add("2. razdoblje");
            cmbRazdoblja.Items.Add("3. razdoblje");
            cmbRazdoblja.Items.Add("4. razdoblje");
            cmbRazdoblja.Items.Add("5. razdoblje");
            cmbRazdoblja.Items.Add("6. razdoblje");
            cmbRazdoblja.Items.Add("7. razdoblje");
            cmbRazdoblja.Items.Add("8. razdoblje");
            cmbRazdoblja.Items.Add("9. razdoblje");
            cmbRazdoblja.Items.Add("Stabilno stanje");

            cmbInterpretacija.Items.Add("1. stupac");
            cmbInterpretacija.Items.Add("2. stupac");
            cmbInterpretacija.Items.Add("3. stupac");
            cmbInterpretacija.Items.Add("1. redak");
            cmbInterpretacija.Items.Add("2. redak");
            cmbInterpretacija.Items.Add("3. redak");
            this.Size = new Size(1030, 300);

        }

        private List<Struktura> listaStrukturi = new List<Struktura>();

        private void txtSmanjenjeBA_TextChanged(object sender, EventArgs e)
        {
            popuniSuprotnoPolje(txtSmanjenjeBA, txtPovecanjeAB);
            provjeriPopunjenostPolja();
            popuniVjerneKorisnikeB();
        }

        private void txtSmanjenjeCA_TextChanged(object sender, EventArgs e)
        {
            popuniSuprotnoPolje(txtSmanjenjeCA, txtPovecanjeAC);
            provjeriPopunjenostPolja();
            popuniVjerneKorisnikeC();
        }

        private void txtSmanjenjeCB_TextChanged(object sender, EventArgs e)
        {
            popuniSuprotnoPolje(txtSmanjenjeCB, txtPovecanjeBC);
            provjeriPopunjenostPolja();
            popuniVjerneKorisnikeC();
        }

        private void txtSmanjenjeBC_TextChanged(object sender, EventArgs e)
        {
            popuniSuprotnoPolje(txtSmanjenjeBC, txtPovecanjeCB);
            provjeriPopunjenostPolja();
            popuniVjerneKorisnikeB();
        }

        private void txtSmanjenjeAC_TextChanged(object sender, EventArgs e)
        {
            popuniSuprotnoPolje(txtSmanjenjeAC, txtPovecanjeCA);
            provjeriPopunjenostPolja();
            popuniVjerneKorisnikeA();
        }

        private void txtSmanjenjeAB_TextChanged(object sender, EventArgs e)
        {
            popuniSuprotnoPolje(txtSmanjenjeAB, txtPovecanjeBA);
            provjeriPopunjenostPolja();
            popuniVjerneKorisnikeA();
        }

        private void txtPovecanjeBA_TextChanged(object sender, EventArgs e)
        {
            popuniSuprotnoPolje(txtPovecanjeBA, txtSmanjenjeAB);
            provjeriPopunjenostPolja();
            popuniSljedeceRazdobljeB();
        }

        private void txtPovecanjeCA_TextChanged(object sender, EventArgs e)
        {
            popuniSuprotnoPolje(txtPovecanjeCA, txtSmanjenjeAC);
            provjeriPopunjenostPolja();
            popuniSljedeceRazdobljeC();
        }

        private void txtPovecanjeCB_TextChanged(object sender, EventArgs e)
        {
            popuniSuprotnoPolje(txtPovecanjeCB, txtSmanjenjeBC);
            provjeriPopunjenostPolja();
            popuniSljedeceRazdobljeC();
        }

        private void txtPovecanjeBC_TextChanged(object sender, EventArgs e)
        {
            popuniSuprotnoPolje(txtPovecanjeBC, txtSmanjenjeCB);
            provjeriPopunjenostPolja();
            popuniSljedeceRazdobljeB();
        }

        private void txtPovecanjeAC_TextChanged(object sender, EventArgs e)
        {
            popuniSuprotnoPolje(txtPovecanjeAC, txtSmanjenjeCA);
            provjeriPopunjenostPolja();
            popuniSljedeceRazdobljeA();
        }

        private void txtPovecanjeAB_TextChanged(object sender, EventArgs e)
        {
            popuniSuprotnoPolje(txtPovecanjeAB, txtSmanjenjeBA);
            provjeriPopunjenostPolja();
            popuniSljedeceRazdobljeA();
        }
        private void txtUslugaA_TextChanged(object sender, EventArgs e)
        {
            provjeriPopunjenostPolja();
        }

        private void txtUslugaB_TextChanged(object sender, EventArgs e)
        {
            provjeriPopunjenostPolja();
        }

        private void txtUslugaC_TextChanged(object sender, EventArgs e)
        {
            provjeriPopunjenostPolja();
        }

        private void txtPrethodnoRazdobljeA_TextChanged(object sender, EventArgs e)
        {
            provjeriPopunjenostPolja();
            popuniVjerneKorisnikeA();
            provjeriIspravnostUnosa(txtPrethodnoRazdobljeA);
        }

        private void txtPrethodnoRazdobljeB_TextChanged(object sender, EventArgs e)
        {
            provjeriPopunjenostPolja();
            popuniVjerneKorisnikeB();
            provjeriIspravnostUnosa(txtPrethodnoRazdobljeB);
        }

        private void txtPrethodnoRazdobljeC_TextChanged(object sender, EventArgs e)
        {
            provjeriPopunjenostPolja();
            popuniVjerneKorisnikeC();
            provjeriIspravnostUnosa(txtPrethodnoRazdobljeC);
        }

        private void popuniSuprotnoPolje(TextBox prvi, TextBox drugi)
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
                else if (broj < 0)
                {
                    MessageBox.Show("Unijeli ste broj manji od 0!!!", "Greška kod unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnPostaviZadatak_Click(object sender, EventArgs e)
        {
            txtPrethodnoRazdobljeA.Text = "232";
            txtPrethodnoRazdobljeB.Text = "163";
            txtPrethodnoRazdobljeC.Text = "57";

            txtSmanjenjeAB.Text = "39";
            txtSmanjenjeAC.Text = "21";
            txtSmanjenjeBA.Text = "28";
            txtSmanjenjeCA.Text = "6";
            txtSmanjenjeCB.Text = "11";
            txtSmanjenjeBC.Text = "23";

            txtVjerniKorisniciA.Text = (Int32.Parse(txtPrethodnoRazdobljeA.Text) - Int32.Parse(txtSmanjenjeAB.Text) - Int32.Parse(txtSmanjenjeAC.Text)).ToString();
            txtVjerniKorisniciB.Text = (Int32.Parse(txtPrethodnoRazdobljeB.Text) - Int32.Parse(txtSmanjenjeBA.Text) - Int32.Parse(txtSmanjenjeBC.Text)).ToString();
            txtVjerniKorisniciC.Text = (Int32.Parse(txtPrethodnoRazdobljeC.Text) - Int32.Parse(txtSmanjenjeCA.Text) - Int32.Parse(txtSmanjenjeCB.Text)).ToString();

            txtSljedeceRazdobljeA.Text = (Int32.Parse(txtVjerniKorisniciA.Text) + Int32.Parse(txtPovecanjeAB.Text) + Int32.Parse(txtPovecanjeAC.Text)).ToString();
            txtSljedeceRazdobljeB.Text = (Int32.Parse(txtVjerniKorisniciB.Text) + Int32.Parse(txtPovecanjeBA.Text) + Int32.Parse(txtPovecanjeBC.Text)).ToString();
            txtSljedeceRazdobljeC.Text = (Int32.Parse(txtVjerniKorisniciC.Text) + Int32.Parse(txtPovecanjeCA.Text) + Int32.Parse(txtPovecanjeCB.Text)).ToString();

            txtUslugaA.Text = "A";
            txtUslugaB.Text = "B";
            txtUslugaC.Text = "C";
            btnIzracunajMPV.Enabled = true;
            
        }

        private void txtOcistiPolja_Click(object sender, EventArgs e)
        {
            txtUslugaA.Text = "";
            txtUslugaB.Text = "";
            txtUslugaC.Text = "";

            txtPrethodnoRazdobljeA.Text = "";
            txtPrethodnoRazdobljeB.Text = "";
            txtPrethodnoRazdobljeC.Text = "";

            txtVjerniKorisniciA.Text = "";
            txtVjerniKorisniciB.Text = "";
            txtVjerniKorisniciC.Text = "";

            txtSljedeceRazdobljeA.Text = "";
            txtSljedeceRazdobljeB.Text = "";
            txtSljedeceRazdobljeC.Text = "";

            txtSmanjenjeAB.Text = "";
            txtSmanjenjeAC.Text = "";
            txtSmanjenjeBA.Text = "";
            txtSmanjenjeBC.Text = "";
            txtSmanjenjeCA.Text = "";
            txtSmanjenjeCB.Text = "";

            txtPovecanjeAB.Text = "";
            txtPovecanjeAC.Text = "";
            txtPovecanjeBA.Text = "";
            txtPovecanjeBC.Text = "";
            txtPovecanjeCA.Text = "";
            txtPovecanjeCB.Text = "";

            txtMpvAA.Text = "";
            txtMpvAB.Text = "";
            txtMpvAC.Text = "";
            txtMpvBA.Text = "";
            txtMpvBB.Text = "";
            txtMpvBC.Text = "";
            txtMpvCA.Text = "";
            txtMpvCB.Text = "";
            txtMpvCC.Text = "";

            txtStrukturaA.Text = "";
            txtStrukturaB.Text = "";
            txtStrukturaC.Text = "";

            txtUdjelA.Text = "";
            txtUdjelB.Text = "";
            txtUdjelC.Text = "";

            txtUdjeliPostatakA.Text = "";
            txtUdjeliPostatakB.Text = "";
            txtUdjeliPostatakC.Text = "";

            cmbRazdoblja.Text = "";

            btnIzracunajMPV.Enabled = false;
            btnIzracunajUdjele.Enabled = false;
            btnIzracunStrukture.Enabled = false;

            grbStruktura.Visible = false;
            grbMPV.Visible = false;
            grbUdjeli.Visible = false;
            this.Size = new Size(1030, 300);


        }

        private void btnIzracunajMPV_Click(object sender, EventArgs e)
        {
            txtMpvAA.Text = Math.Round((Double.Parse(txtVjerniKorisniciA.Text) / Int32.Parse(txtPrethodnoRazdobljeA.Text)), 3).ToString();
            txtMpvAB.Text = Math.Round((Double.Parse(txtSmanjenjeBA.Text) / Int32.Parse(txtPrethodnoRazdobljeB.Text)), 3).ToString();
            txtMpvAC.Text = Math.Round((Double.Parse(txtSmanjenjeCA.Text) / Int32.Parse(txtPrethodnoRazdobljeC.Text)), 3).ToString();

            txtMpvBA.Text = Math.Round((Double.Parse(txtSmanjenjeAB.Text) / Int32.Parse(txtPrethodnoRazdobljeA.Text)), 3).ToString();
            txtMpvBB.Text = Math.Round((Double.Parse(txtVjerniKorisniciB.Text) / Int32.Parse(txtPrethodnoRazdobljeB.Text)), 3).ToString();
            txtMpvBC.Text = Math.Round((Double.Parse(txtSmanjenjeCB.Text) / Int32.Parse(txtPrethodnoRazdobljeC.Text)), 3).ToString();

            txtMpvCA.Text = Math.Round((Double.Parse(txtSmanjenjeAC.Text) / Int32.Parse(txtPrethodnoRazdobljeA.Text)), 3).ToString();
            txtMpvCB.Text = Math.Round((Double.Parse(txtSmanjenjeBC.Text) / Int32.Parse(txtPrethodnoRazdobljeB.Text)), 3).ToString();
            txtMpvCC.Text = Math.Round((Double.Parse(txtVjerniKorisniciC.Text) / Int32.Parse(txtPrethodnoRazdobljeC.Text)), 3).ToString();

            this.Size = new Size(1030, 510);
            grbMPV.Visible = true;
            btnIzracunStrukture
                .Enabled = true;
        }

        private void btnIzracunStrukture_Click(object sender, EventArgs e)
        {
            txtStrukturaA.Text = Math.Round((Double.Parse(txtSljedeceRazdobljeA.Text) / (Int32.Parse(txtPrethodnoRazdobljeA.Text) + Int32.Parse(txtPrethodnoRazdobljeB.Text) + Int32.Parse(txtPrethodnoRazdobljeC.Text))), 3).ToString();
            txtStrukturaB.Text = Math.Round((Double.Parse(txtSljedeceRazdobljeB.Text) / (Int32.Parse(txtPrethodnoRazdobljeA.Text) + Int32.Parse(txtPrethodnoRazdobljeB.Text) + Int32.Parse(txtPrethodnoRazdobljeC.Text))), 3).ToString();
            txtStrukturaC.Text = Math.Round((Double.Parse(txtSljedeceRazdobljeC.Text) / (Int32.Parse(txtPrethodnoRazdobljeA.Text) + Int32.Parse(txtPrethodnoRazdobljeB.Text) + Int32.Parse(txtPrethodnoRazdobljeC.Text))), 3).ToString();
            btnIzracunajUdjele.Enabled = true;
            btnInterpretacijaStrukture.Enabled = true;

            grbStruktura.Visible = true;

        }

        private void btnIzracunajUdjele_Click(object sender, EventArgs e)
        {
            MatricaPrijelaznihVrijednosti matricaPrijelaznihVrijednosti = new MatricaPrijelaznihVrijednosti(Double.Parse(txtMpvAA.Text), Double.Parse(txtMpvAB.Text), Double.Parse(txtMpvAC.Text),
                Double.Parse(txtMpvBA.Text), Double.Parse(txtMpvBB.Text), Double.Parse(txtMpvBC.Text), Double.Parse(txtMpvCA.Text), Double.Parse(txtMpvCB.Text), Double.Parse(txtMpvCC.Text));
            Struktura strukturaKoristenjaUsluga = new Struktura(Double.Parse(txtStrukturaA.Text), Double.Parse(txtStrukturaB.Text), Double.Parse(txtStrukturaC.Text));


            Struktura udjeliUSljedecemRazdoblju = Struktura.IzracunajStrukturuZaSljedeceRazdoblje(matricaPrijelaznihVrijednosti, strukturaKoristenjaUsluga);
            listaStrukturi.Add(udjeliUSljedecemRazdoblju);

            for (int i = 0; i < 8; i++)
            {
                Struktura strukturaZaListu = Struktura.IzracunajStrukturuZaSljedeceRazdoblje(matricaPrijelaznihVrijednosti, listaStrukturi[i]);
                listaStrukturi.Add(strukturaZaListu);
            }

            Struktura strukturaStabilnogStanja = Struktura.IzracunajStabilnoStanje(matricaPrijelaznihVrijednosti);
            listaStrukturi.Add(strukturaStabilnogStanja);

            cmbRazdoblja.SelectedIndex = 0;
            btnIntepretacijaUdjeli.Enabled = true;

            grbUdjeli.Visible = true;
        }

        private void cmbRazdoblja_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUdjelA.Text = listaStrukturi[cmbRazdoblja.SelectedIndex].ElementA.ToString();
            txtUdjelB.Text = listaStrukturi[cmbRazdoblja.SelectedIndex].ElementB.ToString();
            txtUdjelC.Text = listaStrukturi[cmbRazdoblja.SelectedIndex].ElementC.ToString();

            txtUdjeliPostatakA.Text = (Double.Parse(txtUdjelA.Text) * 100).ToString() + "%";
            txtUdjeliPostatakB.Text = (Double.Parse(txtUdjelB.Text) * 100).ToString() + "%";
            txtUdjeliPostatakC.Text = (Double.Parse(txtUdjelC.Text) * 100).ToString() + "%";
        }

        private void btnIntepretacijaUdjeli_Click(object sender, EventArgs e)
        {
            if (cmbRazdoblja.SelectedIndex.Equals(9))
            {
                InterpretacijaForm interpretacija = new InterpretacijaForm();
                interpretacija.Text = "Intepretacija stabilnog stanja";
                RichTextBox richTextBox = (RichTextBox)interpretacija.Controls.Find("rxtIntepretacija", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Udjeli usluga u stabilnom stanju su sljedeći: \n\n";
                richTextBox.Text += "Udio korištenja usluge " + txtUslugaA.Text + " u stabilnom stanju iznosi: " + txtUdjeliPostatakA.Text + "\n\n";
                richTextBox.Text += "Udio korištenja usluge " + txtUslugaB.Text + " u stabilnom stanju iznosi: " + txtUdjeliPostatakB.Text + "\n\n";
                richTextBox.Text += "Udio korištenja usluge " + txtUslugaC.Text + " u stabilnom stanju iznosi: " + txtUdjeliPostatakC.Text + "\n\n";
                interpretacija.ShowDialog();
            }
            else
            {
                InterpretacijaForm interpretacija = new InterpretacijaForm();
                interpretacija.Text = "Intepretacija udjela za " + cmbRazdoblja.Text + "";
                RichTextBox richTextBox = (RichTextBox)interpretacija.Controls.Find("rxtIntepretacija", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Udjeli usluga za " + cmbRazdoblja.Text + " su sljedeći: \n\n";
                richTextBox.Text += "Udio korištenja usluge " + txtUslugaA.Text + " za " + cmbRazdoblja.Text + " iznosi: " + txtUdjeliPostatakA.Text + "\n\n";
                richTextBox.Text += "Udio korištenja usluge " + txtUslugaB.Text + " za " + cmbRazdoblja.Text + " iznosi: " + txtUdjeliPostatakB.Text + "\n\n";
                richTextBox.Text += "Udio korištenja usluge " + txtUslugaC.Text + " za " + cmbRazdoblja.Text + " iznosi: " + txtUdjeliPostatakC.Text + "\n\n";
                interpretacija.ShowDialog();
            }
        }

        private void btnInterpretacijaStrukture_Click(object sender, EventArgs e)
        {
            InterpretacijaForm interpretacija = new InterpretacijaForm();
            interpretacija.Text = "Intepretacija strukture";
            RichTextBox richTextBox = (RichTextBox)interpretacija.Controls.Find("rxtIntepretacija", true)[0];
            richTextBox.Clear();
            richTextBox.Text = "Udjeli usluga u sljedećem razdoblju su sljedeći: \n\n";
            richTextBox.Text += "Udio korištenja usluge " + txtUslugaA.Text + " u sljedećem razdoblju iznosi: " + (Double.Parse(txtStrukturaA.Text) * 100).ToString() + "%\n\n";
            richTextBox.Text += "Udio korištenja usluge " + txtUslugaB.Text + " u sljedećem razdoblju iznosi: " + (Double.Parse(txtStrukturaB.Text) * 100).ToString() + "%\n\n";
            richTextBox.Text += "Udio korištenja usluge " + txtUslugaC.Text + " u sljedećem razdoblju iznosi: " + (Double.Parse(txtStrukturaC.Text) * 100).ToString() + "%\n\n";
            interpretacija.ShowDialog();
        }

        private void PredvidanjeKoristenjaUslugaForm_KeyUp(object sender, KeyEventArgs e)
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
                richTextBox.Text += "Nalazite se u prozoru za predviđanje korištenja usluga, imate 7 mogućnosti:\n\n";
                richTextBox.Text += "1. Klikom na gumb 'Postavi zadatak' ispunjavaju se polja sa testnim podacaima\n\n";
                richTextBox.Text += "2. Klikom na gumb 'Izračunaj MPV' izračunava se matrica prijelaznih vrijednosti\n\n";
                richTextBox.Text += "3. Klikom na gumb 'Izračunaj strukturu' izračunava se struktura udjela u sljedećem razdoblju\n\n";
                richTextBox.Text += "4. Klikom na gumb 'Izračunaj udjele' izračunavaju se udjeli u nekoliko sljedećih razdoblja te u stabilnom stanju\n\n";
                richTextBox.Text += "5. Klikom na gumb 'Očisti polja' brišu se sve vrijednoti koje su unesene u polja\n\n";
                richTextBox.Text += "6. Klikom na gumb 'Interpretacija' prikazuje se forma za interpretaciju određenog razdoblja\n\n";
                richTextBox.Text += "7. Odabirom razdoblja iz padajućeg izbornika prikazuje se udjel usluga u tom razdoblju\n\n";
                pomoc.ShowDialog();
            }
        }

        private void provjeriPopunjenostPolja()
        {
            if (
            txtUslugaA.Text != "" && txtUslugaB.Text != "" && txtUslugaC.Text != ""
            && txtPrethodnoRazdobljeA.Text != "" && txtPrethodnoRazdobljeB.Text != "" && txtPrethodnoRazdobljeC.Text != ""
            && txtVjerniKorisniciA.Text != "" && txtVjerniKorisniciB.Text != "" && txtVjerniKorisniciC.Text != ""
            && txtSljedeceRazdobljeA.Text != "" && txtSljedeceRazdobljeB.Text != "" && txtSljedeceRazdobljeC.Text != ""
            && txtSmanjenjeAB.Text != "" && txtSmanjenjeAC.Text != "" && txtSmanjenjeBA.Text != "" && txtSmanjenjeBC.Text != "" && txtSmanjenjeCA.Text != "" && txtSmanjenjeCB.Text != ""
            && txtPovecanjeAB.Text != "" && txtPovecanjeAC.Text != "" && txtPovecanjeBA.Text != "" && txtPovecanjeBC.Text != "" && txtPovecanjeCA.Text != "" && txtPovecanjeCB.Text != "")
            {
                btnIzracunajMPV.Enabled = true;
            }
        }

        private void popuniVjerneKorisnikeA()
        {
            if (txtPrethodnoRazdobljeA.Text != "" && txtSmanjenjeAB.Text != "" && txtSmanjenjeAC.Text != "")
            {
                txtVjerniKorisniciA.Text = (Int32.Parse(txtPrethodnoRazdobljeA.Text) - Int32.Parse(txtSmanjenjeAB.Text) - Int32.Parse(txtSmanjenjeAC.Text)).ToString();
            }
        }
        private void popuniVjerneKorisnikeB()
        {
            if (txtPrethodnoRazdobljeB.Text != "" && txtSmanjenjeBA.Text != "" && txtSmanjenjeBC.Text != "")
            {
                txtVjerniKorisniciB.Text = (Int32.Parse(txtPrethodnoRazdobljeB.Text) - Int32.Parse(txtSmanjenjeBA.Text) - Int32.Parse(txtSmanjenjeBC.Text)).ToString();
            }
        }
        private void popuniVjerneKorisnikeC()
        {
            if (txtPrethodnoRazdobljeC.Text != "" && txtSmanjenjeCA.Text != "" && txtSmanjenjeCB.Text != "")
            {
                txtVjerniKorisniciC.Text = (Int32.Parse(txtPrethodnoRazdobljeC.Text) - Int32.Parse(txtSmanjenjeCA.Text) - Int32.Parse(txtSmanjenjeCB.Text)).ToString();
            }
        }

        private void popuniSljedeceRazdobljeA()
        {
            if (txtVjerniKorisniciA.Text != "" && txtPovecanjeAB.Text != "" && txtPovecanjeAC.Text != "")
            {
                txtSljedeceRazdobljeA.Text = (Int32.Parse(txtVjerniKorisniciA.Text) + Int32.Parse(txtPovecanjeAB.Text) + Int32.Parse(txtPovecanjeAC.Text)).ToString();
            }
        }
        private void popuniSljedeceRazdobljeB()
        {
            if (txtVjerniKorisniciB.Text != "" && txtPovecanjeBA.Text != "" && txtPovecanjeBC.Text != "")
            {
                txtSljedeceRazdobljeB.Text = (Int32.Parse(txtVjerniKorisniciB.Text) + Int32.Parse(txtPovecanjeBA.Text) + Int32.Parse(txtPovecanjeBC.Text)).ToString();
            }
        }

        private void popuniSljedeceRazdobljeC()
        {
            if (txtVjerniKorisniciC.Text != "" && txtPovecanjeCA.Text != "" && txtPovecanjeCB.Text != "")
            {
                txtSljedeceRazdobljeC.Text = (Int32.Parse(txtVjerniKorisniciC.Text) + Int32.Parse(txtPovecanjeCA.Text) + Int32.Parse(txtPovecanjeCB.Text)).ToString();
            }
        }

        private void txtVjerniKorisniciA_TextChanged(object sender, EventArgs e)
        {
            popuniSljedeceRazdobljeA();
            provjeriPopunjenostPolja();
        }

        private void txtVjerniKorisniciB_TextChanged(object sender, EventArgs e)
        {
            popuniSljedeceRazdobljeB();
            provjeriPopunjenostPolja();
        }

        private void txtVjerniKorisniciC_TextChanged(object sender, EventArgs e)
        {
            popuniSljedeceRazdobljeC();
            provjeriPopunjenostPolja();
        }

        private void txtSljedeceRazdobljeA_TextChanged(object sender, EventArgs e)
        {
            provjeriPopunjenostPolja();
        }

        private void txtSljedeceRazdobljeB_TextChanged(object sender, EventArgs e)
        {
            provjeriPopunjenostPolja();
        }

        private void txtSljedeceRazdobljeC_TextChanged(object sender, EventArgs e)
        {
            provjeriPopunjenostPolja();
        }

        private void cmbInterpretacija_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInterpretacija.SelectedIndex == 0) {
                InterpretacijaForm interpretacija = new InterpretacijaForm();
                interpretacija.Text = "Intepretacija 1. stupca MPV";
                RichTextBox richTextBox = (RichTextBox)interpretacija.Controls.Find("rxtIntepretacija", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Interpretacija 1. stupca MPV je sljedeća: \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvAA.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaA.Text + ", nastavit će koristit uslugu " + txtUslugaA.Text + " \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvBA.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaA.Text + ", sada će koristit uslugu " + txtUslugaB.Text + " \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvCA.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaA.Text + ", sada će koristit uslugu  " + txtUslugaC.Text + " \n\n";
                interpretacija.ShowDialog();
            }
            else if (cmbInterpretacija.SelectedIndex == 1) {
                InterpretacijaForm interpretacija = new InterpretacijaForm();
                interpretacija.Text = "Intepretacija 2. stupca MPV";
                RichTextBox richTextBox = (RichTextBox)interpretacija.Controls.Find("rxtIntepretacija", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Interpretacija 2. stupca MPV je sljedeća: \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvAB.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaB.Text + ", sada će koristit uslugu " + txtUslugaA.Text + " \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvBB.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaB.Text + ", nastavit će koristit uslugu " + txtUslugaB.Text + " \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvCB.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaB.Text + ", sada će koristit uslugu " + txtUslugaC.Text + " \n\n";
                interpretacija.ShowDialog();

            }
            else if (cmbInterpretacija.SelectedIndex == 2)
            {
                InterpretacijaForm interpretacija = new InterpretacijaForm();
                interpretacija.Text = "Intepretacija 3. stupca MPV";
                RichTextBox richTextBox = (RichTextBox)interpretacija.Controls.Find("rxtIntepretacija", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Interpretacija 3. stupca MPV je sljedeća: \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvAC.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaC.Text + ", sada će koristit uslugu " + txtUslugaA.Text + " \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvBC.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaC.Text + ", sada će koristit uslugu " + txtUslugaB.Text + " \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvCC.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaC.Text + ", nastavit će koristit uslugu " + txtUslugaC.Text + " \n\n";

                interpretacija.ShowDialog();
            }
            else if (cmbInterpretacija.SelectedIndex == 3)
            {
                InterpretacijaForm interpretacija = new InterpretacijaForm();
                interpretacija.Text = "Intepretacija 1. retka MPV";
                RichTextBox richTextBox = (RichTextBox)interpretacija.Controls.Find("rxtIntepretacija", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Interpretacija 1. retka MPV je sljedeća: \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvAA.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaA.Text + ", nastavit će koristit uslugu " + txtUslugaA.Text + " \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvAB.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaB.Text + ", sada će koristit uslugu " + txtUslugaA.Text + " \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvAC.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaC.Text + ", sada će koristit uslugu  " + txtUslugaA.Text + " \n\n";
                interpretacija.ShowDialog();
            }
            else if (cmbInterpretacija.SelectedIndex == 4)
            {
                InterpretacijaForm interpretacija = new InterpretacijaForm();
                interpretacija.Text = "Intepretacija 2. retka MPV";
                RichTextBox richTextBox = (RichTextBox)interpretacija.Controls.Find("rxtIntepretacija", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Interpretacija 2. retka MPV je sljedeća: \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvBA.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaA.Text + ", sada će koristit uslugu " + txtUslugaB.Text + " \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvBB.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaB.Text + ", nastavit će koristit uslugu " + txtUslugaB.Text + " \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvBC.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaC.Text + ", sada će koristit uslugu  " + txtUslugaB.Text + " \n\n";
                interpretacija.ShowDialog();
            }
            else if (cmbInterpretacija.SelectedIndex == 4)
            {
                InterpretacijaForm interpretacija = new InterpretacijaForm();
                interpretacija.Text = "Intepretacija 3. retka MPV";
                RichTextBox richTextBox = (RichTextBox)interpretacija.Controls.Find("rxtIntepretacija", true)[0];
                richTextBox.Clear();
                richTextBox.Text = "Interpretacija 3. retka MPV je sljedeća: \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvCA.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaA.Text + ", sada će koristit uslugu " + txtUslugaC.Text + " \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvCB.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaB.Text + ", sada će koristit uslugu  " + txtUslugaC.Text + " \n\n";
                richTextBox.Text += "" + (Double.Parse(txtMpvCC.Text) * 100).ToString() + "% korisnika koji su koristili uslugu " + txtUslugaC.Text + ", nastavit će koristit uslugu " + txtUslugaC.Text + " \n\n";

                interpretacija.ShowDialog();
            }
        }
    }
}
