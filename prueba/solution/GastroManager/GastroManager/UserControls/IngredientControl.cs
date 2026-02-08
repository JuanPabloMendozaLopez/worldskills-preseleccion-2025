using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GastroManager.UserControls
{
    public partial class IngredientControl : UserControl
    {

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IngredientId { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string IngredientName
        {
            get
            {
                return lblNameIngredient.Tag.ToString();
            }
            set
            {
                lblNameIngredient.Text = value;
                lblNameIngredient.Tag = value;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public decimal Price
        {
            get
            {
                return Convert.ToDecimal(lblPrice.Tag);
            }
            set
            {
                lblPrice.Text = "Price: " + value;
                lblPrice.Tag = value;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Stock
        {
            get
            {
                return Convert.ToInt32(numUnit.Value);
            }
            set
            {
                numUnit.Value = value;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Unit
        {
            get
            {
                return lblUnit.Text;
            }
            set
            {
                lblUnit.Text = value;
            }
        }

        //Eventos
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public EventHandler<int> DeleteAction { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public EventHandler<int> ChangedStockAction { get; set; }

        public IngredientControl()
        {
            InitializeComponent();
        }

        private void linkedDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DeleteAction?.Invoke(this, IngredientId);

        }

        private void numUnit_ValueChanged(object sender, EventArgs e)
        {

            ChangedStockAction?.Invoke(this, IngredientId);

        }

        private void numUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == '-' || e.KeyChar == '+')
                e.Handled = true;
        }
    }
}
