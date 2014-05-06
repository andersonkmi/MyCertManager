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
        private String socialSecurityIdNumber;
        #endregion
    }
}
