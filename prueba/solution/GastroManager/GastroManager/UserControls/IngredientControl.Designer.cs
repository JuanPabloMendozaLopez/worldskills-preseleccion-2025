namespace GastroManager.UserControls
{
    partial class IngredientControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblNameIngredient = new Label();
            lblPrice = new Label();
            linkedDelete = new LinkLabel();
            numUnit = new NumericUpDown();
            lblUnit = new Label();
            ((System.ComponentModel.ISupportInitialize)numUnit).BeginInit();
            SuspendLayout();
            // 
            // lblNameIngredient
            // 
            lblNameIngredient.AutoSize = true;
            lblNameIngredient.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameIngredient.Location = new Point(15, 23);
            lblNameIngredient.Name = "lblNameIngredient";
            lblNameIngredient.Size = new Size(205, 34);
            lblNameIngredient.TabIndex = 3;
            lblNameIngredient.Text = "Name of Ingredient";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(15, 58);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 22);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // linkedDelete
            // 
            linkedDelete.AutoSize = true;
            linkedDelete.Font = new Font("Poppins", 9F);
            linkedDelete.LinkColor = Color.Red;
            linkedDelete.Location = new Point(15, 80);
            linkedDelete.Name = "linkedDelete";
            linkedDelete.Size = new Size(46, 22);
            linkedDelete.TabIndex = 5;
            linkedDelete.TabStop = true;
            linkedDelete.Text = "Delete";
            linkedDelete.LinkClicked += linkedDelete_LinkClicked;
            // 
            // numUnit
            // 
            numUnit.Location = new Point(122, 60);
            numUnit.Name = "numUnit";
            numUnit.Size = new Size(49, 23);
            numUnit.TabIndex = 6;
            numUnit.ValueChanged += numUnit_ValueChanged;
            numUnit.KeyPress += numUnit_KeyPress;
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Poppins", 9F);
            lblUnit.Location = new Point(177, 61);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(33, 22);
            lblUnit.TabIndex = 7;
            lblUnit.Text = "Unit";
            // 
            // IngredientControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblUnit);
            Controls.Add(numUnit);
            Controls.Add(linkedDelete);
            Controls.Add(lblPrice);
            Controls.Add(lblNameIngredient);
            Name = "IngredientControl";
            Size = new Size(267, 134);
            ((System.ComponentModel.ISupportInitialize)numUnit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameIngredient;
        private Label lblPrice;
        private LinkLabel linkedDelete;
        private NumericUpDown numUnit;
        private Label lblUnit;
    }
}
