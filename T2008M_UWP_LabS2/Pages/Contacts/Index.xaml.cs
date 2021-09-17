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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2008M_UWP_LabS2.Pages.Contacts
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Index : Page
    {
        public static List<Contact> ClassContacts = ContactManager.GetContacts();
        private List<Contact> Contacts;
        public Index()
        {
            this.InitializeComponent();
            Contacts = ClassContacts;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage.MainFrame?.Navigate(typeof(Add));
        }
    }
}
