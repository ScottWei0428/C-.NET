using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbxNo.Text, out int itemNo))
            {
                MessageBox.Show("Please enter a valid number for Item No.");
                return;
            }

            string description = tbxDescription.Text;

            if (!decimal.TryParse(tbxPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid decimal number for Price.");
                return;
            }

            try
            {
                InventoryItem item = new InventoryItem(itemNo, description, price);
                List<InventoryItem> items = new List<InventoryItem> { item };
                InventoryDB.SaveItems(items);
                MessageBox.Show("Item saved successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
