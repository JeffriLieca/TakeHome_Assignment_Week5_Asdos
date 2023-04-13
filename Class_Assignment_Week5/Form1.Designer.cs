namespace Class_Assignment_Week5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.buttonRemoveProd = new System.Windows.Forms.Button();
            this.buttonAddProd = new System.Windows.Forms.Button();
            this.buttonEditProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNamaProd = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonAddCat = new System.Windows.Forms.Button();
            this.buttonRemoveCat = new System.Windows.Forms.Button();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.AllowUserToResizeColumns = false;
            this.dataGridViewProduct.AllowUserToResizeRows = false;
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(37, 71);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.RowHeadersVisible = false;
            this.dataGridViewProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProduct.Size = new System.Drawing.Size(446, 279);
            this.dataGridViewProduct.TabIndex = 0;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
            this.dataGridViewProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellContentClick);
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.AllowUserToAddRows = false;
            this.dataGridViewCategory.AllowUserToDeleteRows = false;
            this.dataGridViewCategory.AllowUserToResizeColumns = false;
            this.dataGridViewCategory.AllowUserToResizeRows = false;
            this.dataGridViewCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Location = new System.Drawing.Point(529, 71);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.ReadOnly = true;
            this.dataGridViewCategory.RowHeadersVisible = false;
            this.dataGridViewCategory.RowHeadersWidth = 51;
            this.dataGridViewCategory.RowTemplate.Height = 24;
            this.dataGridViewCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategory.Size = new System.Drawing.Size(262, 202);
            this.dataGridViewCategory.TabIndex = 1;
            this.dataGridViewCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellContentClick);
            this.dataGridViewCategory.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCategory_CellMouseClick);
            // 
            // buttonRemoveProd
            // 
            this.buttonRemoveProd.BackColor = System.Drawing.Color.Red;
            this.buttonRemoveProd.Location = new System.Drawing.Point(409, 477);
            this.buttonRemoveProd.Name = "buttonRemoveProd";
            this.buttonRemoveProd.Size = new System.Drawing.Size(74, 57);
            this.buttonRemoveProd.TabIndex = 3;
            this.buttonRemoveProd.Text = "Remove Product";
            this.buttonRemoveProd.UseVisualStyleBackColor = false;
            this.buttonRemoveProd.Click += new System.EventHandler(this.buttonRemoveProd_Click);
            // 
            // buttonAddProd
            // 
            this.buttonAddProd.BackColor = System.Drawing.Color.Lime;
            this.buttonAddProd.Location = new System.Drawing.Point(258, 477);
            this.buttonAddProd.Name = "buttonAddProd";
            this.buttonAddProd.Size = new System.Drawing.Size(79, 57);
            this.buttonAddProd.TabIndex = 4;
            this.buttonAddProd.Text = "Add Product";
            this.buttonAddProd.UseVisualStyleBackColor = false;
            this.buttonAddProd.Click += new System.EventHandler(this.buttonAddProd_Click);
            // 
            // buttonEditProd
            // 
            this.buttonEditProd.BackColor = System.Drawing.Color.Yellow;
            this.buttonEditProd.Location = new System.Drawing.Point(333, 477);
            this.buttonEditProd.Name = "buttonEditProd";
            this.buttonEditProd.Size = new System.Drawing.Size(80, 57);
            this.buttonEditProd.TabIndex = 5;
            this.buttonEditProd.Text = "Edit Product";
            this.buttonEditProd.UseVisualStyleBackColor = false;
            this.buttonEditProd.Click += new System.EventHandler(this.buttonEditProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Category";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(362, 41);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFilter.TabIndex = 9;
            this.comboBoxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_SelectedIndexChanged);
            this.comboBoxFilter.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFilter_SelectionChangeCommitted);
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(248, 41);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(48, 23);
            this.buttonAll.TabIndex = 0;
            this.buttonAll.Text = "All";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFilter.Location = new System.Drawing.Point(302, 41);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(54, 23);
            this.buttonFilter.TabIndex = 12;
            this.buttonFilter.Text = "Filter: ";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nama : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Category : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Harga : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 518);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Stock : ";
            // 
            // textBoxNamaProd
            // 
            this.textBoxNamaProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNamaProd.Location = new System.Drawing.Point(117, 422);
            this.textBoxNamaProd.Name = "textBoxNamaProd";
            this.textBoxNamaProd.Size = new System.Drawing.Size(366, 22);
            this.textBoxNamaProd.TabIndex = 18;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHarga.Location = new System.Drawing.Point(117, 485);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(121, 22);
            this.textBoxHarga.TabIndex = 20;
            this.textBoxHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHarga_KeyPress);
            // 
            // textBoxStock
            // 
            this.textBoxStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStock.Location = new System.Drawing.Point(117, 516);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(121, 22);
            this.textBoxStock.TabIndex = 21;
            this.textBoxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStock_KeyPress);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(117, 450);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCategory.TabIndex = 22;
            // 
            // buttonAddCat
            // 
            this.buttonAddCat.BackColor = System.Drawing.Color.Lime;
            this.buttonAddCat.Location = new System.Drawing.Point(622, 324);
            this.buttonAddCat.Name = "buttonAddCat";
            this.buttonAddCat.Size = new System.Drawing.Size(86, 57);
            this.buttonAddCat.TabIndex = 23;
            this.buttonAddCat.Text = "Add Category";
            this.buttonAddCat.UseVisualStyleBackColor = false;
            this.buttonAddCat.Click += new System.EventHandler(this.buttonAddCat_Click);
            // 
            // buttonRemoveCat
            // 
            this.buttonRemoveCat.BackColor = System.Drawing.Color.Red;
            this.buttonRemoveCat.Location = new System.Drawing.Point(705, 324);
            this.buttonRemoveCat.Name = "buttonRemoveCat";
            this.buttonRemoveCat.Size = new System.Drawing.Size(86, 57);
            this.buttonRemoveCat.TabIndex = 24;
            this.buttonRemoveCat.Text = "Remove Category";
            this.buttonRemoveCat.UseVisualStyleBackColor = false;
            this.buttonRemoveCat.Click += new System.EventHandler(this.buttonRemoveCat_Click);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCategory.Location = new System.Drawing.Point(603, 296);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(188, 22);
            this.textBoxCategory.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nama : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(572, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 190);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(819, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonRemoveCat);
            this.Controls.Add(this.buttonAddCat);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxNamaProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEditProd);
            this.Controls.Add(this.buttonAddProd);
            this.Controls.Add(this.buttonRemoveProd);
            this.Controls.Add(this.dataGridViewCategory);
            this.Controls.Add(this.dataGridViewProduct);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blink Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private System.Windows.Forms.Button buttonRemoveProd;
        private System.Windows.Forms.Button buttonAddProd;
        private System.Windows.Forms.Button buttonEditProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNamaProd;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonAddCat;
        private System.Windows.Forms.Button buttonRemoveCat;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

