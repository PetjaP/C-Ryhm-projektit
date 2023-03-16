namespace Hotellivarausjarjestelma
{
    partial class HuoneidenHallinta
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
            this.uusiHuoneBT = new System.Windows.Forms.Button();
            this.huoneTyyppiCB = new System.Windows.Forms.ComboBox();
            this.huoneetDG = new System.Windows.Forms.DataGridView();
            this.huoneenNumeroTB = new System.Windows.Forms.TextBox();
            this.puhelinTB = new System.Windows.Forms.TextBox();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.muokkaaBT = new System.Windows.Forms.Button();
            this.kyllaRB = new System.Windows.Forms.RadioButton();
            this.eiRB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.poistaBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.huoneetDG)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uusiHuoneBT
            // 
            this.uusiHuoneBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uusiHuoneBT.Location = new System.Drawing.Point(74, 304);
            this.uusiHuoneBT.Name = "uusiHuoneBT";
            this.uusiHuoneBT.Size = new System.Drawing.Size(102, 30);
            this.uusiHuoneBT.TabIndex = 0;
            this.uusiHuoneBT.Text = "Lisää huone";
            this.uusiHuoneBT.UseVisualStyleBackColor = true;
            this.uusiHuoneBT.Click += new System.EventHandler(this.uusiHuoneBT_Click);
            // 
            // huoneTyyppiCB
            // 
            this.huoneTyyppiCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.huoneTyyppiCB.FormattingEnabled = true;
            this.huoneTyyppiCB.Location = new System.Drawing.Point(210, 155);
            this.huoneTyyppiCB.Name = "huoneTyyppiCB";
            this.huoneTyyppiCB.Size = new System.Drawing.Size(168, 28);
            this.huoneTyyppiCB.TabIndex = 1;
            // 
            // huoneetDG
            // 
            this.huoneetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.huoneetDG.Location = new System.Drawing.Point(410, 102);
            this.huoneetDG.Name = "huoneetDG";
            this.huoneetDG.Size = new System.Drawing.Size(445, 261);
            this.huoneetDG.TabIndex = 2;
            this.huoneetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.huoneetDG_CellClick);
            // 
            // huoneenNumeroTB
            // 
            this.huoneenNumeroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.huoneenNumeroTB.Location = new System.Drawing.Point(210, 119);
            this.huoneenNumeroTB.Name = "huoneenNumeroTB";
            this.huoneenNumeroTB.Size = new System.Drawing.Size(168, 26);
            this.huoneenNumeroTB.TabIndex = 3;
            // 
            // puhelinTB
            // 
            this.puhelinTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.puhelinTB.Location = new System.Drawing.Point(210, 189);
            this.puhelinTB.Name = "puhelinTB";
            this.puhelinTB.Size = new System.Drawing.Size(168, 26);
            this.puhelinTB.TabIndex = 4;
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tyhjennaBT.Location = new System.Drawing.Point(74, 340);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(304, 30);
            this.tyhjennaBT.TabIndex = 5;
            this.tyhjennaBT.Text = "Tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // muokkaaBT
            // 
            this.muokkaaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.muokkaaBT.Location = new System.Drawing.Point(182, 304);
            this.muokkaaBT.Name = "muokkaaBT";
            this.muokkaaBT.Size = new System.Drawing.Size(95, 30);
            this.muokkaaBT.TabIndex = 6;
            this.muokkaaBT.Text = "Muokka";
            this.muokkaaBT.UseVisualStyleBackColor = true;
            this.muokkaaBT.Click += new System.EventHandler(this.muokkaaBT_Click);
            // 
            // kyllaRB
            // 
            this.kyllaRB.AutoSize = true;
            this.kyllaRB.Location = new System.Drawing.Point(12, 7);
            this.kyllaRB.Name = "kyllaRB";
            this.kyllaRB.Size = new System.Drawing.Size(59, 24);
            this.kyllaRB.TabIndex = 7;
            this.kyllaRB.TabStop = true;
            this.kyllaRB.Text = "Kyllä";
            this.kyllaRB.UseVisualStyleBackColor = true;
            // 
            // eiRB
            // 
            this.eiRB.AutoSize = true;
            this.eiRB.Location = new System.Drawing.Point(105, 7);
            this.eiRB.Name = "eiRB";
            this.eiRB.Size = new System.Drawing.Size(41, 24);
            this.eiRB.TabIndex = 8;
            this.eiRB.TabStop = true;
            this.eiRB.Text = "Ei";
            this.eiRB.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kyllaRB);
            this.panel1.Controls.Add(this.eiRB);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(210, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 37);
            this.panel1.TabIndex = 9;
            // 
            // poistaBT
            // 
            this.poistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.poistaBT.Location = new System.Drawing.Point(283, 304);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(95, 30);
            this.poistaBT.TabIndex = 10;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Huoneen numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Huoneentyyppi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(45, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Puhelin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(45, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Vapaa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(434, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 39);
            this.label5.TabIndex = 15;
            this.label5.Text = "Huoneiden hallinta";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(-31, -4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 82);
            this.panel2.TabIndex = 16;
            // 
            // HuoneidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(891, 405);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.muokkaaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.puhelinTB);
            this.Controls.Add(this.huoneenNumeroTB);
            this.Controls.Add(this.huoneetDG);
            this.Controls.Add(this.huoneTyyppiCB);
            this.Controls.Add(this.uusiHuoneBT);
            this.Controls.Add(this.panel2);
            this.Name = "HuoneidenHallinta";
            this.Text = "HuoneidenHallinta";
            this.Load += new System.EventHandler(this.HuoneidenHallinta_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.huoneetDG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uusiHuoneBT;
        private System.Windows.Forms.ComboBox huoneTyyppiCB;
        private System.Windows.Forms.DataGridView huoneetDG;
        private System.Windows.Forms.TextBox huoneenNumeroTB;
        private System.Windows.Forms.TextBox puhelinTB;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button muokkaaBT;
        private System.Windows.Forms.RadioButton kyllaRB;
        private System.Windows.Forms.RadioButton eiRB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
    }
}