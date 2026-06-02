using System.Net.Http;   
using Newtonsoft.Json;

namespace Translate
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> languages = new Dictionary<string, string>
            {
                { "Turkish", "tr-TR" },
                { "English", "en-US" },
                { "German", "de-DE" },        
                { "Spanish", "es-ES" },
                { "French", "fr-FR" }
            };

            cmbFrom.DataSource = new BindingSource(languages, null);
            cmbFrom.DisplayMember = "Key"; 
            cmbFrom.ValueMember = "Value"; 

            cmbTo.DataSource = new BindingSource(languages, null);
            cmbTo.DisplayMember = "Key";
            cmbTo.ValueMember = "Value";

            cmbFrom.SelectedIndex = 1; 
            cmbTo.SelectedIndex = 0;   
        }

        private async void btnTranslate_Click(object sender, EventArgs e)
        {
            string textToTranslate = txtInput.Text;

            if (string.IsNullOrWhiteSpace(textToTranslate))
            {
                MessageBox.Show("Please enter a word or text to be translated..", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fromLang = cmbFrom.SelectedValue.ToString();
            string toLang = cmbTo.SelectedValue.ToString();

            string url = $"https://api.mymemory.translated.net/get?q={Uri.EscapeDataString(textToTranslate)}&langpair={fromLang}|{toLang}";

            try
            {
                btnTranslate.Enabled = false;
                btnTranslate.Text = "Translating...";

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); 
                string responseBody = await response.Content.ReadAsStringAsync();

                dynamic result = JsonConvert.DeserializeObject(responseBody);
                string translatedText = result.responseData.translatedText;

                txtOutput.Text = translatedText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during translation.: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnTranslate.Enabled = true;
                btnTranslate.Text = "Translate";
            }
        }
    }
}
