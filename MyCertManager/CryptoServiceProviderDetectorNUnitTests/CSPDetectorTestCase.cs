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
        public void TestDetectorEmptyDetectorsListOK()
        {

        }
    }
}
