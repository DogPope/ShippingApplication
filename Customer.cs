using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;

namespace ShippingApplication
{
    class Customer
    {
        private Int32 custId;
        private String surname;
        private String forename;
        private String town;
        private String county;
        private String EIRCode;
        private String password;
        private String phone;
        private String email;
        private String cardNumber;
        private String status;

        public Customer()
        {
            this.custId = 0;
            this.surname = "Not available!";
            this.forename = "No forename available!";
            this.town = "No town supplied!";
            this.county = "No county data!";
            this.EIRCode = "None";
            this.password = "password";
            this.phone = "0860000000";
            this.email = "null@gmail.com";
            this.cardNumber = "Null";
            this.status = "Registered";
        }

        public Customer(Int32 custId, String surname, String forename, String town, String county, String EIRCode, String password, String phone, String email, String cardNumber, String status)
        {
            // Not sure what I'd use the full constructor for, but it's there anyway.
            this.custId = custId;
            this.surname = surname;
            this.forename = forename;
            this.town = town;
            this.county = county;
            this.EIRCode = EIRCode;
            this.password = password;
            this.phone = phone;
            this.email = email;
            this.cardNumber = cardNumber;
            this.status = status;
        }

        public Customer(String surname, String forename, String town, String county, String EIRCode, String password, String phone, String email, String cardNumber)
        {
            // Main instance of constructor from frmRegisterCustomer. Status and ID number assigned Automatically.
            this.surname = surname;
            this.forename = forename;
            this.town = town;
            this.county = county;
            this.EIRCode = EIRCode;
            this.password = password;
            this.phone = phone;
            this.email = email;
            this.cardNumber = cardNumber;
        }

        public int getCustomerId()
        {
            return this.custId;
        }
        public void setCustomerId(int CustID)
        {
            //if (CustID > 0 && CustID < Int32.MaxValue)
            //    this.custId = CustID;
            //else
            //    custId = 0;
            this.custId = CustID;
        }

        public String getSurname()
        {
            return this.surname;
        }
        public void setSurname(String Surname)
        {
            if (surname.Length > 0)
            {
                isValidName(Surname);
                char.ToUpper(Surname[0]);
                this.surname = Surname;
            }
            else
                surname = "Null";
        }

        public String getForename()
        {
            return this.forename;
        }
        public void setForename(String Forename)
        {
            if (surname.Length > 20)
            {
                isValidName(Forename);
                char.ToUpper(Forename[0]);
                this.forename = Forename;
            }
            else
                surname = "Null";
        }

        public String getTown()
        {
            return this.town;
        }
        public void setTown(String Town)
        {
            if (town.Length < 30)
            {
                char.ToUpper(Town[0]);
                this.town = Town;
            }
            else
                town = "Null";
        }

        public String getCounty()
        {
            return this.county;
        }
        public void setCounty(String County)
        {
            this.county = County;
        }

        
        public String getEircode()
        {
            return this.EIRCode;
        }
        public void setEircode(String EIRcode)
        {
            if (isValidEircode(EIRcode))
            {
                this.EIRCode = EIRcode;
            }
            else
                EIRcode = "Null";
        }
        
        public String getPassword()
        {
            return this.password;
        }
        public void setPassword(String Password)
        {
            this.password = Password;
        }

        public String getPhoneNumber()
        {
            return this.phone;
        }
        public void setPhoneNumber(String Phone)
        {
            this.phone = Phone;
        }

        public String getEmail()
        {
            return this.email;
        }
        public void setEmail(String Email)
        {
            this.email = Email;
        }

        public String getCardNumber()
        {
            return this.cardNumber;
        }
        public void setCardNumber(String CardNumber)
        {
            if (CardNumber.Length <= 20 || CardNumber.Length >= 16)
                CardNumber.Trim(' ');
            foreach (char c in CardNumber)
            {
                if (c >= '0' || c <= '9')
                    this.cardNumber = CardNumber;
            }
        }
        
        public String getStatus()
        {
            return status;
        }
        public void setStatus(String Status)
        {
            this.status = Status;
        }

        private static bool isValidName(String name)
        {
            // Makes sure all characters entered are alphabetical
            return Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }

        private static bool isValidEircode(String EIRCode)
        {
            // This regex string should allow the user to type a recognisable EIR Code.
            return Regex.IsMatch(EIRCode, @"(?:^[AC-FHKNPRTV-Y][0-9]{2}|D6W)[ -]?[0-9AC-FHKNPRTV-Y]{4}$");
        }

        public static bool isValidPassword(String password)
        {
            // Password should have a minimum of one of each Uppercase letters, Lowercase letters, numbers, symbols and be a minimum 8 chars in length, maximum of 20.
            char[] symbols = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '.', ',', '?', '+', '_', '-', '='};
            int numOfNumbers = 0;
            int numSymbols = 0;
            int upperCaseChars = 0;
            int lowerCaseChars = 0;

            if (password.Length > 20 || password.Length < 8)
                return false;

            foreach(char c in password)
            {
                if (c >= 'a' && c <= 'z')
                    lowerCaseChars++;
                else if (c >= 'A' && c <= 'Z')
                    upperCaseChars++;
                else if (c >= 0 && c <= 9)
                    numOfNumbers++;
                foreach (char a in symbols) 
                {
                    if(c == symbols[a])
                            numSymbols++;
                }
                if (lowerCaseChars > 0 && upperCaseChars > 0 && numOfNumbers > 0 && numSymbols > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsValidEmail(string emailaddress)
        {
            // Email validation should support up to a third level domain, only support one '@' Symbol.
            int numOfAtSymbols = 0;
            int domainSize = 0;
            foreach(char c in emailaddress)
            {
                if (c == '@')
                    numOfAtSymbols++;
                if (c == '.')
                    domainSize++;
                if (domainSize <= 3 && numOfAtSymbols == 1)
                    return true;
            }
            return false;
        }

        public void addCustomer()
        {
            try
            {
                OracleConnection connection = new OracleConnection(DBConnect.oradb);

                //Int32 custId, String surname, String forename, String town, String county, String EIRCode, String password, String phone, String email, String cardNumber, String status
                String sqlQuery = "INSERT INTO Customers Values (" + getNextCustomerID() + ",'" +
                    this.forename + "','" + this.surname + "','" +
                    this.town + "','" + this.county + "','" + this.EIRCode + "','" +
                    this.password + "','" + this.phone + "','" + this.email + "','" +
                    this.cardNumber + "','" + this.status + "')";

                OracleCommand cmd = new OracleCommand(sqlQuery, connection);
                Console.WriteLine("Success?");
                connection.Open();

                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch(Exception ex)
            {
                if (ex.Source != null)
                {
                    Console.WriteLine("IOException source: {0}", ex.Source);
                }
                throw;
            }
        }
        public void updateCustomer()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Customers SET " +
                "Cust_Id = " + this.custId + "," +
                "Forename = '" + this.forename + "'," +
                "Surname = '" + this.surname + "'," +
                "Town = '" + this.town + "'," +
                "County = " + this.county + "," +
                "EIRCode = " + this.EIRCode + "," +
                "Status = '" + this.status + "' " +
                "CardNumber = '" + this.cardNumber + "' " +
                "WHERE Cust_Id = " + this.custId + ");";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataSet findCustomer(String forename)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT Cust_Id, forename, surname FROM Customers " +
                "WHERE forename LIKE '%" + forename + "%' ORDER BY forename";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customers");
            conn.Close();
            return ds;
        }
        public static int getNextCustomerID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String sqlQuery = "SELECT MAX(Cust_ID) FROM Customers";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();

            int nextId;
            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }
            conn.Close();
            return nextId;
        }
        public String toString()
        {
            return "Customer Id: " + getCustomerId() + " Forename: " + getForename() + "\nSurname: " + getSurname() + " Town: " + getTown() + "\nCounty: " + getCounty() + 
                " EIR Code: " + getEircode() + "\nPhone: " + getPhoneNumber() + " Email: " + getEmail() + "\nStatus: " + getStatus();
        }
    }
}