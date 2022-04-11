
namespace EntityProjeUygulama
{
    partial class FrmKategori
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
            this.TXTID = new System.Windows.Forms.TextBox();
            this.TXTAD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNLİSTELE = new System.Windows.Forms.Button();
            this.BTNEKLE = new System.Windows.Forms.Button();
            this.BTNGÜNCELLE = new System.Windows.Forms.Button();
            this.BTNSİL = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "KATEGORİ ID :";
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(154, 12);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(167, 31);
            this.TXTID.TabIndex = 1;
            // 
            // TXTAD
            // 
            this.TXTAD.Location = new System.Drawing.Point(154, 54);
            this.TXTAD.Name = "TXTAD";
            this.TXTAD.Size = new System.Drawing.Size(167, 31);
            this.TXTAD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "KATEGORİ ADI :";
            // 
            // BTNLİSTELE
            // 
            this.BTNLİSTELE.Location = new System.Drawing.Point(12, 96);
            this.BTNLİSTELE.Name = "BTNLİSTELE";
            this.BTNLİSTELE.Size = new System.Drawing.Size(136, 37);
            this.BTNLİSTELE.TabIndex = 5;
            this.BTNLİSTELE.Text = "LİSTELE";
            this.BTNLİSTELE.UseVisualStyleBackColor = true;
            this.BTNLİSTELE.Click += new System.EventHandler(this.BTNLİSTELE_Click);
            // 
            // BTNEKLE
            // 
            this.BTNEKLE.Location = new System.Drawing.Point(10, 139);
            this.BTNEKLE.Name = "BTNEKLE";
            this.BTNEKLE.Size = new System.Drawing.Size(136, 37);
            this.BTNEKLE.TabIndex = 6;
            this.BTNEKLE.Text = "EKLE";
            this.BTNEKLE.UseVisualStyleBackColor = true;
            this.BTNEKLE.Click += new System.EventHandler(this.BTNEKLE_Click);
            // 
            // BTNGÜNCELLE
            // 
            this.BTNGÜNCELLE.Location = new System.Drawing.Point(185, 96);
            this.BTNGÜNCELLE.Name = "BTNGÜNCELLE";
            this.BTNGÜNCELLE.Size = new System.Drawing.Size(136, 37);
            this.BTNGÜNCELLE.TabIndex = 7;
            this.BTNGÜNCELLE.Text = "GÜNCELLE";
            this.BTNGÜNCELLE.UseVisualStyleBackColor = true;
            this.BTNGÜNCELLE.Click += new System.EventHandler(this.BTNGÜNCELLE_Click);
            // 
            // BTNSİL
            // 
            this.BTNSİL.Location = new System.Drawing.Point(185, 139);
            this.BTNSİL.Name = "BTNSİL";
            this.BTNSİL.Size = new System.Drawing.Size(136, 37);
            this.BTNSİL.TabIndex = 8;
            this.BTNSİL.Text = "SİL";
            this.BTNSİL.UseVisualStyleBackColor = true;
            this.BTNSİL.Click += new System.EventHandler(this.BTNSİL_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(336, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 164);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(923, 202);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNSİL);
            this.Controls.Add(this.BTNGÜNCELLE);
            this.Controls.Add(this.BTNEKLE);
            this.Controls.Add(this.BTNLİSTELE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTAD);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmKategori";
            this.Text = "KATEGORİ İŞLEMLERİ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.TextBox TXTAD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNLİSTELE;
        private System.Windows.Forms.Button BTNEKLE;
        private System.Windows.Forms.Button BTNGÜNCELLE;
        private System.Windows.Forms.Button BTNSİL;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

