namespace CSharpEgitimKampi501
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_listele = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_productPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_productStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_productCategory = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_productId = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_TotalProductCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_maxPriceProductName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_distinctCategoryCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Id : ";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_id.Location = new System.Drawing.Point(145, 25);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(229, 30);
            this.txt_id.TabIndex = 1;
            // 
            // btn_listele
            // 
            this.btn_listele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_listele.Location = new System.Drawing.Point(12, 289);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(184, 39);
            this.btn_listele.TabIndex = 2;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(407, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 367);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(24, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün Adı : ";
            // 
            // txt_productName
            // 
            this.txt_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_productName.Location = new System.Drawing.Point(145, 76);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(229, 30);
            this.txt_productName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(61, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fiyat : ";
            // 
            // txt_productPrice
            // 
            this.txt_productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_productPrice.Location = new System.Drawing.Point(145, 127);
            this.txt_productPrice.Name = "txt_productPrice";
            this.txt_productPrice.Size = new System.Drawing.Size(229, 30);
            this.txt_productPrice.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(64, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stok : ";
            // 
            // txt_productStock
            // 
            this.txt_productStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_productStock.Location = new System.Drawing.Point(145, 181);
            this.txt_productStock.Name = "txt_productStock";
            this.txt_productStock.Size = new System.Drawing.Size(229, 30);
            this.txt_productStock.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(27, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kategori : ";
            // 
            // txt_productCategory
            // 
            this.txt_productCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txt_productCategory.Location = new System.Drawing.Point(145, 240);
            this.txt_productCategory.Name = "txt_productCategory";
            this.txt_productCategory.Size = new System.Drawing.Size(229, 30);
            this.txt_productCategory.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_ekle.Location = new System.Drawing.Point(217, 289);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(184, 39);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_productId
            // 
            this.txt_productId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.txt_productId.Location = new System.Drawing.Point(12, 353);
            this.txt_productId.Name = "txt_productId";
            this.txt_productId.Size = new System.Drawing.Size(184, 39);
            this.txt_productId.TabIndex = 2;
            this.txt_productId.Text = "Sil";
            this.txt_productId.UseVisualStyleBackColor = true;
            this.txt_productId.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.btn_guncelle.Location = new System.Drawing.Point(217, 353);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(184, 39);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(119, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Toplam Kitap Sayısı : ";
            // 
            // lbl_TotalProductCount
            // 
            this.lbl_TotalProductCount.AutoSize = true;
            this.lbl_TotalProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalProductCount.Location = new System.Drawing.Point(349, 442);
            this.lbl_TotalProductCount.Name = "lbl_TotalProductCount";
            this.lbl_TotalProductCount.Size = new System.Drawing.Size(0, 25);
            this.lbl_TotalProductCount.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(484, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "En Pahalı Kitap : ";
            // 
            // lbl_maxPriceProductName
            // 
            this.lbl_maxPriceProductName.AutoSize = true;
            this.lbl_maxPriceProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_maxPriceProductName.Location = new System.Drawing.Point(714, 442);
            this.lbl_maxPriceProductName.Name = "lbl_maxPriceProductName";
            this.lbl_maxPriceProductName.Size = new System.Drawing.Size(0, 25);
            this.lbl_maxPriceProductName.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(119, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Kategori Sayısı :";
            // 
            // lbl_distinctCategoryCount
            // 
            this.lbl_distinctCategoryCount.AutoSize = true;
            this.lbl_distinctCategoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_distinctCategoryCount.Location = new System.Drawing.Point(296, 494);
            this.lbl_distinctCategoryCount.Name = "lbl_distinctCategoryCount";
            this.lbl_distinctCategoryCount.Size = new System.Drawing.Size(24, 25);
            this.lbl_distinctCategoryCount.TabIndex = 0;
            this.lbl_distinctCategoryCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 586);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.txt_productId);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.txt_productCategory);
            this.Controls.Add(this.txt_productStock);
            this.Controls.Add(this.txt_productPrice);
            this.Controls.Add(this.txt_productName);
            this.Controls.Add(this.lbl_maxPriceProductName);
            this.Controls.Add(this.lbl_distinctCategoryCount);
            this.Controls.Add(this.lbl_TotalProductCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_productPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_productStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_productCategory;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button txt_productId;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_TotalProductCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_maxPriceProductName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_distinctCategoryCount;
    }
}

