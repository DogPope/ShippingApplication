using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text.RegularExpressions;

namespace ShippingApplication
{
    public class Customer
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);
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
            this.forename = "";
            this.surname = "";
            this.town = "";
            this.EIRCode = "";
            this.password = "";
            this.phone = "";
            this.email = "";
            this.cardNumber = "";
            this.county = "";
            this.status = "Deregistered";
        }
        public Customer(Int32 custId, String forename, String surname, String town, String EIRCode, String password, String phone, String email, String cardNumber, String county)
        {
            this.custId = custId;
            this.forename = forename;
            this.surname = surname;
            this.town = town;
            this.EIRCode = EIRCode;
            this.password = password;
            this.phone = phone;
            this.email = email;
            this.cardNumber = cardNumber;
            this.county = county;
        }
        public Customer(Int32 custId, String forename, String surname, String town, String EIRCode, String password, String phone, String email, String cardNumber, String county, String status)
        {
            this.custId = custId;
            this.forename = forename;
            this.surname = surname;
            this.town = town;
            this.EIRCode = EIRCode;
            this.password = password;
            this.phone = phone;
            this.email = email;
            this.cardNumber = cardNumber;
            this.county = county;
            this.status = status;
        }
        public int getCustomerId()
        {
            return this.custId;
        }
        public void setCustomerId(int CustID)
        {
            if (CustID > 0 && CustID < Int32.MaxValue)
            {
                this.custId = CustID;
            }
            else
                throw new ArgumentException();
        }

        public String getSurname()
        {
            return this.surname;
        }
        public void setSurname(String Surname)
        {
            if (Surname.Equals("") || Surname.Length > 20)
            {
                throw new ArgumentException();
            }
            this.surname = Surname;
        }

        public String getForename()
        {
            return this.forename;
        }
        public void setForename(String Forename)
        {
            if (Forename.Equals("") || Forename.Length > 20)
            {
                throw new ArgumentException();
            }
            this.forename = Forename;
        }

        public String getTown()
        {
            return this.town;
        }
        public void setTown(String Town)
        {
            if (Town.Equals("") || Town.Length > 20)
            {
                throw new ArgumentException();
            }
            this.town = Town;
        }

        public String getCounty()
        {
            return this.county;
        }
        public void setCounty(String County)
        {
            if (County.Equals("") || County.Length > 9)
            {
                throw new ArgumentException();
            }
            this.county = County;
        }


        public String getEircode()
        {
            return this.EIRCode;
        }
        public void setEircode(String EIRcode)
        {
            this.EIRCode = EIRcode;
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
            if (isValidEmail(Email))
            {
                this.email = Email;
            }
            else
                throw new ArgumentException();
        }

        public String getCardNumber()
        {
            return this.cardNumber;
        }
        public void setCardNumber(String CardNumber)
        {
            if (isValidCardNumber(CardNumber))
            {
                this.cardNumber = CardNumber;
            }
            else
                throw new ArgumentException();
        }

        public String getStatus()
        {
            return status;
        }
        public void setStatus(String Status)
        {
            this.status = Status;
        }
        public static bool isValidCardNumber(String Cardnumber)
        {
            // Validates Credit Card Number. Checks to see if all chars are numeric.
            foreach (Char c in Cardnumber)
            {
                if (!Char.IsNumber(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isValidEircode(String EIRCode)
        {
            // This regex string accounts for valid EIR Codes.
            return Regex.IsMatch(EIRCode, "(?:^[AC-FHKNPRTV-Y][0-9]{2}|D6W)[ -]?[0-9AC-FHKNPRTV-Y]{4}$");
        }

        public static bool isValidPassword(String password)
        {
            // Password should have a minimum of one of each Uppercase letters, Lowercase letters, numbers, symbols and be a minimum 8 chars in length, maximum of 20.

            // Condition checks that password is between 8 and 20 characters in length.
            if (password.Length < 8 || password.Length > 20)
                return false;

            //No white space
            if (password.Contains(" "))
                return false;

            //At least 1 upper case letter
            if (!password.Any(char.IsUpper))
                return false;

            //At least 1 lower case letter
            if (!password.Any(char.IsLower))
                return false;

            //At least 1 special char
            string specialCharacters = @"%!@#$%^&*()?/>.<,:\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();
            foreach (char c in specialCharactersArray)
            {
                if (password.Contains(c))
                    return true;
            }
            return false;
        }

        public static bool isValidEmail(string emailaddress)
        {
            // Email validation should support up to a third level domain, only support one '@' Symbol.
            int numOfAtSymbols = 0;
            int domainSize = 0;
            foreach (char c in emailaddress)
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
        public static bool isValidPhone(String phoneNumber)
        {
            // Checks if phone number starts with 08 and returns untrue if it doesn't.
            foreach (Char c in phoneNumber)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            String start = phoneNumber.Substring(0, 2);
            if (!start.Equals("08"))
            {
                return false;
            }
            return true;
        }
        public void getCustomer(Int32 Id)
        {
            // Selects customer details where Customer ID is given
            String sqlQuery = "SELECT * FROM Customers WHERE Cust_ID=" + Id;
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            setCustomerId(dr.GetInt32(0));
            setSurname(dr.GetString(1));
            setForename(dr.GetString(2));
            setTown(dr.GetString(3));
            setEircode(dr.GetString(4));
            setPassword(dr.GetString(5));
            setPhoneNumber(dr.GetString(6));
            setEmail(dr.GetString(7));
            setCardNumber(dr.GetString(8));
            setStatus(dr.GetString(9));
            setCounty(dr.GetString(10));

            conn.Close();
        }

        public void addCustomer()
        {
            try
            {
                String sqlQuery = "INSERT INTO Customers Values (" + getNextCustomerID() + ",'" +
                    this.surname + "','" + this.forename + "','" +
                    this.town + "','" + this.EIRCode + "','" +
                    this.password + "','" + this.phone + "','" + this.email + "','" +
                    this.cardNumber + "','Registered','" + this.county + "')";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
        }
        public void updateCustomer()
        {
            // Uses given details to update the Customers attributes.
            String sqlQuery = "UPDATE Customers SET " +
                "Cust_Id = " + this.custId + "," +
                "Forename = '" + this.forename + "'," +
                "Surname = '" + this.surname + "'," +
                "Town = '" + this.town + "'," +
                "EIRCode = '" + this.EIRCode + "'," +
                "Password = '" + this.password + "'," +
                "Phone = '" + this.phone + "'," +
                "Email = '" + this.email + "'," +
                "CardNumber = '" + this.cardNumber + "', " +
                "County = '" + this.county + "'," +
                "Status = '" + this.status + "'" +
                "WHERE Cust_Id = " + this.custId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void deregisterCustomer()
        {
            // Set a customers Status to 'Deregistered'.
            String sqlQuery = "UPDATE Customers SET " +
                "Status = 'Deregistered' " +
                "WHERE Cust_Id = " + this.custId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void findCustomerByEmail(String email)
        {
            // Login form uses this to tie an email to a password for a given account.
            String sqlQuery = "SELECT Cust_id, Forename, Password, Email, Status FROM Customers WHERE email = '" + email + "'";
            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            try
            {
                setCustomerId(dr.GetInt32(0));
                setForename(dr.GetString(1));
                setPassword(dr.GetString(2));
                setEmail(dr.GetString(3));
                setStatus(dr.GetString(4));
            }
            catch (InvalidOperationException ex)
            {
                Console.Write(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        public static DataSet findCustomerByName(String forename)
        {
            // Selects Customers details based on closest match to forename.
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String sqlQuery = "SELECT Cust_Id, forename, surname FROM Customers " +
                "WHERE forename LIKE '%" + forename + "%' ORDER BY Forename";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customers");
            conn.Close();
            return ds;
        }
        public static DataSet viewAllCustomers()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Customers";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customers");
            conn.Close();
            return ds;
        }
        public static int getNextCustomerID()
        {
            // Returns the highest Customer ID from the database and adds 1 to it.
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
            // Returns customer details to a message box to confirm successful entry to database.
            return "Customer Id: " + getCustomerId() +
                "\nForename: " + getForename() +
                "\nSurname: " + getSurname() +
                "\nTown: " + getTown() +
                "\nCounty: " + getCounty() +
                "\nEIR Code: " + getEircode() +
                "\nPhone: " + getPhoneNumber() +
                "\nEmail: " + getEmail() +
                "\nStatus: " + getStatus();
        }
    }
}