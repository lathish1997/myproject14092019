using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsDataLayer
{
    public class Admin
    {
        private int _adminID;
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _gender;
        private DateTime _dob;
        private long _contactNumber;
        private long _altContactNumber;
        private string _emailId;
        private string _password;
        private string _active;

        public Admin()
        {

        }

        public Admin(int _adminID, string _firstName, string _lastName, int _age, string _gender, DateTime _dob, long _contactNumber, long _altContactNumber, string _emailId, string _password, string _active)
        {
            this.AdminID = _adminID;
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.Age = _age;
            this.Gender = _gender;
            this.Dob = _dob;
            this.ContactNumber = _contactNumber;
            this.AltContactNumber = _altContactNumber;
            this.Active = _active;
            this.EmailId = _emailId;
            this._password = _password;
            this.Active = _active;
        }

        public int AdminID
        {
            get
            {
                return _adminID;
            }

            set
            {
                _adminID = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        public DateTime Dob
        {
            get
            {
                return _dob;
            }

            set
            {
                _dob = value;
            }
        }

        public long ContactNumber
        {
            get
            {
                return _contactNumber;
            }

            set
            {
                _contactNumber = value;
            }
        }

        public long AltContactNumber
        {
            get
            {
                return _altContactNumber;
            }

            set
            {
                _altContactNumber = value;
            }
        }

        public string EmailId
        {
            get
            {
                return _emailId;
            }

            set
            {
                _emailId = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }
        
        public string Active
        {
            get
            {
                return _active;
            }

            set
            {
                _active = value;
            }
        }
    }
}
