using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertificateCore
{
    public enum KeyUsage
    {
        NonRepudiation,
        KeyCertSign,
        CrlSign,
        DigitalSignature,
        KeyEncipherment,
        DataEncipherment,
        KeyAgreement,
        EncipherOnly,
        DecipherOnly
    }
}
