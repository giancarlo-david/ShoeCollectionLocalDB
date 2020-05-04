namespace ShoeCollectionLocalDB
{
    partial class formAddShoe
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
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelModel = new System.Windows.Forms.Label();
            this.labelColorway = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbColorway = new System.Windows.Forms.TextBox();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.btnAddShoe = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.Location = new System.Drawing.Point(56, 64);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(47, 16);
            this.labelBrand.TabIndex = 0;
            this.labelBrand.Text = "Brand:";
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModel.Location = new System.Drawing.Point(56, 100);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(49, 16);
            this.labelModel.TabIndex = 1;
            this.labelModel.Text = "Model:";
            // 
            // labelColorway
            // 
            this.labelColorway.AutoSize = true;
            this.labelColorway.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColorway.Location = new System.Drawing.Point(56, 140);
            this.labelColorway.Name = "labelColorway";
            this.labelColorway.Size = new System.Drawing.Size(67, 16);
            this.labelColorway.TabIndex = 2;
            this.labelColorway.Text = "Colorway:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(56, 179);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(37, 16);
            this.labelSize.TabIndex = 3;
            this.labelSize.Text = "Size:";
            // 
            // cbBrand
            // 
            this.cbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.Items.AddRange(new object[] {
            "Adidas",
            "Asics",
            "Converse",
            "Diadora",
            "Jordan",
            "New Balance",
            "Nike",
            "Puma",
            "Reebok",
            "Saucony",
            "Vans",
            "Other"});
            this.cbBrand.Location = new System.Drawing.Point(151, 59);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(100, 21);
            this.cbBrand.TabIndex = 1;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(151, 99);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 20);
            this.tbModel.TabIndex = 2;
            // 
            // tbColorway
            // 
            this.tbColorway.Location = new System.Drawing.Point(151, 136);
            this.tbColorway.Name = "tbColorway";
            this.tbColorway.Size = new System.Drawing.Size(100, 20);
            this.tbColorway.TabIndex = 3;
            // 
            // cbSize
            // 
            this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "7.0",
            "7.5",
            "8.0",
            "8.5",
            "9.0",
            "9.5",
            "10.0",
            "10.5",
            "11.0",
            "11.5",
            "12.0",
            "12.5",
            "13.0"});
            this.cbSize.Location = new System.Drawing.Point(151, 174);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(100, 21);
            this.cbSize.TabIndex = 4;
            // 
            // btnAddShoe
            // 
            this.btnAddShoe.Location = new System.Drawing.Point(59, 240);
            this.btnAddShoe.Name = "btnAddShoe";
            this.btnAddShoe.Size = new System.Drawing.Size(85, 60);
            this.btnAddShoe.TabIndex = 5;
            this.btnAddShoe.Text = "Add Shoe";
            this.btnAddShoe.UseVisualStyleBackColor = true;
            this.btnAddShoe.Click += new System.EventHandler(this.btnAddShoe_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(159, 240);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(92, 60);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // formAddShoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 360);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnAddShoe);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.tbColorway);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelColorway);
            this.Controls.Add(this.labelModel);
            this.Controls.Add(this.labelBrand);
            this.Name = "formAddShoe";
            this.Text = "formAddShoe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.Label labelColorway;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox cbBrand;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbColorway;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Button btnAddShoe;
        private System.Windows.Forms.Button btnFinish;
    }
}