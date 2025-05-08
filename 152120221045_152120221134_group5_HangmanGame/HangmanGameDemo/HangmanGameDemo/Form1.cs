using System.Drawing.Drawing2D;

namespace HangmanGameDemo
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            if(GameSettings.Instance.Category != null)
                cbCategory.SelectedItem = GameSettings.Instance.Category;
            // back image
            pictureBox1.Image = Image.FromFile("Images\\cover2.jpg");
            pictureBox1.Controls.Add(label1);
            pictureBox1.Controls.Add(label2);
            pictureBox1.Controls.Add(cbCategory);
            label1.BackColor = Color.Transparent;

            // button design
            OvalButton(button1);
            OvalButton(btnSettings);
            OvalButton(btnExit);
        }

        public void OvalButton(Button button)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;

            Rectangle rect = new Rectangle(0, 0, button.Width, button.Height);
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbCategory.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir kategori seçin.");
            }
            else
            {
                GameSettings.Instance.Category = cbCategory.SelectedItem.ToString();
                Game game = new Game();
                game.Show();
                this.Hide();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çýkmak istediðinize emin misiniz?", "Çýkýþ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
