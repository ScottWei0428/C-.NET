using System.IO;

namespace lab6
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            LoadItemsIntoDisplayArea();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.ShowDialog();
            LoadItemsIntoDisplayArea();
        }

        public void LoadItemsIntoDisplayArea()
        {
            try
            {

                displayArea.Items.Clear();

                List<InventoryItem> items = InventoryDB.GetItems();

                foreach (var item in items)
                {
                    displayArea.Items.Add($"{item.ItemNo}|{item.Description}|{item.Price}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (displayArea.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.");
            }
            else
            {
                for (int i = displayArea.SelectedItems.Count - 1; i >= 0; i--)
                {
                    displayArea.Items.Remove(displayArea.SelectedItems[i]);
                }
            }

                            
        }
    }
}
