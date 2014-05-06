using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateCore
{
    public enum ExtendedKeyUsage
    {
        /// <summary>
        /// Uso da chave: Autenticação de servidor.
        /// </summary>
        ServerAuthentication, // OID=1.3.6.1.5.5.7.3.1
        ClientAuthentication, // OID=1.3.6.1.5.5.7.3.2
        CodeSigning,          // OID=1.3.6.1.5.5.7.3.3
        EmailProtection,      // OID=1.3.6.1.5.5.7.3.4
        IpsecEndsystem,       // OID=1.3.6.1.5.5.7.3.5
        IpsecTunnel,          // OID=1.3.6.1.5.5.7.3.6
        IpsecUser,            // OID=1.3.6.1.5.5.7.3.7
        TimeStamping,         // OID=1.3.6.1.5.5.7.3.8
        OcspSigning           // OID=1.3.6.1.5.5.7.3.9
    }
}
