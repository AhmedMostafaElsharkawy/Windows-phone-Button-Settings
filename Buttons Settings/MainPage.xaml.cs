using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using CSharp___DllImport;

using Microsoft.Phone.Shell;




namespace VibrationSetting
{
    public partial class MainPage : PhoneApplicationPage
    {

        string Vibratekey = @"Software\OEM\KeyState";
        string CameraButtonKey = @"SOFTWARE\Microsoft\Camera\Settings";
        string PowerSoundPhoneLockedKey = @"ControlPanel\Sounds\PhoneLocked";
        string PowerSoundPhoneUnLockedKey = @"ControlPanel\Sounds\PhoneUnlocked";

        public MainPage()
        {
            try
            {
  InitializeComponent();
            if (WP7RootToolsSDK.Environment.HasRootAccess() == true)
            {
                MainButtonsVibration.IsChecked = false;
                
                if (WP7RootToolsSDK.Registry.GetDWordValue(WP7RootToolsSDK.RegistryHyve.LocalMachine, Vibratekey, "application_btn_vibrate3") == 1)
                {
                    MainButtonsVibration.IsChecked = true;
                }

                btnCamraSoft.IsChecked = false;
                if (WP7RootToolsSDK.Registry.GetDWordValue(WP7RootToolsSDK.RegistryHyve.LocalMachine, CameraButtonKey, "SoftShutterButton") == 1)
                {
                    btnCamraSoft.IsChecked = true;
                }
                btnPowerSound.IsChecked = false;
                if (WP7RootToolsSDK.Registry.GetDWordValue(WP7RootToolsSDK.RegistryHyve.CurrentUser, PowerSoundPhoneUnLockedKey,"Disabled") == 1)
                {
                    btnPowerSound.IsChecked = true;
                }
            }
            else
            {
                MessageBox.Show("Your phone must have a root access to use this application, set this app trusted with WP7 Root Tools before launching.", "Attention", MessageBoxButton.OK);
            }
            }
            catch (Exception )
            {
                MessageBox.Show("Your phone must have a root access to use this application, set this app trusted with WP7 Root Tools before launching.", "Attention", MessageBoxButton.OK);

              
            }

          
        }





        private void Btnvibration_Checked(object sender, RoutedEventArgs e)

        {
            try
            {
                WP7RootToolsSDK.Registry.SetDWordValue(WP7RootToolsSDK.RegistryHyve.LocalMachine, Vibratekey, "application_btn_vibrate3", 1);

            }
            catch (Exception)
            {
                
              
            }
        }
        private void Btnvibration_UnChecked(object sender, RoutedEventArgs e)
        {
            try
            {
                WP7RootToolsSDK.Registry.SetDWordValue(WP7RootToolsSDK.RegistryHyve.LocalMachine, Vibratekey, "application_btn_vibrate3", 0);

            }
            catch (Exception)
            {
                
            
            }
        }



        private void ideasSoftware_Click_1(object sender, EventArgs e)
        {

            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = new Uri("https://www.facebook.com/ideasSoftware", UriKind.Absolute);
            webBrowserTask.Show();
        }

        private void btnPowerSound_UnChecked(object sender, RoutedEventArgs e)
        {
            try
            {
   WP7RootToolsSDK.Registry.SetDWordValue(WP7RootToolsSDK.RegistryHyve.CurrentUser, PowerSoundPhoneUnLockedKey, "Disabled", 0);
            WP7RootToolsSDK.Registry.SetDWordValue(WP7RootToolsSDK.RegistryHyve.CurrentUser, PowerSoundPhoneLockedKey , "Disabled", 0);

            }
            catch (Exception)
            {
                
               
            }

         
        }

        private void btnPowerSound_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                WP7RootToolsSDK.Registry.SetDWordValue(WP7RootToolsSDK.RegistryHyve.CurrentUser, PowerSoundPhoneUnLockedKey, "Disabled", 1);
                WP7RootToolsSDK.Registry.SetDWordValue(WP7RootToolsSDK.RegistryHyve.CurrentUser, PowerSoundPhoneLockedKey, "Disabled", 1);
            }
            catch (Exception)
            {
                
              
            }
       
        }

        private void CameraSoft_Checked(object sender, RoutedEventArgs e)
        {

            try
            {
                WP7RootToolsSDK.Registry.SetDWordValue(WP7RootToolsSDK.RegistryHyve.LocalMachine, CameraButtonKey, "SoftShutterButton", 1);

            }
            catch (Exception)
            {
                
              
            }

        }

        private void CameraSoft_UnChecked(object sender, RoutedEventArgs e)
        {
            try
            {
                WP7RootToolsSDK.Registry.SetDWordValue(WP7RootToolsSDK.RegistryHyve.LocalMachine, CameraButtonKey, "SoftShutterButton", 0);

            }
            catch (Exception)
            {
                
            }

        }

        //private void OperaLauch(object sender, RoutedEventArgs e)
        // {
        //    string d ="\Program Files\Opera Mini\OperaMini5-WM-armv4.exe";
        //WP7RootToolsSDK.Environment.ShellExecute ( d);
        // }
     
        private void btnPower_Click(object sender, RoutedEventArgs e)
        {
            StandardTileData NewTileData = new StandardTileData { Title = "Sleep", BackgroundImage = new Uri("/power.png", UriKind.Relative) };
            ShellTile.Create(new Uri("/sleep.xaml", UriKind.Relative), NewTileData);
        }

    }
}
