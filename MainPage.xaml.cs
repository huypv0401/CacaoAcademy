using CacaoAcademy.ViewModels;
using Microsoft.Maui.Controls;

namespace CacaoAcademy
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void ItemCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Handle item selection and navigation to child page here
            if (e.CurrentSelection.FirstOrDefault() is ItemViewModel selectedItem)
            {
                // Navigate to a child page with the selected item
                //Navigation.PushAsync(new ChildPage(selectedItem));
                // Clear selection after navigation
                ItemCollectionView.SelectedItem = null;
            }
        }
    }
}
