using System.Diagnostics;

namespace DdosWithGoogleSheets
{
    public partial class MessageForm : Form
    {
        private static string _defaultText = string.Empty;
        public MessageForm()
        {
            InitializeComponent();
            _defaultText = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == _defaultText)
            {
                MessageBox.Show("Вставьте ID листа Google Sheets");
                return;
            }
            using (var stream = new StreamWriter("list_id.txt", false))
            {
                stream.Write(textBox1.Text);
            }
            MessageBox.Show("Для работы с API не закрывайте вкладку с листом!");
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo 
            {
                FileName = "https://docs.google.com/spreadsheets/u/0/", 
                UseShellExecute = true
            });
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
