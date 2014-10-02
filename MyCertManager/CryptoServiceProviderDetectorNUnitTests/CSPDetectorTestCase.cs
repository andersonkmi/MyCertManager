using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using CryptoServiceProviderDetector;

namespace CryptoServiceProviderDetectorNUnitTests
{
    [TestFixture]
    public class CSPDetectorTestCase
    {
        private CSPDetector _cspDetector;

        [SetUp]
        public void Setup()
        {
            _cspDetector = new CSPDetector();
        }

        [Test]
        public void TestEmptyDetectorsListOk()
        {
            var csps = _cspDetector.DetectCSPs();
            Assert.IsEmpty(csps);
        }

        [Test]
        public void TestSafeSignDetectorOk()
        {
            var safesignCheck = new SafeSignCSPRegistryCheck();
            _cspDetector.AddCryptoServiceProviderVerifier(safesignCheck);
            var result = _cspDetector.DetectCSPs();
            Assert.IsNotEmpty(result);
            Assert.AreEqual(1, result.Count);
            var safeSign = result.ElementAt(0);
            Assert.True(safeSign.Name.Contains("SafeSign"));
            Assert.AreEqual(@"C:\Windows\system32\aetpkss11.dll", safeSign.Pkcs11LibraryPath);
        }

        [Test]
        public void TestSafeNetDetectorOk()
        {
            var safenetCheck = new SafeNetCSPRegistryCheck();
            _cspDetector.AddCryptoServiceProviderVerifier(safenetCheck);
            var result = _cspDetector.DetectCSPs();
            Assert.IsNotEmpty(result);
            Assert.AreEqual(1, result.Count);
            var safeSign = result.ElementAt(0);
            Assert.True(safeSign.Name.Contains("SafeNet"));
        }

        [Test]
        public void TestAllDetectorsOk()
        {
            var safenetCheck = new SafeNetCSPRegistryCheck();
            var safesignCheck = new SafeSignCSPRegistryCheck();
            _cspDetector.AddCryptoServiceProviderVerifier(safenetCheck);
            _cspDetector.AddCryptoServiceProviderVerifier(safesignCheck);
            var result = _cspDetector.DetectCSPs();
            Assert.IsNotEmpty(result);
            Assert.AreEqual(2, result.Count);
        }
    }
}
