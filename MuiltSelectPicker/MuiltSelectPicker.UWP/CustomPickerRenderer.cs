using MuiltSelectPicker;
using MuiltSelectPicker.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]

namespace MuiltSelectPicker.UWP
{
    public class CustomPickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            Control.ItemsSource = e.NewElement.ItemsSource;
            Control.ItemTemplate = (Windows.UI.Xaml.DataTemplate)App.Current.Resources["templateEmployee"];
            Control.DropDownClosed += Control_DropDownClosed;

        }

        private void Control_DropDownClosed(object sender, object e)
        {
            var NewElement = Element as CustomPicker;
            var items = (sender as ComboBox).ItemsSource;
            NewElement.InvokeAction(items);
        }

    }
}
