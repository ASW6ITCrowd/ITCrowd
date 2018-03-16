using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;   //new
using System.IO;                        //new
using System.Security.Cryptography;     //new


namespace ASW_MethodenProjekt
{
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
            return (this.customerID + ";" + this.firstName + ";" + this.lastName + ";" + this.accountbalance + ";" + this.lastChange + ";" + this.emailAdr);
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


    class Program
    {
        static void Main(string[] args)
        {
            #region Email
            //string[] email = new string[] { "alexander.st@aon.at",
            //                                "@aon.at", "alex.@aon.at",
            //                                "alex(ander.st@aon.at",
            //                                "alex@aonat",
            //                                "alex@aon.a2"};

            //for (int i = 0; i < email.Length; i++)
            //{
            //    Console.WriteLine(emailchek(email[i]));
            //}
            #endregion



            Customer[] Cus = new Customer[4];
            Cus[0] = new Customer("Alexander", "Steiner", "alexander.st@aon.at", 200.25);
            Cus[1] = new Customer("Florian", "Moser", "florian.moser@aon.at", -200.25);
            Cus[2] = new Customer("Markus", "Lohnert", "markus.lo@aon.at", 0.02);
            Cus[3] = new Customer("Christoph", "Oberhuber", "ch.oberhuber@aon.at", -25.24);
            string password = "xandl95";

            //-------------------------------------------------------------------------------------------------------------------------

            //for (int i = 0; i < Cus.Length; i++)
            //{
            //    Console.WriteLine(Cus[i].ToString());
            //}

            //StreamWriter file = File.CreateText(@"..\..\Customers.txt");


            //for (int i = 0; i < Cus.Length; i++)
            //{
            //    file.WriteLine(Encryption.EncryptString(Cus[i].ToString(), password));
            //}
            //file.Close();

            //--------------------------------------------------------------------------------------------------------------------------

            StreamReader leseDatei = File.OpenText(@"..\..\Customers.txt");
            string zeile = string.Empty;
            string[] zeilenElemente;

            while (leseDatei.Peek() != -1)
            {
                zeile = Encryption.DecryptString(leseDatei.ReadLine(), password);
                Console.WriteLine(zeile);
                zeilenElemente = zeile.Split(';');
            }

            leseDatei.Close();




            Console.ReadLine();
        }

        #region Methoden
        //-------------------------------------------------------------------------------------------------------------
        //------------------------------------------ EMAIL - CHECK ----------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------
        static bool emailchek(string email)
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
}
