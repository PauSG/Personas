using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            string claveSync = Personas.Properties.Settings.Default.claveSync;
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(claveSync);
        }
    }
}
