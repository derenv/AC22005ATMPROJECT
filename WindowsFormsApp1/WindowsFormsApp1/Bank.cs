﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FBank : Form
    {
        public FBank()
        {
            InitializeComponent();
            accounts();
        }

        private void FBank_Load(object sender, EventArgs e)
        {

        }

        private Account[] ac = new Account[3];


        //creates a new form Update for threading support
        private void atmCreate_Click_1(object sender, EventArgs e)
        {
            FBank bank_ref = this;
            //create & define thread
            Thread new_atm = new Thread(() =>
            {
                FAtm f = new FAtm();
                f.setAtm(bank_ref);
                Application.Run(f);
            });

            new_atm.Start();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //sets up all the accounts
        public void accounts()
        {
            ac[0] = new Account(300, 1111, 111111);
            ac[1] = new Account(750, 2222, 222222);
            ac[2] = new Account(3000, 3333, 333333);
        }

        public string accountCheck(int account, int pin)
        {
            //stop atms accessing bank data when reading
            lock (ac)
            {
                for (int times = 0; times < ac.Length; times++)
                {
                    int checkAccount = ac[times].getAccountNum();
                    if (account == checkAccount)
                    {
                        if (ac[times].checkPin(pin))
                        {
                            return "PIN OK";
                        }
                        else
                        {
                            return "PIN WRONG";
                        }
                    }
                }
                return "WRONG ACCOUNT";
            }
        }
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        class Account
        {
            //the attributes for the account
            private int balance;
            private int pin;
            private int accountNum;

            // a constructor that takes initial values for each of the attributes (balance, pin, accountNumber)
            public Account(int balance, int pin, int accountNum)
            {
                this.balance = balance;
                this.pin = pin;
                this.accountNum = accountNum;
            }

            //getter and setter functions for balance
            public int getBalance()
            {
                return balance;
            }
            public void setBalance(int newBalance)
            {
                this.balance = newBalance;
            }


            public Boolean decrementBalance(int amount)
            {
                if (this.balance > amount)
                {
                    balance -= amount;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public Boolean checkPin(int pinEntered)
            {
                if (pinEntered == pin)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public int getAccountNum()
            {
                return accountNum;
            }
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        class ATM
        {
            //local referance to the array of accounts
            private Account[] ac;

            //this is a referance to the account that is being used
            private Account activeAccount = null;

            // the atm constructor takes an array of account objects as a referance
            public ATM(Account[] ac)
            {
                this.ac = ac;
                Console.WriteLine("hello from ATM");

                // an infanite loop to keep the flow of controll going on and on
                while (true)
                {

                    //ask for account number and store result in acctiveAccount (null if no match found)
                    activeAccount = this.findAccount();

                    if (activeAccount != null)
                    {
                        //if the account is found check the pin 
                        if (activeAccount.checkPin(this.promptForPin()))
                        {
                            //if the pin is a match give the options to do stuff to the account (take money out, view balance, exit)
                            dispOptions();
                        }
                    }
                    else
                    {   //if the account number entered is not found let the user know!
                        Console.WriteLine("no matching account found.");
                    }

                    //wipes all text from the console
                    Console.Clear();
                }


            }

            /*
             *    this method promts for the input of an account number
             *    the string input is then converted to an int
             *    a for loop is used to check the enterd account number
             *    against those held in the account array
             *    if a match is found a referance to the match is returned
             *    if the for loop completest with no match we return null
             * 
             */
            private Account findAccount()
            {
                Console.WriteLine("enter your account number..");

                int input = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < this.ac.Length; i++)
                {
                    if (ac[i].getAccountNum() == input)
                    {
                        return ac[i];
                    }
                }

                return null;
            }
            /*
             * 
             *  this jsut promt the use to enter a pin number
             *  
             * returns the string entered converted to an int
             * 
             */
            private int promptForPin()
            {
                Console.WriteLine("enter pin:");
                String str = Console.ReadLine();
                int pinNumEntered = Convert.ToInt32(str);
                return pinNumEntered;
            }

            /*
             * 
             *  give the use the options to do with the accoutn
             *  
             *  promt for input
             *  and defer to appropriate method based on input
             *  
             */
            private void dispOptions()
            {
                Console.WriteLine("1> take out cash");
                Console.WriteLine("2> balance");
                Console.WriteLine("3> exit");

                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    dispWithdraw();
                }
                else if (input == 2)
                {
                    dispBalance();
                }
                else if (input == 3)
                {


                }
                else
                {

                }

            }

            /*
             * 
             * offer withdrawable amounts
             * 
             * based on input attempt to withraw the corosponding amount of money
             * 
             */
            private void dispWithdraw()
            {
                Console.WriteLine("1> 10");
                Console.WriteLine("2> 50");
                Console.WriteLine("3> 500");

                int input = Convert.ToInt32(Console.ReadLine());

                if (input > 0 && input < 4)
                {

                    //opiton one is entered by the user
                    if (input == 1)
                    {

                        //attempt to decrement account by 10 punds
                        if (activeAccount.decrementBalance(10))
                        {
                            //if this is possible display new balance and await key press
                            Console.WriteLine("new balance " + activeAccount.getBalance());
                            Console.WriteLine(" (prese enter to continue)");
                            Console.ReadLine();
                        }
                        else
                        {
                            //if this is not possible inform user and await key press
                            Console.WriteLine("insufficent funds");
                            Console.WriteLine(" (prese enter to continue)");
                            Console.ReadLine();
                        }
                    }
                    else if (input == 2)
                    {
                        if (activeAccount.decrementBalance(50))
                        {
                            Console.WriteLine("new balance " + activeAccount.getBalance());
                            Console.WriteLine(" (prese enter to continue)");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("insufficent funds");
                            Console.WriteLine(" (prese enter to continue)");
                            Console.ReadLine();
                        }
                    }
                    else if (input == 3)
                    {
                        if (activeAccount.decrementBalance(500))
                        {
                            Console.WriteLine("new balance " + activeAccount.getBalance());
                            Console.WriteLine(" (prese enter to continue)");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("insufficent funds");
                            Console.WriteLine(" (prese enter to continue)");
                            Console.ReadLine();
                        }
                    }
                }
            }
            /*
             *  display balance of activeAccount and await keypress
             *  
             */
            private void dispBalance()
            {
                if (this.activeAccount != null)
                {
                    Console.WriteLine(" your current balance is : " + activeAccount.getBalance());
                    Console.WriteLine(" (prese enter to continue)");
                    Console.ReadLine();
                }
            }

        }
    }
}
