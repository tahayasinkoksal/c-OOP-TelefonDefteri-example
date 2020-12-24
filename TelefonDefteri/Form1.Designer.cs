namespace TelefonDefteri
{
    partial class Form1
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
            this.tbad = new System.Windows.Forms.TextBox();
            this.tbsoyad = new System.Windows.Forms.TextBox();
            this.tbtelofon = new System.Windows.Forms.TextBox();
            this.tbmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnkayitekle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnkayitlistele = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbarasoyad = new System.Windows.Forms.TextBox();
            this.tbaraad = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewkisiler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-posta:";
            // 
            // tbad
            // 
            this.tbad.Location = new System.Drawing.Point(89, 43);
            this.tbad.Name = "tbad";
            this.tbad.Size = new System.Drawing.Size(200, 23);
            this.tbad.TabIndex = 4;
            // 
            // tbsoyad
            // 
            this.tbsoyad.Location = new System.Drawing.Point(89, 84);
            this.tbsoyad.Name = "tbsoyad";
            this.tbsoyad.Size = new System.Drawing.Size(200, 23);
            this.tbsoyad.TabIndex = 5;
            // 
            // tbtelofon
            // 
            this.tbtelofon.Location = new System.Drawing.Point(89, 135);
            this.tbtelofon.Name = "tbtelofon";
            this.tbtelofon.Size = new System.Drawing.Size(200, 23);
            this.tbtelofon.TabIndex = 6;
            // 
            // tbmail
            // 
            this.tbmail.Location = new System.Drawing.Point(89, 182);
            this.tbmail.Name = "tbmail";
            this.tbmail.Size = new System.Drawing.Size(200, 23);
            this.tbmail.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnkayitekle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbtelofon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbsoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(24, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 285);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Kayıt Ekle";
            // 
            // btnkayitekle
            // 
            this.btnkayitekle.Location = new System.Drawing.Point(89, 238);
            this.btnkayitekle.Name = "btnkayitekle";
            this.btnkayitekle.Size = new System.Drawing.Size(139, 31);
            this.btnkayitekle.TabIndex = 4;
            this.btnkayitekle.Text = "Kayıt Ekle";
            this.btnkayitekle.UseVisualStyleBackColor = true;
            this.btnkayitekle.Click += new System.EventHandler(this.btnkayitekle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnkayitlistele);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbarasoyad);
            this.groupBox2.Controls.Add(this.tbaraad);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(366, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 285);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtları Listele";
            // 
            // btnkayitlistele
            // 
            this.btnkayitlistele.Location = new System.Drawing.Point(74, 238);
            this.btnkayitlistele.Name = "btnkayitlistele";
            this.btnkayitlistele.Size = new System.Drawing.Size(148, 31);
            this.btnkayitlistele.TabIndex = 4;
            this.btnkayitlistele.Text = "Listele";
            this.btnkayitlistele.UseVisualStyleBackColor = true;
            this.btnkayitlistele.Click += new System.EventHandler(this.btnkayitlistele_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(119, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(132, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ad";
            // 
            // tbarasoyad
            // 
            this.tbarasoyad.Location = new System.Drawing.Point(59, 162);
            this.tbarasoyad.Name = "tbarasoyad";
            this.tbarasoyad.Size = new System.Drawing.Size(177, 23);
            this.tbarasoyad.TabIndex = 1;
            // 
            // tbaraad
            // 
            this.tbaraad.Location = new System.Drawing.Point(59, 76);
            this.tbaraad.Name = "tbaraad";
            this.tbaraad.Size = new System.Drawing.Size(177, 23);
            this.tbaraad.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewkisiler);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(24, 365);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(633, 278);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlı Kişiler";
            // 
            // listViewkisiler
            // 
            this.listViewkisiler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewkisiler.GridLines = true;
            this.listViewkisiler.Location = new System.Drawing.Point(6, 23);
            this.listViewkisiler.Name = "listViewkisiler";
            this.listViewkisiler.Size = new System.Drawing.Size(618, 249);
            this.listViewkisiler.TabIndex = 0;
            this.listViewkisiler.UseCompatibleStateImageBehavior = false;
            this.listViewkisiler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "AD";
            this.columnHeader1.Width = 196;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SOYAD";
            this.columnHeader2.Width = 124;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TELEFON";
            this.columnHeader3.Width = 133;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "E-POSTA";
            this.columnHeader4.Width = 158;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(517, 658);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "github.com/tahayasinkoksal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 690);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TELEFON DEFTERİ OOP - github.com/tahayasinkoksal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbad;
        private System.Windows.Forms.TextBox tbsoyad;
        private System.Windows.Forms.TextBox tbtelofon;
        private System.Windows.Forms.TextBox tbmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbarasoyad;
        private System.Windows.Forms.TextBox tbaraad;
        private System.Windows.Forms.Button btnkayitekle;
        private System.Windows.Forms.Button btnkayitlistele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView listViewkisiler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

