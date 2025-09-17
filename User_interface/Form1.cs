using Models.Domain_names;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_interface
{
    public partial class Form1 : Form
    {
        private readonly IHttpServices<ProductsDTO> _productService;
        private readonly IHttpServices<CategoriesDTO> _categoryService;
        private Guid _selectedProductId;
        private Guid _selectedCategoryId;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(IHttpServices<ProductsDTO> productService, IHttpServices<CategoriesDTO> categoryService)
        {
            InitializeComponent();
            _productService = productService;
            _categoryService = categoryService;
        }
        public async Task LoadProducts()
        {
            try
            {
                var products = await _productService.GetAllAsync();

                if (products != null)
                {
                    dataGridView1.DataSource = products;
                }
                else
                {
                    MessageBox.Show("Nije bilo moguće preuzeti podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task LoadCategories()
        {
            try
            {
                var categories = await _categoryService.GetAllAsync();

                if (categories != null)
                {
                    CategoriesDataGrid.DataSource = categories;
                }
                else
                {
                    MessageBox.Show("Nije bilo moguće preuzeti podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void UcitajPodatke(object sender, EventArgs e)
        {
            await LoadProducts();
            await LoadCategories();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var newProduct = new ProductsDTO
                {
                    ProductId = Guid.NewGuid(),
                    ProductName = productName.Text,
                    Price = decimal.Parse(productPrice.Text),
                    StockQuantity = int.Parse(productQuantity.Text),
                    StartAt = dateTimePicker1.Value,
                    Description = productDescription.Text
                };

                await _productService.AddAsync(newProduct);
                MessageBox.Show("Proizvod je uspešno dodat!");
                await LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri dodavanju: {ex.Message}");
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (_selectedProductId == Guid.Empty)
            {
                MessageBox.Show("Niste odabrali proizvod za izmenu.");
                return;
            }

            try
            {
                var updatedProduct = new ProductsDTO
                {
                    ProductId = _selectedProductId,
                    ProductName = productName.Text,
                    Price = decimal.Parse(productPrice.Text),
                    StockQuantity = int.Parse(productQuantity.Text),
                    StartAt = dateTimePicker1.Value,
                    Description = productDescription.Text
                };

                await _productService.UpdateAsync(updatedProduct);
                MessageBox.Show("Proizvod je uspešno ažuriran!");
                await LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri ažuriranju: {ex.Message}");
            }
        }

        private void ChooseItem(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                _selectedProductId = Guid.Parse(row.Cells["ProductId"].Value.ToString());

                productName.Text = row.Cells["ProductName"].Value.ToString();
                productPrice.Text = row.Cells["Price"].Value.ToString();
                productQuantity.Text = row.Cells["StockQuantity"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["StartAt"].Value);
                productDescription.Text = row.Cells["Description"].Value.ToString();
            }
        }

        private void ChooseCategory(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.CategoriesDataGrid.Rows[e.RowIndex];

                _selectedCategoryId = Guid.Parse(row.Cells["CategoryId"].Value.ToString());

                categoryName.Text = row.Cells["CategoryName"].Value.ToString();
                dateOfManifacture.Value = Convert.ToDateTime(row.Cells["CreatedAt"].Value);
            }
        }

        private async void AddCategories_Click(object sender, EventArgs e)
        {
            try
            {
                var newCategory = new CategoriesDTO
                {
                    CategoryId = Guid.NewGuid(),
                    CategoryName = categoryName.Text,
                    CreatedAt = dateOfManifacture.Value,
                };

                await _categoryService.AddAsync(newCategory);
                MessageBox.Show("Proizvod je uspešno dodat!");
                await LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri dodavanju: {ex.Message}");
            }
        }

        private async void UpdateCategories_Click(object sender, EventArgs e)
        {
            if (_selectedCategoryId == Guid.Empty)
            {
                MessageBox.Show("Niste odabrali kategoriju za izmenu.");
                return;
            }

            try
            {
                var updatedCategory = new CategoriesDTO
                {
                    CategoryId = _selectedCategoryId,
                    CategoryName = categoryName.Text, 
                    CreatedAt = dateTimePicker1.Value,
                };

                // 3. Poziva se servis za kategorije
                await _categoryService.UpdateAsync(updatedCategory);
                MessageBox.Show("Kategorija je uspešno ažurirana!"); 
                await LoadCategories(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri ažuriranju: {ex.Message}");
            }
        }

        private async void DeleteCategories_Click(object sender, EventArgs e)
        {
            if (_selectedCategoryId == Guid.Empty)
            {
                MessageBox.Show("Niste odabrali proizvod za brisanje.");
                return;
            }

            var confirmation = MessageBox.Show("Da li ste sigurni da želite da obrišete ovu kategoriju?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    await _categoryService.DeleteAsync(_selectedCategoryId);
                    MessageBox.Show("Proizvod je uspešno obrisan!");
                    await LoadCategories();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška pri brisanju: {ex.Message}");
                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (_selectedProductId == Guid.Empty)
            {
                MessageBox.Show("Niste odabrali proizvod za brisanje.");
                return;
            }

            var confirmation = MessageBox.Show("Da li ste sigurni da želite da obrišete ovaj proizvod?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    await _productService.DeleteAsync(_selectedProductId);
                    MessageBox.Show("Proizvod je uspešno obrisan!");
                    await LoadProducts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Greška pri brisanju: {ex.Message}");
                }
            }
        }
    }

}
