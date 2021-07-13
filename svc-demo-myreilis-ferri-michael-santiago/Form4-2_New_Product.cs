using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace EmptyGUI
{
    public partial class Form4_2_New_Product : Form
    {
        public Form4_2_New_Product()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                char delimeter = '/';
                string none = "";
                if (txtProduct_ID.Text == none || txtName.Text == none || txtCategory.Text == none || txtPrice.Text == none || txtQuantity.Text == none)
                {
                    MessageBox.Show("All values must be written correctly");
                }
                if (txtProduct_ID.Text != none && txtName.Text != none && txtCategory.Text != none && txtPrice.Text != none && txtQuantity.Text != none)
                {                                               //  Add the Product_List.txt file located in the folder: App_Data
                    StreamWriter Product_List = File.AppendText("C:\\Users\\msant\\source\\repos\\UPRM-SICI-3029\\svc-demo-myreilis-ferri-michael-santiago\\bin\\Debug\\Product_List.txt");

                    Product_List.Write(txtProduct_ID.Text + delimeter);
                    Product_List.Write(txtName.Text + delimeter);
                    Product_List.Write(txtCategory.Text + delimeter);
                    Product_List.Write(txtPrice.Text + delimeter);
                    Product_List.WriteLine(txtQuantity.Text + delimeter);
                    Product_List.Close();
                    MessageBox.Show("Item was added");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
