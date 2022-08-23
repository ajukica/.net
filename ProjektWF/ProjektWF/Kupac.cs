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
    public partial class Kupac : Form
    {
        public Kupac()
        {
            InitializeComponent();
        }

        private async void btnUnos_ClickAsync(object sender, EventArgs e)
        {
            async Task<string> NoviKupac()
            {
                string kupacID = textBoxID.Text.Trim();
                string ime = textBoxIme.Text.Trim();
                string prezime = textBoxPrezime.Text.Trim();


                if ( ime.Length == 0 || prezime.Length == 0)
                {
                    MessageBox.Show("Sva polja moraju biti popunjena!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {
                    { "KupacID" , kupacID },
                    { "Ime", ime },
                    { "Prezime", prezime }

                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PostAsync("https://localhost:44306/kupac/novikupac/", unos))
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
                await NoviKupac();
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

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
