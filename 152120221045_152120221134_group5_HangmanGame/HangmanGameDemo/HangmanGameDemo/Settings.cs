using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanGameDemo
{
    public partial class Settings : Form
    {
        
        public Settings()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("Images\\cover2.jpg");
            pictureBox1.Controls.Add(lblBaslik);
            pictureBox1.Controls.Add(lblResim);
            pictureBox1.Controls.Add(lblSure);
            pictureBox1.Controls.Add(lblZorluk);
            OvalButton(btnBack);
            if(GameSettings.Instance.Level != null)
                cbLevel.SelectedItem = GameSettings.Instance.Level;
            if (GameSettings.Instance.GameDuration != null) 
            {
                string time = GameSettings.Instance.GameDuration.ToString();
                cbTime.SelectedItem = time;
            }
                
            if(GameSettings.Instance.ImageID != null)
                cbPicture.SelectedIndex = GameSettings.Instance.ImageID;

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbLevel.SelectedItem != null)
                GameSettings.Instance.Level = cbLevel.SelectedItem.ToString();
            if (cbTime.SelectedItem != null)
                GameSettings.Instance.GameDuration = Convert.ToInt32(cbTime.SelectedItem.ToString());
            if (cbPicture.SelectedItem != null)
                GameSettings.Instance.ImageID = cbPicture.SelectedIndex;

            MessageBox.Show("Ayarlar başarıyla kaydedildi.");

            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
