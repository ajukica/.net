﻿using System;
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

        private async void btnBrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?", "Važno", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                async Task<string> IzbrisiKupca(int id)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        using (HttpResponseMessage res = await client.DeleteAsync("https://localhost:44306/kupac/delete/" + id))
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
                    await IzbrisiKupca(int.Parse(textBoxID.Text.Trim()));
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
            async Task<string> IzmjeniKupca()
            {

                string kupacId = textBoxID.Text.Trim();
                string kupacIme = textBoxIme.Text.Trim();
                string kupacPrezime = textBoxPrezime.Text.Trim();
                


                if (kupacId.Length == 0 || kupacIme.Length == 0 || kupacPrezime.Length == 0)
                {
                    MessageBox.Show("Sva polja moraju biti popunjena!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {
                    {"kupacID", kupacId},
                    { "Ime" , kupacIme },
                    { "Prezime", kupacPrezime }
                  
                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PutAsync("https://localhost:44306/kupac/update/", unos))
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
                await IzmjeniKupca();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Kupac_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_FastFood_MDFDataSet3.Kupac' table. You can move, or remove it, as needed.
            this.kupacTableAdapter.Fill(this._FastFood_MDFDataSet3.Kupac);

        }
    }
}
    

