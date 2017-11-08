using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MuiltSelectPicker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MyPicker.ItemsSource = new MainViewModel().itemSource;
            MyPicker.RegisterAction(IsCheckItems);
        }
        private List<Item> SelecItms = new List<Item>();
        private void IsCheckItems(object data)
        {
            var items = data as ObservableCollection<Item>;
            var str = new StringBuilder();
            foreach (var item in items)
            {
                if (item.IsCheck)
                {
                    SelecItms.Add(item);
                    str.AppendLine(item.Content);
                }
            }
            SeleitemLabel.Text = str.ToString();
        }
    }
}
