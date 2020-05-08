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

        private void showList()
        {
            List<Shoe> shoeCount = ShoeDB.GetAllShoes();
            tbShoeCount.Text = shoeCount.Count.ToString();

            string brand = cbFilter.GetItemText(cbFilter.SelectedItem);

            if (brand == "All" || brand == "")
            {
                List<Shoe> shoeList = ShoeDB.GetAllShoes();
                dgvShoes.DataSource = shoeList;
            }

            else if (brand != "All")
            {
                List<Shoe> shoeList = ShoeDB.GetShoeByType(brand);
                dgvShoes.DataSource = shoeList;
            }

            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showList();
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

                    showList();
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
                showList();
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            showList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = dgvShoes.CurrentRow.Cells[0].Value.ToString();
                string model = dgvShoes.CurrentRow.Cells[1].Value.ToString();
                string colorway = dgvShoes.CurrentRow.Cells[2].Value.ToString();
                double size = (double)dgvShoes.CurrentRow.Cells[3].Value;


                Shoe editShoe = ShoeDB.GetShoe(brand, model, colorway, size);

                formEditShoe form = new formEditShoe(editShoe);
                DialogResult r = form.ShowDialog();

                if (r == DialogResult.OK)
                {
                    showList();
                }
            }

            catch
            {
                MessageBox.Show("Please add some shoes");
            }
        }

        private void btnShoeOfDay_Click(object sender, EventArgs e)
        {
            try
            {
                string shoePicked = ShoeDB.GetRandomShoe().ToString();
                MessageBox.Show("Shoe of the Day:\t" + shoePicked);
            }

            catch
            {
                MessageBox.Show("Please add some shoes");
            }
        }

        private void buttonWeeklyRotation_Click(object sender, EventArgs e)
        {
            try
            {
                List<Shoe> rotation = ShoeDB.GetWeeklyRotation();

                string sunday = rotation[0].ToString();
                string monday = rotation[1].ToString();
                string tuesday = rotation[2].ToString();
                string wednesday = rotation[3].ToString();
                string thursday = rotation[4].ToString();
                string friday = rotation[5].ToString();
                string saturday = rotation[6].ToString();

                MessageBox.Show("Sunday:\t\t" + sunday +
                                "\nMonday:\t\t" + monday +
                                "\nTuesday:\t\t" + tuesday +
                                "\nWednesday:\t" + wednesday +
                                "\nThursday:\t" + thursday +
                                "\nFriday:\t\t" + friday +
                                "\nSaturday:\t" + saturday);
            }

            catch
            {
                MessageBox.Show("Please add some shoes");
            }
        }
    }
}
