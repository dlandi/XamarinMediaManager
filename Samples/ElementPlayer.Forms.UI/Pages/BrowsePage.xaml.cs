﻿using ElementPlayer.Core.ViewModels;
using MvvmCross.Forms.Views;
using Xamarin.Forms.Xaml;

namespace ElementPlayer.Forms.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrowsePage : MvxContentPage<BrowseViewModel>
    {
        public BrowsePage()
        {
            InitializeComponent();
        }
    }
}
