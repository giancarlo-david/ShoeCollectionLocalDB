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
    public partial class formEditShoe : Form
    {
        public Shoe shoeToEdit;

        public void makeShoeGlobal(Shoe e)
        {
            shoeToEdit = e;
        }

        public formEditShoe(Shoe eShoe)
        {
            InitializeComponent();
            Shoe editShoe = eShoe;
            makeShoeGlobal(editShoe);
        }

        private void formEditShoe_Load(object sender, EventArgs e)
        {
            cbBrand.SelectedIndex = cbBrand.FindString(shoeToEdit.Brand);
            tbModel.Text = shoeToEdit.Model;
            tbColorway.Text = shoeToEdit.Colorway;
            cbSize.SelectedIndex = cbSize.FindString(shoeToEdit.Size.ToString());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                Shoe changedShoe = new Shoe()
                {
                    Brand = cbBrand.SelectedItem.ToString(),
                    Model = tbModel.Text,
                    Colorway = tbColorway.Text,
                    Size = double.Parse(cbSize.SelectedItem.ToString()),
                };

                try
                {
                    ShoeDB.EditShoe(shoeToEdit, changedShoe);
                    MessageBox.Show("The shoe was edited successfully");
                }

                catch
                {
                    MessageBox.Show("Error editing shoe");
                }
            }

            catch
            {
                MessageBox.Show("Please fill out all the fields properly");
            }


        }
    }
}
