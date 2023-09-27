

using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace CacaoAcademy.ViewModels
{
    public class MainPageViewModel : BindableObject
    {
        public ObservableCollection<ItemViewModel> Items { get; } = new ObservableCollection<ItemViewModel>();

        public MainPageViewModel()
        {
            // Add sample items
            Items.Add(new ItemViewModel { ImageSource = "image1.jpg", Text = "Item 1" });
            Items.Add(new ItemViewModel { ImageSource = "image2.jpg", Text = "Item 2" });
            // Add more items as needed
        }
    }

    public class ItemViewModel : BindableObject
    {
        public string ImageSource { get; set; }
        public string Text { get; set; }
    }
}
