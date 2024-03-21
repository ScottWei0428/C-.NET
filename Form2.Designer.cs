namespace lab6
{
    partial class FormAdd
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
            lblNo = new Label();
            tbxNo = new TextBox();
            tbxDescription = new TextBox();
            lblDescription = new Label();
            tbxPrice = new TextBox();
            lblPrice = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(191, 67);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(84, 24);
            lblNo.TabIndex = 0;
            lblNo.Text = "Item &No:";
            // 
            // tbxNo
            // 
            tbxNo.Location = new Point(316, 61);
            tbxNo.Name = "tbxNo";
            tbxNo.Size = new Size(197, 30);
            tbxNo.TabIndex = 1;
            // 
            // tbxDescription
            // 
            tbxDescription.Location = new Point(316, 137);
            tbxDescription.Name = "tbxDescription";
            tbxDescription.Size = new Size(197, 30);
            tbxDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(191, 143);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(113, 24);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "&Description:";
            // 
            // tbxPrice
            // 
            tbxPrice.Location = new Point(316, 225);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(197, 30);
            tbxPrice.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(191, 228);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(52, 24);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "&Price";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(191, 325);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(124, 41);
            btnSave.TabIndex = 6;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(451, 325);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 41);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tbxPrice);
            Controls.Add(lblPrice);
            Controls.Add(tbxDescription);
            Controls.Add(lblDescription);
            Controls.Add(tbxNo);
            Controls.Add(lblNo);
            Name = "FormAdd";
            Text = "New Inventory Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNo;
        private TextBox tbxNo;
        private TextBox tbxDescription;
        private Label lblDescription;
        private TextBox tbxPrice;
        private Label lblPrice;
        private Button btnSave;
        private Button btnCancel;
    }
}