using IDUN2.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace IDUN2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Initialization : Page
    {
        private bool Pass = true;

        public Initialization()
        {
            this.InitializeComponent();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            if (ObjectIDTB.Text=="" || ObjectIDTB.Text == null || ObjectIDTB.Text == " ") { Pass = false; }
            if (ObjectNameTB.Text == "" || ObjectNameTB.Text == null || ObjectNameTB.Text == " ") { Pass = false; }
            if (ObjectDescriptionTB.Text == "" || ObjectDescriptionTB.Text == null || ObjectDescriptionTB.Text == " ") { Pass = false; }
            if (MaintenanceOrgIDTB.Text == "" || MaintenanceOrgIDTB.Text == null || MaintenanceOrgIDTB.Text == " ") { Pass = false; }
            if (MaintenanceOrgNameTB.Text == "" || MaintenanceOrgNameTB.Text == null || MaintenanceOrgNameTB.Text == " ") { Pass = false; }
            if (SiteTB.Text == "" || SiteTB.Text == null || SiteTB.Text == " ") { Pass = false; }

            if (Pass==true)
            {
                (Application.Current as IDUN2.App).SetupInit.Add(new SetupInitialization { ObjectIDTB = ObjectIDTB.Text, ObjectNameTB = ObjectNameTB.Text.ToString(), ObjectDescriptionTB = ObjectDescriptionTB.Text.ToString(), MaintenanceOrgIDTB= MaintenanceOrgIDTB.Text.ToString(), MaintenanceOrgNameTB = MaintenanceOrgNameTB.Text.ToString(), SiteTB=SiteTB.Text.ToString() });
                (App.Current as IDUN2.App).Initialization = true;
                Frame.Navigate(typeof(Configuration));
            }
            
        }
    }
}
