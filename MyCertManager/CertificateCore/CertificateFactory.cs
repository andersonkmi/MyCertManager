using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography;

namespace CertificateCore
{
    public class CertificateFactory
    {
        #region Constants
        private static readonly String BASIC_RESTRICTIONS = "2.5.29.19";
        private static readonly String KEY_USAGE = "2.5.29.15";
        private static readonly String EXTENDED_KEY_USAGE = "2.5.29.37";
        private static readonly String AUTHORITY_KEY_IDENTIFIER = "2.5.29.35";
        private static readonly String SUBJECT_KEY_IDENTIFIER = "2.5.29.14";
        private static readonly String SUBJECT_ALTERNATIVE_NAME = "2.5.29.17";
        private static readonly String CERTIFICATE_POLICY = "2.5.29.32";
        private static readonly String CRL_DISTRIBUTION_POINT_LIST = "2.5.29.31";
        private static readonly String CA_INFORMATION_ACCESS = "1.3.6.1.5.5.7.1.1";

        private static readonly String SERVER_AUTHENTICATION_OID = "1.3.6.1.5.5.7.3.1";
        private static readonly String CLIENT_AUTHENTICATION_OID = "1.3.6.1.5.5.7.3.2";
        private static readonly String CODE_SIGNING_OID = "1.3.6.1.5.5.7.3.3";
        private static readonly String EMAIL_PROTECTION_OID = "1.3.6.1.5.5.7.3.4";
        private static readonly String IPSEC_END_SYSTEM_OID = "1.3.6.1.5.5.7.3.5";
        private static readonly String IPSEC_TUNNEL_OID = "1.3.6.1.5.5.7.3.6";
        private static readonly String IPSEC_USER_OID = "1.3.6.1.5.5.7.3.7";
        private static readonly String TIMESTAMPING_OID = "1.3.6.1.5.5.7.3.8";
        private static readonly String OCSP_SIGNING_OID = "1.3.6.1.5.5.7.3.9";

        private static readonly String ECpf = "e-CPF";
        private static readonly String ECnpj = "e-CNPJ";
        private static readonly String NFe = "NF-e";

        private static readonly String SHA1WithRSAOid = "1.2.840.113549.1.1.5";
        private static readonly String SHA256WthRSAOid = "1.2.840.113549.1.1.11";
        private static readonly String SHA384WithRSAOid = "1.2.840.113549.1.1.12";
        private static readonly String SHA512WithRSAOid = "1.2.840.113549.1.1.13";
        #endregion
        #region Methods
        public Certificate build()
        {
            return null;
        }
        #endregion
    }
}
