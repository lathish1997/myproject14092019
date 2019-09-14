using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsDataLayer
{
    public class PlanCode
    {
        private int _planCodeId;
        private string _planDescription;
        private string _coverage1;
        private string _coverage2;
        private string _coverage3;
        private string _coverage4;
        private string _coverage5;

        public PlanCode()
        {

        }

        public PlanCode(int _planCodeId, string _planDescription, string _coverage1, string _coverage2, string _coverage3, string _coverage4, string _coverage5)
        {
            this.PlanCodeId = _planCodeId;
            this.PlanDescription = _planDescription;
            this.Coverage1 = _coverage1;
            this.Coverage2 = _coverage2;
            this.Coverage3 = _coverage3;
            this.Coverage4 = _coverage4;
            this.Coverage5 = _coverage5;
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

        public string PlanDescription
        {
            get
            {
                return _planDescription;
            }

            set
            {
                _planDescription = value;
            }
        }

        public string Coverage1
        {
            get
            {
                return _coverage1;
            }

            set
            {
                _coverage1 = value;
            }
        }

        public string Coverage2
        {
            get
            {
                return _coverage2;
            }

            set
            {
                _coverage2 = value;
            }
        }

        public string Coverage3
        {
            get
            {
                return _coverage3;
            }

            set
            {
                _coverage3 = value;
            }
        }

        public string Coverage4
        {
            get
            {
                return _coverage4;
            }

            set
            {
                _coverage4 = value;
            }
        }

        public string Coverage5
        {
            get
            {
                return _coverage5;
            }

            set
            {
                _coverage5 = value;
            }
        }
        
    }
}
