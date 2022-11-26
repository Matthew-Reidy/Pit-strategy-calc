using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Overlays
{
    /// <summary>
    /// Interaction logic for FuelOverlay.xaml
    /// </summary>
    public partial class FuelOverlay : Window
    {
        /// <summary>
        /// import SetWindowLongPtr32 to use functions that manipulate window settings
        /// </summary>
        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtrA")]
        private static extern IntPtr SetWindowLongPtrA(IntPtr hWnd, int nIndex, IntPtr dwNewLong);
        /// <summary>
        /// import GetWindowLongPtr32 to get information about window settings
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="nIndex"></param>
        /// <param name="dwNewLong"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "SetWindowLongPtrA")]
        private static extern IntPtr GetWindowLongPtrA(IntPtr hWnd, int nIndex);

        [Serializable]
        public struct FuelOverlaySettings
        {
            public decimal transparency;
            public double[] position;
            public bool isClickThrough;
        }
        //settings for the overlay
        public FuelOverlaySettings settings = new();
        private const int GWL_EXSTYLE = (-20);
        private const int WS_EX_TRANSPARENT = 0x00000020;
        public FuelOverlay(FuelOverlaySettings newSettings)
        {
            InitializeComponent();
            
            if (newSettings.position == null)
            {
                newSettings.position = new double[2];
                newSettings.position[0] = 256;
                newSettings.position[1] = 256;
            }
            settings = newSettings;
            switch (settings.isClickThrough)
            {
                case true:
                    makeClickthrough();
                    break;
                case false:
                    makeClickable();
                    break;

            }
            RestoreSettings();
        }
        /// <summary>
        /// implementation of ResetSettings
        /// </summary>
        public void ResetSettings()
        {

        }
        /// <summary>
        /// implementation of SaveSettings
        /// </summary>
        public FuelOverlaySettings GetSettings()
        {
            settings.position[0] = Left;
            settings.position[1] = Top;
            return settings;
        }
        /// <summary>
        /// implementation of RestoreSettings
        /// </summary>
        public void RestoreSettings()
        {
            {
                Left = settings.position[0];
                Top = settings.position[1];
                ChangeTransparency(settings.transparency/100);
            }
        }
        ///<summary>
        ///implementation of ResetPosition
        /// </summary>
        public void ResetPosition()
        {

        }
        ///<summary>
        /// implementation of ChangeTransparency
        /// </summary>
        public void ChangeTransparency(decimal transparency)
        {
            Background.Opacity = (double)transparency;
            settings.transparency = transparency * 100;
        }        
        /// <summary>
        /// update the average row of data
        /// </summary>
        public void UpdateAverage(decimal fillTo, decimal lapsRemaining, decimal fuelAtEnd)
        {
            lblPitInAvg.Dispatcher.Invoke(() => { lblPitInAvg.Content = lapsRemaining; });
            lblAddAvg.Dispatcher.Invoke(() => lblAddAvg.Content = fillTo);
            lblAfterPitAvg.Dispatcher.Invoke(() => lblAfterPitAvg.Content = fuelAtEnd);
        }
        /// <summary>
        /// update the maximal row of data
        /// </summary>
        public void UpdateMax(decimal fillTo, decimal lapsRemaining, decimal fuelAtEnd)
        {
            lblPitInMax.Dispatcher.Invoke(() => { lblPitInMax.Content = lapsRemaining; });
            lblAddMax.Dispatcher.Invoke(() => lblAddMax.Content = fillTo);
            lblAfterPitMax.Dispatcher.Invoke(() => lblAfterPitMax.Content = fuelAtEnd);
        }
        /// <summary>
        /// update the minimal row of data
        /// </summary>
        public void UpdateMin(decimal fillTo, decimal lapsRemaining, decimal fuelAtEnd)
        {
            lblPitInMin.Dispatcher.Invoke(() => { lblPitInMin.Content = lapsRemaining; });
            lblAddMin.Dispatcher.Invoke(() => lblAddMin.Content = fillTo);
            lblAfterPitMin.Dispatcher.Invoke(() => lblAfterPitMin.Content = fuelAtEnd);
        }
        /// <summary>
        /// permits moving the overlay despite not having a border to grab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }/*
        public bool isClickthrough()
        {
            return settings.isClickThrough;
        }*/
        public void makeClickthrough()
        {
            IntPtr hwnd = new System.Windows.Interop.WindowInteropHelper(this).Handle;
            int extendedStyle = (int)GetWindowLongPtrA(hwnd, GWL_EXSTYLE);
            SetWindowLongPtrA(hwnd, GWL_EXSTYLE, extendedStyle | WS_EX_TRANSPARENT);
            settings.isClickThrough= true;
        }
        public void makeClickable()
        {
            IntPtr hwnd = new System.Windows.Interop.WindowInteropHelper(this).Handle;
            int extendedStyle = (int)GetWindowLongPtrA(hwnd, GWL_EXSTYLE);
            SetWindowLongPtrA(hwnd, GWL_EXSTYLE, extendedStyle & ~WS_EX_TRANSPARENT);
            settings.isClickThrough = false;
        }
    }
}
