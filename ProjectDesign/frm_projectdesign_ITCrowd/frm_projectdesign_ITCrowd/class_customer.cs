//Alexander Steiner - Gregor Prammer
//IT-Crowd
//Class Customer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;   //new


namespace class_customer
{
    //frm_projectdesign_ITCrowd
    class Customer
    {
        #region Membervariable
        int customerID = 0;
        string firstName;
        string lastName;
        string emailAdr;
        double accountbalance;
        DateTime lastChange;
        #endregion

        #region Constructor
        public Customer(string firstName, string lastName, string emailAdr, double accountBalance)
        {
            customerID++;
            this.firstName = firstName.ToUpper();
            this.lastName = lastName.ToUpper();
            this.emailAdr = emailAdr.ToLower();
            this.accountbalance = accountBalance;

            //Check First Name if only letters
            for (int i = 0; i < firstName.Length; i++)
            {
                if (!char.IsLetter(firstName[i]))
                {
                    throw new Exception("First Name");
                }
            }

            //Check Last Name if only letters
            for (int i = 0; i < lastName.Length; i++)
            {
                if (!char.IsLetter(lastName[i]))
                {
                    throw new Exception("First Name");
                }
            }

            //Check Email Address
            if (!EmailChek(emailAdr))
            {
                throw new Exception("Email Address");
            }
        }
        #endregion

        #region Properties
        public double AccBalance
        {
            get
            {
                return (this.accountbalance);
            }
        }

        public int CusID
        {
            get
            {
                return (this.customerID);
            }
        }

        public string FirstName
        {
            get
            {
                return (this.firstName);
            }
        }
        public string LastName
        {
            get
            {
                return (this.lastName);
            }
        }
        public string Email
        {
            get
            {
                return (this.emailAdr);
            }
        }
        #endregion

        #region To-String
        public override string ToString()
        {
            return (this.customerID + " " + this.firstName + "\n" + this.lastName + "\n" + this.accountbalance + "\n" + this.accountbalance + "\n" + this.emailAdr + "\n");
        }
        #endregion

        #region Methodes
        //-------------------------------------------------------------------------------------------------------------
        //------------------------------------------ EMAIL - CHECK ----------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------
        static bool EmailChek(string email)
        {
            string afterAT = "";
            string beforeAT = "";
            string beforeLastDot = "";
            string afterLastDot = "";

            bool emailOK = true;

            int atCounter = 0;
            int dotCounter = 0;

            //Regex to check valid chars 
            Regex re = new Regex("^[A-Za-z0-9_!#$%&'*+-/=?^_`{|}~.@_]+$", RegexOptions.IgnoreCase);


            if (!re.IsMatch(email))
            {
                emailOK = false;
            }
            else
            {
                //Seperate email at the AT
                for (int i = 0; i < email.Length; i++)
                {
                    if (email[i] == '@')
                    {
                        atCounter++;
                        afterAT = email.Substring(i + 1);
                        beforeAT = email.Substring(0, i);
                    }
                }
                if (atCounter != 1) //If more than 1 AT --> false
                {
                    emailOK = false;
                }
                else
                {
                    //Seperate the email to get te chars after the final dot
                    for (int i = 0; i < afterAT.Length; i++)
                    {
                        if (afterAT[i] == '.')
                        {
                            dotCounter++;
                            afterLastDot = afterAT.Substring(i + 1);
                            beforeLastDot = afterAT.Substring(0, i);
                        }
                    }
                    if (dotCounter < 1) //If there is not at least one 1 dot after the AT --> false
                    {
                        emailOK = false;
                    }
                    else
                    {
                        //The part after the final . must be 2‐4 characters long and contain only letters
                        if (afterLastDot.Length < 2 || afterLastDot.Length > 4)
                        {
                            emailOK = false;
                        }
                        else
                        {
                            for (int i = 0; i < afterLastDot.Length; i++)
                            {
                                if (!char.IsLetter(afterLastDot[i]))
                                {
                                    emailOK = false;
                                    break;
                                }
                            }
                        }

                        //There must be at least one character before the @
                        if (beforeAT.Length < 1)
                        {
                            emailOK = false;
                        }
                        else
                        {
                            //There must not be a . at the start, end or just before/after the @
                            if (beforeAT[0] == '.' || beforeAT[beforeAT.Length - 1] == '.' || afterAT[0] == '.')
                            {
                                emailOK = false;
                            }
                        }
                    }
                }
            }
            return (emailOK);
        }
        #endregion
    }
}


