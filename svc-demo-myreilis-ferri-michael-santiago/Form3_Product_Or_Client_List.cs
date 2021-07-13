using System;
using System.Threading;
using System.Windows.Forms;

namespace EmptyGUI
{
    public partial class Form3_Product_Or_Client_List : Form
    {
        Thread Sign_In;
        public Form3_Product_Or_Client_List()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProduct_List_Click(object sender, EventArgs e)
        {
            Form4_1_Product_List Product_List = new Form4_1_Product_List();
            Product_List.Show();
        }

        private void btnClient_List_Click(object sender, EventArgs e)
        {
            Form5_1_Client_List Client_List = new Form5_1_Client_List();
            Client_List.Show();
        }

        private void btnLog_Out_Click(object sender, EventArgs e)
        {
            this.Close();
            Sign_In = new Thread(open_Form1_Sign_In);
            Sign_In.SetApartmentState(ApartmentState.STA);
            Sign_In.Start();
        }
        //Log out btn to Sign In form
        private void open_Form1_Sign_In()
        {
            Application.Run(new Form1_Sign_In());
        }
    }
}
