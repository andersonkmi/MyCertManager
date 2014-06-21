using System.Collections.Generic;

namespace CryptoServiceProviderDetector
{
    public class CSPDetector
    {
        #region Internal attributes
        private ISet<ICSPRegistryCheck> cspDetectors;
        #endregion

        #region Constructor
        public CSPDetector()
        {
            this.cspDetectors = new HashSet<ICSPRegistryCheck>();
        }
        #endregion

        #region Methods
        public void AddCryptoServiceProviderVerifier(ICSPRegistryCheck item)
        {
            this.cspDetectors.Add(item);
        }

        public ISet<CryptoServiceProviderInformation> DetectCSPs()
        {
            ISet<CryptoServiceProviderInformation> results = new HashSet<CryptoServiceProviderInformation>();
            ExecuteDetectors(results);
            return results;
        }

        private void ExecuteDetectors(ISet<CryptoServiceProviderInformation> items)
        {
            foreach (ICSPRegistryCheck detector in cspDetectors)
            {
                items.Add(detector.verifyInstallation());
            }
        }
        #endregion
    }
}
