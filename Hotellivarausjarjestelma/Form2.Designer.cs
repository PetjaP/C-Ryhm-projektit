namespace Hotellivarausjarjestelma
{
    partial class KirjautumisIkkunaForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.KayttajaTunnusTB = new System.Windows.Forms.TextBox();
            this.SalaSanaTB = new System.Windows.Forms.TextBox();
            this.KirjauduBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(339, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 195);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kirjaudu sisään";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.KirjauduBT);
            this.panel2.Controls.Add(this.SalaSanaTB);
            this.panel2.Controls.Add(this.KayttajaTunnusTB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 242);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Käyttäjätunnus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "Salasana:";
            // 
            // KayttajaTunnusTB
            // 
            this.KayttajaTunnusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajaTunnusTB.Location = new System.Drawing.Point(395, 39);
            this.KayttajaTunnusTB.Name = "KayttajaTunnusTB";
            this.KayttajaTunnusTB.Size = new System.Drawing.Size(526, 53);
            this.KayttajaTunnusTB.TabIndex = 2;
            // 
            // SalaSanaTB
            // 
            this.SalaSanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaSanaTB.Location = new System.Drawing.Point(395, 110);
            this.SalaSanaTB.Name = "SalaSanaTB";
            this.SalaSanaTB.Size = new System.Drawing.Size(526, 53);
            this.SalaSanaTB.TabIndex = 3;
            // 
            // KirjauduBT
            // 
            this.KirjauduBT.Location = new System.Drawing.Point(14, 184);
            this.KirjauduBT.Name = "KirjauduBT";
            this.KirjauduBT.Size = new System.Drawing.Size(907, 44);
            this.KirjauduBT.TabIndex = 4;
            this.KirjauduBT.Text = "Kirjaudu";
            this.KirjauduBT.UseVisualStyleBackColor = true;
            this.KirjauduBT.Click += new System.EventHandler(this.KirjauduBT_Click);
            // 
            // KirjautumisIkkunaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 672);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KirjautumisIkkunaForm";
            this.Text = "Kirjautumisikkuna";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button KirjauduBT;
        private System.Windows.Forms.TextBox SalaSanaTB;
        private System.Windows.Forms.TextBox KayttajaTunnusTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}