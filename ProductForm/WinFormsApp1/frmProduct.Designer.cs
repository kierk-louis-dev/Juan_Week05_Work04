namespace WinFormsApp1
{
    partial class frmProduct
    {

        private System.ComponentModel.IContainer components = null;


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
            lblBarcode = new Label();
            txtBarcode = new TextBox();
            lblBarcodeStatus = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblOrigin = new Label();
            grpOrigin = new GroupBox();
            rdoLocal = new RadioButton();
            rdoAbroad = new RadioButton();
            lblStatus = new Label();
            chkActive = new CheckBox();
            lblCost = new Label();
            txtCost = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblMarkup = new Label();
            txtMarkup = new TextBox();
            btnCancel = new Button();
            btnClear = new Button();
            BtnSave = new Button();
            grpOrigin.SuspendLayout();
            SuspendLayout();
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(12, 20);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(48, 15);
            lblBarcode.TabIndex = 0;
            lblBarcode.Text = "Barcode";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(110, 17);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(255, 23);
            txtBarcode.TabIndex = 1;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            // 
            // lblBarcodeStatus
            // 
            lblBarcodeStatus.AutoSize = true;
            lblBarcodeStatus.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBarcodeStatus.ForeColor = SystemColors.GrayText;
            lblBarcodeStatus.Location = new Point(110, 42);
            lblBarcodeStatus.Name = "lblBarcodeStatus";
            lblBarcodeStatus.Size = new Size(105, 13);
            lblBarcodeStatus.TabIndex = 2;
            lblBarcodeStatus.Text = "Barcode is available.";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 65);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(110, 62);
            txtName.Name = "txtName";
            txtName.Size = new Size(255, 23);
            txtName.TabIndex = 4;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 94);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Multiline = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Location = new Point(110, 91);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(255, 70);
            txtDescription.TabIndex = 6;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 174);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(110, 171);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(255, 23);
            cmbCategory.TabIndex = 8;
            // 
            // lblOrigin
            // 
            lblOrigin.AutoSize = true;
            lblOrigin.Location = new Point(12, 210);
            lblOrigin.Name = "lblOrigin";
            lblOrigin.Size = new Size(37, 15);
            lblOrigin.TabIndex = 9;
            lblOrigin.Text = "Origin";
            lblOrigin.Click += lblOrigin_Click;
            // 
            // grpOrigin
            // 
            grpOrigin.Controls.Add(rdoAbroad);
            grpOrigin.Controls.Add(rdoLocal);
            grpOrigin.TabStop = false;
            grpOrigin.Location = new Point(110, 202);
            grpOrigin.Name = "grpOrigin";
            grpOrigin.Size = new Size(255, 55);
            grpOrigin.TabIndex = 10;
            grpOrigin.Text = "Manufactured";
            // 
            // rdoLocal
            // 
            rdoLocal.AutoSize = true;
            rdoLocal.Checked = true;
            rdoLocal.TabStop = true;
            rdoLocal.Location = new Point(22, 24);
            rdoLocal.Name = "rdoLocal";
            rdoLocal.Size = new Size(52, 19);
            rdoLocal.TabIndex = 11;
            rdoLocal.Text = "Local";
            rdoLocal.UseVisualStyleBackColor = true;
            // 
            // rdoAbroad
            // 
            rdoAbroad.AutoSize = true;
            rdoAbroad.Location = new Point(120, 24);
            rdoAbroad.Name = "rdoAbroad";
            rdoAbroad.Size = new Size(60, 19);
            rdoAbroad.TabIndex = 12;
            rdoAbroad.Text = "Abroad";
            rdoAbroad.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 275);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status";
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(110, 274);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(59, 19);
            chkActive.TabIndex = 14;
            chkActive.Text = "Active";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(12, 312);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(31, 15);
            lblCost.TabIndex = 15;
            lblCost.Text = "Cost";
            // 
            // txtCost
            // 
            txtCost.Location = new Point(12, 330);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(95, 23);
            txtCost.TabIndex = 16;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(113, 312);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 17;
            lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(113, 330);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(95, 23);
            txtPrice.TabIndex = 18;
            // 
            // lblMarkup
            // 
            lblMarkup.AutoSize = true;
            lblMarkup.Location = new Point(270, 312);
            lblMarkup.Name = "lblMarkup";
            lblMarkup.Size = new Size(70, 15);
            lblMarkup.TabIndex = 19;
            lblMarkup.Text = "Markup (%)";
            // 
            // txtMarkup
            // 
            txtMarkup.Location = new Point(270, 330);
            txtMarkup.Name = "txtMarkup";
            txtMarkup.Size = new Size(95, 23);
            txtMarkup.TabIndex = 20;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 375);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 30);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(113, 375);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(95, 30);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // BtnSave
            // 
            BtnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSave.Location = new Point(270, 375);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(95, 30);
            BtnSave.TabIndex = 23;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // frmProduct
            // 
            AcceptButton = BtnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(380, 425);
            Controls.Add(BtnSave);
            Controls.Add(btnClear);
            Controls.Add(btnCancel);
            Controls.Add(txtMarkup);
            Controls.Add(lblMarkup);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtCost);
            Controls.Add(lblCost);
            Controls.Add(chkActive);
            Controls.Add(lblStatus);
            Controls.Add(grpOrigin);
            Controls.Add(lblOrigin);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lblBarcodeStatus);
            Controls.Add(txtBarcode);
            Controls.Add(lblBarcode);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Form";
            Load += frmProduct_Load;
            grpOrigin.ResumeLayout(false);
            grpOrigin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBarcode;
        private TextBox txtBarcode;
        private Label lblBarcodeStatus;
        private Label lblName;
        private TextBox txtName;
        private Label lblDescription;
        private TextBox txtDescription;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblOrigin;
        private GroupBox grpOrigin;
        private RadioButton rdoLocal;
        private RadioButton rdoAbroad;
        private Label lblStatus;
        private CheckBox chkActive;
        private Label lblCost;
        private TextBox txtCost;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblMarkup;
        private TextBox txtMarkup;
        private Button btnCancel;
        private Button btnClear;
        private Button BtnSave;
    }
}
