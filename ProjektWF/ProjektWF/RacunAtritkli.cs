using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using Projekt;
using Projekt.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            string racunID = btnRacun.RacunID;
            popuniKategorije();
            textBoxRacunID.Text = racunID;            
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

        async Task<string> PrikaziCijene()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync("https://localhost:44306/artikli/getcijena"))
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

        async Task<string> PrikaziImeArtikl()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync("https://localhost:44306/artikli/getID"))
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
        private async void textBoxKolicina_TextChangedAsync(object sender, EventArgs e)
        {
            try
            {
                var response = await PrikaziCijene();
                var podaci = JsonConvert.DeserializeObject<Dictionary<string, decimal>>(response);

                var artiklCijena = podaci.FirstOrDefault(x => x.Key == comboBoxArtikli.Text).Value;

                textBoxUkupno.Text = (artiklCijena * (int.Parse(textBoxKolicina.Text))).ToString();
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }

        }
        private async void comboBoxKolicina_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var response = await PrikaziCijene();
                var podaci = JsonConvert.DeserializeObject<Dictionary<string, decimal>>(response);

                var artiklCijena = podaci.FirstOrDefault(x => x.Key == comboBoxArtikli.Text).Value;

                textBoxUkupno.Text = (artiklCijena * (int.Parse(textBoxKolicina.SelectedText))).ToString();
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            async Task<string> dodajArtikl()
            {
                string racunId = textBoxRacunID.Text.Trim();

                var response = await PrikaziImeArtikl();
                var podaci = JsonConvert.DeserializeObject<Dictionary<string, int>>(response);

                string artiklID = podaci.FirstOrDefault(x => x.Key == comboBoxArtikli.Text).Value.ToString();


                string kolicina = textBoxKolicina.Text;
                string cijena = textBoxUkupno.Text.ToString();

                if (racunId.Length == 0 || artiklID.Length == 0 || kolicina.Length == 0 || cijena.Length == 0)
                {
                    MessageBox.Show("Sva polja moraju biti popunjena!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {        
                    { "RacunID", racunId },
                    { "ArtikliID", artiklID },           
                    { "Kolicina", kolicina }
                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PostAsync("https://localhost:44306/racunartikli/noviracunartikl", unos))
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
                await dodajArtikl();
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

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            async Task<string> Prikazi(int id)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("https://localhost:44306/racunartikli/getracunartiklibyid/" + id))
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
                var response = await Prikazi(int.Parse(textBoxRacunID.Text.Trim()));

                var podaci = JsonConvert.DeserializeObject<List<Detalji>>(response);
                dataGridViewDetalji.DataSource = podaci;
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

       
            private void btnIspis_Click(object sender, EventArgs e)
            {
                void Ispis()
                {
                    var pdfDoc = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);
                    string path = $"C:\\Users\\Korisnik\\Desktop\\RacunBR{btnRacun.BrojRacuna}.pdf";

                    PdfWriter.GetInstance(pdfDoc, new FileStream(path, FileMode.OpenOrCreate));
                    pdfDoc.Open();

                    //var imagepath = @"C:\Users\tbozi\source\repos\Projekt\logo.png";

                    //using (FileStream fs = new FileStream(imagepath, FileMode.Open))
                    //{
                    //    var png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(fs),
                    //            ImageFormat.Png);
                    //    png.ScalePercent(2f);
                    //    png.SetAbsolutePosition(pdfDoc.Left, pdfDoc.Top);
                    //    pdfDoc.Add(png);
                    //}

                    var Naslov = new Paragraph("Fast Food Original");
                    pdfDoc.Add(Naslov);


                    var spacer = new Paragraph("")
                    {
                        SpacingBefore = 10f,
                        SpacingAfter = 10f,
                    };

                    pdfDoc.Add(spacer);

                    var headerTable = new PdfPTable(new[] { .75f, 2f })
                    {
                        HorizontalAlignment = Left,
                        WidthPercentage = 75,
                        DefaultCell = { MinimumHeight = 22f }
                    };


                    headerTable.AddCell("RacunID");
                    headerTable.AddCell(textBoxRacunID.Text.Trim());
                    headerTable.AddCell("Broj Racuna");
                    headerTable.AddCell(btnRacun.BrojRacuna);
                   

                    pdfDoc.Add(headerTable);
                    pdfDoc.Add(spacer);

                    var columnCount = dataGridViewDetalji.ColumnCount;
                    var columnWidths = new[] { 1f, 1f, 1.5f, 1f, 1f, 1f,1f };

                    var table = new PdfPTable(columnWidths)
                    {
                        HorizontalAlignment = Left,
                        WidthPercentage = 100,
                        DefaultCell = { MinimumHeight = 22f }
                    };

                    var cell = new PdfPCell(new Phrase("Stavke Racuna"))
                    {
                        Colspan = columnCount,
                        HorizontalAlignment = 1,
                        MinimumHeight = 30f
                    };

                    table.AddCell(cell);

                    //headers

                    dataGridViewDetalji.Columns
                        .OfType<DataGridViewColumn>()
                        .ToList()
                        .ForEach(c => table.AddCell(c.Name));

                    // rows

                    dataGridViewDetalji.Rows
                        .OfType<DataGridViewRow>()
                        .ToList()
                        .ForEach(r =>
                        {
                            var cells = r.Cells.OfType<DataGridViewCell>().ToList();
                            cells.ForEach(c => table.AddCell(c.Value.ToString()));
                        });


                    decimal ukupnaCijena = 0;

                    for (int i = 0; i < dataGridViewDetalji.Rows.Count; ++i)
                    {
                        ukupnaCijena += Convert.ToDecimal(dataGridViewDetalji.Rows[i].Cells[6].Value);
                    }


                    var ukupno = new PdfPCell(new Phrase("Ukupna Cijena: " +
                        ukupnaCijena))
                    {
                        Colspan = columnCount,
                        HorizontalAlignment = 7,
                        MinimumHeight = 30f
                    };

                    table.AddCell(ukupno);  

                    pdfDoc.Add(table);

                    pdfDoc.Close();
                    System.Diagnostics.Process.Start(path);
                }


                Ispis();


            }

        private void dataGridViewDetalji_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
        
}
