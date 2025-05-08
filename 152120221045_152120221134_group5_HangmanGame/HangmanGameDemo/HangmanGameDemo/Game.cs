using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGameDemo
{
    public partial class Game : Form
    {
        // Resimler için liste
        public static List<string> Manimage = new List<string>()
        {
            "Images\\Man\\man-01.jpg",
            "Images\\Man\\man-02.jpg",
            "Images\\Man\\man-03.jpg",
            "Images\\Man\\man-04.jpg",
            "Images\\Man\\man-05.jpg",
            "Images\\Man\\man-06.jpg",
            "Images\\Man\\man-07.jpg",
            "Images\\Man\\man-08.jpg",
            "Images\\Man\\man-09.jpg",
            "Images\\Man\\man-10.jpg"
        };
        public static List<string> Stickmanimage = new List<string>()
        {
            "Images\\Stickman\\stick-1.jpg",
            "Images\\Stickman\\stick-2.jpg",
            "Images\\Stickman\\stick-3.jpg",
            "Images\\Stickman\\stick-4.jpg",
            "Images\\Stickman\\stick-5.jpg",
            "Images\\Stickman\\stick-6.jpg",
            "Images\\Stickman\\stick-7.jpg",
            "Images\\Stickman\\stick-8.jpg",
            "Images\\Stickman\\stick-9.jpg",
            "Images\\Stickman\\stick-10.jpg"
        };
        public static List<string> Flowerimage = new List<string>()
        {
            "Images\\Flower\\flower-01.jpg",
            "Images\\Flower\\flower-02.jpg",
            "Images\\Flower\\flower-03.jpg",
            "Images\\Flower\\flower-04.jpg",
            "Images\\Flower\\flower-05.jpg",
            "Images\\Flower\\flower-06.jpg",
            "Images\\Flower\\flower-07.jpg",
            "Images\\Flower\\flower-08.jpg",
            "Images\\Flower\\flower-09.jpg",
            "Images\\Flower\\flower-10.jpg"
        };

        int j = 0;
        private WordData currentWord;
        private WordRepo wordRepo;
        private int remainingTime;
        public Game()
        {
            InitializeComponent();

            wordRepo = new WordRepo("Kelimeler.csv");
            currentWord = wordRepo.GetWord();

            if (currentWord == null)
            {
                MessageBox.Show("Belirtilen ayarlara uygun kelime bulunamadı.");
                this.Hide();
                Form1 frm = new Form1(); ;
                frm.Show();

            }
            else
            {


                remainingTime = GameSettings.Instance.GameDuration;
                for (int i = 0; i < currentWord.Word.Length; i++)
                {
                    lblWord.Text += "_ ";
                }
                GameTimer.Start();
                lblinfo.Text = "Süre: " + remainingTime + " saniye - Kategori: " + currentWord.Category + " - Seviye: " + currentWord.Level;
            }




            //button designs
            OvalButton(btnClue);
            OvalButton(btnGuess);
            OvalButton(btnExit);
        }
        // Bu kısımda butonları oval yapıyoruz.
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

        private void Game_Load(object sender, EventArgs e)
        {
            if (GameSettings.Instance.ImageID == 0)
                pictureBox1.Image = Image.FromFile(Manimage[j]);
            if (GameSettings.Instance.ImageID == 1)
                pictureBox1.Image = Image.FromFile(Stickmanimage[j]);
            if (GameSettings.Instance.ImageID == 2)
                pictureBox1.Image = Image.FromFile(Flowerimage[j]);


            lblLength.Text = "Kelime Uzunluğu:" + Convert.ToString(currentWord.Word.Length);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                GameTimer.Stop();
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }
        // Bu kısımda harf tahmin ediliyor.
        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Lütfen bir harf giriniz.");
                return;
            }

            char guess = char.ToLower(textBox1.Text[0]);
            bool correctGuess = false;
            string[] displayedLetters = lblWord.Text.Split(' ');
            char[] wordChars = currentWord.Word.ToLower().ToCharArray();

            for (int i = 0; i < wordChars.Length; i++)
            {
                if (wordChars[i] == guess)
                {
                    displayedLetters[i] = guess.ToString();
                    correctGuess = true;
                }
            }

            lblWord.Text = string.Join(" ", displayedLetters);

            if (!lblWord.Text.Contains("_"))
            {
                this.BackColor = Color.Green;
                DialogResult dialog = MessageBox.Show("Tebrikler! Kelimeyi doğru tahmin ettiniz.\nYeniden başlamak ister misiniz?", "Tebrikler!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                    Game newGame = new Game();
                    newGame.Show();
                }
                else
                {
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();
                }
                return;
            }


            if (!correctGuess)
            {
                if (!lblYanlış.Text.ToLower().Split(' ').Contains(guess.ToString()))
                {
                    lblYanlış.Text += guess + " ";
                }

                j++;

                // Puan düşür ve resmi değiştir
                if (Convert.ToInt32(lblPoint.Text) > 0)
                {
                    lblPoint.Text = Convert.ToString(Convert.ToInt32(lblPoint.Text) - 10);
                }

                if (j < Manimage.Count || j < Stickmanimage.Count || j < Flowerimage.Count)
                {
                    if (GameSettings.Instance.ImageID == 0)
                        pictureBox1.Image = Image.FromFile(Manimage[j]);
                    if (GameSettings.Instance.ImageID == 1)
                        pictureBox1.Image = Image.FromFile(Stickmanimage[j]);
                    if (GameSettings.Instance.ImageID == 2)
                        pictureBox1.Image = Image.FromFile(Flowerimage[j]);
                }

                // Oyun bitme kontrolü: hem puan 0 hem resim son ise
                if (j >= Manimage.Count - 1 || j >= Stickmanimage.Count - 1 || j >= Flowerimage.Count - 1)
                {
                    lblPoint.Text = "0";
                    this.BackColor = Color.Red;
                    GameTimer.Stop();
                    MessageBox.Show("Maalesef tahmin edemediniz! Doğru kelime: " + currentWord.Word);
                    DialogResult dialog = MessageBox.Show("Yeniden başlamak ister misiniz?", "Kaybettiniz!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        this.Hide();
                        Game newGame = new Game();
                        newGame.Show();
                    }
                    else
                    {
                        this.Hide();
                        Form1 form = new Form1();
                        form.Show();
                    }
                }
            }

            // textbox'ı temizle
            textBox1.Clear();
        }


        private void btnClue_Click(object sender, EventArgs e)
        {
            MessageBox.Show(currentWord.Clue);
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            lblTime.Text = $"{remainingTime} saniye";

            if (remainingTime <= 0)
            {
                GameTimer.Stop();
                MessageBox.Show("Süre doldu! Oyunu kaybettiniz.");
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece harf girişine izin ver
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
