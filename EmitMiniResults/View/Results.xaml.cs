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
using EmitMiniResults.Helpers;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace EmitMiniResults.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Results : Page
    {
        public Results()
        {
            this.InitializeComponent();
            CreateTopList();
        }

        public void CreateTopList()
        {
            var results = ReadResults.ReadFile("temp");
            var counter = 0;
            foreach (var result in results)
            {
                counter++;
                TextBlock newTextBlock = new TextBlock { Name = "TopResult_" + counter.ToString(), Text = counter + ":" + result.EndResultTime+ "|" + result.CompetitorName, Margin = new Thickness(12, -6, 12, 0) };
                ResultBaseGrid.Children.Add(newTextBlock);
            }
        }

        private void ReadPreviousResults()
        {

        }
    }
}
