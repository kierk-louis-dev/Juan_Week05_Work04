using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmProduct : Form
    {
        private List<Product> products = new List<Product>();

        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            cboCategory.Items.Add("Beverages");
            cboCategory.Items.Add("Snacks");
            cboCategory.Items.Add("Canned Goods");
            cboCategory.Items.Add("Personal Care");
            cboCategory.Items.Add("Household");
            cboCategory.Items.Add("Electronics");
            cboCategory.Items.Add("Others");

            lvwProducts.Columns.Add("Barcode", 100);
            lvwProducts.Columns.Add("Name", 100);
            lvwProducts.Columns.Add("Category", 85);
            lvwProducts.Columns.Add("Origin", 55);
            lvwProducts.Columns.Add("Status", 55);
            lvwProducts.Columns.Add("Cost", 50);
            lvwProducts.Columns.Add("Price", 50);
            lvwProducts.Columns.Add("Markup %", 60);

            txtBarcode.Focus();
        }

        private bool IsDigitsOnly(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void UpdateTotal()
        {
            lblTotal.Text = "Total products: " + products.Count;
        }

        private bool HasInput()
        {
            if (!string.IsNullOrWhiteSpace(txtBarcode.Text) ||
                !string.IsNullOrWhiteSpace(txtName.Text) ||
                !string.IsNullOrWhiteSpace(txtDescription.Text) ||
                cboCategory.SelectedIndex != -1 ||
                !string.IsNullOrWhiteSpace(txtCost.Text) ||
                !string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                return true;
            }
            return false;
        }

        private bool BarcodeExists(string barcode)
        {
            foreach (Product p in products)
            {
                if (p.Barcode == barcode)
                {
                    return true;
                }
            }
            return false;
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            CheckBarcode();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            lblDescriptionCount.Text = txtDescription.Text.Length + " / 200";
        }

        private void CheckBarcode()
        {
            if (string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                lblBarcodeStatus.Text = "";
                return;
            }

            if (BarcodeExists(txtBarcode.Text.Trim()))
            {
                lblBarcodeStatus.Text = "Barcode already exists.";
                lblBarcodeStatus.ForeColor = Color.Red;
            }
            else
            {
                lblBarcodeStatus.Text = "Barcode is available.";
                lblBarcodeStatus.ForeColor = Color.Green;
            }
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
            {
                chkActive.Text = "Active";
            }
            else
            {
                chkActive.Text = "Inactive";
            }
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtCost.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtPrice.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            ComputeMarkup();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            ComputeMarkup();
        }

        private void txtCost_Leave(object sender, EventArgs e)
        {
            decimal cost;
            if (decimal.TryParse(txtCost.Text, out cost))
            {
                txtCost.Text = cost.ToString("0.00");
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            decimal price;
            if (decimal.TryParse(txtPrice.Text, out price))
            {
                txtPrice.Text = price.ToString("0.00");
            }
        }

        private void ComputeMarkup()
        {
            decimal cost;
            decimal price;

            if (decimal.TryParse(txtCost.Text, out cost) &&
                decimal.TryParse(txtPrice.Text, out price) &&
                cost > 0)
            {
                decimal markup = (price - cost) / cost * 100;
                txtMarkup.Text = markup.ToString("0.00");

                if (markup < 0)
                {
                    txtMarkup.ForeColor = Color.Red;
                }
                else
                {
                    txtMarkup.ForeColor = Color.Black;
                }
            }
            else
            {
                txtMarkup.Text = "";
            }
        }

        private void ClearForm()
        {
            txtBarcode.Clear();
            txtName.Clear();
            txtDescription.Clear();
            cboCategory.SelectedIndex = -1;
            rdoLocal.Checked = true;
            chkActive.Checked = false;
            txtCost.Clear();
            txtPrice.Clear();
            txtMarkup.Clear();
            lblBarcodeStatus.Text = "";
            txtBarcode.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (HasInput())
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to clear all the fields?",
                    "Clear",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Please select a product to delete.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }

            ListViewItem selected = lvwProducts.SelectedItems[0];

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete " + selected.SubItems[1].Text + "?",
                "Delete Product",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.No)
            {
                return;
            }

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Barcode == selected.Text)
                {
                    products.RemoveAt(i);
                    break;
                }
            }

            lvwProducts.Items.Remove(selected);
            UpdateTotal();
            CheckBarcode();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel?",
                "Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                MessageBox.Show(
                    "Please enter the barcode.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                txtBarcode.Focus();
                return;
            }

            if (!IsDigitsOnly(txtBarcode.Text.Trim()))
            {
                MessageBox.Show(
                    "The barcode must contain numbers only.",
                    "Invalid Barcode",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                txtBarcode.Focus();
                return;
            }

            if (txtBarcode.Text.Trim().Length < 8)
            {
                MessageBox.Show(
                    "The barcode must be at least 8 digits.",
                    "Invalid Barcode",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                txtBarcode.Focus();
                return;
            }

            if (BarcodeExists(txtBarcode.Text.Trim()))
            {
                MessageBox.Show(
                    "This barcode is already used by another product.",
                    "Duplicate Barcode",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                txtBarcode.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(
                    "Please enter the product name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show(
                    "Please enter the product description.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                txtDescription.Focus();
                return;
            }

            if (cboCategory.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a category.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                cboCategory.Focus();
                return;
            }

            decimal cost;
            decimal price;

            if (!decimal.TryParse(txtCost.Text, out cost) || cost <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid cost.",
                    "Invalid Cost",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                txtCost.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out price) || price <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid price.",
                    "Invalid Price",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                txtPrice.Focus();
                return;
            }

            if (price < cost)
            {
                DialogResult result = MessageBox.Show(
                    "The price is lower than the cost. Do you still want to save?",
                    "Low Price",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (result == DialogResult.No)
                {
                    txtPrice.Focus();
                    return;
                }
            }

            string origin = "Local";
            if (rdoAbroad.Checked)
            {
                origin = "Abroad";
            }

            string status = "Inactive";
            if (chkActive.Checked)
            {
                status = "Active";
            }

            var product = new Product
            {
                Barcode = txtBarcode.Text.Trim(),
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Category = cboCategory.Text,
                Origin = origin,
                IsActive = chkActive.Checked,
                Cost = cost,
                Price = price,
                Markup = (price - cost) / cost * 100,
            };

            products.Add(product);

            ListViewItem item = new ListViewItem(product.Barcode);
            item.SubItems.Add(product.Name);
            item.SubItems.Add(product.Category);
            item.SubItems.Add(product.Origin);
            item.SubItems.Add(status);
            item.SubItems.Add(product.Cost.ToString("0.00"));
            item.SubItems.Add(product.Price.ToString("0.00"));
            item.SubItems.Add(product.Markup.ToString("0.00"));
            lvwProducts.Items.Add(item);
            UpdateTotal();

            MessageBox.Show(
                $"Barcode: {product.Barcode}\nName: {product.Name}\nDescription: {product.Description}\nCategory: {product.Category}\nOrigin: {product.Origin}\nStatus: {status}\nCost: {product.Cost:0.00}\nPrice: {product.Price:0.00}\nMarkup: {product.Markup:0.00}%\n\nTotal products saved: {products.Count}",
                "Product Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

            ClearForm();
        }
    }
}
