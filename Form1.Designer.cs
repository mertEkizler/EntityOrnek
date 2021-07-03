
namespace EntityOrnek
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnUrunListele = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnBul = new System.Windows.Forms.Button();
            this.GroupBoxProduct = new System.Windows.Forms.GroupBox();
            this.TxtUnitPrice = new System.Windows.Forms.TextBox();
            this.LblUnitPrice = new System.Windows.Forms.Label();
            this.TxtUnitsInStock = new System.Windows.Forms.TextBox();
            this.LblUnitsInStock = new System.Windows.Forms.Label();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.LblProductName = new System.Windows.Forms.Label();
            this.TxtProductID = new System.Windows.Forms.TextBox();
            this.LblProductID = new System.Windows.Forms.Label();
            this.GroupBoxCategory = new System.Windows.Forms.GroupBox();
            this.TxtCategoryName = new System.Windows.Forms.TextBox();
            this.LblCategoryName = new System.Windows.Forms.Label();
            this.TxtCategoryID = new System.Windows.Forms.TextBox();
            this.LblCategoryID = new System.Windows.Forms.Label();
            this.BtnUrunListele2 = new System.Windows.Forms.Button();
            this.BtnUrunListele3 = new System.Windows.Forms.Button();
            this.BtnProsedur = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BtnLinqEntity = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBoxProduct.SuspendLayout();
            this.GroupBoxCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 246);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnUrunListele
            // 
            this.BtnUrunListele.Location = new System.Drawing.Point(4, 253);
            this.BtnUrunListele.Name = "BtnUrunListele";
            this.BtnUrunListele.Size = new System.Drawing.Size(131, 36);
            this.BtnUrunListele.TabIndex = 1;
            this.BtnUrunListele.Text = "Ürün Listele";
            this.BtnUrunListele.UseVisualStyleBackColor = true;
            this.BtnUrunListele.Click += new System.EventHandler(this.BtnUrunListele_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(4, 295);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(131, 36);
            this.BtnKaydet.TabIndex = 2;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(4, 337);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(131, 36);
            this.BtnSil.TabIndex = 3;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(4, 379);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(131, 36);
            this.BtnGuncelle.TabIndex = 4;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnBul
            // 
            this.BtnBul.Location = new System.Drawing.Point(4, 421);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(131, 36);
            this.BtnBul.TabIndex = 5;
            this.BtnBul.Text = "Bul";
            this.BtnBul.UseVisualStyleBackColor = true;
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // GroupBoxProduct
            // 
            this.GroupBoxProduct.Controls.Add(this.TxtUnitPrice);
            this.GroupBoxProduct.Controls.Add(this.LblUnitPrice);
            this.GroupBoxProduct.Controls.Add(this.TxtUnitsInStock);
            this.GroupBoxProduct.Controls.Add(this.LblUnitsInStock);
            this.GroupBoxProduct.Controls.Add(this.TxtProductName);
            this.GroupBoxProduct.Controls.Add(this.LblProductName);
            this.GroupBoxProduct.Controls.Add(this.TxtProductID);
            this.GroupBoxProduct.Controls.Add(this.LblProductID);
            this.GroupBoxProduct.Location = new System.Drawing.Point(141, 253);
            this.GroupBoxProduct.Name = "GroupBoxProduct";
            this.GroupBoxProduct.Size = new System.Drawing.Size(323, 194);
            this.GroupBoxProduct.TabIndex = 6;
            this.GroupBoxProduct.TabStop = false;
            this.GroupBoxProduct.Text = "Products";
            // 
            // TxtUnitPrice
            // 
            this.TxtUnitPrice.Location = new System.Drawing.Point(161, 156);
            this.TxtUnitPrice.Name = "TxtUnitPrice";
            this.TxtUnitPrice.Size = new System.Drawing.Size(129, 26);
            this.TxtUnitPrice.TabIndex = 21;
            // 
            // LblUnitPrice
            // 
            this.LblUnitPrice.AutoSize = true;
            this.LblUnitPrice.Location = new System.Drawing.Point(45, 159);
            this.LblUnitPrice.Name = "LblUnitPrice";
            this.LblUnitPrice.Size = new System.Drawing.Size(77, 20);
            this.LblUnitPrice.TabIndex = 20;
            this.LblUnitPrice.Text = "Unit Price";
            // 
            // TxtUnitsInStock
            // 
            this.TxtUnitsInStock.Location = new System.Drawing.Point(161, 121);
            this.TxtUnitsInStock.Name = "TxtUnitsInStock";
            this.TxtUnitsInStock.Size = new System.Drawing.Size(129, 26);
            this.TxtUnitsInStock.TabIndex = 19;
            // 
            // LblUnitsInStock
            // 
            this.LblUnitsInStock.AutoSize = true;
            this.LblUnitsInStock.Location = new System.Drawing.Point(45, 127);
            this.LblUnitsInStock.Name = "LblUnitsInStock";
            this.LblUnitsInStock.Size = new System.Drawing.Size(109, 20);
            this.LblUnitsInStock.TabIndex = 18;
            this.LblUnitsInStock.Text = "Units In Stock";
            // 
            // TxtProductName
            // 
            this.TxtProductName.Location = new System.Drawing.Point(161, 89);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(129, 26);
            this.TxtProductName.TabIndex = 17;
            this.TxtProductName.TextChanged += new System.EventHandler(this.TxtProductName_TextChanged);
            // 
            // LblProductName
            // 
            this.LblProductName.AutoSize = true;
            this.LblProductName.Location = new System.Drawing.Point(45, 95);
            this.LblProductName.Name = "LblProductName";
            this.LblProductName.Size = new System.Drawing.Size(110, 20);
            this.LblProductName.TabIndex = 16;
            this.LblProductName.Text = "Product Name";
            // 
            // TxtProductID
            // 
            this.TxtProductID.Location = new System.Drawing.Point(161, 57);
            this.TxtProductID.Name = "TxtProductID";
            this.TxtProductID.Size = new System.Drawing.Size(129, 26);
            this.TxtProductID.TabIndex = 15;
            // 
            // LblProductID
            // 
            this.LblProductID.AutoSize = true;
            this.LblProductID.Location = new System.Drawing.Point(45, 63);
            this.LblProductID.Name = "LblProductID";
            this.LblProductID.Size = new System.Drawing.Size(89, 20);
            this.LblProductID.TabIndex = 14;
            this.LblProductID.Text = "Product ID:";
            // 
            // GroupBoxCategory
            // 
            this.GroupBoxCategory.Controls.Add(this.TxtCategoryName);
            this.GroupBoxCategory.Controls.Add(this.LblCategoryName);
            this.GroupBoxCategory.Controls.Add(this.TxtCategoryID);
            this.GroupBoxCategory.Controls.Add(this.LblCategoryID);
            this.GroupBoxCategory.Location = new System.Drawing.Point(480, 253);
            this.GroupBoxCategory.Name = "GroupBoxCategory";
            this.GroupBoxCategory.Size = new System.Drawing.Size(282, 194);
            this.GroupBoxCategory.TabIndex = 7;
            this.GroupBoxCategory.TabStop = false;
            this.GroupBoxCategory.Text = "Categories";
            // 
            // TxtCategoryName
            // 
            this.TxtCategoryName.Location = new System.Drawing.Point(136, 115);
            this.TxtCategoryName.Name = "TxtCategoryName";
            this.TxtCategoryName.Size = new System.Drawing.Size(129, 26);
            this.TxtCategoryName.TabIndex = 21;
            // 
            // LblCategoryName
            // 
            this.LblCategoryName.AutoSize = true;
            this.LblCategoryName.Location = new System.Drawing.Point(20, 121);
            this.LblCategoryName.Name = "LblCategoryName";
            this.LblCategoryName.Size = new System.Drawing.Size(119, 20);
            this.LblCategoryName.TabIndex = 20;
            this.LblCategoryName.Text = "Category Name";
            // 
            // TxtCategoryID
            // 
            this.TxtCategoryID.Location = new System.Drawing.Point(136, 83);
            this.TxtCategoryID.Name = "TxtCategoryID";
            this.TxtCategoryID.Size = new System.Drawing.Size(129, 26);
            this.TxtCategoryID.TabIndex = 19;
            // 
            // LblCategoryID
            // 
            this.LblCategoryID.AutoSize = true;
            this.LblCategoryID.Location = new System.Drawing.Point(20, 89);
            this.LblCategoryID.Name = "LblCategoryID";
            this.LblCategoryID.Size = new System.Drawing.Size(98, 20);
            this.LblCategoryID.TabIndex = 18;
            this.LblCategoryID.Text = "Category ID:";
            // 
            // BtnUrunListele2
            // 
            this.BtnUrunListele2.Location = new System.Drawing.Point(4, 463);
            this.BtnUrunListele2.Name = "BtnUrunListele2";
            this.BtnUrunListele2.Size = new System.Drawing.Size(131, 36);
            this.BtnUrunListele2.TabIndex = 8;
            this.BtnUrunListele2.Text = "Ürün Listele2";
            this.BtnUrunListele2.UseVisualStyleBackColor = true;
            this.BtnUrunListele2.Click += new System.EventHandler(this.BtnUrunListele2_Click);
            // 
            // BtnUrunListele3
            // 
            this.BtnUrunListele3.Location = new System.Drawing.Point(4, 507);
            this.BtnUrunListele3.Name = "BtnUrunListele3";
            this.BtnUrunListele3.Size = new System.Drawing.Size(131, 36);
            this.BtnUrunListele3.TabIndex = 9;
            this.BtnUrunListele3.Text = "Ürün Listele3";
            this.BtnUrunListele3.UseVisualStyleBackColor = true;
            this.BtnUrunListele3.Click += new System.EventHandler(this.BtnUrunListele3_Click);
            // 
            // BtnProsedur
            // 
            this.BtnProsedur.Location = new System.Drawing.Point(144, 463);
            this.BtnProsedur.Name = "BtnProsedur";
            this.BtnProsedur.Size = new System.Drawing.Size(131, 36);
            this.BtnProsedur.TabIndex = 10;
            this.BtnProsedur.Text = "Prosedur";
            this.BtnProsedur.UseVisualStyleBackColor = true;
            this.BtnProsedur.Click += new System.EventHandler(this.BtnProsedur_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(870, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(186, 24);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İsme Göre Sırala (A-Z)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // BtnLinqEntity
            // 
            this.BtnLinqEntity.Location = new System.Drawing.Point(918, 468);
            this.BtnLinqEntity.Name = "BtnLinqEntity";
            this.BtnLinqEntity.Size = new System.Drawing.Size(150, 31);
            this.BtnLinqEntity.TabIndex = 12;
            this.BtnLinqEntity.Text = "Linq Entity";
            this.BtnLinqEntity.UseVisualStyleBackColor = true;
            this.BtnLinqEntity.Click += new System.EventHandler(this.BtnLinqEntity_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(870, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(186, 24);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "İsme Göre Sırala (Z-A)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(870, 96);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(105, 24);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "İlk Üç Kayıt";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(870, 139);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(143, 24);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ID ye Göre Getir";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(870, 181);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(176, 24);
            this.radioButton5.TabIndex = 16;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "İsmi A ile Başlayanlar";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(870, 223);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(148, 24);
            this.radioButton6.TabIndex = 17;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "İsmi A ile Bitenler";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(870, 265);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(120, 24);
            this.radioButton7.TabIndex = 18;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Değer Var Mı";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(870, 301);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(163, 24);
            this.radioButton8.TabIndex = 19;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Toplam Ürün Sayısı";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(870, 338);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(117, 24);
            this.radioButton9.TabIndex = 20;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Toplam Fiyat";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(870, 368);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(130, 24);
            this.radioButton10.TabIndex = 21;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Ortalama Fiyat";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(870, 398);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(172, 24);
            this.radioButton11.TabIndex = 22;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "En yüksek ürün fiyatı";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(870, 433);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(166, 24);
            this.radioButton12.TabIndex = 23;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "En düşük ürün fiyatı";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 537);
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.radioButton11);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.BtnLinqEntity);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BtnProsedur);
            this.Controls.Add(this.BtnUrunListele3);
            this.Controls.Add(this.BtnUrunListele2);
            this.Controls.Add(this.GroupBoxCategory);
            this.Controls.Add(this.GroupBoxProduct);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnUrunListele);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBoxProduct.ResumeLayout(false);
            this.GroupBoxProduct.PerformLayout();
            this.GroupBoxCategory.ResumeLayout(false);
            this.GroupBoxCategory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnUrunListele;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.GroupBox GroupBoxProduct;
        private System.Windows.Forms.TextBox TxtUnitPrice;
        private System.Windows.Forms.Label LblUnitPrice;
        private System.Windows.Forms.TextBox TxtUnitsInStock;
        private System.Windows.Forms.Label LblUnitsInStock;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.Label LblProductName;
        private System.Windows.Forms.TextBox TxtProductID;
        private System.Windows.Forms.Label LblProductID;
        private System.Windows.Forms.GroupBox GroupBoxCategory;
        private System.Windows.Forms.TextBox TxtCategoryName;
        private System.Windows.Forms.Label LblCategoryName;
        private System.Windows.Forms.TextBox TxtCategoryID;
        private System.Windows.Forms.Label LblCategoryID;
        private System.Windows.Forms.Button BtnUrunListele2;
        private System.Windows.Forms.Button BtnUrunListele3;
        private System.Windows.Forms.Button BtnProsedur;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button BtnLinqEntity;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
    }
}

