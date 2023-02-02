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
        private Int64 cardNumber;
        private char status;

        public Customer()
        {
            this.custId = 0;
            this.surname = "No surname available!";
            this.forename = "No forename available!";
            this.town = "No town supplied!";
            this.county = "No county data!";
            this.EIRCode = "None";
            this.password = "password";
            this.phone = "0860000000";
            this.email = "null@gmail.com";
            this.cardNumber = 1111111111111111;
        }

        public Customer(Int32 custId, String surname, String forename, String town, String county, String EIRCode, String password, String phone, String email, Int32 cardNumber, char status)
        {
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

        public int getCustomerId()
        {
            return this.custId;
        }
        public void setCustomerId(int CustID)
        {
            if (CustID > 0 && CustID < Int32.MaxValue)
                this.custId = CustID;
            else
                custId = 0;
        }

        public String getSurname()
        {
            return this.surname;
        }
        public void setSurname(String Surname)
        {
            if (surname.Length > 20)
            {
                isValidName(Surname);
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
                this.surname = Forename;
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
                this.town = Town;
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

        public Int64 getCardNumber()
        {
            return this.cardNumber;
        }
        public void setCardNumber(Int64 CardNumber)
        {
            this.cardNumber = CardNumber;
        }
        
        public char getStatus()
        {
            return status;
        }
        public void setStatus(char Status)
        {
            this.status = Status;
        }

        private static bool isValidName(String name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }

        private static bool isValidEircode(String EIRCode)
        {
            return Regex.IsMatch(EIRCode, @"(?:^[AC-FHKNPRTV-Y][0-9]{2}|D6W)[ -]?[0-9AC-FHKNPRTV-Y]{4}$");
        }

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public void addCustomer()
        {
            OracleConnection connection = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Customers Values (" +
                this.custId + ",'" + this.forename + "','" + this.surname + "','" +
                this.town + "'," + this.county + "," + this.EIRCode + ",'" + 
                this.password + ",'" + this.phone + "','" + this.email + "','" + 
                this.cardNumber + "','" + this.status + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, connection);
            connection.Open();

            cmd.ExecuteNonQuery();

            connection.Close();
        }
        public void updateGame()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Customer SET " +
                "Customer Id = " + this.custId + "," +
                "Forename = '" + this.forename + "'," +
                "Surname = '" + this.surname + "'," +
                "Town = '" + this.town + "'," +
                "County = " + this.county + "," +
                "EIR Code = " + this.EIRCode + "," +
                "Status = '" + this.status + "' " +
                "Card Number = '" + this.cardNumber + "' " +
                "WHERE CustId = " + this.custId;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataSet findGame(String forename)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT CustId, forename, surname FROM Customers " +
                "WHERE forname LIKE '%" + forename + "%' ORDER BY Name";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "prod");
            conn.Close();
            return ds;
        }
        public static int getNextCustomerID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            String sqlQuery = "SELECT MAX(CustID) FROM Customers";
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
    }
}
/*  Code copied from Stack Overflow at https://stackoverflow.com/questions/7587110/basic-user-input-string-validation
 *  Used for reference.
 * public string Name
{
    get { return _name; }

    set 
    {
        if (! Regex.IsMatch(value, @"\w{1-35}"))
           throw new ArgumentException("Name must be 1-35 alfanum");
        _name = value;
    }
}
 */
