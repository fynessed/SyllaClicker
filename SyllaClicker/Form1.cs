using System.Diagnostics;

namespace SyllaClicker
{
    public partial class Form1 : Form
    {

        private bool listening = false;

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(keyListener);
        }

        private void hotkeyButtonClick(object sender, EventArgs e)
        {
            listening = true;
            hotkey.Text = "...";
        }

        private void keyListener(object sender, KeyEventArgs e)
        {
            if (listening)
            {
                hotkey.Text = e.KeyCode.ToString();
                listening = false;
            }
        }

        private void githubLink_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/fynessed/SyllaClicker",
                UseShellExecute = true
            };

            try
            {
                Process.Start(startInfo);
            } catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
