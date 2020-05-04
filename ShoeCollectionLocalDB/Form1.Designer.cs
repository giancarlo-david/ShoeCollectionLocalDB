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
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvShoes = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelShoesCount = new System.Windows.Forms.Label();
            this.tbShoeCount = new System.Windows.Forms.TextBox();
            this.labelCurrentShoe = new System.Windows.Forms.Label();
            this.tbCurrentShoe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(48, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 60);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvShoes
            // 
            this.dgvShoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShoes.Location = new System.Drawing.Point(187, 62);
            this.dgvShoes.Name = "dgvShoes";
            this.dgvShoes.Size = new System.Drawing.Size(601, 292);
            this.dgvShoes.TabIndex = 1;
            this.dgvShoes.SelectionChanged += new System.EventHandler(this.dgvShoes_SelectionChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(48, 176);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 60);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 60);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelShoesCount
            // 
            this.labelShoesCount.AutoSize = true;
            this.labelShoesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShoesCount.Location = new System.Drawing.Point(595, 40);
            this.labelShoesCount.Name = "labelShoesCount";
            this.labelShoesCount.Size = new System.Drawing.Size(87, 16);
            this.labelShoesCount.TabIndex = 4;
            this.labelShoesCount.Text = "Shoes Count:";
            // 
            // tbShoeCount
            // 
            this.tbShoeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShoeCount.Location = new System.Drawing.Point(688, 34);
            this.tbShoeCount.Name = "tbShoeCount";
            this.tbShoeCount.ReadOnly = true;
            this.tbShoeCount.Size = new System.Drawing.Size(100, 22);
            this.tbShoeCount.TabIndex = 5;
            // 
            // labelCurrentShoe
            // 
            this.labelCurrentShoe.AutoSize = true;
            this.labelCurrentShoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentShoe.Location = new System.Drawing.Point(183, 375);
            this.labelCurrentShoe.Name = "labelCurrentShoe";
            this.labelCurrentShoe.Size = new System.Drawing.Size(185, 20);
            this.labelCurrentShoe.TabIndex = 6;
            this.labelCurrentShoe.Text = "Currently Selected Shoe:";
            // 
            // tbCurrentShoe
            // 
            this.tbCurrentShoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentShoe.Location = new System.Drawing.Point(374, 369);
            this.tbCurrentShoe.Name = "tbCurrentShoe";
            this.tbCurrentShoe.ReadOnly = true;
            this.tbCurrentShoe.Size = new System.Drawing.Size(414, 26);
            this.tbCurrentShoe.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCurrentShoe);
            this.Controls.Add(this.labelCurrentShoe);
            this.Controls.Add(this.tbShoeCount);
            this.Controls.Add(this.labelShoesCount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dgvShoes);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShoes)).EndInit();
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
    }
}

