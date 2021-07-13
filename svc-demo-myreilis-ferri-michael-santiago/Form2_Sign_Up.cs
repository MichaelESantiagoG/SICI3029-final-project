using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace EmptyGUI
{
    public partial class Form_SignUp : Form
    {
        Thread Sign_In;
        Thread Product_Or_Client_List;
        public Form_SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_SignUpForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Password_SignUp.Text == txt_Re_enter_Password.Text)
                {
                    StreamWriter User_Info;     //  Add the User_Info.txt file located in the folder: App_Data 
                    User_Info = File.AppendText("C:\\Users\\msant\\source\\repos\\UPRM-SICI-3029\\svc-demo-myreilis-ferri-michael-santiago\\bin\\Debug\\User_Info.txt");
                    string none = "";
                    if (txt_First_Name_SignUp.Text == none || txt_Last_Name_SignUp.Text == none || txt_Email_SignUp.Text == none || txt_Phone_Number_SignUp.Text == none || txt_UserName_SignUp.Text == none || txt_Password_SignUp.Text == none)
                    {
                        MessageBox.Show("Please fill up the blanks");
                    }
                    if (txt_First_Name_SignUp.Text != none && txt_Last_Name_SignUp.Text != none && txt_Email_SignUp.Text != none && txt_Phone_Number_SignUp.Text != none && txt_UserName_SignUp.Text != none && txt_Password_SignUp.Text != none)
                    {
                        User_Info.WriteLine("___________________");

                        User_Info.WriteLine(txt_First_Name_SignUp.Text);
                        User_Info.WriteLine(txt_Last_Name_SignUp.Text);
                        User_Info.WriteLine(txt_Email_SignUp.Text);
                        User_Info.WriteLine(txt_Phone_Number_SignUp.Text);
                        User_Info.WriteLine(txt_UserName_SignUp.Text);
                        User_Info.WriteLine(txt_Password_SignUp.Text);

                        User_Info.Close();
                        this.Close();
                        this.Close();
                        Product_Or_Client_List = new Thread(Open_Product_Or_Client_List);
                        Product_Or_Client_List.SetApartmentState(ApartmentState.STA);
                        Product_Or_Client_List.Start();
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong\nPlease try again");
            }

        }

        private void Open_Product_Or_Client_List()
        {
            Application.Run(new Form3_Product_Or_Client_List());
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            this.Close();
            Sign_In = new Thread(open_Form1_Sign_In);
            Sign_In.SetApartmentState(ApartmentState.STA);
            Sign_In.Start();
        }
        //return btn to Sign In form
        private void open_Form1_Sign_In()
        {
            Application.Run(new Form1_Sign_In());
        }
    }
}
