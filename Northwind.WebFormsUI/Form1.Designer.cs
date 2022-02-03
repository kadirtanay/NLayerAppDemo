
namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.navPanel = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxCategoryId = new System.Windows.Forms.ComboBox();
            this.tbxProductAddName = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblProductAddingName = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.UpdateTbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.UpdateTbxUnitinStoc = new System.Windows.Forms.TextBox();
            this.UpdateTbxUnitPrice = new System.Windows.Forms.TextBox();
            this.UpdateCbxCategoryId = new System.Windows.Forms.ComboBox();
            this.UpdateTbxProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.navPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.navPanel.Controls.Add(this.MinimizeBtn);
            this.navPanel.Controls.Add(this.ExitBtn);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPanel.Font = new System.Drawing.Font("Webdings", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(956, 32);
            this.navPanel.TabIndex = 1;
            this.navPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.navPanel_MouseDown);
            this.navPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.navPanel_MouseMove);
            this.navPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.navPanel_MouseUp);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.MinimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimizeBtn.ForeColor = System.Drawing.Color.White;
            this.MinimizeBtn.Location = new System.Drawing.Point(899, 4);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(24, 24);
            this.MinimizeBtn.TabIndex = 2;
            this.MinimizeBtn.Text = "0";
            this.MinimizeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeBtn.UseCompatibleTextRendering = true;
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(923, 6);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(24, 24);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "r";
            this.ExitBtn.UseCompatibleTextRendering = true;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(0, 106);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowTemplate.Height = 25;
            this.dgwProduct.Size = new System.Drawing.Size(956, 159);
            this.dgwProduct.TabIndex = 2;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Font = new System.Drawing.Font("Serifa BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxCategory.ForeColor = System.Drawing.Color.White;
            this.gbxCategory.Location = new System.Drawing.Point(0, 38);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(428, 62);
            this.gbxCategory.TabIndex = 3;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Search with Category";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(169, 22);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(242, 27);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategory.ForeColor = System.Drawing.Color.Yellow;
            this.lblCategory.Location = new System.Drawing.Point(34, 22);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(98, 23);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // gbxProductName
            // 
            this.gbxProductName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Font = new System.Drawing.Font("Serifa BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxProductName.ForeColor = System.Drawing.Color.White;
            this.gbxProductName.Location = new System.Drawing.Point(434, 38);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(522, 62);
            this.gbxProductName.TabIndex = 4;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Search with Product Name";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(215, 25);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(274, 26);
            this.tbxProductName.TabIndex = 1;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.ForeColor = System.Drawing.Color.Yellow;
            this.lblProductName.Location = new System.Drawing.Point(6, 25);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(150, 23);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxStockAmount);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxProductAdd.Controls.Add(this.cbxCategoryId);
            this.gbxProductAdd.Controls.Add(this.tbxProductAddName);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblProductAddingName);
            this.gbxProductAdd.Controls.Add(this.lblStockAmount);
            this.gbxProductAdd.Controls.Add(this.lblCategoryId);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxProductAdd.ForeColor = System.Drawing.Color.White;
            this.gbxProductAdd.Location = new System.Drawing.Point(0, 276);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(428, 247);
            this.gbxProductAdd.TabIndex = 5;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Add New Product";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Yellow;
            this.btnAdd.Location = new System.Drawing.Point(356, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 201);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(145, 206);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(205, 29);
            this.tbxQuantityPerUnit.TabIndex = 15;
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(145, 163);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(205, 29);
            this.tbxStockAmount.TabIndex = 14;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(145, 120);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(205, 29);
            this.tbxUnitPrice.TabIndex = 13;
            // 
            // cbxCategoryId
            // 
            this.cbxCategoryId.FormattingEnabled = true;
            this.cbxCategoryId.Location = new System.Drawing.Point(145, 77);
            this.cbxCategoryId.Name = "cbxCategoryId";
            this.cbxCategoryId.Size = new System.Drawing.Size(205, 29);
            this.cbxCategoryId.TabIndex = 12;
            // 
            // tbxProductAddName
            // 
            this.tbxProductAddName.Location = new System.Drawing.Point(145, 34);
            this.tbxProductAddName.Name = "tbxProductAddName";
            this.tbxProductAddName.Size = new System.Drawing.Size(205, 29);
            this.tbxProductAddName.TabIndex = 11;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantityPerUnit.ForeColor = System.Drawing.Color.Yellow;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(6, 214);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(133, 21);
            this.lblQuantityPerUnit.TabIndex = 10;
            this.lblQuantityPerUnit.Text = "Quantity Per Unit";
            // 
            // lblProductAddingName
            // 
            this.lblProductAddingName.AutoSize = true;
            this.lblProductAddingName.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProductAddingName.ForeColor = System.Drawing.Color.Yellow;
            this.lblProductAddingName.Location = new System.Drawing.Point(6, 34);
            this.lblProductAddingName.Name = "lblProductAddingName";
            this.lblProductAddingName.Size = new System.Drawing.Size(115, 21);
            this.lblProductAddingName.TabIndex = 6;
            this.lblProductAddingName.Text = "Product Name";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStockAmount.ForeColor = System.Drawing.Color.Yellow;
            this.lblStockAmount.Location = new System.Drawing.Point(6, 169);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(114, 21);
            this.lblStockAmount.TabIndex = 9;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCategoryId.ForeColor = System.Drawing.Color.Yellow;
            this.lblCategoryId.Location = new System.Drawing.Point(6, 79);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(78, 21);
            this.lblCategoryId.TabIndex = 7;
            this.lblCategoryId.Text = "Category";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUnitPrice.ForeColor = System.Drawing.Color.Yellow;
            this.lblUnitPrice.Location = new System.Drawing.Point(6, 124);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(80, 21);
            this.lblUnitPrice.TabIndex = 8;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.UpdateTbxQuantityPerUnit);
            this.groupBox1.Controls.Add(this.UpdateTbxUnitinStoc);
            this.groupBox1.Controls.Add(this.UpdateTbxUnitPrice);
            this.groupBox1.Controls.Add(this.UpdateCbxCategoryId);
            this.groupBox1.Controls.Add(this.UpdateTbxProductName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(438, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 247);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Product";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Red;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Location = new System.Drawing.Point(369, 189);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 46);
            this.btnRemove.TabIndex = 18;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Location = new System.Drawing.Point(369, 120);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 49);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateTbxQuantityPerUnit
            // 
            this.UpdateTbxQuantityPerUnit.Location = new System.Drawing.Point(145, 206);
            this.UpdateTbxQuantityPerUnit.Name = "UpdateTbxQuantityPerUnit";
            this.UpdateTbxQuantityPerUnit.Size = new System.Drawing.Size(205, 29);
            this.UpdateTbxQuantityPerUnit.TabIndex = 15;
            // 
            // UpdateTbxUnitinStoc
            // 
            this.UpdateTbxUnitinStoc.Location = new System.Drawing.Point(145, 163);
            this.UpdateTbxUnitinStoc.Name = "UpdateTbxUnitinStoc";
            this.UpdateTbxUnitinStoc.Size = new System.Drawing.Size(205, 29);
            this.UpdateTbxUnitinStoc.TabIndex = 14;
            // 
            // UpdateTbxUnitPrice
            // 
            this.UpdateTbxUnitPrice.Location = new System.Drawing.Point(145, 120);
            this.UpdateTbxUnitPrice.Name = "UpdateTbxUnitPrice";
            this.UpdateTbxUnitPrice.Size = new System.Drawing.Size(205, 29);
            this.UpdateTbxUnitPrice.TabIndex = 13;
            // 
            // UpdateCbxCategoryId
            // 
            this.UpdateCbxCategoryId.FormattingEnabled = true;
            this.UpdateCbxCategoryId.Location = new System.Drawing.Point(145, 77);
            this.UpdateCbxCategoryId.Name = "UpdateCbxCategoryId";
            this.UpdateCbxCategoryId.Size = new System.Drawing.Size(205, 29);
            this.UpdateCbxCategoryId.TabIndex = 12;
            // 
            // UpdateTbxProductName
            // 
            this.UpdateTbxProductName.Location = new System.Drawing.Point(145, 34);
            this.UpdateTbxProductName.Name = "UpdateTbxProductName";
            this.UpdateTbxProductName.Size = new System.Drawing.Size(205, 29);
            this.UpdateTbxProductName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(6, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quantity Per Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(6, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Stock Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe WP Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Unit Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(956, 545);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.navPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.navPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblProductAddingName;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxStockAmount;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.ComboBox cbxCategoryId;
        private System.Windows.Forms.TextBox tbxProductAddName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox UpdateTbxQuantityPerUnit;
        private System.Windows.Forms.TextBox UpdateTbxUnitinStoc;
        private System.Windows.Forms.TextBox UpdateTbxUnitPrice;
        private System.Windows.Forms.ComboBox UpdateCbxCategoryId;
        private System.Windows.Forms.TextBox UpdateTbxProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemove;
    }
}

