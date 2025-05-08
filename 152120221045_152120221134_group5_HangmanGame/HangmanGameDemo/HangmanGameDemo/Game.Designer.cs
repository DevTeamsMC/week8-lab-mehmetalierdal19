namespace HangmanGameDemo
{
    partial class Game
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
            components = new System.ComponentModel.Container();
            btnExit = new Button();
            btnGuess = new Button();
            textBox1 = new TextBox();
            lblPoint = new Label();
            lblWrongWords = new Label();
            lblCount = new Label();
            lblYanlış = new Label();
            lblLength = new Label();
            btnClue = new Button();
            lblWord = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lblinfo = new Label();
            label2 = new Label();
            label3 = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            lblTime = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Tomato;
            btnExit.FlatAppearance.BorderColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(269, 268);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 42);
            btnExit.TabIndex = 10;
            btnExit.Text = "Oyunu Bitir";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnGuess
            // 
            btnGuess.BackColor = Color.Green;
            btnGuess.FlatAppearance.BorderColor = Color.White;
            btnGuess.FlatAppearance.BorderSize = 0;
            btnGuess.FlatStyle = FlatStyle.Flat;
            btnGuess.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuess.ForeColor = Color.White;
            btnGuess.Location = new Point(139, 268);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(115, 42);
            btnGuess.TabIndex = 9;
            btnGuess.Text = "Tahmin Et";
            btnGuess.UseVisualStyleBackColor = false;
            btnGuess.Click += btnGuess_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(16, 268);
            textBox1.MaxLength = 1;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(65, 43);
            textBox1.TabIndex = 8;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPoint.Location = new Point(16, 222);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(45, 25);
            lblPoint.TabIndex = 7;
            lblPoint.Text = "100";
            // 
            // lblWrongWords
            // 
            lblWrongWords.AutoSize = true;
            lblWrongWords.Location = new Point(139, 173);
            lblWrongWords.Name = "lblWrongWords";
            lblWrongWords.Size = new Size(0, 15);
            lblWrongWords.TabIndex = 6;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(139, 144);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 15);
            lblCount.TabIndex = 6;
            // 
            // lblYanlış
            // 
            lblYanlış.AutoSize = true;
            lblYanlış.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYanlış.Location = new Point(16, 173);
            lblYanlış.Name = "lblYanlış";
            lblYanlış.Size = new Size(115, 17);
            lblYanlış.TabIndex = 5;
            lblYanlış.Text = "Yanlış Tahminler:";
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLength.Location = new Point(16, 142);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(117, 17);
            lblLength.TabIndex = 4;
            lblLength.Text = "Kelime Uzunluğu:";
            // 
            // btnClue
            // 
            btnClue.BackColor = Color.FromArgb(255, 128, 0);
            btnClue.FlatAppearance.BorderColor = Color.White;
            btnClue.FlatAppearance.BorderSize = 0;
            btnClue.FlatStyle = FlatStyle.Flat;
            btnClue.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnClue.ForeColor = SystemColors.Control;
            btnClue.Location = new Point(304, 77);
            btnClue.Name = "btnClue";
            btnClue.Size = new Size(75, 27);
            btnClue.TabIndex = 3;
            btnClue.Text = "İpucu?";
            btnClue.UseVisualStyleBackColor = false;
            btnClue.Click += btnClue_Click;
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.BackColor = SystemColors.ControlDarkDark;
            lblWord.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblWord.Location = new Point(16, 28);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(0, 37);
            lblWord.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(30, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 274);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(308, 34);
            label1.Name = "label1";
            label1.Size = new Size(174, 40);
            label1.TabIndex = 2;
            label1.Text = "HANGMAN";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(lblLength);
            panel1.Controls.Add(btnGuess);
            panel1.Controls.Add(lblWord);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btnClue);
            panel1.Controls.Add(lblPoint);
            panel1.Controls.Add(lblYanlış);
            panel1.Controls.Add(lblWrongWords);
            panel1.Controls.Add(lblCount);
            panel1.Location = new Point(18, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 341);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(449, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(354, 341);
            panel2.TabIndex = 4;
            // 
            // lblinfo
            // 
            lblinfo.AutoSize = true;
            lblinfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblinfo.Location = new Point(18, 443);
            lblinfo.Name = "lblinfo";
            lblinfo.Size = new Size(343, 21);
            lblinfo.TabIndex = 5;
            lblinfo.Text = "Süre: 30 saniye - Kategori: Spor - Seviye: Orta ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 489);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 494);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // GameTimer
            // 
            GameTimer.Interval = 1000;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTime.Location = new Point(18, 54);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 20);
            lblTime.TabIndex = 8;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(825, 526);
            Controls.Add(lblTime);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblinfo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hangman";
            Load += Game_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblWord;
        private Button btnClue;
        private Label lblWrongWords;
        private Label lblCount;
        private Label lblYanlış;
        private Label lblLength;
        private Label lblPoint;
        private PictureBox pictureBox1;
        private Button btnGuess;
        private TextBox textBox1;
        private Button btnExit;
        private Panel panel1;
        private Panel panel2;
        private Label lblinfo;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer GameTimer;
        private Label lblTime;
    }
}