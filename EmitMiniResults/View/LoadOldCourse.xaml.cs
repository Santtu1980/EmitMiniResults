using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MTRSerial;
using MTRSerial.Enumerations;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace EmitMiniResults.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoadOldCourse : Page
    {
        public LoadOldCourse()
        {
            this.InitializeComponent();
            MTRSerial.MTRSerialPort _serialPort = new MTRSerialPort();
            _serialPort.AskFromMTR(CommandsToMTR.CommandName.Status);
        }

        private StorageFile _loadedCourse = null;

        private void BtnBrowseForFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }

        private async void OpenFile()
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            //picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".txt");

            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
            if(file != null)
            {
                _loadedCourse = file;
                // Application now has read/write access to the picked file
                this.TxtFileName.Text = Path.Combine(file.Path, file.Name);
            }
            else
            {
                this.TxtFileName.Text = "Operation cancelled.";
            }
        }

        private void BtnLoadOldCourse_Click(object sender, RoutedEventArgs e)
        {
            ReadCourseFromFileToMemory();
            //TxtFileName.Text = _text;
        }

        private string _text = "";
        private async void ReadCourseFromFileToMemory()
        {

            // Read file
            _text = await FileIO.ReadTextAsync(_loadedCourse);
        }
    }
}
