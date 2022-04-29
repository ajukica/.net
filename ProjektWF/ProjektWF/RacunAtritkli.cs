using Newtonsoft.Json;
using Projekt;
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
    public partial class RacunAtritkli : Form
    {
        public RacunAtritkli()
        {
            InitializeComponent();
            //string racunID = Racun.racunID;           
            popuniKategorije();

            //textRacunId.Text = racunID;            
        }

        //string brojRacuna = RacunAtritkli.brojRacuna;
        //decimal partnerPopust = Racun.partnerPopust;

        async Task<string> PrikaziKategorije()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync("https://localhost:44306/kategorija/getname"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
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
        public async void popuniKategorije()
        {
            try
            {
                var response = await PrikaziKategorije();
                var podaci = JsonConvert.DeserializeObject<Dictionary<int, string>>(response);

                foreach (var pod in podaci)
                {
                    comboBoxKategorija.Items.Add(pod.Value);
                }
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void popuniArtikle()
        {
            async Task<string> PrikaziArtikle(int id)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("https://localhost:44306/artikli/getartiklkategorija/" + id))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                            
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
                var response = await PrikaziKategorije();
                var podaci = JsonConvert.DeserializeObject<Dictionary<int, string>>(response);
                var kategorijaID = podaci.FirstOrDefault(x => x.Value == comboBoxKategorija.SelectedText).Key;

                var response2 = await PrikaziArtikle(kategorijaID);
                var podaci2 = JsonConvert.DeserializeObject<Dictionary<int, string>>(response2);

                foreach (var pod2 in podaci2)
                {
                    comboBoxArtikli.Items.Add(pod2.Value);
                }
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }


        }

        private void comboBoxKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            popuniArtikle();
            comboBoxArtikli.Items.Clear();

        }
    }
}
