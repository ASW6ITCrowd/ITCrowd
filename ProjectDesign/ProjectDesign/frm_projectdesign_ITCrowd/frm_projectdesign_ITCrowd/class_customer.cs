//Alexander Steiner - Gregor Prammer
//IT-Crowd
//Class Customer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;   //new
using System.Security.Cryptography;     //new
using System.IO;                        //new


namespace class_customer
{
    //frm_projectdesign_ITCrowd
    public class Customer
    {
        #region Membervariable
        int customerID;
        string firstName;
        string lastName;
        string emailAdr;
        double accountbalance;
        DateTime lastChange;
        #endregion

        #region Constructor
        public Customer(string firstName, string lastName, string emailAdr, double accountBalance, int id)
        {
            this.firstName = firstName.ToUpper();
            this.lastName = lastName.ToUpper();
            this.emailAdr = emailAdr.ToLower();
            this.accountbalance = accountBalance;
            this.customerID = id;
            this.lastChange = DateTime.Now;

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
            set
            {
                this.accountbalance = value;
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
            set
            {
                this.lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return (this.emailAdr);
            }
            set
            {
                this.emailAdr = value;
            }
        }

        public DateTime LastChange
        {
            set
            {
                this.lastChange = value;
            }
        }
        #endregion

        #region To-String
        public override string ToString()
        {
            return (this.customerID + " " + this.firstName + " " + this.lastName + " " + this.accountbalance + " " + this.emailAdr + " " + this.lastChange.ToShortDateString() + "--" + this.lastChange.ToLongTimeString());
        }
        #endregion

        #region Methodes
        //-------------------------------------------------------------------------------------------------------------
        //------------------------------------------ EMAIL - CHECK ----------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------
        public static bool EmailChek(string email)
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


        //-------------------------------------------------------------------------------------------------------------
        //-------------------------------------------- READ - CSV  ----------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------
        public static Customer[] ReadCSV(string password)
        {
            Customer[] cus = new Customer[100];

            StreamReader readFile = File.OpenText(@"..\..\Customers.csv");
            string line = string.Empty;
            string[] linesegment;

            int i = 0;
            while (readFile.Peek() != -1)
            {
                line = Encryption.DecryptString(readFile.ReadLine(), password);
                linesegment = line.Split(';');
                cus[i] = new Customer(linesegment[1], linesegment[2], linesegment[3], Convert.ToDouble(linesegment[4]), Convert.ToInt32(linesegment[0]));
                cus[i].LastChange = Convert.ToDateTime(linesegment[5]);
                i++;

            }
            readFile.Close();

            return cus;
        }

        //-------------------------------------------------------------------------------------------------------------
        //-------------------------------------------- WRITE - CSV ----------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------
        public static void WriteCSV(Customer[] customer, string password)
        {
            StreamWriter file = File.CreateText(@"..\..\Customers.csv");


            for (int i = 0; i < customer.Length; i++)
            {
                if (customer[i] != null)
                {
                    file.WriteLine(Encryption.EncryptString(customer[i].CusID + ";" + customer[i].firstName + ";" + customer[i].lastName + ";" + customer[i].emailAdr + ";" + customer[i].AccBalance + ";" + customer[i].lastChange, password));
                }
                
            }
            file.Close();
        }

        //-------------------------------------------------------------------------------------------------------------
        //-------------------------------------------- PAY - MONEY -----------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------
        public static void Pay(Customer cus, double amount)
        {
            cus.AccBalance += amount;
            cus.LastChange = DateTime.Now;
        }

        //-------------------------------------------------------------------------------------------------------------
        //-------------------------------------------- PAY - MONEY -----------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------
        public static void Owe(Customer cus, double amount)
        {
            cus.AccBalance -= amount;
            cus.LastChange = DateTime.Now;
        }
        #endregion
    }

    public class Encryption
    {
        /// <summary>
        /// Encrypts the string.
        /// </summary>
        /// <param name="clearText">The clear text.</param>
        /// <param name="Key">The key.</param>
        /// <param name="IV">The IV.</param>
        /// <returns></returns>
        private static byte[] EncryptString(byte[] clearText, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(clearText, 0, clearText.Length);
            cs.Close();
            byte[] encryptedData = ms.ToArray();
            return encryptedData;
        }

        /// <summary>
        /// Encrypts the string.
        /// </summary>
        /// <param name="clearText">The clear text.</param>
        /// <param name="Password">The password.</param>
        /// <returns></returns>
        public static string EncryptString(string clearText, string Password)
        {
            byte[] clearBytes = System.Text.Encoding.Unicode.GetBytes(clearText);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            byte[] encryptedData = EncryptString(clearBytes, pdb.GetBytes(32), pdb.GetBytes(16));
            return Convert.ToBase64String(encryptedData);
        }

        /// <summary>
        /// Decrypts the string.
        /// </summary>
        /// <param name="cipherData">The cipher data.</param>
        /// <param name="Key">The key.</param>
        /// <param name="IV">The IV.</param>
        /// <returns></returns>
        private static byte[] DecryptString(byte[] cipherData, byte[] Key, byte[] IV)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(cipherData, 0, cipherData.Length);
            cs.Close();
            byte[] decryptedData = ms.ToArray();
            return decryptedData;
        }

        /// <summary>
        /// Decrypts the string.
        /// </summary>
        /// <param name="cipherText">The cipher text.</param>
        /// <param name="Password">The password.</param>
        /// <returns></returns>
        public static string DecryptString(string cipherText, string Password)
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            byte[] decryptedData = DecryptString(cipherBytes, pdb.GetBytes(32), pdb.GetBytes(16));
            return System.Text.Encoding.Unicode.GetString(decryptedData);
        }
    }
}


