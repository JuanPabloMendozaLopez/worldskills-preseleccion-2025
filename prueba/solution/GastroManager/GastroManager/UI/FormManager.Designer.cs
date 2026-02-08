namespace GastroManager
{
    partial class FormManager
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
            tabControls = new TabControl();
            tabDishes = new TabPage();
            dgvDishes = new DataGridView();
            colDishId = new DataGridViewTextBoxColumn();
            colDishName = new DataGridViewTextBoxColumn();
            colPortionPrice = new DataGridViewTextBoxColumn();
            colDetails = new DataGridViewLinkColumn();
            numMax = new NumericUpDown();
            numMin = new NumericUpDown();
            lblPrice = new Label();
            checkAvailable = new CheckBox();
            txtName = new TextBox();
            lblName = new Label();
            cbCategory = new ComboBox();
            lblCategory = new Label();
            lblListOfDishDescription = new Label();
            lblListOfDishes = new Label();
            tabIngredients = new TabPage();
            flowIngredients = new FlowLayoutPanel();
            lblIngredientsDescription = new Label();
            lblIngredientsTitle = new Label();
            tabDishDescription = new TabPage();
            txtDescriptionDetail = new RichTextBox();
            numServingDetail = new NumericUpDown();
            lblCostDetail = new Label();
            btnBackDetail = new Button();
            lblServingDetail = new Label();
            lblRecipeDetail = new Label();
            lblCategoryDetail = new Label();
            lblTimeDetail = new Label();
            lblIngredientsDetail = new Label();
            dgvIngredientsDetail = new DataGridView();
            colStock = new DataGridViewCheckBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colUnit = new DataGridViewTextBoxColumn();
            colCost = new DataGridViewTextBoxColumn();
            lblImageDetail = new Label();
            pImageDetail = new PictureBox();
            pItems = new FlowLayoutPanel();
            btnDishes = new Button();
            btnIngredients = new Button();
            btnExit = new Button();
            tabControls.SuspendLayout();
            tabDishes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDishes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMin).BeginInit();
            tabIngredients.SuspendLayout();
            tabDishDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numServingDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientsDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pImageDetail).BeginInit();
            pItems.SuspendLayout();
            SuspendLayout();
            // 
            // tabControls
            // 
            tabControls.Controls.Add(tabDishes);
            tabControls.Controls.Add(tabIngredients);
            tabControls.Controls.Add(tabDishDescription);
            tabControls.Location = new Point(166, -25);
            tabControls.Name = "tabControls";
            tabControls.SelectedIndex = 0;
            tabControls.Size = new Size(640, 492);
            tabControls.TabIndex = 1;
            // 
            // tabDishes
            // 
            tabDishes.Controls.Add(dgvDishes);
            tabDishes.Controls.Add(numMax);
            tabDishes.Controls.Add(numMin);
            tabDishes.Controls.Add(lblPrice);
            tabDishes.Controls.Add(checkAvailable);
            tabDishes.Controls.Add(txtName);
            tabDishes.Controls.Add(lblName);
            tabDishes.Controls.Add(cbCategory);
            tabDishes.Controls.Add(lblCategory);
            tabDishes.Controls.Add(lblListOfDishDescription);
            tabDishes.Controls.Add(lblListOfDishes);
            tabDishes.Location = new Point(4, 24);
            tabDishes.Name = "tabDishes";
            tabDishes.Padding = new Padding(3);
            tabDishes.Size = new Size(632, 464);
            tabDishes.TabIndex = 1;
            tabDishes.Text = "tabPage2";
            tabDishes.UseVisualStyleBackColor = true;
            // 
            // dgvDishes
            // 
            dgvDishes.AllowUserToAddRows = false;
            dgvDishes.AllowUserToDeleteRows = false;
            dgvDishes.AllowUserToOrderColumns = true;
            dgvDishes.AllowUserToResizeColumns = false;
            dgvDishes.AllowUserToResizeRows = false;
            dgvDishes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDishes.Columns.AddRange(new DataGridViewColumn[] { colDishId, colDishName, colPortionPrice, colDetails });
            dgvDishes.Location = new Point(33, 170);
            dgvDishes.MultiSelect = false;
            dgvDishes.Name = "dgvDishes";
            dgvDishes.Size = new Size(537, 257);
            dgvDishes.TabIndex = 12;
            dgvDishes.CellContentClick += dgvDishes_CellContentClick;
            dgvDishes.SelectionChanged += dgvDishes_SelectionChanged;
            // 
            // colDishId
            // 
            colDishId.HeaderText = "Dish Id";
            colDishId.Name = "colDishId";
            colDishId.ReadOnly = true;
            colDishId.Visible = false;
            // 
            // colDishName
            // 
            colDishName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDishName.HeaderText = "Dish Name";
            colDishName.Name = "colDishName";
            colDishName.ReadOnly = true;
            // 
            // colPortionPrice
            // 
            colPortionPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPortionPrice.HeaderText = "Portion Price";
            colPortionPrice.Name = "colPortionPrice";
            colPortionPrice.ReadOnly = true;
            // 
            // colDetails
            // 
            colDetails.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDetails.HeaderText = "Details";
            colDetails.Name = "colDetails";
            colDetails.ReadOnly = true;
            // 
            // numMax
            // 
            numMax.Location = new Point(512, 126);
            numMax.Name = "numMax";
            numMax.Size = new Size(41, 23);
            numMax.TabIndex = 10;
            numMax.Value = new decimal(new int[] { 50, 0, 0, 0 });
            numMax.ValueChanged += maxPrice_ValueChanged;
            // 
            // numMin
            // 
            numMin.Location = new Point(465, 126);
            numMin.Name = "numMin";
            numMin.Size = new Size(41, 23);
            numMin.TabIndex = 8;
            numMin.ValueChanged += minPrice_ValueChanged;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Poppins Medium", 8F, FontStyle.Bold);
            lblPrice.Location = new Point(340, 128);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(119, 19);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price (min-max):";
            // 
            // checkAvailable
            // 
            checkAvailable.AutoSize = true;
            checkAvailable.Font = new Font("Poppins", 8F);
            checkAvailable.Location = new Point(36, 124);
            checkAvailable.Name = "checkAvailable";
            checkAvailable.Size = new Size(266, 23);
            checkAvailable.TabIndex = 6;
            checkAvailable.Text = "Show only dishes with available ingredients";
            checkAvailable.UseVisualStyleBackColor = true;
            checkAvailable.CheckedChanged += checkAvailable_CheckedChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(397, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(173, 23);
            txtName.TabIndex = 5;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Poppins Medium", 8F, FontStyle.Bold);
            lblName.Location = new Point(340, 89);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 19);
            lblName.TabIndex = 4;
            lblName.Text = "Name:";
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(111, 86);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(121, 23);
            cbCategory.TabIndex = 3;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Poppins Medium", 8F, FontStyle.Bold);
            lblCategory.Location = new Point(33, 89);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(72, 19);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category:";
            // 
            // lblListOfDishDescription
            // 
            lblListOfDishDescription.AutoSize = true;
            lblListOfDishDescription.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListOfDishDescription.Location = new Point(33, 53);
            lblListOfDishDescription.Name = "lblListOfDishDescription";
            lblListOfDishDescription.Size = new Size(516, 22);
            lblListOfDishDescription.TabIndex = 1;
            lblListOfDishDescription.Text = "Explore our full menu below. Use the filter to see only dishes with available ingredients.";
            // 
            // lblListOfDishes
            // 
            lblListOfDishes.AutoSize = true;
            lblListOfDishes.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListOfDishes.Location = new Point(33, 19);
            lblListOfDishes.Name = "lblListOfDishes";
            lblListOfDishes.Size = new Size(143, 34);
            lblListOfDishes.TabIndex = 0;
            lblListOfDishes.Text = "List of Dishes";
            // 
            // tabIngredients
            // 
            tabIngredients.Controls.Add(flowIngredients);
            tabIngredients.Controls.Add(lblIngredientsDescription);
            tabIngredients.Controls.Add(lblIngredientsTitle);
            tabIngredients.Location = new Point(4, 24);
            tabIngredients.Name = "tabIngredients";
            tabIngredients.Padding = new Padding(3);
            tabIngredients.Size = new Size(632, 464);
            tabIngredients.TabIndex = 0;
            tabIngredients.Text = "tabPage1";
            tabIngredients.UseVisualStyleBackColor = true;
            // 
            // flowIngredients
            // 
            flowIngredients.AutoScroll = true;
            flowIngredients.Location = new Point(33, 96);
            flowIngredients.Name = "flowIngredients";
            flowIngredients.Size = new Size(575, 330);
            flowIngredients.TabIndex = 4;
            // 
            // lblIngredientsDescription
            // 
            lblIngredientsDescription.AutoSize = true;
            lblIngredientsDescription.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIngredientsDescription.Location = new Point(33, 53);
            lblIngredientsDescription.Name = "lblIngredientsDescription";
            lblIngredientsDescription.Size = new Size(316, 22);
            lblIngredientsDescription.TabIndex = 3;
            lblIngredientsDescription.Text = "Total available ingredients for the amount ($): NNNN";
            // 
            // lblIngredientsTitle
            // 
            lblIngredientsTitle.AutoSize = true;
            lblIngredientsTitle.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngredientsTitle.Location = new Point(33, 19);
            lblIngredientsTitle.Name = "lblIngredientsTitle";
            lblIngredientsTitle.Size = new Size(191, 34);
            lblIngredientsTitle.TabIndex = 2;
            lblIngredientsTitle.Text = "List of Ingredients";
            // 
            // tabDishDescription
            // 
            tabDishDescription.Controls.Add(txtDescriptionDetail);
            tabDishDescription.Controls.Add(numServingDetail);
            tabDishDescription.Controls.Add(lblCostDetail);
            tabDishDescription.Controls.Add(btnBackDetail);
            tabDishDescription.Controls.Add(lblServingDetail);
            tabDishDescription.Controls.Add(lblRecipeDetail);
            tabDishDescription.Controls.Add(lblCategoryDetail);
            tabDishDescription.Controls.Add(lblTimeDetail);
            tabDishDescription.Controls.Add(lblIngredientsDetail);
            tabDishDescription.Controls.Add(dgvIngredientsDetail);
            tabDishDescription.Controls.Add(lblImageDetail);
            tabDishDescription.Controls.Add(pImageDetail);
            tabDishDescription.Location = new Point(4, 24);
            tabDishDescription.Name = "tabDishDescription";
            tabDishDescription.Padding = new Padding(3);
            tabDishDescription.Size = new Size(632, 464);
            tabDishDescription.TabIndex = 2;
            tabDishDescription.Text = "tabDishDescription";
            tabDishDescription.UseVisualStyleBackColor = true;
            // 
            // txtDescriptionDetail
            // 
            txtDescriptionDetail.Location = new Point(31, 119);
            txtDescriptionDetail.Name = "txtDescriptionDetail";
            txtDescriptionDetail.ReadOnly = true;
            txtDescriptionDetail.Size = new Size(556, 39);
            txtDescriptionDetail.TabIndex = 23;
            txtDescriptionDetail.Text = "";
            // 
            // numServingDetail
            // 
            numServingDetail.Location = new Point(367, 56);
            numServingDetail.Name = "numServingDetail";
            numServingDetail.Size = new Size(47, 23);
            numServingDetail.TabIndex = 20;
            numServingDetail.ValueChanged += numServingDetail_ValueChanged;
            // 
            // lblCostDetail
            // 
            lblCostDetail.AutoSize = true;
            lblCostDetail.Font = new Font("Poppins Medium", 8F, FontStyle.Bold);
            lblCostDetail.Location = new Point(293, 87);
            lblCostDetail.Name = "lblCostDetail";
            lblCostDetail.Size = new Size(79, 19);
            lblCostDetail.TabIndex = 21;
            lblCostDetail.Text = "Total Cost:";
            // 
            // btnBackDetail
            // 
            btnBackDetail.BackColor = Color.White;
            btnBackDetail.Font = new Font("Poppins Medium", 9.75F, FontStyle.Bold);
            btnBackDetail.Location = new Point(225, 398);
            btnBackDetail.Name = "btnBackDetail";
            btnBackDetail.Size = new Size(130, 30);
            btnBackDetail.TabIndex = 3;
            btnBackDetail.Text = "Back";
            btnBackDetail.UseVisualStyleBackColor = false;
            btnBackDetail.Click += btnBackDetail_Click;
            // 
            // lblServingDetail
            // 
            lblServingDetail.AutoSize = true;
            lblServingDetail.Font = new Font("Poppins Medium", 8F, FontStyle.Bold);
            lblServingDetail.Location = new Point(293, 58);
            lblServingDetail.Name = "lblServingDetail";
            lblServingDetail.Size = new Size(68, 19);
            lblServingDetail.TabIndex = 19;
            lblServingDetail.Text = "Servings:";
            // 
            // lblRecipeDetail
            // 
            lblRecipeDetail.AutoSize = true;
            lblRecipeDetail.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecipeDetail.Location = new Point(23, 20);
            lblRecipeDetail.Name = "lblRecipeDetail";
            lblRecipeDetail.Size = new Size(239, 34);
            lblRecipeDetail.TabIndex = 16;
            lblRecipeDetail.Text = "Recipe for \"Dish Name\"";
            // 
            // lblCategoryDetail
            // 
            lblCategoryDetail.AutoSize = true;
            lblCategoryDetail.Font = new Font("Poppins Medium", 8F, FontStyle.Bold);
            lblCategoryDetail.Location = new Point(26, 58);
            lblCategoryDetail.Name = "lblCategoryDetail";
            lblCategoryDetail.Size = new Size(72, 19);
            lblCategoryDetail.TabIndex = 17;
            lblCategoryDetail.Text = "Category:";
            // 
            // lblTimeDetail
            // 
            lblTimeDetail.AutoSize = true;
            lblTimeDetail.Font = new Font("Poppins Medium", 8F, FontStyle.Bold);
            lblTimeDetail.Location = new Point(26, 87);
            lblTimeDetail.Name = "lblTimeDetail";
            lblTimeDetail.Size = new Size(101, 19);
            lblTimeDetail.TabIndex = 18;
            lblTimeDetail.Text = "Cooking Time:";
            // 
            // lblIngredientsDetail
            // 
            lblIngredientsDetail.AutoSize = true;
            lblIngredientsDetail.Font = new Font("Poppins", 12F, FontStyle.Bold);
            lblIngredientsDetail.Location = new Point(31, 167);
            lblIngredientsDetail.Name = "lblIngredientsDetail";
            lblIngredientsDetail.Size = new Size(108, 28);
            lblIngredientsDetail.TabIndex = 15;
            lblIngredientsDetail.Text = "Ingredients";
            // 
            // dgvIngredientsDetail
            // 
            dgvIngredientsDetail.AllowUserToAddRows = false;
            dgvIngredientsDetail.AllowUserToDeleteRows = false;
            dgvIngredientsDetail.AllowUserToOrderColumns = true;
            dgvIngredientsDetail.AllowUserToResizeRows = false;
            dgvIngredientsDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredientsDetail.Columns.AddRange(new DataGridViewColumn[] { colStock, colName, colQuantity, colUnit, colCost });
            dgvIngredientsDetail.Location = new Point(31, 198);
            dgvIngredientsDetail.Name = "dgvIngredientsDetail";
            dgvIngredientsDetail.Size = new Size(324, 183);
            dgvIngredientsDetail.TabIndex = 14;
            // 
            // colStock
            // 
            colStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colStock.FillWeight = 48.8505974F;
            colStock.HeaderText = "";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.FillWeight = 126.903557F;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colQuantity.FillWeight = 108.081963F;
            colQuantity.HeaderText = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colUnit
            // 
            colUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUnit.FillWeight = 108.081963F;
            colUnit.HeaderText = "Unit";
            colUnit.Name = "colUnit";
            colUnit.ReadOnly = true;
            // 
            // colCost
            // 
            colCost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCost.FillWeight = 108.081963F;
            colCost.HeaderText = "Cost";
            colCost.Name = "colCost";
            colCost.ReadOnly = true;
            // 
            // lblImageDetail
            // 
            lblImageDetail.AutoSize = true;
            lblImageDetail.Font = new Font("Poppins", 12F, FontStyle.Bold);
            lblImageDetail.Location = new Point(399, 167);
            lblImageDetail.Name = "lblImageDetail";
            lblImageDetail.Size = new Size(66, 28);
            lblImageDetail.TabIndex = 11;
            lblImageDetail.Text = "Image";
            // 
            // pImageDetail
            // 
            pImageDetail.Cursor = Cursors.Hand;
            pImageDetail.Location = new Point(399, 198);
            pImageDetail.Name = "pImageDetail";
            pImageDetail.Size = new Size(188, 183);
            pImageDetail.SizeMode = PictureBoxSizeMode.StretchImage;
            pImageDetail.TabIndex = 13;
            pImageDetail.TabStop = false;
            pImageDetail.Click += pImageDetail_Click;
            // 
            // pItems
            // 
            pItems.Controls.Add(btnDishes);
            pItems.Controls.Add(btnIngredients);
            pItems.Controls.Add(btnExit);
            pItems.Dock = DockStyle.Left;
            pItems.Location = new Point(0, 0);
            pItems.Name = "pItems";
            pItems.Size = new Size(175, 450);
            pItems.TabIndex = 13;
            // 
            // btnDishes
            // 
            btnDishes.BackColor = Color.White;
            btnDishes.Font = new Font("Poppins", 9.75F);
            btnDishes.Location = new Point(3, 3);
            btnDishes.Name = "btnDishes";
            btnDishes.Size = new Size(168, 40);
            btnDishes.TabIndex = 0;
            btnDishes.Text = "Dishes";
            btnDishes.UseVisualStyleBackColor = false;
            btnDishes.Click += btnDishes_Click;
            // 
            // btnIngredients
            // 
            btnIngredients.BackColor = Color.White;
            btnIngredients.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngredients.Location = new Point(3, 49);
            btnIngredients.Name = "btnIngredients";
            btnIngredients.Size = new Size(168, 40);
            btnIngredients.TabIndex = 1;
            btnIngredients.Text = "Ingredients";
            btnIngredients.UseVisualStyleBackColor = false;
            btnIngredients.Click += btnIngredients_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.Font = new Font("Poppins", 9.75F);
            btnExit.Location = new Point(3, 95);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(168, 40);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // FormManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pItems);
            Controls.Add(tabControls);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dishes";
            Load += FormManager_Load;
            tabControls.ResumeLayout(false);
            tabDishes.ResumeLayout(false);
            tabDishes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDishes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMin).EndInit();
            tabIngredients.ResumeLayout(false);
            tabIngredients.PerformLayout();
            tabDishDescription.ResumeLayout(false);
            tabDishDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numServingDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientsDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pImageDetail).EndInit();
            pItems.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControls;
        private TabPage tabDishes;
        private TabPage tabIngredients;
        private Label lblListOfDishDescription;
        private Label lblListOfDishes;
        private CheckBox checkAvailable;
        private TextBox txtName;
        private Label lblName;
        private ComboBox cbCategory;
        private Label lblCategory;
        private NumericUpDown numMax;
        private NumericUpDown numMin;
        private Label lblPrice;
        private DataGridView dgvDishes;
        private DataGridViewTextBoxColumn colDishId;
        private DataGridViewTextBoxColumn colDishName;
        private DataGridViewTextBoxColumn colPortionPrice;
        private DataGridViewLinkColumn colDetails;
        private FlowLayoutPanel pItems;
        private Button btnDishes;
        private Button btnIngredients;
        private Button btnExit;
        private TabPage tabDishDescription;
        private PictureBox pImageDetail;
        private NumericUpDown numServingDetail;
        private Label lblCostDetail;
        private Button btnBackDetail;
        private Label lblServingDetail;
        private Label lblRecipeDetail;
        private Label lblCategoryDetail;
        private Label lblTimeDetail;
        private Label lblIngredientsDetail;
        private DataGridView dgvIngredientsDetail;
        private Label lblImageDetail;
        private DataGridViewCheckBoxColumn colStock;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colUnit;
        private DataGridViewTextBoxColumn colCost;
        private RichTextBox txtDescriptionDetail;
        private FlowLayoutPanel flowIngredients;
        private Label lblIngredientsDescription;
        private Label lblIngredientsTitle;
    }
}
