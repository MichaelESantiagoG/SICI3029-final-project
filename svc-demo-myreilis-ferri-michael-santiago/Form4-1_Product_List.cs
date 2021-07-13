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
    public partial class Form4_1_Product_List : Form
    {
        public Form4_1_Product_List()
        {
            InitializeComponent();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            Form4_2_New_Product New_Product = new Form4_2_New_Product();
            New_Product.Show();
        }

        private void btn_Sign_Out_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        DataTable table = new DataTable();
        private void btnReload_Click(object sender, EventArgs e)
        {
                                                        //    Add the Product_List.txt file located in the folder: App_Data
            using (var streamReader = new StreamReader(@"C:\\Users\\msant\\source\\repos\\UPRM-SICI-3029\\svc-demo-myreilis-ferri-michael-santiago\\bin\\Debug\\Product_List.txt"))
            {
                this.dataGridView1.Rows.Clear();
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    var values = line.Split('/');
                    var rowIndex = dataGridView1.Rows.Add();
                    for (int i = 0; i < values.Length; i++)
                    {
                        dataGridView1.Rows[rowIndex].Cells[i].Value = values[i];
                    }
                }
            }
        }
        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    int index = dataGridView1.SelectedCells[0].RowIndex;
                    dataGridView1.Rows.RemoveAt(index);                      // Add the Product_List.txt file located in the folder: App_Data
                    var file = new List<string>(System.IO.File.ReadAllLines("C:\\Users\\msant\\source\\repos\\UPRM-SICI-3029\\svc-demo-myreilis-ferri-michael-santiago\\bin\\Debug\\Product_List.txt"));
                    file.RemoveAt(index);                                    //Add the Product_List.txt file located in the folder: App_Data
                    File.WriteAllLines("C:\\Users\\msant\\source\\repos\\UPRM-SICI-3029\\svc-demo-myreilis-ferri-michael-santiago\\bin\\Debug\\Product_List.txt", file.ToArray());
                }
            }
            catch
            {
            }
        }
    }
}
