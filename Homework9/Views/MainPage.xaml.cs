using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Homework9.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
		ListView listView = new ListView();
		List<Contact> contacts;

        public MainPage()
        {
            InitializeComponent();

            SetupData();
            listView.ItemsSource = contacts;

        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                var detailPage = new DetailPage();
                detailPage.BindingContext = e.SelectedItem as Contact;
                listView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }

        void SetupData()
        {
            contacts = new List<Contact>();
            contacts.Add(new Contact
            {
                Name = "Jane Doe",
                Age = 30,
                Occupation = "Developer",
                Country = "USA"
            });
            contacts.Add(new Contact
            {
                Name = "John Doe",
                Age = 34,
                Occupation = "Tester",
                Country = "USA"
            });
            contacts.Add(new Contact
            {
                Name = "John Smith",
                Age = 52,
                Occupation = "PM",
                Country = "UK"
            });
            contacts.Add(new Contact
            {
                Name = "Kath Smith",
                Age = 55,
                Occupation = "Business Analyst",
                Country = "UK"
            });
            contacts.Add(new Contact
            {
                Name = "Steve Smith",
                Age = 19,
                Occupation = "Junior Developer",
                Country = "UK"
            });
        }
    }
}