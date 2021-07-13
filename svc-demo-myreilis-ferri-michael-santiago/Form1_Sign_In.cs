using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace EmptyGUI
{
    public partial class Form1_Sign_In : Form
    {
        Thread Product_Or_Client_List;
        Thread Sign_Up;
        public Form1_Sign_In()
        {
            InitializeComponent();
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            bool isValueUser = false;
            bool isValuePassword = false;               //  Add the User_Info.txt file located in the folder: App_Data 
            StreamReader User_Info = new StreamReader("C:\\Users\\msant\\source\\repos\\UPRM-SICI-3029\\svc-demo-myreilis-ferri-michael-santiago\\bin\\Debug\\User_Info.txt");
            string line = User_Info.ReadLine();
            if (txtPassword.Text != null && txtUsername != null)
            while (line != null)
            {
                if (line == txtUsername.Text)
                {
                    isValueUser = true;
                }
                line = User_Info.ReadLine();

                if (line == txtPassword.Text)
                {
                    isValuePassword = true;
                }
                line = User_Info.ReadLine();
            }
            if (isValueUser == true && isValuePassword == true)
            {
                MessageBox.Show("Welcome back!");
                this.Close();
                Product_Or_Client_List = new Thread(Open_Product_Or_Client_List);
                Product_Or_Client_List.SetApartmentState(ApartmentState.STA);
                Product_Or_Client_List.Start();
            }
            else
            {
                MessageBox.Show("Sorry, user not found");
            }
        } 
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            Sign_Up = new Thread(Open_Sign_Up);
            Sign_Up.SetApartmentState(ApartmentState.STA);
            Sign_Up.Start();
        }
        private void btnExitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.Close();
            Product_Or_Client_List = new Thread(Open_Product_Or_Client_List);
            Product_Or_Client_List.SetApartmentState(ApartmentState.STA);
            Product_Or_Client_List.Start();
        }
        // Skip & Sign In btn to Product_Or_Client_List form
        private void Open_Product_Or_Client_List()
        {
            Application.Run(new Form3_Product_Or_Client_List());
        }
        //Sign Up btn to Sign up form
        private void Open_Sign_Up()
        {
            Application.Run(new Form_SignUp());
        }
    }
}
