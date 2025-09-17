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

        private async void UcitajPodatke(object sender, EventArgs e)
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
    }
}
