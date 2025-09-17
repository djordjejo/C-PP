namespace User_interface
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
            tabControl1 = new TabControl();
            Product = new TabPage();
            productQuantity = new TextBox();
            label8 = new Label();
            productDescription = new RichTextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            productPrice = new TextBox();
            productName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            UpdateCategories = new Button();
            dateOfManifacture = new DateTimePicker();
            CategoriesDataGrid = new DataGridView();
            DeleteCategories = new Button();
            AddCategories = new Button();
            categoryName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tabControl1.SuspendLayout();
            Product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CategoriesDataGrid).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Product);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1367, 648);
            tabControl1.TabIndex = 0;
            // 
            // Product
            // 
            Product.BackColor = Color.PeachPuff;
            Product.Controls.Add(productQuantity);
            Product.Controls.Add(label8);
            Product.Controls.Add(productDescription);
            Product.Controls.Add(label7);
            Product.Controls.Add(dateTimePicker1);
            Product.Controls.Add(dataGridView1);
            Product.Controls.Add(button3);
            Product.Controls.Add(button2);
            Product.Controls.Add(button1);
            Product.Controls.Add(productPrice);
            Product.Controls.Add(productName);
            Product.Controls.Add(label3);
            Product.Controls.Add(label2);
            Product.Controls.Add(label1);
            Product.Location = new Point(4, 29);
            Product.Name = "Product";
            Product.Padding = new Padding(3);
            Product.Size = new Size(1359, 615);
            Product.TabIndex = 0;
            Product.Text = "Products";
            // 
            // productQuantity
            // 
            productQuantity.Location = new Point(275, 190);
            productQuantity.Name = "productQuantity";
            productQuantity.Size = new Size(250, 27);
            productQuantity.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(146, 193);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 13;
            label8.Text = "Quantity";
            // 
            // productDescription
            // 
            productDescription.Location = new Point(146, 347);
            productDescription.Name = "productDescription";
            productDescription.Size = new Size(379, 80);
            productDescription.TabIndex = 12;
            productDescription.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(165, 241);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 11;
            label7.Text = "Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(275, 241);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(583, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(722, 374);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += ChooseItem;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(411, 457);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(280, 457);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(130, 457);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // productPrice
            // 
            productPrice.Location = new Point(275, 132);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(250, 27);
            productPrice.TabIndex = 4;
            // 
            // productName
            // 
            productName.Location = new Point(275, 68);
            productName.Name = "productName";
            productName.Size = new Size(250, 27);
            productName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 308);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 2;
            label3.Text = "Product description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 139);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Product price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 71);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Product name";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.PeachPuff;
            tabPage2.Controls.Add(UpdateCategories);
            tabPage2.Controls.Add(dateOfManifacture);
            tabPage2.Controls.Add(CategoriesDataGrid);
            tabPage2.Controls.Add(DeleteCategories);
            tabPage2.Controls.Add(AddCategories);
            tabPage2.Controls.Add(categoryName);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1359, 615);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Categories";
            // 
            // UpdateCategories
            // 
            UpdateCategories.BackColor = SystemColors.ActiveCaption;
            UpdateCategories.ForeColor = SystemColors.ActiveCaptionText;
            UpdateCategories.Location = new Point(260, 337);
            UpdateCategories.Name = "UpdateCategories";
            UpdateCategories.Size = new Size(94, 29);
            UpdateCategories.TabIndex = 20;
            UpdateCategories.Text = "Update";
            UpdateCategories.UseVisualStyleBackColor = false;
            UpdateCategories.Click += UpdateCategories_Click;
            // 
            // dateOfManifacture
            // 
            dateOfManifacture.Location = new Point(270, 214);
            dateOfManifacture.Name = "dateOfManifacture";
            dateOfManifacture.Size = new Size(250, 27);
            dateOfManifacture.TabIndex = 19;
            // 
            // CategoriesDataGrid
            // 
            CategoriesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoriesDataGrid.Location = new Point(601, 78);
            CategoriesDataGrid.Name = "CategoriesDataGrid";
            CategoriesDataGrid.RowHeadersWidth = 51;
            CategoriesDataGrid.Size = new Size(708, 288);
            CategoriesDataGrid.TabIndex = 18;
            CategoriesDataGrid.CellClick += ChooseCategory;
            // 
            // DeleteCategories
            // 
            DeleteCategories.BackColor = SystemColors.ActiveCaption;
            DeleteCategories.ForeColor = SystemColors.ActiveCaptionText;
            DeleteCategories.Location = new Point(401, 337);
            DeleteCategories.Name = "DeleteCategories";
            DeleteCategories.Size = new Size(94, 29);
            DeleteCategories.TabIndex = 17;
            DeleteCategories.Text = "Delete";
            DeleteCategories.UseVisualStyleBackColor = false;
            DeleteCategories.Click += DeleteCategories_Click;
            // 
            // AddCategories
            // 
            AddCategories.BackColor = SystemColors.ActiveCaption;
            AddCategories.ForeColor = SystemColors.ActiveCaptionText;
            AddCategories.Location = new Point(120, 337);
            AddCategories.Name = "AddCategories";
            AddCategories.Size = new Size(94, 29);
            AddCategories.TabIndex = 15;
            AddCategories.Text = "Add";
            AddCategories.UseVisualStyleBackColor = false;
            AddCategories.Click += AddCategories_Click;
            // 
            // categoryName
            // 
            categoryName.Location = new Point(270, 143);
            categoryName.Name = "categoryName";
            categoryName.Size = new Size(250, 27);
            categoryName.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 213);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(173, 214);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 10;
            label5.Text = "Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(141, 146);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 9;
            label6.Text = "Category name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 648);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += UcitajPodatke;
            tabControl1.ResumeLayout(false);
            Product.ResumeLayout(false);
            Product.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CategoriesDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Product;
        private TextBox productName;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox productPrice;
        private DataGridView CategoriesDataGrid;
        private Button DeleteCategories;
        private Button Update;
        private Button AddCategories;
        private TextBox categoryName;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private RichTextBox productDescription;
        private DateTimePicker dateOfManifacture;
        private TextBox productQuantity;
        private Label label8;
        private Button UpdateCategories;
    }
}