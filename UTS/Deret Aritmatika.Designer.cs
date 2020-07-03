namespace UTS
{
    partial class Deret_Aritmatika
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
            this.listDeret = new System.Windows.Forms.ListBox();
            this.txtSukuTengah = new System.Windows.Forms.TextBox();
            this.txtBanyakSuku = new System.Windows.Forms.TextBox();
            this.txtSukuPertama = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSukuTerakhir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listDeret
            // 
            this.listDeret.FormattingEnabled = true;
            this.listDeret.Location = new System.Drawing.Point(52, 151);
            this.listDeret.Name = "listDeret";
            this.listDeret.Size = new System.Drawing.Size(67, 95);
            this.listDeret.TabIndex = 17;
            // 
            // txtSukuTengah
            // 
            this.txtSukuTengah.Location = new System.Drawing.Point(149, 167);
            this.txtSukuTengah.Name = "txtSukuTengah";
            this.txtSukuTengah.Size = new System.Drawing.Size(138, 20);
            this.txtSukuTengah.TabIndex = 16;
            // 
            // txtBanyakSuku
            // 
            this.txtBanyakSuku.Location = new System.Drawing.Point(128, 72);
            this.txtBanyakSuku.Name = "txtBanyakSuku";
            this.txtBanyakSuku.Size = new System.Drawing.Size(100, 20);
            this.txtBanyakSuku.TabIndex = 15;
            this.txtBanyakSuku.TextChanged += new System.EventHandler(this.txtBanyakSuku_TextChanged);
            // 
            // txtSukuPertama
            // 
            this.txtSukuPertama.Location = new System.Drawing.Point(128, 42);
            this.txtSukuPertama.Name = "txtSukuPertama";
            this.txtSukuPertama.Size = new System.Drawing.Size(138, 20);
            this.txtSukuPertama.TabIndex = 14;
            this.txtSukuPertama.TextChanged += new System.EventHandler(this.txtSukuPertama_TextChanged);
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(281, 42);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(56, 20);
            this.btnProses.TabIndex = 13;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Suku Tengah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Deret";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Banyaknya Suku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Suku Pertama";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Kembali ke Menu Utama";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(27, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 89);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSukuTerakhir);
            this.groupBox2.Location = new System.Drawing.Point(27, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 150);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUTPUT";
            // 
            // txtSukuTerakhir
            // 
            this.txtSukuTerakhir.Location = new System.Drawing.Point(122, 102);
            this.txtSukuTerakhir.Name = "txtSukuTerakhir";
            this.txtSukuTerakhir.Size = new System.Drawing.Size(138, 20);
            this.txtSukuTerakhir.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Suku Akhir";
            // 
            // Deret_Aritmatika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 378);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listDeret);
            this.Controls.Add(this.txtSukuTengah);
            this.Controls.Add(this.txtBanyakSuku);
            this.Controls.Add(this.txtSukuPertama);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Deret_Aritmatika";
            this.Text = ".: Deret Aritmatika :.";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listDeret;
        private System.Windows.Forms.TextBox txtSukuTengah;
        private System.Windows.Forms.TextBox txtBanyakSuku;
        private System.Windows.Forms.TextBox txtSukuPertama;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSukuTerakhir;
        private System.Windows.Forms.Label label5;
    }
}