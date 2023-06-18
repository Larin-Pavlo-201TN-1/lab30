namespace lab30
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FadList = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbUpload = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tbNewDir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tbRemoveDir = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Підключитись до серверу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Завантажити файл на сервер";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ftp сервер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ім\'я користувача";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(12, 31);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(113, 22);
            this.tbHost.TabIndex = 4;
            this.tbHost.Text = "ftp://192.168.0.106";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(143, 31);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(114, 22);
            this.tbUser.TabIndex = 5;
            this.tbUser.Text = "qwe";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(282, 31);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(114, 22);
            this.tbPass.TabIndex = 7;
            this.tbPass.Text = "qwe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // FadList
            // 
            this.FadList.FormattingEnabled = true;
            this.FadList.ItemHeight = 16;
            this.FadList.Location = new System.Drawing.Point(12, 130);
            this.FadList.Name = "FadList";
            this.FadList.Size = new System.Drawing.Size(252, 68);
            this.FadList.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbUpload
            // 
            this.tbUpload.Location = new System.Drawing.Point(355, 102);
            this.tbUpload.Name = "tbUpload";
            this.tbUpload.Size = new System.Drawing.Size(129, 22);
            this.tbUpload.TabIndex = 10;
            this.tbUpload.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Шлях до дерикторії";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(282, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 44);
            this.button3.TabIndex = 11;
            this.button3.Text = "Створити директорію";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbNewDir
            // 
            this.tbNewDir.Location = new System.Drawing.Point(401, 152);
            this.tbNewDir.Name = "tbNewDir";
            this.tbNewDir.Size = new System.Drawing.Size(129, 22);
            this.tbNewDir.TabIndex = 12;
            this.tbNewDir.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Назва дерикторії";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 44);
            this.button4.TabIndex = 14;
            this.button4.Text = "APPE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(151, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 46);
            this.button5.TabIndex = 15;
            this.button5.Text = "Видалення";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(131, 204);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 46);
            this.button6.TabIndex = 18;
            this.button6.Text = "Завантаження файлу";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 304);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(133, 44);
            this.button7.TabIndex = 21;
            this.button7.Text = "Час останього змінення файлу";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 255);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 44);
            this.button8.TabIndex = 24;
            this.button8.Text = "Розмір файлу";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(608, 9);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(139, 44);
            this.button9.TabIndex = 27;
            this.button9.Text = "Відобразити файли серверу";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(608, 64);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(139, 44);
            this.button10.TabIndex = 28;
            this.button10.Text = "Відобразити файли серверу";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // tbRemoveDir
            // 
            this.tbRemoveDir.Location = new System.Drawing.Point(418, 228);
            this.tbRemoveDir.Name = "tbRemoveDir";
            this.tbRemoveDir.Size = new System.Drawing.Size(163, 22);
            this.tbRemoveDir.TabIndex = 31;
            this.tbRemoveDir.Text = "/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Шлях + назва директорії";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(282, 206);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(133, 44);
            this.button11.TabIndex = 29;
            this.button11.Text = "Видалення директорії";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(282, 259);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(133, 43);
            this.button12.TabIndex = 32;
            this.button12.Text = "Перейменувати";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // tbNewName
            // 
            this.tbNewName.Location = new System.Drawing.Point(418, 280);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(163, 22);
            this.tbNewName.TabIndex = 34;
            this.tbNewName.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Нове ім\'я";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(151, 304);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(113, 44);
            this.button13.TabIndex = 35;
            this.button13.Text = "Upload";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(12, 354);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(252, 44);
            this.button14.TabIndex = 36;
            this.button14.Text = "UploadFileWithUniqueName";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.tbNewName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.tbRemoveDir);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNewDir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbUpload);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FadList);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox FadList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbUpload;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbNewDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox tbRemoveDir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
    }
}

