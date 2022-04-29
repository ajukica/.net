
using Newtonsoft.Json;
using ProjektWF.Modeli;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjektWF
{
   

    public partial class btnRacun : Form
    {
      
        public static string RacunID;
        public static string KupacID;     
        public static string ZaposlenikID;
        public static string BrojRacuna;

        public btnRacun()
        {
            InitializeComponent();
            PopuniComboBox();
            PopuniComboBoxKupac();



        }
        private async void PopuniComboBox()
        {
            async Task<string> PrikaziSveZaposlenike()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("https://localhost:44306/zaposlenik/getzaposlenik"))
                    {
                        using (HttpContent content = res.Content)
                        {
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
                var response = await PrikaziSveZaposlenike();
                var podaci = JsonConvert.DeserializeObject<List<ZaposlenikModel>>(response);
                
                foreach (var pod in podaci)
                {
                    comboBox1.Items.Add( pod.Prezime);
                    
                }
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }


        private async void comboBox1_SelectedIndexChangedAsync(object sender, EventArgs e)
        { 
            async Task<string> PrikaziSveZaposlenike()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("https://localhost:44306/zaposlenik/getzaposlenikbyname"))
                    {
                        using (HttpContent content = res.Content)
                        {
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
                var response = await PrikaziSveZaposlenike();
                var podaci = JsonConvert.DeserializeObject<Dictionary<int,string>>(response);
                var id = podaci.FirstOrDefault(x => x.Value == comboBox1.SelectedText).Key;
                textZaposlenikID.Text = id.ToString();
                            
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnUnesiRacun_Click(object sender, EventArgs e)
        {
            async Task<string> NoviRacun()
            {
              
                string zaposlenikID = textZaposlenikID.Text.Trim();
                string kupacID = textKupacID.Text.Trim();
                string brojRacuna = textBrojRacuna.Text.Trim();
                
                if (zaposlenikID.Length == 0 || kupacID.Length == 0 || brojRacuna.Length == 0)
                {
                    MessageBox.Show("Molim popunite polja!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {                    
                    { "KupacID", kupacID } ,
                    { "ZaposlenikID", zaposlenikID },                                    
                    {"Brojracuna", brojRacuna }
                };

                var jsonDictionary = JsonConvert.SerializeObject(uneseniPodaci);
                var podaci = new StringContent(jsonDictionary, Encoding.UTF8, "application/json");

               
                using (HttpClient client = new HttpClient())
                {                   
                    using (HttpResponseMessage res = await client.PostAsync("https://localhost:44306/racun/noviracun", podaci))
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
                await NoviRacun();
                MessageBox.Show("Uspješno obavljeno");
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
            catch (FormatException x)
            {
                MessageBox.Show(x.Message);
            }

            this.Close();
        }

        private async void PopuniComboBoxKupac()
        {
            async Task<string> PrikaziSveKupce()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("https://localhost:44306/kupac/getkupac"))
                    {
                        using (HttpContent content = res.Content)
                        {
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
                var response = await PrikaziSveKupce();
                var podaci = JsonConvert.DeserializeObject<List<KupacModel>>(response);

                foreach (var pod in podaci)
                {
                    comboBoxKupac.Items.Add(pod.Prezime);

                }
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void comboBoxKupac_SelectedIndexChangedAsync(object sender, EventArgs e)
        {
            async Task<string> PrikaziSveKupce()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("https://localhost:44306/kupac/getkupacbyname"))
                    {
                        using (HttpContent content = res.Content)
                        {
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
                var response = await PrikaziSveKupce();
                var podaci = JsonConvert.DeserializeObject<Dictionary<int, string>>(response);
                var id = podaci.FirstOrDefault(x => x.Value == comboBoxKupac.SelectedText).Key;
                textKupacID.Text = id.ToString();

            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void btnPopuniRacun_Click(object sender, EventArgs e)
        {
            try
            {
                RacunID = textBoxRacunID.Text;
                BrojRacuna = textBrojRacuna.Text;
                ZaposlenikID = textZaposlenikID.Text;
                KupacID = textKupacID.Text;
                //TYPO
                RacunAtritkli racunArtikli = new RacunAtritkli();
                racunArtikli.ShowDialog();
            }
            catch (System.FormatException k)
            {
                MessageBox.Show("Odaberite Račun!");
            }
        }

        private void btnRacun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_FastFood_MDFDataSet2.Racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter1.Fill(this._FastFood_MDFDataSet2.Racun);
            // TODO: This line of code loads data into the '_FastFood_MDFDataSet1.Racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.Fill(this._FastFood_MDFDataSet1.Racun);

        }


        private void dataGridRacuni_MouseDoubleClick(object sender, MouseEventArgs e)
        {
      
           
            if (dataGridRacuni.CurrentRow.Index != -1)
            {
                textBoxRacunID.Text = (Convert.ToInt32(dataGridRacuni.CurrentRow.Cells[0].Value)).ToString();
                textBrojRacuna.Text = (Convert.ToInt32(dataGridRacuni.CurrentRow.Cells[1].Value)).ToString();
                textKupacID.Text = (string)(dataGridRacuni.CurrentRow.Cells[2].Value).ToString();
                textZaposlenikID.Text = (Convert.ToInt32(dataGridRacuni.CurrentRow.Cells[3].Value)).ToString();
            }
        }

        private void dataGridRacuni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnIzbrisiRacun_Click(object sender, EventArgs e)
        {          
                if (MessageBox.Show("Da li ste", "Sigurni?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    async Task<string> izbrisiRacun(int id)
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            using (HttpResponseMessage res = await client.DeleteAsync("https://localhost:44306/racun/delete/"+ id))
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
                        await izbrisiRacun(int.Parse(textBoxRacunID.Text.Trim()));
                        dataGridRacuni.DataSource = racunBindingSource1;
                        dataGridRacuni.Update();

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

            }

        private async void btnIzmjeni_Click(object sender, EventArgs e)
        {
            async Task<string> IzmjeniRacun()
            {
                int id = int.Parse(textBoxRacunID.Text.Trim());

                string racunZaposlenik = textZaposlenikID.Text.Trim();
                string brojRacuna = textBrojRacuna.Text.Trim();
                string racunKupac = textKupacID.Text.Trim();

             
                var uneseniPodaci = new Dictionary<string, string>
                {
                    { "ZaposlenikID", racunZaposlenik },
                    { "KupacID", racunKupac },
                    { "brojRacuna", brojRacuna }
                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PutAsync("https://localhost:44306/racun/update", unos))
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
                await IzmjeniRacun();
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
            

