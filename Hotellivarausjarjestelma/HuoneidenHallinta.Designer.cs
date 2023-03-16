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
            ((System.ComponentModel.ISupportInitialize)(this.huoneetDG)).BeginInit();
            this.SuspendLayout();
            // 
            // uusiHuoneBT
            // 
            this.uusiHuoneBT.Location = new System.Drawing.Point(152, 155);
            this.uusiHuoneBT.Name = "uusiHuoneBT";
            this.uusiHuoneBT.Size = new System.Drawing.Size(75, 23);
            this.uusiHuoneBT.TabIndex = 0;
            this.uusiHuoneBT.Text = "Lisää huone";
            this.uusiHuoneBT.UseVisualStyleBackColor = true;
            this.uusiHuoneBT.Click += new System.EventHandler(this.uusiHuoneBT_Click);
            // 
            // huoneTyyppiCB
            // 
            this.huoneTyyppiCB.FormattingEnabled = true;
            this.huoneTyyppiCB.Location = new System.Drawing.Point(200, 199);
            this.huoneTyyppiCB.Name = "huoneTyyppiCB";
            this.huoneTyyppiCB.Size = new System.Drawing.Size(121, 21);
            this.huoneTyyppiCB.TabIndex = 1;
            // 
            // huoneetDG
            // 
            this.huoneetDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.huoneetDG.Location = new System.Drawing.Point(152, 243);
            this.huoneetDG.Name = "huoneetDG";
            this.huoneetDG.Size = new System.Drawing.Size(240, 150);
            this.huoneetDG.TabIndex = 2;
            // 
            // HuoneidenHallinta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.huoneetDG);
            this.Controls.Add(this.huoneTyyppiCB);
            this.Controls.Add(this.uusiHuoneBT);
            this.Name = "HuoneidenHallinta";
            this.Text = "HuoneidenHallinta";
            ((System.ComponentModel.ISupportInitialize)(this.huoneetDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uusiHuoneBT;
        private System.Windows.Forms.ComboBox huoneTyyppiCB;
        private System.Windows.Forms.DataGridView huoneetDG;
    }
}