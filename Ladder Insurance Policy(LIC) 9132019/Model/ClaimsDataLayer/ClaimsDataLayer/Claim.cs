using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsDataLayer
{
    public class Claim
    {
        private int _claimId;
        private int _memberId;
        private DateTime _claimServiceDate;
        private DateTime _claimSubmissionDate;
        private DateTime _claimProcessingDate;
        private string _claimStatus;
        private float _claimAmount;
        private float _approvedAmount;

        public Claim()
        {

        }

        public Claim(int _claimId, int _memberId, DateTime _claimServiceDate, DateTime _claimSubmissionDate, DateTime _claimProcessingDate, string _claimStatus, float _claimAmount, float _approvedAmount)
        {
            this.ClaimId = _claimId;
            this.MemberId = _memberId;
            this.ClaimServiceDate = _claimServiceDate;
            this.ClaimSubmissionDate = _claimSubmissionDate;
            this.ClaimProcessingDate = _claimProcessingDate;
            this.ClaimStatus = _claimStatus;
            this.ClaimAmount = _claimAmount;
            this.ApprovedAmount = _approvedAmount;
        }

        public int ClaimId
        {
            get
            {
                return _claimId;
            }

            set
            {
                _claimId = value;
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

        public DateTime ClaimServiceDate
        {
            get
            {
                return _claimServiceDate;
            }

            set
            {
                _claimServiceDate = value;
            }
        }

        public DateTime ClaimSubmissionDate
        {
            get
            {
                return _claimSubmissionDate;
            }

            set
            {
                _claimSubmissionDate = value;
            }
        }

        public DateTime ClaimProcessingDate
        {
            get
            {
                return _claimProcessingDate;
            }

            set
            {
                _claimProcessingDate = value;
            }
        }

        public string ClaimStatus
        {
            get
            {
                return _claimStatus;
            }

            set
            {
                _claimStatus = value;
            }
        }

        public float ClaimAmount
        {
            get
            {
                return _claimAmount;
            }

            set
            {
                _claimAmount = value;
            }
        }

        public float ApprovedAmount
        {
            get
            {
                return _approvedAmount;
            }

            set
            {
                _approvedAmount = value;
            }
        }
        
    }
}

