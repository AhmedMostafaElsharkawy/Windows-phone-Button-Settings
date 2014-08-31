using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace ButtonsSettings
{
    public partial class sleep : PhoneApplicationPage
    {
        public sleep()
        {
            InitializeComponent();
            OneKeyScreenClose.Phone.OS.PowerLock();
            throw new Exception();
        }
    }
}