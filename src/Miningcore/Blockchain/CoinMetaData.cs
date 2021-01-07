using System.Collections.Generic;

namespace Miningcore.Blockchain
{
    public static class DevDonation
    {
        public const decimal Percent = 0.1m;

        public static readonly Dictionary<string, string> Addresses = new Dictionary<string, string>
        {
            { "TUBE", "bxdAFKYA5sJYKM3zcn3SLaLRjsFF582VE1Uv5NChrVLm6o6UF4SdbZBZLrTBD6yEFZDzuTQGBCa8FLpX8charjxH2G3iMRX6R" },
        };
    }

    public static class CoinMetaData
    {
        public const string BlockHeightPH = "$height$";
        public const string BlockHashPH = "$hash$";
    }
}
