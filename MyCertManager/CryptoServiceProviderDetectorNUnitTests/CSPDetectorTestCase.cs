using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CryptoServiceProviderDetector;

namespace CryptoServiceProviderDetectorNUnitTests
{
    [TestFixture]
    public class CSPDetectorTestCase
    {
        private CSPDetector detector;

        [SetUp]
        public void Setup()
        {
            this.detector = new CSPDetector();
        }

        [Test]
        public void TestEmptyDetectorsListOK()
        {
            ISet<CryptoServiceProviderInformation> csps = detector.DetectCSPs();
            Assert.IsEmpty(csps);
        }

        [Test]
        public void TestSafeSignDetectorOK()
        {
            SafeSignCSPRegistryCheck safesignCheck = new SafeSignCSPRegistryCheck();
            this.detector.AddCryptoServiceProviderVerifier(safesignCheck);
            ISet<CryptoServiceProviderInformation> result = this.detector.DetectCSPs();
            Assert.IsNotEmpty(result);
            Assert.AreEqual(1, result.Count);
            CryptoServiceProviderInformation safeSign = result.ElementAt(0);
            Assert.True(safeSign.Name.Contains("SafeSign"));
            Assert.AreEqual(@"C:\Windows\system32\aetpkss11.dll", safeSign.Pkcs11LibraryPath);
        }

        [Test]
        public void TestSafeNetDetectorOK()
        {
            SafeNetCSPRegistryCheck safenetCheck = new SafeNetCSPRegistryCheck();
            this.detector.AddCryptoServiceProviderVerifier(safenetCheck);
            ISet<CryptoServiceProviderInformation> result = this.detector.DetectCSPs();
            Assert.IsNotEmpty(result);
            Assert.AreEqual(1, result.Count);
            CryptoServiceProviderInformation safeSign = result.ElementAt(0);
            Assert.True(safeSign.Name.Contains("SafeNet"));
        }

        [Test]
        public void TestAllDetectorsOK()
        {
            SafeNetCSPRegistryCheck safenetCheck = new SafeNetCSPRegistryCheck();
            SafeSignCSPRegistryCheck safesignCheck = new SafeSignCSPRegistryCheck();
            this.detector.AddCryptoServiceProviderVerifier(safenetCheck);
            this.detector.AddCryptoServiceProviderVerifier(safesignCheck);
            ISet<CryptoServiceProviderInformation> result = this.detector.DetectCSPs();
            Assert.IsNotEmpty(result);
            Assert.AreEqual(2, result.Count);
        }
    }
}
