using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeCollectionLocalDB
{
    public partial class formAddShoe : Form
    {
        public formAddShoe()
        {
            InitializeComponent();
        }

        private void btnAddShoe_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = cbBrand.SelectedItem.ToString();
                double size = double.Parse(cbSize.SelectedItem.ToString());

                Shoe tempShoe = new Shoe
                {
                    Brand = brand,
                    Model = tbModel.Text.ToString(),
                    Colorway = tbColorway.Text.ToString(),
                    Size = size,
                };

                try
                {
                    ShoeDB.AddShoe(tempShoe);
                    MessageBox.Show("The shoe was added successfully");
                }

                catch
                {
                    MessageBox.Show("Error adding shoe");
                }
            }
            catch
            {
                MessageBox.Show("Please fill all the fields properly");
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
