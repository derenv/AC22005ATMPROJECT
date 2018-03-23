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
        Label[] output_labels;

        //custom input
        Button custom_enter;
        TextBox custom_input;
        int custom_amount;

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

            //option labels
            output_labels = new Label[3];

            //custom input button
            custom_enter = new Button();
            custom_enter.SetBounds(175, 200, 100, 25);
            custom_enter.Click += new EventHandler(this.custom_button_Click);
            custom_enter.Text = "Enter Value";

            //custom input textbox custom_input_KeyPress
            custom_input = new TextBox();
            custom_input.SetBounds(150, 170, 150, 50);
            custom_input.KeyPress += new KeyPressEventHandler(this.custom_input_KeyPress);

            //custom input value
            custom_amount = 0;

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
                right_lbls[i].SetBounds(300, 65 + (70 * i), 50, 50);
            }

            //creation loop
            for (int j = 0; j < 3; j++)
            {
                //title labels
                output_labels[j] = new Label();
                output_labels[j].SetBounds(150, 50 + (j * 120), 150, 100);
                output_labels[j].Font = new Font("Arial", 10, FontStyle.Regular);
                output_labels[j].TextAlign = ContentAlignment.TopCenter;
            }

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
                //top title text
                output_labels[0].Text = "==Main Menu==";
                //output text
                output_labels[1].Text = "Welcome to our ATM!";
                //bottom title text
                output_labels[2].Text = "==Main Menu==";

                //option text
                left_btns[0].Text = "";
                left_lbls[0].Text = "Balance";
                left_btns[0].Tag = "balance";

                left_btns[1].Text = "";
                left_lbls[1].Text = "Deposit";
                left_btns[1].Tag = "deposit";

                left_btns[2].Text = "";
                left_lbls[2].Text = "Withdraw";
                left_btns[2].Tag = "withdraw";

                left_btns[3].Text = "";
                left_lbls[3].Text = "Exit";
                left_btns[3].Tag = "exit";

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
                //top title text
                output_labels[0].Text = "==Check Balance==";

                //get balance
                String balance = "";
                output_labels[1].Text = balance;

                //bottom title text
                output_labels[2].Text = "==Check Balance==";

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
            else if (menu_type.Equals("post_transaction"))
            {
                //top title text
                output_labels[0].Text = "";
                //output text
                output_labels[1].Text = "Would you like to perform another transaction?";
                //bottom title text
                output_labels[2].Text = "";

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
            else if (menu_type.Equals("custom"))
            {
                //top title text
                output_labels[0].Text = "==Other amount==";
                //output text
                output_labels[1].Text = "";
                //bottom title text
                output_labels[2].Text = "==Other amount==";

                //option text
                left_btns[0].Text = "";
                left_lbls[0].Text = "";
                left_btns[0].Tag = "null";

                left_btns[1].Text = "";
                left_lbls[1].Text = "";
                left_btns[1].Tag = "null";

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
                right_lbls[3].Text = "Exit";
                right_btns[3].Tag = "exit";
            }
            else if (menu_type.Equals("withdraw"))
            {
                //top title text
                output_labels[0].Text = "==Withdraw Cash==";
                //output text
                output_labels[1].Text = "Please select amount to withdraw";
                //bottom title text
                output_labels[2].Text = "==Withdraw Cash==";

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
                left_lbls[3].Text = "£100";
                left_btns[3].Tag = "withdraw-100";

                right_btns[0].Text = "";
                right_lbls[0].Text = "£20";
                right_btns[0].Tag = "withdraw-20";

                right_btns[1].Text = "";
                right_lbls[1].Text = "£40";
                right_btns[1].Tag = "withdraw-40";

                right_btns[2].Text = "";
                right_lbls[2].Text = "£80";
                right_btns[2].Tag = "withdraw-80";

                right_btns[3].Text = "";
                right_lbls[3].Text = "Other";
                right_btns[3].Tag = "withdraw-custom";
            }
            else if (menu_type.Equals("deposit"))
            {
                //top title text
                output_labels[0].Text = "==Deposit Cash==";
                //output text
                output_labels[1].Text = "Please select amount to deposit";
                //bottom title text
                output_labels[2].Text = "==Deposit Cash==";

                //option text
                left_btns[0].Text = "";
                left_lbls[0].Text = "£10";
                left_btns[0].Tag = "deposit-10";

                left_btns[1].Text = "";
                left_lbls[1].Text = "£30";
                left_btns[1].Tag = "deposit-30";

                left_btns[2].Text = "";
                left_lbls[2].Text = "£50";
                left_btns[2].Tag = "deposit-50";

                left_btns[3].Text = "";
                left_lbls[3].Text = "£100";
                left_btns[3].Tag = "deposit-100";

                right_btns[0].Text = "";
                right_lbls[0].Text = "£20";
                right_btns[0].Tag = "deposit-20";

                right_btns[1].Text = "";
                right_lbls[1].Text = "£40";
                right_btns[1].Tag = "deposit-40";

                right_btns[2].Text = "";
                right_lbls[2].Text = "£80";
                right_btns[2].Tag = "deposit-80";

                right_btns[3].Text = "";
                right_lbls[3].Text = "Other";
                right_btns[3].Tag = "deposit-custom";
            }
        }

        /*
         * show the options of the atm
         * specifically, all input buttons & their labels AND output labels
         * 
         */
        private void new_atm_show(object sender, EventArgs e)
        {
            //add to form loop
            for (int i = 0; i < 4; i++)
            {
                //add input buttons &n labels to form
                Controls.Add(left_btns[i]);
                Controls.Add(left_lbls[i]);
                Controls.Add(right_btns[i]);
                Controls.Add(right_lbls[i]);
            }

            //add to form loop
            for (int j = 0; j < 3; j++)
            {
                //add output labels to form
                Controls.Add(output_labels[j]);
            }

            //add custom input items
            Controls.Add(custom_enter);
            Controls.Add(custom_input);
            custom_enter.Hide();
            custom_input.Hide();
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
         * submit custom amount for deposit/withdrawl
         */
        private void custom_button_Click(object sender, EventArgs e)
        {
            if (custom_input.Equals(""))
            {
                //handle empty input
            }
            else
            {
                try
                {
                    //get input number
                    custom_amount = int.Parse(custom_input.Text);

                    //attempt operation
                    if (custom_enter.Tag.Equals("withdraw"))
                    {
                        //TEST
                        Console.WriteLine("..ATTEMPTING TO WITHDRAW £" + custom_amount + "..");

                        //call withdraw method using cash_value[1]
                        //

                        //TEST
                        Console.WriteLine("..NO RESULT..");
                    }
                    else if (custom_enter.Tag.Equals("deposit"))
                    {
                        //TEST
                        Console.WriteLine("..ATTEMPTING TO DEPOSIT £" + custom_amount + "..");

                        //call deposit method using cash_value[1]
                        //

                        //TEST
                        Console.WriteLine("..NO RESULT..");
                    }

                    //hide input
                    custom_enter.Hide();
                    custom_input.Hide();
                    output_labels[1].Show();

                    //set correct menu
                    menu_setup("post_transaction");
                }
                catch(Exception)
                {
                    //handle invalid input number
                }
            }
        }

        /*
         * allow only digits (no decimals) to be entered as custom input
         * modified code snippet from:
         * https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers
         */
        private void custom_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TEST
            Console.WriteLine("char entered : "+e.KeyChar);
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)/* && (e.KeyChar != '.')*/)
            {
                e.Handled = true;
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
                    if (cash_value[1].Equals("custom"))
                    {
                        //TEST
                        Console.WriteLine("..CUSTOM VALUE WITHDRAW..");

                        //get custom amount
                        menu_setup("custom");
                        custom_enter.Tag = "withdraw";
                        custom_input.Text = "";
                        custom_enter.Show();
                        custom_input.Show();
                        output_labels[1].Hide();
                    }
                    else
                    {
                        //TEST
                        Console.WriteLine("..ATTEMPTING TO WITHDRAW £" + cash_value[1] + "..");

                        //call withdraw method using cash_value[1]
                        //

                        //TEST
                        Console.WriteLine("..NO RESULT..");

                        //set correct menu
                        menu_setup("post_transaction");
                    }
                }
                else
                {
                    //set correct menu
                    menu_setup(sending_button.Tag.ToString());
                }
            }
            else if (cash_value[0].Equals("deposit"))
            {
                //if deposit value
                if (cash_value.Length == 2)
                {
                    if (cash_value[1].Equals("custom"))
                    {
                        //TEST
                        Console.WriteLine("..CUSTOM VALUE DEPOSIT..");

                        //get custom amount
                        menu_setup("custom");
                        custom_enter.Tag = "deposit";
                        custom_input.Text = "";
                        custom_enter.Show();
                        custom_input.Show();
                        output_labels[1].Hide();
                    }
                    else
                    {
                        //TEST
                        Console.WriteLine("..ATTEMPTING TO DEPOSIT £" + cash_value[1] + "..");
                        
                        //call deposit method using cash_value[1]
                        //

                        //TEST
                        Console.WriteLine("..NO RESULT..");

                        //set correct menu
                        menu_setup("post_transaction");
                    }
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
