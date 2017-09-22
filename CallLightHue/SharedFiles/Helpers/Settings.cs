// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace SharedFiles.Helpers
{
	/// <summary>
	/// This is the Settings static class that can be used in your Core solution or in any
	/// of your client applications. All settings are laid out the same exact way with getters
	/// and setters. 
	/// </summary>
	public static class Settings
	{
		private static ISettings AppSettings
		{
			get
			{
				return CrossSettings.Current;
			}
		}

		#region Setting Constants

		private const string SettingsKey = "settingsKey";
        private const string UserNameKey = "UserNameKey";
        private const string LightsKey = "LightsKey";
        private const string LastIpKey = "LastIpKey";
        private static readonly string SettingsDefault = string.Empty;

        #endregion

        public static string LastIp
        {
            get
            {
                return AppSettings.GetValueOrDefault(LastIpKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(LastIpKey, value);
            }
        }

        public static string Lights
        {
            get
            {
                return AppSettings.GetValueOrDefault(LightsKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(LightsKey, value);
            }
        }

        public static string UserName
        {
            get
            {
                return AppSettings.GetValueOrDefault(UserNameKey, SettingsDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue(UserNameKey, value);
            }
        }

        public static string GeneralSettings
		{
			get
			{
				return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
			}
			set
			{
				AppSettings.AddOrUpdateValue(SettingsKey, value);
			}
		}

	}
}