using nercoreangular.Debugging;

namespace nercoreangular
{
    public class nercoreangularConsts
    {
        public const string LocalizationSourceName = "nercoreangular";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;

        public const string prefix = "ANG_";

        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "32bba224cc824423a041c4ee4d159534";
    }
}
