using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektWF
{
    public partial class Zaposlenik : Form
    {
        public Zaposlenik()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Zaposlenik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_FastFood_MDFDataSet4.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this._FastFood_MDFDataSet4.Zaposlenik);

        }

        private void textBoxIme_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnUnos_Click(object sender, EventArgs e)
        {
            async Task<string> NoviZaposlenik()
            {
                string ime = textBoxIme.Text.Trim();
                string prezime = textBoxPrezime.Text.Trim();


                if (ime.Length == 0 || prezime.Length == 0)
                {
                    MessageBox.Show("Sva polja moraju biti popunjena!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {
                    { "Ime", ime },
                    { "Prezime", prezime }

                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PostAsync("https://localhost:44306/zaposlenik/novizaposlenik/", unos))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                            MessageBox.Show(statusCode);

                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                await NoviZaposlenik();
            }

            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
            catch (FormatException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void btnBrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?", "Važno", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                async Task<string> IzbrisiZaposlenika(int id)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        using (HttpResponseMessage res = await client.DeleteAsync("https://localhost:44306/zaposlenik/delete/" + id))
                        {
                            using (HttpContent content = res.Content)
                            {
                                string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                                MessageBox.Show(statusCode);

                                string data = await content.ReadAsStringAsync();

                                if (data != null)
                                {
                                    return data;
                                }
                            }
                        }
                    }
                    return string.Empty;
                }

                try
                {
                    await IzbrisiZaposlenika(int.Parse(textBoxID.Text.Trim()));
                }
                catch (HttpRequestException x)
                {
                    MessageBox.Show(x.Message);
                }
                catch (System.FormatException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            else
            {
                MessageBox.Show("Proizvod neće biti izbrisan.");
            }
        }

        private async void btnIzmjeni_Click(object sender, EventArgs e)
        {
            async Task<string> IzmjeniZaposlenika()
            {

                string zaspolenikId = textBoxID.Text.Trim();
                string zaposlenikIme = textBoxIme.Text.Trim();
                string zaposlenikPrezime = textBoxPrezime.Text.Trim();



                if (zaspolenikId.Length == 0 || zaposlenikIme.Length == 0 || zaposlenikPrezime.Length == 0)
                {
                    MessageBox.Show("Sva polja moraju biti popunjena!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {
                    {"ZaposlenikID", zaspolenikId},
                    { "Ime" , zaposlenikIme },
                    { "Prezime", zaposlenikPrezime }

                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PutAsync("https://localhost:44306/zaposlenik/update/", unos))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                            MessageBox.Show(statusCode);

                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                }
                return string.Empty;
            }
            try
            {
                await IzmjeniZaposlenika();
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
            catch (FormatException x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
 }

