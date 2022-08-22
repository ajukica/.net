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
    public partial class Artikli : Form
    {
        public Artikli()
        {
            InitializeComponent();
        }

        private void Artikli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_FastFood_MDFDataSet.Artikli' table. You can move, or remove it, as needed.
            this.artikliTableAdapter.Fill(this._FastFood_MDFDataSet.Artikli);

        }

        // GREŠKA -- NEĆE DA IZBRIŠE IZ BAZE JER IMA REFERENCU 
        private async void btnIzbrisiArtikl_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Jeste li sigurni?", "Važno", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                async Task<string> IzbrisiProizvod(int id)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        using (HttpResponseMessage res = await client.DeleteAsync("https://localhost:44306/artikli/delete/" + id))
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
                    await IzbrisiProizvod(int.Parse(textBoxIdArtikla.Text.Trim()));
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

        private async void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            async Task<string> DodajNoviArtikl()
            {
                string kategorijaId = textBoxKategorijaId.Text.Trim();
                string proizvodCijena = textBoxCijena.Text.Trim();
                string artiklNaziv = textBoxNazivArtikla.Text.Trim();


                if (kategorijaId.Length == 0 || proizvodCijena.Length == 0 || artiklNaziv.Length == 0)
                {
                    MessageBox.Show("Sva polja moraju biti popunjena!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {
                    { "KategorijaID" , kategorijaId },
                    { "Cijena", proizvodCijena },
                    { "Naziv", artiklNaziv }

                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PostAsync("https://localhost:44306/artikli/noviartikl/", unos))
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
                await DodajNoviArtikl();
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

        private async void btnIzmjeniArtikl_Click(object sender, EventArgs e)
        {
            async Task<string> IzmjeniArtikl()
            {
                
                string artikliId = textBoxIdArtikla.Text.Trim();
                string kategorijaId = textBoxKategorijaId.Text.Trim();
                string proizvodCijena = textBoxCijena.Text.Trim();
                string artiklNaziv = textBoxNazivArtikla.Text.Trim();
                
              
                if (kategorijaId.Length == 0 || proizvodCijena.Length == 0 || artiklNaziv.Length == 0 || artikliId.Length == 0)
                {
                    MessageBox.Show("Sva polja moraju biti popunjena!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {
                    {"ArtikliID", artikliId},
                    { "KategorijaID" , kategorijaId },
                    { "Cijena", proizvodCijena },
                    { "Naziv", artiklNaziv }               
                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PutAsync("https://localhost:44306/artikli/update/", unos))
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
                await IzmjeniArtikl();
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
