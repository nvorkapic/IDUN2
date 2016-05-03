using IDUN2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class Configuration : Page
    {
        public List<SetupConfiguration> ConfigList = new List<SetupConfiguration>();

        public string maxThreshold { get; set; }
        public string minThreshold { get; set; }

        public Configuration()
        {
            this.InitializeComponent();

            MeasurementsList.Items.Add(new SetupConfiguration { Measurement = "Usage"});
            MeasurementsList.Items.Add(new SetupConfiguration { Measurement = "Pressure"});
            MeasurementsList.Items.Add(new SetupConfiguration { Measurement = "Temperature"});
            MeasurementsList.Items.Add(new SetupConfiguration { Measurement = "Humidity"});
            MeasurementsList.Items.Add(new SetupConfiguration { Measurement = "Magnetic Field"});
            MeasurementsList.Items.Add(new SetupConfiguration { Measurement = "Gyroscope"});
            MeasurementsList.Items.Add(new SetupConfiguration { Measurement = "Accelerometer"});

            MeasurementsList.SelectionChanged += MeasurementsList_SelectionChanged;

            SRRButton.Checked += SRRButton_Checked;
            SRRButton.Unchecked += SRRButton_Unchecked;

        }



        private void SRRButton_Unchecked(object sender, RoutedEventArgs e)
        {
            ReportsForSimple.Visibility = Visibility.Collapsed;
            AdvancedR.Visibility = Visibility.Visible;
        }

        private void SRRButton_Checked(object sender, RoutedEventArgs e)
        {
            ReportsForSimple.Visibility = Visibility.Visible;
            AdvancedR.Visibility = Visibility.Collapsed;
        }

        private void MeasurementsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ThresholdList.ItemsSource = MeasurementsList.SelectedItems;
            AdvancedRList.ItemsSource = MeasurementsList.SelectedItems;
            MeasurementsDensityList.ItemsSource = MeasurementsList.SelectedItems;
            IntervalsList.ItemsSource = MeasurementsList.SelectedItems;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            foreach (SetupConfiguration item in MeasurementsList.SelectedItems)
            { 
                ConfigList.Add(new SetupConfiguration { Measurement = item.Measurement });
            }



            foreach (SetupConfiguration item in ThresholdList.SelectedItems)
            {
                item.ThresholdEnabled = true;

                


                //TextBox tbMax = FindName("maxTresh") as TextBox;
                //item.ThresholdMax=double.Parse(tbMax.Text);
            }



            foreach (SetupConfiguration item in ThresholdList.Items)
            {
                
                ConfigList.FirstOrDefault(x => x.Measurement == item.Measurement).ThresholdEnabled = item.ThresholdEnabled;
                ConfigList.FirstOrDefault(x => x.Measurement == item.Measurement).ThresholdMax = item.ThresholdMax;
                ConfigList.FirstOrDefault(x => x.Measurement == item.Measurement).ThresholdMin = item.ThresholdMin;
            }
        }
    }
}