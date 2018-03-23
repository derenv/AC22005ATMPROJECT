using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FAtm : Form
    {
        //bank pointer
        FBank fPointer = null;

        //option labels
        Label[] left_lbls;
        Label[] right_lbls;

        //option buttons
        Button[] left_btns;
        Button[] right_btns;

        //output text label
        Label output_label;

        public FAtm()
        {
            //form resize
            this.Size = new Size(345, 300);

            //init main components
            InitializeComponent();
        }

        /*
         * set bank main computer reference
         * for accessing data
         * 
         */
        public void setAtm(FBank point)
        {
            fPointer = point;
        }

        private void Atm_Load(object sender, EventArgs e) { }
        private void Atm_Show(object sender, EventArgs e) { }

        /*
         * load the options of the atm
         * 
         * 
         */
        private void new_atm_load(object sender, EventArgs e)
        {
            //form resize
            this.Size = new Size(500,500);

            //option labels
            left_lbls = new Label[4];
            right_lbls = new Label[4];

            //option buttons
            left_btns = new Button[4];
            right_btns = new Button[4];

            //creation loop
            for (int i = 0; i < 4; i++)
            {
                left_btns[i] = new Button();
                left_btns[i].SetBounds(10, 50 + (70 * i), 50, 50);
                left_btns[i].Click += new EventHandler(this.atm_button_Click);
                left_lbls[i] = new Label();
                left_lbls[i].SetBounds(70, 65 + (70 * i), 70, 70);

                right_btns[i] = new Button();
                right_btns[i].SetBounds(350, 50 + (70 * i), 50, 50);
                right_btns[i].Click += new EventHandler(this.atm_button_Click);
                right_lbls[i] = new Label();
                right_lbls[i].SetBounds(410, 65 + (70 * i), 70, 70);
            }

            //output label
            output_label = new Label();
            output_label.SetBounds(150, 50, 150, 150);
            output_label.Font = new Font("Arial", 10, FontStyle.Regular);
            output_label.TextAlign = ContentAlignment.TopCenter;

            //setup buttons with main menu
            menu_setup("main");
        }

        /*
         * show the options of the atm
         * 
         * 
         */
        private void menu_setup(string menu_type)
        {
            if (menu_type.Equals("main"))
            {
                //output text
                output_label.Text = "==Main Menu==\r\n\r\nWelcome to our ATM!\r\n\r\n==Main Menu==";
                
                //option text
                left_btns[0].Text = "";
                left_lbls[0].Text = "Balance";
                left_btns[0].Tag = "balance";

                left_btns[1].Text = "";
                left_lbls[1].Text = "Withdraw";
                left_btns[1].Tag = "withdraw";

                left_btns[2].Text = "";
                left_lbls[2].Text = "";
                left_btns[2].Tag = "null";

                left_btns[3].Text = "";
                left_lbls[3].Text = "";
                left_btns[3].Tag = "null";

                right_btns[0].Text = "";
                right_lbls[0].Text = "";
                right_btns[0].Tag = "null";

                right_btns[1].Text = "";
                right_lbls[1].Text = "";
                right_btns[1].Tag = "null";

                right_btns[2].Text = "";
                right_lbls[2].Text = "";
                right_btns[2].Tag = "null";

                right_btns[3].Text = "";
                right_lbls[3].Text = "";
                right_btns[3].Tag = "null";
            }
            else if (menu_type.Equals("balance"))
            {
                //output text
                output_label.Text = "==Check Balance==\r\n\r\n";

                //get balance
                String balance = "";


                output_label.Text = output_label.Text + balance + "\r\n\r\n==Check Balance==";

                //option text
                left_btns[0].Text = "";
                left_lbls[0].Text = "More Transactions";
                left_btns[0].Tag = "main";

                left_btns[1].Text = "";
                left_lbls[1].Text = "Exit";
                left_btns[1].Tag = "exit";

                left_btns[2].Text = "";
                left_lbls[2].Text = "";
                left_btns[2].Tag = "null";

                left_btns[3].Text = "";
                left_lbls[3].Text = "";
                left_btns[3].Tag = "null";

                right_btns[0].Text = "";
                right_lbls[0].Text = "";
                right_btns[0].Tag = "null";

                right_btns[1].Text = "";
                right_lbls[1].Text = "";
                right_btns[1].Tag = "null";

                right_btns[2].Text = "";
                right_lbls[2].Text = "";
                right_btns[2].Tag = "null";

                right_btns[3].Text = "";
                right_lbls[3].Text = "";
                right_btns[3].Tag = "null";
            }
            else if (menu_type.Equals("post_withdraw"))
            {
                //output text
                output_label.Text = "==Withdraw Cash==\r\n\r\nWould you like to perform another transaction?\r\n\r\n==Withdraw Cash==";

                //option text
                left_btns[0].Text = "";
                left_lbls[0].Text = "More Transactions";
                left_btns[0].Tag = "main";

                left_btns[1].Text = "";
                left_lbls[1].Text = "Exit";
                left_btns[1].Tag = "exit";

                left_btns[2].Text = "";
                left_lbls[2].Text = "";
                left_btns[2].Tag = "null";

                left_btns[3].Text = "";
                left_lbls[3].Text = "";
                left_btns[3].Tag = "null";

                right_btns[0].Text = "";
                right_lbls[0].Text = "";
                right_btns[0].Tag = "null";

                right_btns[1].Text = "";
                right_lbls[1].Text = "";
                right_btns[1].Tag = "null";

                right_btns[2].Text = "";
                right_lbls[2].Text = "";
                right_btns[2].Tag = "null";

                right_btns[3].Text = "";
                right_lbls[3].Text = "";
                right_btns[3].Tag = "null";
            }
            else if (menu_type.Equals("withdraw"))
            {
                //output text
                output_label.Text = "==Withdraw Cash==\r\n\r\nPlease select amount to withdraw\r\n\r\n==Withdraw Cash==";

                //option text
                left_btns[0].Text = "";
                left_lbls[0].Text = "£10";
                left_btns[0].Tag = "withdraw-10";

                left_btns[1].Text = "";
                left_lbls[1].Text = "£30";
                left_btns[1].Tag = "withdraw-30";

                left_btns[2].Text = "";
                left_lbls[2].Text = "£50";
                left_btns[2].Tag = "withdraw-50";

                left_btns[3].Text = "";
                left_lbls[3].Text = "£70";
                left_btns[3].Tag = "withdraw-70";

                right_btns[0].Text = "";
                right_btns[0].Text = "£20";
                right_btns[0].Tag = "withdraw-20";

                right_btns[1].Text = "";
                right_btns[1].Text = "£40";
                right_btns[1].Tag = "withdraw-40";

                right_btns[2].Text = "";
                right_btns[2].Text = "£60";
                right_btns[2].Tag = "withdraw-60";

                right_btns[3].Text = "";
                right_btns[3].Text = "£80";
                right_btns[3].Tag = "withdraw-80";
            }
        }

        /*
         * show the options of the atm
         * 
         * 
         */
        private void new_atm_show(object sender, EventArgs e)
        {
            //creation loop
            for (int i = 0; i < 4; i++)
            {
                //TEST
                Console.WriteLine("leftbtn  "+i+" pos : "+left_btns[i].Location);
                Console.WriteLine("leftlbl  " + i + " pos : " + left_lbls[i].Location);
                Console.WriteLine("rightbtn " + i + " pos : " + right_btns[i].Location);
                Console.WriteLine("rightlbl " + i + " pos : " + right_btns[i].Location);

                //add to form
                Controls.Add(left_btns[i]);
                Controls.Add(left_lbls[i]);
                Controls.Add(right_btns[i]);
                Controls.Add(right_lbls[i]);
            }

            Controls.Add(output_label);
        }

        /*
         * send the data inputed in the text boxes to the 
         * main form holding the data and get a return 
         * that the data is correct
         */
        public Boolean checkAccount()
        {
            //check valid account & PIN
            int cAccount = Convert.ToInt32(Account.Text);
            int cPin = Convert.ToInt32(Pin.Text);
            String validity = fPointer.accountCheck(cAccount, cPin);

            //TEST
            Console.WriteLine("STATUS : " + validity);

            //return value
            if (validity.Equals("PIN OK"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /*
         * submit account no. and PIN for validation
         * if valid display 
         */
        private void atm_button_Click(object sender, EventArgs e)
        {
            //get calling object & tag
            Button sending_button = (Button)sender;
            String operation = (String)sending_button.Tag;

            //split tag by '-' character
            String[] cash_value = operation.Split('-');

            //deal with button output
            if (cash_value[0].Equals("exit"))
            {
                //exit ATM thread instance
                this.Close();
            }
            else if (cash_value[0].Equals("withdraw"))
            {

                //if withdraw value
                if (cash_value.Length == 2)
                {
                    //TEST
                    Console.WriteLine("..ATTEMPTING TO WITHDRAW £" + cash_value[1] + "..");

                    //call withdraw method using cash_value[1]

                    //TEST
                    Console.WriteLine("..NO RESULT..");

                    //set correct menu
                    menu_setup("post_withdraw");
                }
                else
                {
                    //set correct menu
                    menu_setup(sending_button.Tag.ToString());
                }
            }
            else
            {
                //set correct menu
                menu_setup(sending_button.Tag.ToString());
            }
        }

        /*
         * submit account no. and PIN for validation
         * if valid display 
         */
        private void submit_Click(object sender, EventArgs e)
        {
            //TEST
            Console.WriteLine("==SIGN IN ATTEMPT==");

            //check valid account & PIN
            Boolean valid = checkAccount();

            if (valid)
            {
                //TEST
                Console.WriteLine("..ACCESS GRANTED!..");

                //hide account & PIN input
                Account.Hide();
                Pin.Hide();
                lblAccount.Hide();
                lblPin.Hide();
                submit.Hide();

                Button test = new Button();

                //Display options
                new_atm_load(sender, e);
                new_atm_show(sender, e);
            }
            else
            {
                //provide user error message
                //

                //TEST
                Console.WriteLine("..ACCESS DENIED!..");

                //clear text boxes
                Account.Clear();
                Pin.Clear();
            }
        }
    }
}
