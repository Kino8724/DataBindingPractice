using DataBindingPractice.Models;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DataBindingPractice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Customer> Customers { get; } = new ObservableCollection<Customer>();
        public MainPage()
        {
            this.InitializeComponent();

            this.Customers.Add(new Customer() { Name="Wyatt"});
            this.Customers.Add(new Customer() { Name="Grace"});
            this.Customers.Add(new Customer() { Name="Walker"});

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string tag = button.Tag.ToString();
            for (int i = 0; i < Customers.Count; i++)
            {
                if (Customers[i].Name == tag)
                {
                    Customers.RemoveAt(i);
                }
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string newCustomer = AddCustomerTextBox.Text;
            Customers.Add(new Customer() { Name=newCustomer });
        }

        private void AddCustomerTextBox_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if(e.Key== Windows.System.VirtualKey.Enter)
            {
                string newCustomer = AddCustomerTextBox.Text;
                Customers.Add(new Customer() { Name=newCustomer });
            }

        }
    }
}
