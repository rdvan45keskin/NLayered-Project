namespace Northwind.WebFormsUI
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.gbxAddProduct = new System.Windows.Forms.GroupBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblProductStock = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxUpdateCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxUpdateStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUpdateQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.lblUpdateProductQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblUpdateProductStockAmount = new System.Windows.Forms.Label();
            this.lblUpdateProductUnitPrice = new System.Windows.Forms.Label();
            this.lblUpdateProductCategory = new System.Windows.Forms.Label();
            this.lblUpdateProductName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.gbxAddProduct.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(12, 288);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(845, 150);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Location = new System.Drawing.Point(13, 13);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(245, 100);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye göre arama";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(7, 26);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Kategori";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(73, 19);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(166, 21);
            this.cbxCategory.TabIndex = 3;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Location = new System.Drawing.Point(13, 120);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(245, 100);
            this.gbxSearch.TabIndex = 2;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Ürün Adına Göre Arama";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(10, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(63, 13);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Ürün Arama";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(73, 19);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(166, 20);
            this.tbxSearch.TabIndex = 3;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // gbxAddProduct
            // 
            this.gbxAddProduct.Controls.Add(this.btnAdd);
            this.gbxAddProduct.Controls.Add(this.cbxCategoryId);
            this.gbxAddProduct.Controls.Add(this.tbxStockAmount);
            this.gbxAddProduct.Controls.Add(this.tbxQuantityPerUnit);
            this.gbxAddProduct.Controls.Add(this.tbxUnitPrice);
            this.gbxAddProduct.Controls.Add(this.tbxProductName);
            this.gbxAddProduct.Controls.Add(this.lblProductQuantityPerUnit);
            this.gbxAddProduct.Controls.Add(this.lblProductStock);
            this.gbxAddProduct.Controls.Add(this.lblUnitPrice);
            this.gbxAddProduct.Controls.Add(this.lblProductCategory);
            this.gbxAddProduct.Controls.Add(this.lblProductName);
            this.gbxAddProduct.Location = new System.Drawing.Point(283, 13);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Size = new System.Drawing.Size(200, 207);
            this.gbxAddProduct.TabIndex = 3;
            this.gbxAddProduct.TabStop = false;
            this.gbxAddProduct.Text = "Ürün Ekleme";
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(76, 126);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(118, 20);
            this.tbxStockAmount.TabIndex = 9;
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(76, 100);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(118, 20);
            this.tbxQuantityPerUnit.TabIndex = 8;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(76, 74);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(118, 20);
            this.tbxUnitPrice.TabIndex = 7;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(76, 20);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(118, 20);
            this.tbxProductName.TabIndex = 5;
            // 
            // lblProductQuantityPerUnit
            // 
            this.lblProductQuantityPerUnit.AutoSize = true;
            this.lblProductQuantityPerUnit.Location = new System.Drawing.Point(6, 103);
            this.lblProductQuantityPerUnit.Name = "lblProductQuantityPerUnit";
            this.lblProductQuantityPerUnit.Size = new System.Drawing.Size(59, 13);
            this.lblProductQuantityPerUnit.TabIndex = 4;
            this.lblProductQuantityPerUnit.Text = "Birim Adedi";
            // 
            // lblProductStock
            // 
            this.lblProductStock.AutoSize = true;
            this.lblProductStock.Location = new System.Drawing.Point(6, 129);
            this.lblProductStock.Name = "lblProductStock";
            this.lblProductStock.Size = new System.Drawing.Size(59, 13);
            this.lblProductStock.TabIndex = 3;
            this.lblProductStock.Text = "Stok Adedi";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(6, 77);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Fiyat";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Location = new System.Drawing.Point(6, 50);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(46, 13);
            this.lblProductCategory.TabIndex = 1;
            this.lblProductCategory.Text = "Kategori";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 26);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(76, 47);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(118, 21);
            this.cbxCategoryId.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(185, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.cbxUpdateCategoryId);
            this.gbxUpdate.Controls.Add(this.tbxUpdateQuantityPerUnit);
            this.gbxUpdate.Controls.Add(this.tbxUpdateUnitPrice);
            this.gbxUpdate.Controls.Add(this.lblUpdateProductStockAmount);
            this.gbxUpdate.Controls.Add(this.tbxUpdateStockAmount);
            this.gbxUpdate.Controls.Add(this.tbxUpdateProductName);
            this.gbxUpdate.Controls.Add(this.lblUpdateProductUnitPrice);
            this.gbxUpdate.Controls.Add(this.lblUpdateProductCategory);
            this.gbxUpdate.Controls.Add(this.lblUpdateProductName);
            this.gbxUpdate.Controls.Add(this.lblUpdateProductQuantityPerUnit);
            this.gbxUpdate.Location = new System.Drawing.Point(508, 13);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(200, 207);
            this.gbxUpdate.TabIndex = 4;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Ürün Güncelleme";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(9, 170);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(185, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxUpdateCategoryId
            // 
            this.cbxUpdateCategoryId.FormattingEnabled = true;
            this.cbxUpdateCategoryId.Location = new System.Drawing.Point(76, 47);
            this.cbxUpdateCategoryId.Name = "cbxUpdateCategoryId";
            this.cbxUpdateCategoryId.Size = new System.Drawing.Size(118, 21);
            this.cbxUpdateCategoryId.TabIndex = 10;
            // 
            // tbxUpdateStockAmount
            // 
            this.tbxUpdateStockAmount.Location = new System.Drawing.Point(76, 126);
            this.tbxUpdateStockAmount.Name = "tbxUpdateStockAmount";
            this.tbxUpdateStockAmount.Size = new System.Drawing.Size(118, 20);
            this.tbxUpdateStockAmount.TabIndex = 9;
            // 
            // tbxUpdateQuantityPerUnit
            // 
            this.tbxUpdateQuantityPerUnit.Location = new System.Drawing.Point(76, 100);
            this.tbxUpdateQuantityPerUnit.Name = "tbxUpdateQuantityPerUnit";
            this.tbxUpdateQuantityPerUnit.Size = new System.Drawing.Size(118, 20);
            this.tbxUpdateQuantityPerUnit.TabIndex = 8;
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(76, 74);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(118, 20);
            this.tbxUpdateUnitPrice.TabIndex = 7;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(76, 20);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(118, 20);
            this.tbxUpdateProductName.TabIndex = 5;
            // 
            // lblUpdateProductQuantityPerUnit
            // 
            this.lblUpdateProductQuantityPerUnit.AutoSize = true;
            this.lblUpdateProductQuantityPerUnit.Location = new System.Drawing.Point(6, 103);
            this.lblUpdateProductQuantityPerUnit.Name = "lblUpdateProductQuantityPerUnit";
            this.lblUpdateProductQuantityPerUnit.Size = new System.Drawing.Size(59, 13);
            this.lblUpdateProductQuantityPerUnit.TabIndex = 4;
            this.lblUpdateProductQuantityPerUnit.Text = "Birim Adedi";
            // 
            // lblUpdateProductStockAmount
            // 
            this.lblUpdateProductStockAmount.AutoSize = true;
            this.lblUpdateProductStockAmount.Location = new System.Drawing.Point(6, 129);
            this.lblUpdateProductStockAmount.Name = "lblUpdateProductStockAmount";
            this.lblUpdateProductStockAmount.Size = new System.Drawing.Size(59, 13);
            this.lblUpdateProductStockAmount.TabIndex = 3;
            this.lblUpdateProductStockAmount.Text = "Stok Adedi";
            // 
            // lblUpdateProductUnitPrice
            // 
            this.lblUpdateProductUnitPrice.AutoSize = true;
            this.lblUpdateProductUnitPrice.Location = new System.Drawing.Point(6, 77);
            this.lblUpdateProductUnitPrice.Name = "lblUpdateProductUnitPrice";
            this.lblUpdateProductUnitPrice.Size = new System.Drawing.Size(29, 13);
            this.lblUpdateProductUnitPrice.TabIndex = 2;
            this.lblUpdateProductUnitPrice.Text = "Fiyat";
            // 
            // lblUpdateProductCategory
            // 
            this.lblUpdateProductCategory.AutoSize = true;
            this.lblUpdateProductCategory.Location = new System.Drawing.Point(6, 50);
            this.lblUpdateProductCategory.Name = "lblUpdateProductCategory";
            this.lblUpdateProductCategory.Size = new System.Drawing.Size(46, 13);
            this.lblUpdateProductCategory.TabIndex = 1;
            this.lblUpdateProductCategory.Text = "Kategori";
            // 
            // lblUpdateProductName
            // 
            this.lblUpdateProductName.AutoSize = true;
            this.lblUpdateProductName.Location = new System.Drawing.Point(6, 26);
            this.lblUpdateProductName.Name = "lblUpdateProductName";
            this.lblUpdateProductName.Size = new System.Drawing.Size(48, 13);
            this.lblUpdateProductName.TabIndex = 0;
            this.lblUpdateProductName.Text = "Ürün Adı";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(731, 259);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(126, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAddProduct);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgvProduct);
            this.Name = "Form1";
            this.Text = "Ürünler(Gelismis)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxAddProduct.ResumeLayout(false);
            this.gbxAddProduct.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.GroupBox gbxAddProduct;
        private System.Windows.Forms.Label lblProductQuantityPerUnit;
        private System.Windows.Forms.Label lblProductStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxUpdateCategoryId;
        private System.Windows.Forms.TextBox tbxUpdateStockAmount;
        private System.Windows.Forms.TextBox tbxUpdateQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label lblUpdateProductQuantityPerUnit;
        private System.Windows.Forms.Label lblUpdateProductStockAmount;
        private System.Windows.Forms.Label lblUpdateProductUnitPrice;
        private System.Windows.Forms.Label lblUpdateProductCategory;
        private System.Windows.Forms.Label lblUpdateProductName;
        private System.Windows.Forms.Button btnRemove;
    }
}

