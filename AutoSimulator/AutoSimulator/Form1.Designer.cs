namespace AutoSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_off = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Honk = new System.Windows.Forms.Button();
            this.btn_on = new System.Windows.Forms.Button();
            this.lbl_gang = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_onoroff = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto Wählen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(379, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_off);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.btn_Honk);
            this.groupBox1.Controls.Add(this.btn_on);
            this.groupBox1.Controls.Add(this.lbl_gang);
            this.groupBox1.Controls.Add(this.lbl_speed);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lbl_onoroff);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(23, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 290);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(375, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(176, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "km/h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(362, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gang";
            // 
            // btn_off
            // 
            this.btn_off.Location = new System.Drawing.Point(57, 89);
            this.btn_off.Name = "btn_off";
            this.btn_off.Size = new System.Drawing.Size(30, 22);
            this.btn_off.TabIndex = 13;
            this.btn_off.Text = "Off";
            this.btn_off.UseVisualStyleBackColor = true;
            this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(93, 49);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 13);
            this.lbl_Status.TabIndex = 12;
            // 
            // btn_Honk
            // 
            this.btn_Honk.Location = new System.Drawing.Point(23, 195);
            this.btn_Honk.Name = "btn_Honk";
            this.btn_Honk.Size = new System.Drawing.Size(64, 22);
            this.btn_Honk.TabIndex = 11;
            this.btn_Honk.Text = "Hupen";
            this.btn_Honk.UseVisualStyleBackColor = true;
            this.btn_Honk.Click += new System.EventHandler(this.btn_Honk_Click);
            // 
            // btn_on
            // 
            this.btn_on.Location = new System.Drawing.Point(23, 90);
            this.btn_on.Name = "btn_on";
            this.btn_on.Size = new System.Drawing.Size(30, 22);
            this.btn_on.TabIndex = 10;
            this.btn_on.Text = "On";
            this.btn_on.UseVisualStyleBackColor = true;
            this.btn_on.Click += new System.EventHandler(this.btn_on_Click_1);
            // 
            // lbl_gang
            // 
            this.lbl_gang.AutoSize = true;
            this.lbl_gang.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbl_gang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_gang.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_gang.Location = new System.Drawing.Point(382, 67);
            this.lbl_gang.Name = "lbl_gang";
            this.lbl_gang.Size = new System.Drawing.Size(0, 17);
            this.lbl_gang.TabIndex = 9;
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbl_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.lbl_speed.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_speed.Location = new System.Drawing.Point(188, 79);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(20, 22);
            this.lbl_speed.TabIndex = 8;
            this.lbl_speed.Text = "0";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(361, 67);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(97, 49);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(174, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 49);
            this.button4.TabIndex = 6;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(155, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 80);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 127);
            this.button2.TabIndex = 4;
            this.button2.Text = "Gas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 127);
            this.button1.TabIndex = 3;
            this.button1.Text = "Bremse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // lbl_onoroff
            // 
            this.lbl_onoroff.AutoSize = true;
            this.lbl_onoroff.Location = new System.Drawing.Point(93, 31);
            this.lbl_onoroff.Name = "lbl_onoroff";
            this.lbl_onoroff.Size = new System.Drawing.Size(40, 13);
            this.lbl_onoroff.TabIndex = 2;
            this.lbl_onoroff.Text = "Status:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AutoSimulator.Properties.Resources.R;
            this.pictureBox2.Location = new System.Drawing.Point(23, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AutoSimulator.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(23, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(528, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_onoroff;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lbl_gang;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Button btn_on;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Honk;
        private System.Windows.Forms.Button btn_off;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
    }
}

