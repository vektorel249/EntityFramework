namespace Vektorel.EFForm
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvResult = new DataGridView();
            btnSuppliers1 = new Button();
            btnProductsOutOfStok = new Button();
            btnCustomers = new Button();
            btnMostSoldProducts = new Button();
            btnAllProducts1 = new Button();
            btnMostSoldCustomers = new Button();
            LastMonthSales = new Button();
            ProductDiscountSummary = new Button();
            btnAnnualSales = new Button();
            btnEmployeeSales = new Button();
            btnEmpğloyeeAnnualSales = new Button();
            btnMostSoldCategories = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // dgvResult
            // 
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(12, 12);
            dgvResult.Name = "dgvResult";
            dgvResult.Size = new Size(627, 341);
            dgvResult.TabIndex = 0;
            // 
            // btnSuppliers1
            // 
            btnSuppliers1.Location = new Point(12, 363);
            btnSuppliers1.Name = "btnSuppliers1";
            btnSuppliers1.Size = new Size(153, 40);
            btnSuppliers1.TabIndex = 1;
            btnSuppliers1.Text = "Almanyadaki Firmalar";
            btnSuppliers1.UseVisualStyleBackColor = true;
            btnSuppliers1.Click += btnSuppliers1_Click;
            // 
            // btnProductsOutOfStok
            // 
            btnProductsOutOfStok.Location = new Point(12, 409);
            btnProductsOutOfStok.Name = "btnProductsOutOfStok";
            btnProductsOutOfStok.Size = new Size(153, 40);
            btnProductsOutOfStok.TabIndex = 2;
            btnProductsOutOfStok.Text = "Tükenen Ürünler";
            btnProductsOutOfStok.UseVisualStyleBackColor = true;
            btnProductsOutOfStok.Click += btnProductsOutOfStok_Click;
            // 
            // btnCustomers
            // 
            btnCustomers.Location = new Point(168, 363);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(153, 40);
            btnCustomers.TabIndex = 3;
            btnCustomers.Text = "Müşteriler, İletişim Bilgileri ve Firmaları";
            btnCustomers.UseVisualStyleBackColor = true;
            btnCustomers.Click += btnCustomers_Click;
            // 
            // btnMostSoldProducts
            // 
            btnMostSoldProducts.Location = new Point(171, 409);
            btnMostSoldProducts.Name = "btnMostSoldProducts";
            btnMostSoldProducts.Size = new Size(153, 40);
            btnMostSoldProducts.TabIndex = 4;
            btnMostSoldProducts.Text = "En Çok Kazanç Getiren 5 Ürün";
            btnMostSoldProducts.UseVisualStyleBackColor = true;
            btnMostSoldProducts.Click += btnMostSoldProducts_Click;
            // 
            // btnAllProducts1
            // 
            btnAllProducts1.Location = new Point(327, 363);
            btnAllProducts1.Name = "btnAllProducts1";
            btnAllProducts1.Size = new Size(153, 40);
            btnAllProducts1.TabIndex = 5;
            btnAllProducts1.Text = "Ürünler, Kategorileri ve Tedarikçileri";
            btnAllProducts1.UseVisualStyleBackColor = true;
            btnAllProducts1.Click += btnAllProducts1_Click;
            // 
            // btnMostSoldCustomers
            // 
            btnMostSoldCustomers.Location = new Point(327, 409);
            btnMostSoldCustomers.Name = "btnMostSoldCustomers";
            btnMostSoldCustomers.Size = new Size(153, 40);
            btnMostSoldCustomers.TabIndex = 6;
            btnMostSoldCustomers.Text = "En Çok Kazanç Getiren 5 Müşteri ";
            btnMostSoldCustomers.UseVisualStyleBackColor = true;
            btnMostSoldCustomers.Click += btnMostSoldCustomers_Click;
            // 
            // LastMonthSales
            // 
            LastMonthSales.Location = new Point(486, 363);
            LastMonthSales.Name = "LastMonthSales";
            LastMonthSales.Size = new Size(153, 40);
            LastMonthSales.TabIndex = 7;
            LastMonthSales.Text = "Son Ay Elde Edilen Ciro";
            LastMonthSales.UseVisualStyleBackColor = true;
            LastMonthSales.Click += LastMonthSales_Click;
            // 
            // ProductDiscountSummary
            // 
            ProductDiscountSummary.Location = new Point(486, 409);
            ProductDiscountSummary.Name = "ProductDiscountSummary";
            ProductDiscountSummary.Size = new Size(153, 40);
            ProductDiscountSummary.TabIndex = 8;
            ProductDiscountSummary.Text = "Ürün Bazında İndirimden Dolayı Kaybedilen Tutar";
            ProductDiscountSummary.UseVisualStyleBackColor = true;
            ProductDiscountSummary.Click += ProductDiscountSummary_Click;
            // 
            // btnAnnualSales
            // 
            btnAnnualSales.Location = new Point(327, 455);
            btnAnnualSales.Name = "btnAnnualSales";
            btnAnnualSales.Size = new Size(153, 40);
            btnAnnualSales.TabIndex = 11;
            btnAnnualSales.Text = "Yıllara Göre Elde Edilen Gelir";
            btnAnnualSales.UseVisualStyleBackColor = true;
            btnAnnualSales.Click += btnAnnualSales_Click;
            // 
            // btnEmployeeSales
            // 
            btnEmployeeSales.Location = new Point(171, 455);
            btnEmployeeSales.Name = "btnEmployeeSales";
            btnEmployeeSales.Size = new Size(153, 40);
            btnEmployeeSales.TabIndex = 10;
            btnEmployeeSales.Text = "Personeli Satış Performansı";
            btnEmployeeSales.UseVisualStyleBackColor = true;
            btnEmployeeSales.Click += btnEmployeeSales_Click;
            // 
            // btnEmpğloyeeAnnualSales
            // 
            btnEmpğloyeeAnnualSales.Location = new Point(12, 455);
            btnEmpğloyeeAnnualSales.Name = "btnEmpğloyeeAnnualSales";
            btnEmpğloyeeAnnualSales.Size = new Size(153, 40);
            btnEmpğloyeeAnnualSales.TabIndex = 9;
            btnEmpğloyeeAnnualSales.Text = "Personelin Yıllara Göre Satış Çizelgesi";
            btnEmpğloyeeAnnualSales.UseVisualStyleBackColor = true;
            btnEmpğloyeeAnnualSales.Click += btnEmpğloyeeAnnualSales_Click;
            // 
            // btnMostSoldCategories
            // 
            btnMostSoldCategories.Location = new Point(486, 455);
            btnMostSoldCategories.Name = "btnMostSoldCategories";
            btnMostSoldCategories.Size = new Size(153, 40);
            btnMostSoldCategories.TabIndex = 12;
            btnMostSoldCategories.Text = "En Çok Satan 3 Kategori ve Tutarı";
            btnMostSoldCategories.UseVisualStyleBackColor = true;
            btnMostSoldCategories.Click += btnMostSoldCategories_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 507);
            Controls.Add(btnMostSoldCategories);
            Controls.Add(btnAnnualSales);
            Controls.Add(btnEmployeeSales);
            Controls.Add(btnEmpğloyeeAnnualSales);
            Controls.Add(ProductDiscountSummary);
            Controls.Add(LastMonthSales);
            Controls.Add(btnMostSoldCustomers);
            Controls.Add(btnAllProducts1);
            Controls.Add(btnMostSoldProducts);
            Controls.Add(btnCustomers);
            Controls.Add(btnProductsOutOfStok);
            Controls.Add(btnSuppliers1);
            Controls.Add(dgvResult);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmMain";
            Text = "Entity Framework";
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvResult;
        private Button btnSuppliers1;
        private Button btnProductsOutOfStok;
        private Button btnCustomers;
        private Button btnMostSoldProducts;
        private Button btnAllProducts1;
        private Button btnMostSoldCustomers;
        private Button LastMonthSales;
        private Button ProductDiscountSummary;
        private Button btnAnnualSales;
        private Button btnEmployeeSales;
        private Button btnEmpğloyeeAnnualSales;
        private Button btnMostSoldCategories;
    }
}
