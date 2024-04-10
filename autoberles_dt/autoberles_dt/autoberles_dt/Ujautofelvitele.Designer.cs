
namespace autoberles_dt
{
    partial class Ujautofelvitele
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rendSzamBox = new System.Windows.Forms.TextBox();
            this.szinBox = new System.Windows.Forms.TextBox();
            this.nevBox = new System.Windows.Forms.TextBox();
            this.evjaratBox = new System.Windows.Forms.TextBox();
            this.berlesArBox = new System.Windows.Forms.TextBox();
            this.kategoriaBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szín:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Név:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Évjárat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bérlés napi ára:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kategória:";
            // 
            // rendSzamBox
            // 
            this.rendSzamBox.Location = new System.Drawing.Point(215, 48);
            this.rendSzamBox.Name = "rendSzamBox";
            this.rendSzamBox.Size = new System.Drawing.Size(100, 20);
            this.rendSzamBox.TabIndex = 6;
            this.rendSzamBox.TextChanged += new System.EventHandler(this.rendSzamBox_TextChanged);
            // 
            // szinBox
            // 
            this.szinBox.Location = new System.Drawing.Point(215, 108);
            this.szinBox.Name = "szinBox";
            this.szinBox.Size = new System.Drawing.Size(100, 20);
            this.szinBox.TabIndex = 7;
            // 
            // nevBox
            // 
            this.nevBox.Location = new System.Drawing.Point(215, 162);
            this.nevBox.Name = "nevBox";
            this.nevBox.Size = new System.Drawing.Size(100, 20);
            this.nevBox.TabIndex = 8;
            // 
            // evjaratBox
            // 
            this.evjaratBox.Location = new System.Drawing.Point(215, 226);
            this.evjaratBox.Name = "evjaratBox";
            this.evjaratBox.Size = new System.Drawing.Size(100, 20);
            this.evjaratBox.TabIndex = 9;
            // 
            // berlesArBox
            // 
            this.berlesArBox.Location = new System.Drawing.Point(215, 278);
            this.berlesArBox.Name = "berlesArBox";
            this.berlesArBox.Size = new System.Drawing.Size(100, 20);
            this.berlesArBox.TabIndex = 10;
            // 
            // kategoriaBox
            // 
            this.kategoriaBox.Location = new System.Drawing.Point(215, 325);
            this.kategoriaBox.Name = "kategoriaBox";
            this.kategoriaBox.Size = new System.Drawing.Size(100, 20);
            this.kategoriaBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Felvétel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ujautofelvitele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kategoriaBox);
            this.Controls.Add(this.berlesArBox);
            this.Controls.Add(this.evjaratBox);
            this.Controls.Add(this.nevBox);
            this.Controls.Add(this.szinBox);
            this.Controls.Add(this.rendSzamBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ujautofelvitele";
            this.Text = "Ujautofelvitele";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox rendSzamBox;
        private System.Windows.Forms.TextBox szinBox;
        private System.Windows.Forms.TextBox nevBox;
        private System.Windows.Forms.TextBox evjaratBox;
        private System.Windows.Forms.TextBox berlesArBox;
        private System.Windows.Forms.TextBox kategoriaBox;
        private System.Windows.Forms.Button button1;
    }
}