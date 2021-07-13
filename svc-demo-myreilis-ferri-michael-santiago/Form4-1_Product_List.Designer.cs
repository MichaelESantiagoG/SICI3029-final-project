
namespace EmptyGUI
{
    partial class Form4_1_Product_List
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
            this.txt_Searchbox = new System.Windows.Forms.TextBox();
            this.btn_Sign_Out = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Searchbox
            // 
            this.txt_Searchbox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Searchbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Searchbox.Location = new System.Drawing.Point(644, 111);
            this.txt_Searchbox.Name = "txt_Searchbox";
            this.txt_Searchbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_Searchbox.Size = new System.Drawing.Size(159, 21);
            this.txt_Searchbox.TabIndex = 0;
            this.txt_Searchbox.Text = "Search";
            // 
            // btn_Sign_Out
            // 
            this.btn_Sign_Out.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Sign_Out.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Sign_Out.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sign_Out.Location = new System.Drawing.Point(28, 26);
            this.btn_Sign_Out.Name = "btn_Sign_Out";
            this.btn_Sign_Out.Size = new System.Drawing.Size(77, 23);
            this.btn_Sign_Out.TabIndex = 1;
            this.btn_Sign_Out.Text = "return";
            this.btn_Sign_Out.UseVisualStyleBackColor = false;
            this.btn_Sign_Out.Click += new System.EventHandler(this.btn_Sign_Out_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_ID,
            this.Product_Name,
            this.Category,
            this.Price,
            this.Stock_Quantity,
            this.Image});
            this.dataGridView1.Location = new System.Drawing.Point(28, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 298);
            this.dataGridView1.TabIndex = 2;
            // 
            // Product_ID
            // 
            this.Product_ID.Frozen = true;
            this.Product_ID.HeaderText = "Product_ID";
            this.Product_ID.MinimumWidth = 50;
            this.Product_ID.Name = "Product_ID";
            this.Product_ID.ReadOnly = true;
            // 
            // Product_Name
            // 
            this.Product_Name.Frozen = true;
            this.Product_Name.HeaderText = "Product_Name";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            this.Product_Name.Width = 163;
            // 
            // Category
            // 
            this.Category.Frozen = true;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 70;
            // 
            // Stock_Quantity
            // 
            this.Stock_Quantity.Frozen = true;
            this.Stock_Quantity.HeaderText = "Stock_Quantity";
            this.Stock_Quantity.Name = "Stock_Quantity";
            this.Stock_Quantity.ReadOnly = true;
            // 
            // Image
            // 
            this.Image.Frozen = true;
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 200;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewProduct.Location = new System.Drawing.Point(27, 111);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(132, 23);
            this.btnNewProduct.TabIndex = 3;
            this.btnNewProduct.Text = "New Product";
            this.btnNewProduct.UseVisualStyleBackColor = false;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReload.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReload.Location = new System.Drawing.Point(303, 111);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(132, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Re-load";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.BackColor = System.Drawing.Color.Red;
            this.btnRemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemoveProduct.Location = new System.Drawing.Point(165, 111);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(132, 23);
            this.btnRemoveProduct.TabIndex = 5;
            this.btnRemoveProduct.Text = "Remove Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = false;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EmptyGUI.Properties.Resources._7513c0a3_b359_4526_a21b_e8570df4b57d_200x200;
            this.pictureBox1.Location = new System.Drawing.Point(713, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form4_1_Product_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::EmptyGUI.Properties.Resources.image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 443);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Sign_Out);
            this.Controls.Add(this.txt_Searchbox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form4_1_Product_List";
            this.Text = "Form4_1_Product_List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Searchbox;
        private System.Windows.Forms.Button btn_Sign_Out;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}