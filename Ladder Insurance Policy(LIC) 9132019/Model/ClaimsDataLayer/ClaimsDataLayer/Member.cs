using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsDataLayer
{
    public class Member
    {
        private int _memberID;
        private string _firstName;
        private string _lastName;
        private int age;
        private string gender;
        private DateTime _dob;
        private long _contactNumber;
        private long _altContactNumber;
        private string _emailId;
        private string _password;
        private int _planCodeId;
        private int _memberPlanId;
        private string _addressLine1;
        private string _addressLine2;
        private string _city;
        private string _state;
        private string _zipCode;
        private string _active;

        public Member()
        {

        }

        public Member(int _memberID, string _firstName, string _lastName, int age, string gender, DateTime _dob, long _contactNumber, long _altContactNumber, string _emailId, string _password, int _planCodeId, int _memberPlanId, string _addressLine1, string _addressLine2, string _city, string _state, string _zipCode, string _active)
        {
            this.MemberID = _memberID;
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.Age = age;
            this.Gender = gender;
            this.Dob = _dob;
            this.ContactNumber = _contactNumber;
            this.AltContactNumber = _altContactNumber;
            this.EmailId = _emailId;
            this.Password = _password;
            this.PlanCodeId = _planCodeId;
            this.MemberPlanId = _memberPlanId;
            this.AddressLine1 = _addressLine1;
            this.AddressLine2 = _addressLine2;
            this.City = _city;
            this.State = _state;
            this.ZipCode = _zipCode;
            this.Active = _active;
        }

        public int MemberID
        {
            get
            {
                return _memberID;
            }

            set
            {
                _memberID = value;
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
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
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

        public int PlanCodeId
        {
            get
            {
                return _planCodeId;
            }

            set
            {
                _planCodeId = value;
            }
        }

        public int MemberPlanId
        {
            get
            {
                return _memberPlanId;
            }

            set
            {
                _memberPlanId = value;
            }
        }

        public string AddressLine1
        {
            get
            {
                return _addressLine1;
            }

            set
            {
                _addressLine1 = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                return _addressLine2;
            }

            set
            {
                _addressLine2 = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                _city = value;
            }
        }

        public string State
        {
            get
            {
                return _state;
            }

            set
            {
                _state = value;
            }
        }

        public string ZipCode
        {
            get
            {
                return _zipCode;
            }

            set
            {
                _zipCode = value;
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
