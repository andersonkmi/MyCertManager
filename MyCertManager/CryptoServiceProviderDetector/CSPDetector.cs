using System.Collections.Generic;

namespace CryptoServiceProviderDetector
{
    public class CSPDetector
    {
        #region Internal attributes
        private ISet<ICSPRegistryCheck> cspDetectors;
        #endregion

        #region Constructors
        public CSPDetector()
        {
            this.cspDetectors = new HashSet<ICSPRegistryCheck>();
        }

        public CSPDetector(ISet<ICSPRegistryCheck> detectors)
        {
            this.cspDetectors = detectors;
        }
        #endregion

        #region Methods
        public ISet<CryptoServiceProviderInformation> detectCSPs()
        {
            ISet<CryptoServiceProviderInformation> results = new HashSet<CryptoServiceProviderInformation>();
            return results;
        }

        private void executeDetectors(ISet<CryptoServiceProviderInformation> items)
        {
            foreach (ICSPRegistryCheck detector in cspDetectors)
            {
                items.Add(detector.verifyInstallation());
            }
        }
        #endregion
    }
}
