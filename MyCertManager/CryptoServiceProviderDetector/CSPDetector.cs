using System.Collections.Generic;

namespace CryptoServiceProviderDetector
{
    public class CSPDetector
    {
        #region Internal attributes
        private readonly ISet<ICSPRegistryCheck> _cspDetectors;
        #endregion

        #region Constructor
        public CSPDetector()
        {
            _cspDetectors = new HashSet<ICSPRegistryCheck>();
        }
        #endregion

        #region Methods
        public void AddCryptoServiceProviderVerifier(ICSPRegistryCheck item)
        {
            _cspDetectors.Add(item);
        }

        public ISet<CryptoServiceProviderInformation> DetectCSPs()
        {
            ISet<CryptoServiceProviderInformation> results = new HashSet<CryptoServiceProviderInformation>();
            ExecuteDetectors(results);
            return results;
        }

        private void ExecuteDetectors(ISet<CryptoServiceProviderInformation> items)
        {
            foreach (var detector in _cspDetectors)
            {
                items.Add(detector.verifyInstallation());
            }
        }
        #endregion
    }
}
