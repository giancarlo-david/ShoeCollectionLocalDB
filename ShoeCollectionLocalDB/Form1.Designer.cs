namespace ShoeCollectionLocalDB
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvShoes = new System.Windows.Forms.DataGridView();
            this.labelShoesCount = new System.Windows.Forms.Label();
            this.tbShoeCount = new System.Windows.Forms.TextBox();
            this.labelCurrentShoe = new System.Windows.Forms.Label();
            this.tbCurrentShoe = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelDesignSide = new System.Windows.Forms.Panel();
            this.btnShoeOfDay = new System.Windows.Forms.Button();
            this.buttonWeeklyRotation = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelFilter = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.panelDesign = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoes)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShoes
            // 
            this.dgvShoes.AllowUserToAddRows = false;
            this.dgvShoes.AllowUserToDeleteRows = false;
            this.dgvShoes.AllowUserToResizeColumns = false;
            this.dgvShoes.AllowUserToResizeRows = false;
            this.dgvShoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShoes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.dgvShoes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvShoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(68)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShoes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShoes.GridColor = System.Drawing.Color.White;
            this.dgvShoes.Location = new System.Drawing.Point(206, 62);
            this.dgvShoes.Name = "dgvShoes";
            this.dgvShoes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShoes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvShoes.RowHeadersVisible = false;
            this.dgvShoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShoes.Size = new System.Drawing.Size(788, 292);
            this.dgvShoes.TabIndex = 1;
            this.dgvShoes.TabStop = false;
            this.dgvShoes.SelectionChanged += new System.EventHandler(this.dgvShoes_SelectionChanged);
            // 
            // labelShoesCount
            // 
            this.labelShoesCount.AutoSize = true;
            this.labelShoesCount.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShoesCount.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelShoesCount.Location = new System.Drawing.Point(790, 364);
            this.labelShoesCount.Name = "labelShoesCount";
            this.labelShoesCount.Size = new System.Drawing.Size(98, 17);
            this.labelShoesCount.TabIndex = 4;
            this.labelShoesCount.Text = "Shoe Count:";
            // 
            // tbShoeCount
            // 
            this.tbShoeCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.tbShoeCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbShoeCount.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShoeCount.ForeColor = System.Drawing.SystemColors.Info;
            this.tbShoeCount.Location = new System.Drawing.Point(894, 364);
            this.tbShoeCount.Name = "tbShoeCount";
            this.tbShoeCount.ReadOnly = true;
            this.tbShoeCount.Size = new System.Drawing.Size(100, 18);
            this.tbShoeCount.TabIndex = 5;
            this.tbShoeCount.TabStop = false;
            this.tbShoeCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCurrentShoe
            // 
            this.labelCurrentShoe.AutoSize = true;
            this.labelCurrentShoe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCurrentShoe.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentShoe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelCurrentShoe.Location = new System.Drawing.Point(202, 361);
            this.labelCurrentShoe.Name = "labelCurrentShoe";
            this.labelCurrentShoe.Size = new System.Drawing.Size(193, 20);
            this.labelCurrentShoe.TabIndex = 6;
            this.labelCurrentShoe.Text = "Currently Selected Shoe";
            // 
            // tbCurrentShoe
            // 
            this.tbCurrentShoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.tbCurrentShoe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCurrentShoe.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentShoe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbCurrentShoe.Location = new System.Drawing.Point(206, 393);
            this.tbCurrentShoe.Multiline = true;
            this.tbCurrentShoe.Name = "tbCurrentShoe";
            this.tbCurrentShoe.ReadOnly = true;
            this.tbCurrentShoe.Size = new System.Drawing.Size(189, 128);
            this.tbCurrentShoe.TabIndex = 7;
            this.tbCurrentShoe.TabStop = false;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.panelButtons.Controls.Add(this.panelDesignSide);
            this.panelButtons.Controls.Add(this.btnShoeOfDay);
            this.panelButtons.Controls.Add(this.buttonWeeklyRotation);
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnRemove);
            this.panelButtons.Controls.Add(this.btnEdit);
            this.panelButtons.Controls.Add(this.btnExit);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(191, 533);
            this.panelButtons.TabIndex = 8;
            // 
            // panelDesignSide
            // 
            this.panelDesignSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.panelDesignSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDesignSide.Location = new System.Drawing.Point(0, 0);
            this.panelDesignSide.Name = "panelDesignSide";
            this.panelDesignSide.Size = new System.Drawing.Size(191, 53);
            this.panelDesignSide.TabIndex = 12;
            // 
            // btnShoeOfDay
            // 
            this.btnShoeOfDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.btnShoeOfDay.FlatAppearance.BorderSize = 0;
            this.btnShoeOfDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoeOfDay.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoeOfDay.Image = ((System.Drawing.Image)(resources.GetObject("btnShoeOfDay.Image")));
            this.btnShoeOfDay.Location = new System.Drawing.Point(0, 302);
            this.btnShoeOfDay.Name = "btnShoeOfDay";
            this.btnShoeOfDay.Size = new System.Drawing.Size(191, 73);
            this.btnShoeOfDay.TabIndex = 4;
            this.btnShoeOfDay.Text = "Shoe of the Day";
            this.btnShoeOfDay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShoeOfDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnShoeOfDay.UseVisualStyleBackColor = false;
            this.btnShoeOfDay.Click += new System.EventHandler(this.btnShoeOfDay_Click);
            // 
            // buttonWeeklyRotation
            // 
            this.buttonWeeklyRotation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.buttonWeeklyRotation.FlatAppearance.BorderSize = 0;
            this.buttonWeeklyRotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWeeklyRotation.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWeeklyRotation.Image = ((System.Drawing.Image)(resources.GetObject("buttonWeeklyRotation.Image")));
            this.buttonWeeklyRotation.Location = new System.Drawing.Point(0, 381);
            this.buttonWeeklyRotation.Name = "buttonWeeklyRotation";
            this.buttonWeeklyRotation.Size = new System.Drawing.Size(191, 73);
            this.buttonWeeklyRotation.TabIndex = 5;
            this.buttonWeeklyRotation.Text = "Weekly Rotation";
            this.buttonWeeklyRotation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonWeeklyRotation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonWeeklyRotation.UseVisualStyleBackColor = false;
            this.buttonWeeklyRotation.Click += new System.EventHandler(this.buttonWeeklyRotation_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(0, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(191, 73);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(0, 223);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(191, 73);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(0, 144);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(191, 73);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.Location = new System.Drawing.Point(0, 460);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(191, 73);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelFilter.Location = new System.Drawing.Point(494, 363);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(50, 17);
            this.labelFilter.TabIndex = 9;
            this.labelFilter.Text = "Filter:";
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "All",
            "Adidas",
            "Asics",
            "Converse",
            "Diadora",
            "Jordan",
            "New Balance",
            "Nike",
            "Other",
            "Puma",
            "Reebok",
            "Saucony",
            "Vans"});
            this.cbFilter.Location = new System.Drawing.Point(550, 360);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 21);
            this.cbFilter.TabIndex = 7;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // panelDesign
            // 
            this.panelDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.panelDesign.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDesign.Location = new System.Drawing.Point(191, 0);
            this.panelDesign.Name = "panelDesign";
            this.panelDesign.Size = new System.Drawing.Size(815, 53);
            this.panelDesign.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1006, 533);
            this.Controls.Add(this.panelDesign);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.tbCurrentShoe);
            this.Controls.Add(this.labelCurrentShoe);
            this.Controls.Add(this.tbShoeCount);
            this.Controls.Add(this.labelShoesCount);
            this.Controls.Add(this.dgvShoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Shoe Collection";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoes)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvShoes;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelShoesCount;
        private System.Windows.Forms.TextBox tbShoeCount;
        private System.Windows.Forms.Label labelCurrentShoe;
        private System.Windows.Forms.TextBox tbCurrentShoe;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnShoeOfDay;
        private System.Windows.Forms.Button buttonWeeklyRotation;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Panel panelDesignSide;
        private System.Windows.Forms.Panel panelDesign;
    }
}

