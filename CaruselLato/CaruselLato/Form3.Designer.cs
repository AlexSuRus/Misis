namespace CaruselLato
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Backb = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CNOTC1 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.g1 = new System.Windows.Forms.Button();
            this.j1 = new System.Windows.Forms.Button();
            this.e1 = new System.Windows.Forms.Button();
            this.d1 = new System.Windows.Forms.Button();
            this.j2 = new System.Windows.Forms.Button();
            this.e2 = new System.Windows.Forms.Button();
            this.d2 = new System.Windows.Forms.Button();
            this.g2 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.CNOTC2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.C1CCET = new System.Windows.Forms.Button();
            this.C1CCET2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textbox1b = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Backb
            // 
            this.Backb.Location = new System.Drawing.Point(12, 12);
            this.Backb.Name = "Backb";
            this.Backb.Size = new System.Drawing.Size(70, 58);
            this.Backb.TabIndex = 0;
            this.Backb.Text = "Меню";
            this.Backb.UseVisualStyleBackColor = true;
            this.Backb.Click += new System.EventHandler(this.Backb_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(221, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Yu Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Location = new System.Drawing.Point(157, 12);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(476, 36);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "Предыдущее число: 0";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(188, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(643, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            // 
            // CNOTC1
            // 
            this.CNOTC1.Location = new System.Drawing.Point(12, 117);
            this.CNOTC1.Name = "CNOTC1";
            this.CNOTC1.Size = new System.Drawing.Size(100, 33);
            this.CNOTC1.TabIndex = 5;
            this.CNOTC1.Text = "а)НЕЧЕТ";
            this.CNOTC1.UseVisualStyleBackColor = true;
            this.CNOTC1.Click += new System.EventHandler(this.CNOTC1_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 156);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(203, 33);
            this.b1.TabIndex = 6;
            this.b1.Text = "б) [1, 18] или [19, 36]";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(12, 195);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(203, 33);
            this.c1.TabIndex = 7;
            this.c1.Text = "в) [1, 12], [13, 24], [25, 36]";
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.c1_Click);
            // 
            // g1
            // 
            this.g1.Location = new System.Drawing.Point(12, 234);
            this.g1.Name = "g1";
            this.g1.Size = new System.Drawing.Size(203, 45);
            this.g1.TabIndex = 8;
            this.g1.Text = "г) [1, 9], [10, 18], [19,27], [28,36]";
            this.g1.UseVisualStyleBackColor = true;
            this.g1.Click += new System.EventHandler(this.g1_Click);
            // 
            // j1
            // 
            this.j1.Location = new System.Drawing.Point(12, 380);
            this.j1.Name = "j1";
            this.j1.Size = new System.Drawing.Size(203, 33);
            this.j1.TabIndex = 11;
            this.j1.Text = " ж)[1, 2], [3, 4], ..., [35, 36]";
            this.j1.UseVisualStyleBackColor = true;
            this.j1.Click += new System.EventHandler(this.j1_Click);
            // 
            // e1
            // 
            this.e1.Location = new System.Drawing.Point(12, 337);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(203, 37);
            this.e1.TabIndex = 10;
            this.e1.Text = " е)[1, 3], [4, 6], ..., [34, 36]";
            this.e1.UseVisualStyleBackColor = true;
            this.e1.Click += new System.EventHandler(this.e1_Click);
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(12, 279);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(203, 52);
            this.d1.TabIndex = 9;
            this.d1.Text = "д) [1, 6], [7, 12], [13, 18], [19, 24], [25, 30], [31, 36]";
            this.d1.UseVisualStyleBackColor = true;
            this.d1.Click += new System.EventHandler(this.d1_Click);
            // 
            // j2
            // 
            this.j2.Location = new System.Drawing.Point(647, 380);
            this.j2.Name = "j2";
            this.j2.Size = new System.Drawing.Size(203, 33);
            this.j2.TabIndex = 19;
            this.j2.Text = "ж) [1, 2], [3, 4], ..., [35, 36];";
            this.j2.UseVisualStyleBackColor = true;
            this.j2.Click += new System.EventHandler(this.j2_Click);
            // 
            // e2
            // 
            this.e2.Location = new System.Drawing.Point(648, 337);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(203, 37);
            this.e2.TabIndex = 18;
            this.e2.Text = " e)[1, 3], [4, 6], ..., [34, 36]";
            this.e2.UseVisualStyleBackColor = true;
            this.e2.Click += new System.EventHandler(this.e2_Click);
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(648, 279);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(203, 52);
            this.d2.TabIndex = 17;
            this.d2.Text = " д)[1, 6], [7, 12], [13, 18], [19, 24], [25, 30], [31, 36]";
            this.d2.UseVisualStyleBackColor = true;
            this.d2.Click += new System.EventHandler(this.d2_Click);
            // 
            // g2
            // 
            this.g2.Location = new System.Drawing.Point(648, 234);
            this.g2.Name = "g2";
            this.g2.Size = new System.Drawing.Size(203, 45);
            this.g2.TabIndex = 16;
            this.g2.Text = "г)[1, 9], [10, 18], [19,27], [28,36]";
            this.g2.UseVisualStyleBackColor = true;
            this.g2.Click += new System.EventHandler(this.g2_Click);
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(648, 195);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(203, 33);
            this.c2.TabIndex = 15;
            this.c2.Text = " в)[1, 12], [13, 24], [25, 36]";
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.c2_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(648, 156);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(203, 33);
            this.b2.TabIndex = 14;
            this.b2.Text = "б) [1, 18] или [19, 36]";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // CNOTC2
            // 
            this.CNOTC2.Location = new System.Drawing.Point(648, 117);
            this.CNOTC2.Name = "CNOTC2";
            this.CNOTC2.Size = new System.Drawing.Size(92, 33);
            this.CNOTC2.TabIndex = 13;
            this.CNOTC2.Text = "а)НЕЧЕТ";
            this.CNOTC2.UseVisualStyleBackColor = true;
            this.CNOTC2.Click += new System.EventHandler(this.CNOTC2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(648, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 22);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "0";
            // 
            // C1CCET
            // 
            this.C1CCET.Location = new System.Drawing.Point(118, 117);
            this.C1CCET.Name = "C1CCET";
            this.C1CCET.Size = new System.Drawing.Size(97, 33);
            this.C1CCET.TabIndex = 23;
            this.C1CCET.Text = "а)ЧЕТ";
            this.C1CCET.UseVisualStyleBackColor = true;
            this.C1CCET.Click += new System.EventHandler(this.C1CCET_Click);
            // 
            // C1CCET2
            // 
            this.C1CCET2.Location = new System.Drawing.Point(746, 117);
            this.C1CCET2.Name = "C1CCET2";
            this.C1CCET2.Size = new System.Drawing.Size(104, 33);
            this.C1CCET2.TabIndex = 24;
            this.C1CCET2.Text = "а)ЧЕТ";
            this.C1CCET2.UseVisualStyleBackColor = true;
            this.C1CCET2.Click += new System.EventHandler(this.C1CCET2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(97, 22);
            this.textBox3.TabIndex = 25;
            this.textBox3.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(746, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(104, 22);
            this.textBox4.TabIndex = 26;
            this.textBox4.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(776, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 58);
            this.button1.TabIndex = 27;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textbox1b
            // 
            this.textbox1b.Location = new System.Drawing.Point(12, 422);
            this.textbox1b.Name = "textbox1b";
            this.textbox1b.Size = new System.Drawing.Size(203, 23);
            this.textbox1b.TabIndex = 28;
            this.textbox1b.Text = "з) Выдадает число К";
            this.textbox1b.UseVisualStyleBackColor = true;
            this.textbox1b.Click += new System.EventHandler(this.textbox1b_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "з) Выдадает число К";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CaruselLato.Properties.Resources._33;
            this.ClientSize = new System.Drawing.Size(872, 457);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textbox1b);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.C1CCET2);
            this.Controls.Add(this.C1CCET);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.j2);
            this.Controls.Add(this.e2);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.g2);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.CNOTC2);
            this.Controls.Add(this.j1);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.g1);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.CNOTC1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Backb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Карусель-лото";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CNOTC1;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button g1;
        private System.Windows.Forms.Button j1;
        private System.Windows.Forms.Button e1;
        private System.Windows.Forms.Button d1;
        private System.Windows.Forms.Button j2;
        private System.Windows.Forms.Button e2;
        private System.Windows.Forms.Button d2;
        private System.Windows.Forms.Button g2;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button CNOTC2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button C1CCET;
        private System.Windows.Forms.Button C1CCET2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button textbox1b;
        private System.Windows.Forms.Button button2;
    }
}