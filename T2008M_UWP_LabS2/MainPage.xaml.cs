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
using T2008M_UWP_LabS2.Models;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T2008M_UWP_LabS2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary> 

    public sealed partial class MainPage : Page
    {
        public static Frame MainFrame;
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Pages.Home));
            MainFrame = MyFrame;
            
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                string currentPage = MyFrame.SourcePageType.FullName;
                if (currentPage.Contains("Home"))
                {
                    Home.IsSelected = true;
                } 
                else if (currentPage.Contains("Contacts.Index"))
                {
                    ContactsPage.IsSelected = true;
                }
                else if (currentPage.Contains("Customers.Index"))
                {
                    Customers.IsSelected = true;
                }
                else if (currentPage.Contains("Mails.Index"))
                {
                    Mails.IsSelected = true;
                }
            }
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Home.IsSelected)
            {
                MyFrame.Navigate(typeof(Pages.Home));
            } 
            else if (ContactsPage.IsSelected)
            {
                MyFrame.Navigate(typeof(Pages.Contacts.Index));
            }
            else if (Customers.IsSelected)
            {
                MyFrame.Navigate(typeof(Pages.Customers));
            }
            else if (Mails.IsSelected)
            {
                MyFrame.Navigate(typeof(Pages.Mails));
            }
        }
    }
}
