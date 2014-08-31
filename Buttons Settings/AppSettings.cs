using System;
using System.IO.IsolatedStorage;


namespace VibrationSetting
{
    public class AppSettings
    {
        IsolatedStorageSettings isolatedStore;
        const string Toggle1KeyName = "Toggle1Setting";
        const string Toggle2KeyName = "Toggle2Setting";
        const string Toggle3KeyName = "Toggle3Setting";

        const bool Toggle1SettingDefault = false;
        const bool Toggle2SettingDefault = false;
        const bool Toggle3SettingDefault = false;


        public AppSettings()
        {

        }
    }
}
