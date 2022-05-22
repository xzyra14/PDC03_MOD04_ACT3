using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_MOD2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity3 : ContentPage
    {
        public Activity3()
        {
            InitializeComponent();

            //lst.ItemsSource = new List<String>()
            //{ 
            //    // Collection of String
            //    "One", "Two", "Three", "Four", "Five"
            //};

            lst.ItemsSource = new List<Contacts>()
            {
                new Contacts()
                {
                    Name = "Xzyra L. Lapid",
                    Number = "09759843504"
                },
                new Contacts()
                {
                    Name = "Stephanie Lopez",
                    Number = "09123456789"
                },
                new Contacts()
                {
                    Name = "Irvin Justin M. Naguit",
                    Number = "09198765432"
                },
            };
        }
    }
}