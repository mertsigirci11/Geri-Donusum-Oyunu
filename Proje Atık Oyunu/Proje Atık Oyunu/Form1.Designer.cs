namespace Proje_Atık_Oyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.puanLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.cikisButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yeniOyunButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.organikListBox = new System.Windows.Forms.ListBox();
            this.organikBosaltButton = new System.Windows.Forms.Button();
            this.organikProgressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.kagitButton = new System.Windows.Forms.Button();
            this.kagitListBox = new System.Windows.Forms.ListBox();
            this.kagitProgressBar = new System.Windows.Forms.ProgressBar();
            this.kagitBosaltButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.organikButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.camButton = new System.Windows.Forms.Button();
            this.camBosaltButton = new System.Windows.Forms.Button();
            this.camProgressBar = new System.Windows.Forms.ProgressBar();
            this.camListBox = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.metalButton = new System.Windows.Forms.Button();
            this.metalBosaltButton = new System.Windows.Forms.Button();
            this.metalProgressBar = new System.Windows.Forms.ProgressBar();
            this.metalListBox = new System.Windows.Forms.ListBox();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // puanLabel
            // 
            this.puanLabel.BackColor = System.Drawing.Color.Silver;
            this.puanLabel.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanLabel.Location = new System.Drawing.Point(25, 290);
            this.puanLabel.Name = "puanLabel";
            this.puanLabel.Size = new System.Drawing.Size(186, 43);
            this.puanLabel.TabIndex = 6;
            this.puanLabel.Text = "0";
            this.puanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "PUAN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLabel
            // 
            this.timerLabel.BackColor = System.Drawing.Color.Silver;
            this.timerLabel.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timerLabel.Location = new System.Drawing.Point(25, 168);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(186, 43);
            this.timerLabel.TabIndex = 5;
            this.timerLabel.Text = "60";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.Color.Turquoise;
            this.cikisButton.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisButton.Location = new System.Drawing.Point(25, 355);
            this.cikisButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(186, 69);
            this.cikisButton.TabIndex = 4;
            this.cikisButton.Text = "ÇIKIŞ";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "SÜRE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yeniOyunButton
            // 
            this.yeniOyunButton.BackColor = System.Drawing.Color.Turquoise;
            this.yeniOyunButton.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeniOyunButton.Location = new System.Drawing.Point(25, 24);
            this.yeniOyunButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.yeniOyunButton.Name = "yeniOyunButton";
            this.yeniOyunButton.Size = new System.Drawing.Size(186, 69);
            this.yeniOyunButton.TabIndex = 0;
            this.yeniOyunButton.Text = "YENİ OYUN";
            this.yeniOyunButton.UseVisualStyleBackColor = false;
            this.yeniOyunButton.Click += new System.EventHandler(this.yeniOyunButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(299, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "ATIK KUTULARI";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // organikListBox
            // 
            this.organikListBox.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.organikListBox.FormattingEnabled = true;
            this.organikListBox.ItemHeight = 19;
            this.organikListBox.Location = new System.Drawing.Point(3, 56);
            this.organikListBox.Name = "organikListBox";
            this.organikListBox.Size = new System.Drawing.Size(220, 156);
            this.organikListBox.TabIndex = 3;
            // 
            // organikBosaltButton
            // 
            this.organikBosaltButton.BackColor = System.Drawing.Color.Turquoise;
            this.organikBosaltButton.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.organikBosaltButton.Location = new System.Drawing.Point(3, 246);
            this.organikBosaltButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.organikBosaltButton.Name = "organikBosaltButton";
            this.organikBosaltButton.Size = new System.Drawing.Size(220, 41);
            this.organikBosaltButton.TabIndex = 2;
            this.organikBosaltButton.Text = "BOŞALT";
            this.organikBosaltButton.UseVisualStyleBackColor = false;
            this.organikBosaltButton.Click += new System.EventHandler(this.organikBosaltButton_Click);
            // 
            // organikProgressBar
            // 
            this.organikProgressBar.Location = new System.Drawing.Point(3, 218);
            this.organikProgressBar.Name = "organikProgressBar";
            this.organikProgressBar.Size = new System.Drawing.Size(218, 23);
            this.organikProgressBar.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox4.Controls.Add(this.kagitButton);
            this.groupBox4.Controls.Add(this.kagitListBox);
            this.groupBox4.Controls.Add(this.kagitProgressBar);
            this.groupBox4.Controls.Add(this.kagitBosaltButton);
            this.groupBox4.Location = new System.Drawing.Point(540, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 300);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // kagitButton
            // 
            this.kagitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.kagitButton.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kagitButton.Location = new System.Drawing.Point(3, 9);
            this.kagitButton.Name = "kagitButton";
            this.kagitButton.Size = new System.Drawing.Size(220, 41);
            this.kagitButton.TabIndex = 7;
            this.kagitButton.Text = "KAĞIT ATIK";
            this.kagitButton.UseVisualStyleBackColor = false;
            this.kagitButton.Click += new System.EventHandler(this.kagitButton_Click);
            // 
            // kagitListBox
            // 
            this.kagitListBox.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kagitListBox.FormattingEnabled = true;
            this.kagitListBox.ItemHeight = 19;
            this.kagitListBox.Location = new System.Drawing.Point(3, 56);
            this.kagitListBox.Name = "kagitListBox";
            this.kagitListBox.Size = new System.Drawing.Size(220, 156);
            this.kagitListBox.TabIndex = 6;
            // 
            // kagitProgressBar
            // 
            this.kagitProgressBar.Location = new System.Drawing.Point(3, 217);
            this.kagitProgressBar.Name = "kagitProgressBar";
            this.kagitProgressBar.Size = new System.Drawing.Size(220, 23);
            this.kagitProgressBar.TabIndex = 5;
            // 
            // kagitBosaltButton
            // 
            this.kagitBosaltButton.BackColor = System.Drawing.Color.Turquoise;
            this.kagitBosaltButton.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kagitBosaltButton.Location = new System.Drawing.Point(3, 246);
            this.kagitBosaltButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.kagitBosaltButton.Name = "kagitBosaltButton";
            this.kagitBosaltButton.Size = new System.Drawing.Size(220, 41);
            this.kagitBosaltButton.TabIndex = 3;
            this.kagitBosaltButton.Text = "BOŞALT";
            this.kagitBosaltButton.UseVisualStyleBackColor = false;
            this.kagitBosaltButton.Click += new System.EventHandler(this.kagitBosaltButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 168);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Location = new System.Drawing.Point(19, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.cikisButton);
            this.panel2.Controls.Add(this.puanLabel);
            this.panel2.Controls.Add(this.yeniOyunButton);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.timerLabel);
            this.panel2.Location = new System.Drawing.Point(13, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 448);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.organikButton);
            this.panel3.Controls.Add(this.organikBosaltButton);
            this.panel3.Controls.Add(this.organikProgressBar);
            this.panel3.Controls.Add(this.organikListBox);
            this.panel3.Location = new System.Drawing.Point(299, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 300);
            this.panel3.TabIndex = 13;
            // 
            // organikButton
            // 
            this.organikButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.organikButton.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.organikButton.Location = new System.Drawing.Point(3, 9);
            this.organikButton.Name = "organikButton";
            this.organikButton.Size = new System.Drawing.Size(220, 41);
            this.organikButton.TabIndex = 4;
            this.organikButton.Text = "ORGANİK ATIK";
            this.organikButton.UseVisualStyleBackColor = false;
            this.organikButton.Click += new System.EventHandler(this.organikButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.camButton);
            this.panel4.Controls.Add(this.camBosaltButton);
            this.panel4.Controls.Add(this.camProgressBar);
            this.panel4.Controls.Add(this.camListBox);
            this.panel4.Location = new System.Drawing.Point(299, 357);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 300);
            this.panel4.TabIndex = 14;
            // 
            // camButton
            // 
            this.camButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.camButton.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.camButton.Location = new System.Drawing.Point(3, 9);
            this.camButton.Name = "camButton";
            this.camButton.Size = new System.Drawing.Size(220, 41);
            this.camButton.TabIndex = 4;
            this.camButton.Text = "CAM ATIK";
            this.camButton.UseVisualStyleBackColor = false;
            this.camButton.Click += new System.EventHandler(this.camButton_Click);
            // 
            // camBosaltButton
            // 
            this.camBosaltButton.BackColor = System.Drawing.Color.Turquoise;
            this.camBosaltButton.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.camBosaltButton.Location = new System.Drawing.Point(3, 247);
            this.camBosaltButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.camBosaltButton.Name = "camBosaltButton";
            this.camBosaltButton.Size = new System.Drawing.Size(222, 41);
            this.camBosaltButton.TabIndex = 2;
            this.camBosaltButton.Text = "BOŞALT";
            this.camBosaltButton.UseVisualStyleBackColor = false;
            this.camBosaltButton.Click += new System.EventHandler(this.camBosaltButton_Click);
            // 
            // camProgressBar
            // 
            this.camProgressBar.Location = new System.Drawing.Point(3, 218);
            this.camProgressBar.Name = "camProgressBar";
            this.camProgressBar.Size = new System.Drawing.Size(220, 23);
            this.camProgressBar.TabIndex = 1;
            // 
            // camListBox
            // 
            this.camListBox.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.camListBox.FormattingEnabled = true;
            this.camListBox.ItemHeight = 19;
            this.camListBox.Location = new System.Drawing.Point(3, 56);
            this.camListBox.Name = "camListBox";
            this.camListBox.Size = new System.Drawing.Size(220, 156);
            this.camListBox.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel5.Controls.Add(this.metalButton);
            this.panel5.Controls.Add(this.metalBosaltButton);
            this.panel5.Controls.Add(this.metalProgressBar);
            this.panel5.Controls.Add(this.metalListBox);
            this.panel5.Location = new System.Drawing.Point(540, 357);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(227, 300);
            this.panel5.TabIndex = 15;
            // 
            // metalButton
            // 
            this.metalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.metalButton.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metalButton.Location = new System.Drawing.Point(3, 9);
            this.metalButton.Name = "metalButton";
            this.metalButton.Size = new System.Drawing.Size(220, 41);
            this.metalButton.TabIndex = 4;
            this.metalButton.Text = "METAL ATIK";
            this.metalButton.UseVisualStyleBackColor = false;
            this.metalButton.Click += new System.EventHandler(this.metalButton_Click);
            // 
            // metalBosaltButton
            // 
            this.metalBosaltButton.BackColor = System.Drawing.Color.Turquoise;
            this.metalBosaltButton.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metalBosaltButton.Location = new System.Drawing.Point(3, 247);
            this.metalBosaltButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metalBosaltButton.Name = "metalBosaltButton";
            this.metalBosaltButton.Size = new System.Drawing.Size(220, 41);
            this.metalBosaltButton.TabIndex = 2;
            this.metalBosaltButton.Text = "BOŞALT";
            this.metalBosaltButton.UseVisualStyleBackColor = false;
            this.metalBosaltButton.Click += new System.EventHandler(this.metalBosaltButton_Click);
            // 
            // metalProgressBar
            // 
            this.metalProgressBar.Location = new System.Drawing.Point(3, 218);
            this.metalProgressBar.Name = "metalProgressBar";
            this.metalProgressBar.Size = new System.Drawing.Size(220, 23);
            this.metalProgressBar.TabIndex = 1;
            // 
            // metalListBox
            // 
            this.metalListBox.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metalListBox.FormattingEnabled = true;
            this.metalListBox.ItemHeight = 19;
            this.metalListBox.Location = new System.Drawing.Point(3, 56);
            this.metalListBox.Name = "metalListBox";
            this.metalListBox.Size = new System.Drawing.Size(220, 156);
            this.metalListBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(779, 667);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATIK TOPLAMA OYUNU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label puanLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yeniOyunButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button organikBosaltButton;
        private System.Windows.Forms.ProgressBar organikProgressBar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox organikListBox;
        private System.Windows.Forms.ListBox kagitListBox;
        private System.Windows.Forms.ProgressBar kagitProgressBar;
        private System.Windows.Forms.Button kagitBosaltButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button kagitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button organikButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button camButton;
        private System.Windows.Forms.Button camBosaltButton;
        private System.Windows.Forms.ProgressBar camProgressBar;
        private System.Windows.Forms.ListBox camListBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button metalButton;
        private System.Windows.Forms.Button metalBosaltButton;
        private System.Windows.Forms.ProgressBar metalProgressBar;
        private System.Windows.Forms.ListBox metalListBox;
    }
}

