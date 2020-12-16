namespace CaruselLato
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Startb = new System.Windows.Forms.Button();
            this.Settingsb = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Startb
            // 
            this.Startb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Startb.Location = new System.Drawing.Point(266, 92);
            this.Startb.Name = "Startb";
            this.Startb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Startb.Size = new System.Drawing.Size(225, 60);
            this.Startb.TabIndex = 0;
            this.Startb.Text = "Начать игру";
            this.Startb.UseVisualStyleBackColor = true;
            this.Startb.Click += new System.EventHandler(this.Startb_Click);
            // 
            // Settingsb
            // 
            this.Settingsb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Settingsb.Location = new System.Drawing.Point(266, 181);
            this.Settingsb.Name = "Settingsb";
            this.Settingsb.Size = new System.Drawing.Size(225, 60);
            this.Settingsb.TabIndex = 1;
            this.Settingsb.Text = "Настройки";
            this.Settingsb.UseVisualStyleBackColor = true;
            this.Settingsb.Click += new System.EventHandler(this.Settingsb_Click);
            // 
            // exitB
            // 
            this.exitB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitB.Location = new System.Drawing.Point(266, 271);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(225, 60);
            this.exitB.TabIndex = 2;
            this.exitB.Text = "Выход";
            this.exitB.UseVisualStyleBackColor = true;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CaruselLato.Properties.Resources._33;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.Settingsb);
            this.Controls.Add(this.Startb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Карусель-лото";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Startb;
        private System.Windows.Forms.Button Settingsb;
        private System.Windows.Forms.Button exitB;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

