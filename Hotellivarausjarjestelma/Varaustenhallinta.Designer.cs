namespace Hotellivarausjarjestelma
{
    partial class testLB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.varauksetDG = new System.Windows.Forms.DataGridView();
            this.lisaaVarausBT = new System.Windows.Forms.Button();
            this.muokkaaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.varausNroTB = new System.Windows.Forms.TextBox();
            this.huoneTyyppiCB = new System.Windows.Forms.ComboBox();
            this.huoneenNroCB = new System.Windows.Forms.ComboBox();
            this.sisaanDTP = new System.Windows.Forms.DateTimePicker();
            this.ulosDTP = new System.Windows.Forms.DateTimePicker();
            this.asiakasNroCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varausten hallinta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Varaus nro.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Asiakas nro.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Huonetyyppi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Huoneen nro.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sisään:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 403);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ulos:";
            // 
            // varauksetDG
            // 
            this.varauksetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varauksetDG.Location = new System.Drawing.Point(452, 136);
            this.varauksetDG.Name = "varauksetDG";
            this.varauksetDG.Size = new System.Drawing.Size(513, 410);
            this.varauksetDG.TabIndex = 7;
            this.varauksetDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varauksetDG_CellClick);
            this.varauksetDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.varauksetDG_CellContentClick);
            // 
            // lisaaVarausBT
            // 
            this.lisaaVarausBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lisaaVarausBT.Location = new System.Drawing.Point(32, 453);
            this.lisaaVarausBT.Name = "lisaaVarausBT";
            this.lisaaVarausBT.Size = new System.Drawing.Size(127, 33);
            this.lisaaVarausBT.TabIndex = 8;
            this.lisaaVarausBT.Text = "Lisää varaus";
            this.lisaaVarausBT.UseVisualStyleBackColor = true;
            this.lisaaVarausBT.Click += new System.EventHandler(this.lisaaVarausBT_Click);
            // 
            // muokkaaBT
            // 
            this.muokkaaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muokkaaBT.Location = new System.Drawing.Point(196, 454);
            this.muokkaaBT.Name = "muokkaaBT";
            this.muokkaaBT.Size = new System.Drawing.Size(109, 32);
            this.muokkaaBT.TabIndex = 9;
            this.muokkaaBT.Text = "Muokkaa";
            this.muokkaaBT.UseVisualStyleBackColor = true;
            this.muokkaaBT.Click += new System.EventHandler(this.muokkaaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poistaBT.Location = new System.Drawing.Point(342, 452);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(81, 33);
            this.poistaBT.TabIndex = 10;
            this.poistaBT.Text = "Poista";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyhjennaBT.Location = new System.Drawing.Point(281, 513);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(142, 33);
            this.tyhjennaBT.TabIndex = 11;
            this.tyhjennaBT.Text = "Tyhjennä";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // varausNroTB
            // 
            this.varausNroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varausNroTB.Location = new System.Drawing.Point(207, 143);
            this.varausNroTB.Name = "varausNroTB";
            this.varausNroTB.Size = new System.Drawing.Size(239, 31);
            this.varausNroTB.TabIndex = 12;
            // 
            // huoneTyyppiCB
            // 
            this.huoneTyyppiCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneTyyppiCB.FormattingEnabled = true;
            this.huoneTyyppiCB.Location = new System.Drawing.Point(207, 243);
            this.huoneTyyppiCB.Name = "huoneTyyppiCB";
            this.huoneTyyppiCB.Size = new System.Drawing.Size(239, 33);
            this.huoneTyyppiCB.TabIndex = 14;
            this.huoneTyyppiCB.SelectedIndexChanged += new System.EventHandler(this.huoneTyyppiCB_SelectedIndexChanged);
            // 
            // huoneenNroCB
            // 
            this.huoneenNroCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huoneenNroCB.FormattingEnabled = true;
            this.huoneenNroCB.Location = new System.Drawing.Point(207, 295);
            this.huoneenNroCB.Name = "huoneenNroCB";
            this.huoneenNroCB.Size = new System.Drawing.Size(239, 33);
            this.huoneenNroCB.TabIndex = 15;
            // 
            // sisaanDTP
            // 
            this.sisaanDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sisaanDTP.Location = new System.Drawing.Point(207, 351);
            this.sisaanDTP.Name = "sisaanDTP";
            this.sisaanDTP.Size = new System.Drawing.Size(239, 31);
            this.sisaanDTP.TabIndex = 16;
            // 
            // ulosDTP
            // 
            this.ulosDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ulosDTP.Location = new System.Drawing.Point(207, 403);
            this.ulosDTP.Name = "ulosDTP";
            this.ulosDTP.Size = new System.Drawing.Size(239, 31);
            this.ulosDTP.TabIndex = 17;
            // 
            // asiakasNroCB
            // 
            this.asiakasNroCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asiakasNroCB.FormattingEnabled = true;
            this.asiakasNroCB.Location = new System.Drawing.Point(207, 191);
            this.asiakasNroCB.Name = "asiakasNroCB";
            this.asiakasNroCB.Size = new System.Drawing.Size(239, 33);
            this.asiakasNroCB.TabIndex = 18;
            // 
            // testLB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(977, 575);
            this.Controls.Add(this.asiakasNroCB);
            this.Controls.Add(this.ulosDTP);
            this.Controls.Add(this.sisaanDTP);
            this.Controls.Add(this.huoneenNroCB);
            this.Controls.Add(this.huoneTyyppiCB);
            this.Controls.Add(this.varausNroTB);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.muokkaaBT);
            this.Controls.Add(this.lisaaVarausBT);
            this.Controls.Add(this.varauksetDG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "testLB";
            this.Text = "Varaustenhallinta";
            this.Load += new System.EventHandler(this.Varaustenhallinta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varauksetDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView varauksetDG;
        private System.Windows.Forms.Button lisaaVarausBT;
        private System.Windows.Forms.Button muokkaaBT;
        private System.Windows.Forms.Button poistaBT;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.TextBox varausNroTB;
        private System.Windows.Forms.ComboBox huoneTyyppiCB;
        private System.Windows.Forms.ComboBox huoneenNroCB;
        private System.Windows.Forms.DateTimePicker sisaanDTP;
        private System.Windows.Forms.DateTimePicker ulosDTP;
        private System.Windows.Forms.ComboBox asiakasNroCB;
    }
}