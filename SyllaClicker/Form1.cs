namespace SyllaClicker
{
    public partial class Form1 : Form
    {
        
        private bool listening = false;

        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(keyListener);
            hotkeyButton.Click += new EventHandler(hotkeyButtonClick);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
