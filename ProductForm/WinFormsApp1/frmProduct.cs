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
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Add("Food");
            cmbCategory.Items.Add("Drinks");
            cmbCategory.Items.Add("Clothing");
            cmbCategory.Items.Add("Electronics");
            cmbCategory.Items.Add("Others");

            lblBarcodeStatus.Text = "";
        }

        private void lblOrigin_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                lblBarcodeStatus.Text = "";
            }
            else
            {
                lblBarcodeStatus.Text = "Barcode is available.";
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarcode.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtCost.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtMarkup.Text))
            {
                MessageBox.Show(
                    "Please fill in all fields. ",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning

                    );
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                //MessageBox.Show("Please select a category. ");
                MessageBox.Show(
                    "Please select a category.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                cmbCategory.Focus();
                return;
            }

            decimal cost;
            decimal price;
            decimal markup;

            if (!decimal.TryParse(txtCost.Text, out cost) ||
                !decimal.TryParse(txtPrice.Text, out price) ||
                !decimal.TryParse(txtMarkup.Text, out markup))
            {
                MessageBox.Show(
                    "Cost, Price and Markup should be numbers. ",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }

            string origin = "";
            if (rdoLocal.Checked)
            {
                origin = "Local";
            }
            else
            {
                origin = "Abroad";
            }

            var product = new Product
            {
                Barcode = txtBarcode.Text.Trim(),
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Category = cmbCategory.Text,
                Origin = origin,
                IsActive = chkActive.Checked,
                Cost = cost,
                Price = price,
                Markup = markup,
            };

            string status = "Inactive";
            if (product.IsActive)
            {
                status = "Active";
            }

            MessageBox.Show(
                $"Barcode: {product.Barcode}\nName: {product.Name}\nDescription: {product.Description}\nCategory: {product.Category}\nOrigin: {product.Origin}\nStatus: {status}\nCost: {product.Cost}\nPrice: {product.Price}\nMarkup: {product.Markup}%",
                "Product saved succesfully!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBarcode.Clear();
            txtName.Clear();
            txtDescription.Clear();
            cmbCategory.SelectedIndex = -1;
            rdoLocal.Checked = true;
            chkActive.Checked = false;
            txtCost.Clear();
            txtPrice.Clear();
            txtMarkup.Clear();

            txtBarcode.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
