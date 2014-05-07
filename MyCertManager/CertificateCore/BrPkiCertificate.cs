using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateCore
{
    public class BrPkiCertificate : Certificate
    {
        #region Fields
        private BrazilPKICertificateType type;
        private String taxpayerId;
        private String federalTaxId;
        private String certificateRep;
        private String civilIdentification;
        private String workerFundIdentification;
        private DateTime dateOfBirth;
        private String voterIdNumber;
        private String votingZone;
        private String votingSection;
        private String votingLocation;
        private String socialSecurityNumber;
        #endregion

        #region Properties
        public BrazilPKICertificateType BrazilPKICertType
        {
            get { return type; }
            set { type = value; }
        }

        public String TaxpayerId
        {
            get { return taxpayerId; }
            set { taxpayerId = value; }
        }

        public String FederalTaxId
        {
            get { return federalTaxId; }
            set { federalTaxId = value; }
        }

        public String CertificateRep
        {
            get { return certificateRep; }
            set { certificateRep = value; }
        }

        public String CivilIdentification
        {
            get { return civilIdentification; }
            set { civilIdentification = value; }
        }

        public String WorkerFundIdentification
        {
            get { return workerFundIdentification; }
            set { workerFundIdentification = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public String VoterIdNumber
        {
            get { return voterIdNumber; }
            set { voterIdNumber = value; }
        }

        public String VotingZone
        {
            get { return votingZone; }
            set { votingZone = value; }
        }

        public String VotingSection
        {
            get { return votingSection; }
            set { votingSection = value; }
        }

        public String VotingLocation
        {
            get { return votingLocation; }
            set { votingLocation = value; }
        }

        public String SocialSecurityNumber
        {
            get { return socialSecurityNumber; }
            set { socialSecurityNumber = value; }
        }
        #endregion
    }
}
