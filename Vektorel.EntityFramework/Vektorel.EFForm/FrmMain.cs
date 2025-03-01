using Microsoft.EntityFrameworkCore;
using Vektorel.Data.Context;
using Vektorel.Data.DTOs;

namespace Vektorel.EFForm
{
    public partial class FrmMain : Form
    {
        private NorthwindContext context;

        public FrmMain()
        {
            InitializeComponent();
            context = new NorthwindContext();
        }

        private void btnSuppliers1_Click(object sender, EventArgs e)
        {
            dgvResult.DataSource = null;
            dgvResult.DataSource = context.Suppliers
                                          .Where(f => f.Country == "Germany")
                                          .ToList();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnAllProducts1_Click(object sender, EventArgs e)
        {
            dgvResult.DataSource = null;
            dgvResult.DataSource = context.Products
                                          .Select(s => new DetailedProductInfoDTO
                                          {
                                              Name = s.Name,
                                              Category = s.Category.CategoryName, // left join
                                              Supplier = s.Supplier.CompanyName // left join
                                          })
                                          .Take(15)
                                          .OrderBy(o => o.Name)
                                          .ToList();
        }

        private void LastMonthSales_Click(object sender, EventArgs e)
        {

        }

        private void btnProductsOutOfStok_Click(object sender, EventArgs e)
        {
            dgvResult.DataSource = null;
            dgvResult.DataSource = context.Products
                                          .Where(f => f.Stock == 0)
                                          .ToList();
        }

        private void btnMostSoldProducts_Click(object sender, EventArgs e)
        {
            dgvResult.DataSource = null;
            dgvResult.DataSource = context.OrderDetails
                                          .Select(s => new ProductIncomeDTO
                                          {
                                              Product = s.Product.Name,
                                              Income = s.Quantity * s.UnitPrice * (1 - (decimal)s.Discount)
                                          })
                                          .GroupBy(g => g.Product)
                                          .Select(s => new ProductIncomeDTO
                                          {
                                              Product = s.Key,
                                              Income = s.Sum(i => i.Income)
                                          })
                                          .OrderByDescending(o => o.Income)
                                          .Take(5)
                                          .ToList();
        }

        private void btnMostSoldCustomers_Click(object sender, EventArgs e)
        {

        }

        private void ProductDiscountSummary_Click(object sender, EventArgs e)
        {
            dgvResult.DataSource = null;
            dgvResult.DataSource = context.OrderDetails
                                          .Where(f => f.Discount > 0)
                                          .Select(s => new ProductDiscountOrderDetailDTO
                                          {
                                              Name = s.Product.Name, // inner join
                                              DiscountTotal = s.UnitPrice * s.Quantity * (decimal)s.Discount
                                          })
                                          .GroupBy(g => g.Name) // group by
                                          .Select(s => new ProductDiscountOrderDetailDTO
                                          {
                                              Name = s.Key,
                                              DiscountTotal = s.Sum(a => a.DiscountTotal)
                                          })
                                          .OrderByDescending(o => o.DiscountTotal) // order by
                                          .ToList();
        }

        private void btnEmpðloyeeAnnualSales_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployeeSales_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnualSales_Click(object sender, EventArgs e)
        {

        }

        private void btnMostSoldCategories_Click(object sender, EventArgs e)
        {

        }
    }
}
