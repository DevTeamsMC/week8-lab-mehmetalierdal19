namespace HangmanGameDemo
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblBaslik = new Label();
            lblZorluk = new Label();
            lblSure = new Label();
            lblResim = new Label();
            cbLevel = new ComboBox();
            cbTime = new ComboBox();
            cbPicture = new ComboBox();
            btnBack = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-5, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(812, 462);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.BackColor = Color.Transparent;
            lblBaslik.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.Location = new Point(304, 26);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(191, 65);
            lblBaslik.TabIndex = 1;
            lblBaslik.Text = "Ayarlar";
            // 
            // lblZorluk
            // 
            lblZorluk.AutoSize = true;
            lblZorluk.BackColor = Color.Transparent;
            lblZorluk.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblZorluk.Location = new Point(203, 127);
            lblZorluk.Name = "lblZorluk";
            lblZorluk.Size = new Size(80, 30);
            lblZorluk.TabIndex = 2;
            lblZorluk.Text = "Zorluk:";
            // 
            // lblSure
            // 
            lblSure.AutoSize = true;
            lblSure.BackColor = Color.Transparent;
            lblSure.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblSure.Location = new Point(203, 184);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(60, 30);
            lblSure.TabIndex = 4;
            lblSure.Text = "Süre:";
            // 
            // lblResim
            // 
            lblResim.AutoSize = true;
            lblResim.BackColor = Color.Transparent;
            lblResim.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lblResim.Location = new Point(203, 239);
            lblResim.Name = "lblResim";
            lblResim.Size = new Size(74, 30);
            lblResim.TabIndex = 5;
            lblResim.Text = "Resim:";
            // 
            // cbLevel
            // 
            cbLevel.Font = new Font("Segoe UI", 12F);
            cbLevel.FormattingEnabled = true;
            cbLevel.Items.AddRange(new object[] { "Kolay", "Orta", "Zor" });
            cbLevel.Location = new Point(304, 127);
            cbLevel.Name = "cbLevel";
            cbLevel.Size = new Size(243, 29);
            cbLevel.TabIndex = 6;
            // 
            // cbTime
            // 
            cbTime.Font = new Font("Segoe UI", 12F);
            cbTime.FormattingEnabled = true;
            cbTime.Items.AddRange(new object[] { "30", "60\t", "90" });
            cbTime.Location = new Point(304, 184);
            cbTime.Name = "cbTime";
            cbTime.Size = new Size(44, 29);
            cbTime.TabIndex = 8;
            // 
            // cbPicture
            // 
            cbPicture.Font = new Font("Segoe UI", 12F);
            cbPicture.FormattingEnabled = true;
            cbPicture.Items.AddRange(new object[] { "Default", "Stick Man", "Flower" });
            cbPicture.Location = new Point(304, 239);
            cbPicture.Name = "cbPicture";
            cbPicture.Size = new Size(243, 29);
            cbPicture.TabIndex = 9;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Tomato;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(60, 375);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(41, 42);
            btnBack.TabIndex = 10;
            btnBack.Text = "<";
            btnBack.TextAlign = ContentAlignment.TopCenter;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(375, 306);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(96, 38);
            btnSave.TabIndex = 11;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnBack);
            Controls.Add(cbPicture);
            Controls.Add(cbTime);
            Controls.Add(cbLevel);
            Controls.Add(lblResim);
            Controls.Add(lblSure);
            Controls.Add(lblZorluk);
            Controls.Add(lblBaslik);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ayarlar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblBaslik;
        private Label lblZorluk;
        private Label lblSure;
        private Label lblResim;
        private ComboBox cbLevel;
        private ComboBox cbTime;
        private ComboBox cbPicture;
        private Button btnBack;
        private Button btnSave;
    }
}