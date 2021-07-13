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
    public partial class Form5_1_Client_List : Form
    {
        public Form5_1_Client_List()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string none = "";
            if (txtCustomerID.Text != none && txtFirstName.Text != none && txtLastName.Text != none && txtPhone.Text != none && txtEmail.Text != none)
            {

                int n = dtgvClientList.Rows.Add();

                dtgvClientList.Rows[n].Cells[0].Value = txtCustomerID.Text;
                dtgvClientList.Rows[n].Cells[1].Value = txtFirstName.Text;
                dtgvClientList.Rows[n].Cells[2].Value = txtLastName.Text;
                dtgvClientList.Rows[n].Cells[3].Value = txtPhone.Text;
                dtgvClientList.Rows[n].Cells[4].Value = txtEmail.Text;

                char delimeter = '/';                       //  Add the Client_List.txt file located in the folder: App_Data
                StreamWriter Client_List = File.AppendText("C:\\Users\\msant\\source\\repos\\UPRM-SICI-3029\\svc-demo-myreilis-ferri-michael-santiago\\bin\\Debug\\Client_List.txt");

                Client_List.Write(txtCustomerID.Text + delimeter);
                Client_List.Write(txtFirstName.Text + delimeter);
                Client_List.Write(txtLastName.Text + delimeter);
                Client_List.Write(txtPhone.Text + delimeter);
                Client_List.WriteLine(txtEmail.Text);
                Client_List.Close();

                txtCustomerID.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
            }
            else
            {
                MessageBox.Show("Fill in the blanks");
            }

        }

        private void dtgvClientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int index = dtgvClientList.SelectedCells[0].RowIndex;
                    dtgvClientList.Rows.RemoveAt(index);                      // Add the Client_List.txt file located in the folder: App_Data
                    var file = new List<string>(System.IO.File.ReadAllLines("C:\\Users\\msant\\source\\repos\\UPRM-SICI-3029\\svc-demo-myreilis-ferri-michael-santiago\\bin\\Debug\\Client_List.txt"));
                    file.RemoveAt(index);                                    //Add the Client_List.txt file located in the folder: App_Data
                    File.WriteAllLines("C:\\Users\\msant\\source\\repos\\UPRM-SICI-3029\\svc-demo-myreilis-ferri-michael-santiago\\bin\\Debug\\Client_List.txt", file.ToArray());
                }
            }
            catch
            {
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataTable table = new DataTable();
        private void btnReload_Click(object sender, EventArgs e)
        {                                               //  Add the Client_List.txt file located in the folder: App_Data
            using (var streamReader = new StreamReader(@"C:\\Users\\msant\\source\\repos\\UPRM-SICI-3029\\svc-demo-myreilis-ferri-michael-santiago\\bin\\Debug\\Client_List.txt"))
            {
                this.dtgvClientList.Rows.Clear();
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    var values = line.Split('/');
                    var rowIndex = dtgvClientList.Rows.Add();
                    for (int x = 0; x < values.Length; x++)
                    {
                        dtgvClientList.Rows[rowIndex].Cells[x].Value = values[x];
                    }
                }
            }
        }
    }
}