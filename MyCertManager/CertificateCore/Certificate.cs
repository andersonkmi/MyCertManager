using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateCore
{
    public class Certificate
    {
        #region Fields
        private CertificateType type;
        private String issuedTo;
        private String commonName;
        private String subjectAlternativeName;
        private String issuer;
        private DateTime validFrom;
        private DateTime validTo;
        private String version;
        private String serialNumber;
        private String signingAlgorithm;
        private String authorityKeyIdentifier;
        private String subjectKeyIdentifier;
        private String thumbPrint;
        private String certificateDirective;
        private List<String> crls;
        private HashSet<KeyUsage> keyUsages;
        private HashSet<ExtendedKeyUsage> extendedKeyUsages;
        private Stack<Certificate> certificateChain;
        private HashAlgorithm hashAlgorithm;
        #endregion

        #region Constructor
        public Certificate()
        {
            type = CertificateType.EndUser;
            issuedTo = "";
            commonName = "";
            subjectAlternativeName = "";
            issuer = "";
            validFrom = DateTime.Now;
            validTo = DateTime.Now;
            version = "";
            serialNumber = "";
            signingAlgorithm = "";
            authorityKeyIdentifier = "";
            subjectKeyIdentifier = "";
            thumbPrint = "";
            certificateDirective = "";
            crls = new List<string>();
            keyUsages = new HashSet<KeyUsage>();
            extendedKeyUsages = new HashSet<ExtendedKeyUsage>();
            certificateChain = new Stack<Certificate>();
            hashAlgorithm = HashAlgorithm.SHA1;
        }
        #endregion

        #region Properties
        public CertificateType Type
        {
            get { return type; }
            set { type = value; }
        }

        public String IssuedTo
        {
            get { return issuedTo; }
            set { issuedTo = value; }
        }

        public String CommonName
        {
            get { return commonName; }
            set { commonName = value; }
        }

        public String SubjectAlternativeName
        {
            get { return subjectAlternativeName; }
            set { subjectAlternativeName = value; }
        }

        public String Issuer
        {
            get { return issuer; }
            set { issuer = value; }
        }

        public DateTime ValidFrom
        {
            get { return validFrom; }
            set { validFrom = value; }
        }

        public DateTime ValidTo
        {
            get { return validTo; }
            set { validTo = value; }
        }

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        public String SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        public String SigningAlgorithm
        {
            get { return signingAlgorithm; }
            set { signingAlgorithm = value; }
        }

        public String SubjectKeyIdentifier
        {
            get { return subjectKeyIdentifier; }
            set { subjectKeyIdentifier = value; }
        }

        public String AuthorityKeyIdentifier
        {
            get { return authorityKeyIdentifier; }
            set { authorityKeyIdentifier = value; }
        }

        public String ThumbPrint
        {
            get { return thumbPrint; }
            set { thumbPrint = value; }
        }

        public String CertificateDirective
        {
            get { return certificateDirective; }
            set { certificateDirective = value; }
        }

        public List<String> Crls
        {
            get
            {
                List<String> items = new List<string>();
                items.AddRange(crls);
                return items;
            }
        }

        public HashSet<KeyUsage> KeyUsages
        {
            get
            {
                HashSet<KeyUsage> items = new HashSet<KeyUsage>(keyUsages);
                return items;
            }
        }

        public HashSet<ExtendedKeyUsage> ExtendedKeyUsages
        {
            get
            {
                HashSet<ExtendedKeyUsage> items = new HashSet<ExtendedKeyUsage>(extendedKeyUsages);
                return items;
            }
        }

        public Stack<Certificate> CertificateChain
        {
            get
            {
                return certificateChain;
            }
        }

        public HashAlgorithm HashAlgorithm
        {
            get { return hashAlgorithm; }
            set { hashAlgorithm = value; }
        }
        #endregion

        #region Methods
        public void AddCrls(String crlsAddress)
        {
            crls.Add(crlsAddress);
        }

        public void AddKeyUsage(KeyUsage usage)
        {
            keyUsages.Add(usage);
        }

        public void AddExtendedKeyUsage(ExtendedKeyUsage usage)
        {
            extendedKeyUsages.Add(usage);
        }

        public void AddCertificateChain(Certificate item)
        {
            certificateChain.Push(item);
        }
        #endregion
    }
}
