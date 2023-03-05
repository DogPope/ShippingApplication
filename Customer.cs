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
            this.forename = "No forename available!";
            this.surname = "Not available!";
            this.town = "No town supplied!";
            this.EIRCode = "None";
            this.password = "password";
            this.phone = "0860000000";
            this.email = "null@gmail.com";
            this.cardNumber = "Null";
            this.county = "No county data!";
            this.status = "Registered";
        }
        //Int32 custId, String forename, String surname, String town, String EIRCode, String password, String phone, String email, String cardNumber, String county, String status
        public Customer(Int32 custId, String forename, String surname, String town, String EIRCode, String password, String phone, String email, String cardNumber, String status, String county)
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
            this.custId = CustID;
        }

        public String getSurname()
        {
            return this.surname;
        }
        public void setSurname(String Surname)
        {
            this.surname = Surname;
        }

        public String getForename()
        {
            return this.forename;
        }
        public void setForename(String Forename)
        {
            this.forename = Forename;
        }

        public String getTown()
        {
            return this.town;
        }
        public void setTown(String Town)
        {
            this.town = Town;
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
            this.email = Email;
        }

        public String getCardNumber()
        {
            return this.cardNumber;
        }
        public void setCardNumber(String CardNumber)
        {
            this.cardNumber = CardNumber;
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

        public static bool isValidEircode(String EIRCode)
        {
            // This regex string should allow the user to type a recognisable EIR Code.
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
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
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

        public void getCustomer(Int32 Id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String sqlQuery = "SELECT * FROM Customers WHERE Cust_ID = " + Id;
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
            setCounty(dr.GetString(9));
            setStatus(dr.GetString(10));

            conn.Close();
        }

        public void addCustomer()
        {
                OracleConnection connection = new OracleConnection(DBConnect.oradb);

                //Int32 custId, String forename, String surname, String town, String EIRCode, String password, String phone, String email, String cardNumber, String county, String status
                String sqlQuery = "INSERT INTO Customers Values (" + getNextCustomerID() + ",'" +
                    this.surname + "','" + this.forename + "','" +
                    this.town + "','" + this.EIRCode + "','" +
                    this.password + "','" + this.phone + "','" + this.email + "','" +
                    this.cardNumber + "','" + this.status +  "','" + this.county + "')";

                /*
                 INSERT INTO Customers Values(id,'sname','fname','town','EIRcode','
                 */
                OracleCommand cmd = new OracleCommand(sqlQuery, connection);
                connection.Open();

                cmd.ExecuteNonQuery();

                connection.Close();
        }
        public void updateCustomer()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            //Int32 custId, String forename, String surname, String town, String EIRCode, String password, String phone, String email, String cardNumber, String county, String status
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
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Customers SET " +
                "Status = 'Deregistered' " +
                "WHERE Cust_Id = " + this.custId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataSet findCustomerById(Int32 CustId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT Cust_Id, forename, surname, town, county, EIRcode, phone, email, status, cardnumber FROM Customers " +
                "WHERE cust_id = " + CustId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customers");
            conn.Close();
            return ds;
        }
        public static DataSet findCustomerByName(String forename)
        {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT Cust_Id, forename, surname, town, county, EIRcode, phone, email, status, cardnumber FROM Customers " +
                "WHERE forename LIKE '%" + forename + "%' ORDER BY Forename";

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