using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsDataLayer
{
    public class MemberPlan
    {
        private int _memberPlanId;
        private int _memberId;
        private int plancodeId;
        private DateTime _startDate;
        private DateTime _endDate;

        public MemberPlan()
        {

        }

        public MemberPlan(int _memberPlanId, int _memberId, int plancodeId, DateTime _startDate, DateTime _endDate)
        {
            this.MemberPlanId = _memberPlanId;
            this.MemberId = _memberId;
            this.PlancodeId = plancodeId;
            this.StartDate = _startDate;
            this.EndDate = _endDate;
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

        public int MemberId
        {
            get
            {
                return _memberId;
            }

            set
            {
                _memberId = value;
            }
        }

        public int PlancodeId
        {
            get
            {
                return plancodeId;
            }

            set
            {
                plancodeId = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }

            set
            {
                _startDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }

            set
            {
                _endDate = value;
            }
        }
       
    }
}
