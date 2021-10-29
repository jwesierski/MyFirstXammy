using System;
using System.Collections.Generic;
using System.ComponentModel;
using MyFirstXammy.Models;
using MyFirstXammy.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstXammy.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}