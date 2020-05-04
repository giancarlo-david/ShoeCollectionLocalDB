using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ShoeCollectionLocalDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Shoe> shoeList = ShoeDB.GetAllShoes();
            dgvShoes.DataSource = shoeList;

            tbShoeCount.Text = shoeList.Count.ToString();
        }

        private void dgvShoes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string brand = dgvShoes.CurrentRow.Cells[0].Value.ToString();
                string model = dgvShoes.CurrentRow.Cells[1].Value.ToString();
                string colorway = dgvShoes.CurrentRow.Cells[2].Value.ToString();
                double size = (double)dgvShoes.CurrentRow.Cells[3].Value;


                Shoe tempShoe = ShoeDB.GetShoe(brand, model, colorway, size);

                if (tempShoe != null)
                {
                    tbCurrentShoe.Text = tempShoe.ToString();
                }

                else
                {
                    MessageBox.Show("That shoe is not valid now");
                }
            }
            catch
            {
                MessageBox.Show("Please select a valid shoe");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = dgvShoes.CurrentRow.Cells[0].Value.ToString();
                string model = dgvShoes.CurrentRow.Cells[1].Value.ToString();
                string colorway = dgvShoes.CurrentRow.Cells[2].Value.ToString();
                double size = (double)dgvShoes.CurrentRow.Cells[3].Value;

                Shoe tempShoe = ShoeDB.GetShoe(brand, model, colorway, size);

                DialogResult dialog = MessageBox.Show("Are you sure you want to delete " + tempShoe.ToString() + "?",
                    "Verify", MessageBoxButtons.YesNo);

                if (dialog == DialogResult.Yes)
                {
                    ShoeDB.DeleteShoe(tempShoe);
                    MessageBox.Show("The shoe was removed successfully!");
                    this.DialogResult = DialogResult.OK;

                    List<Shoe> shoeList = ShoeDB.GetAllShoes();
                    dgvShoes.DataSource = shoeList;
                    tbShoeCount.Text = shoeList.Count.ToString();
                }
            }

            catch
            {
                MessageBox.Show("There is no shoe to remove there");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formAddShoe form = new formAddShoe();
            DialogResult r = form.ShowDialog();

            if (r == DialogResult.OK)
            {
                List<Shoe> shoeList = ShoeDB.GetAllShoes();
                dgvShoes.DataSource = shoeList;
                tbShoeCount.Text = shoeList.Count.ToString();
            }
        }
    }
}
