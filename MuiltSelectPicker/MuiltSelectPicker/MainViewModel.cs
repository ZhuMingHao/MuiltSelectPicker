using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MuiltSelectPicker
{
    public class MainViewModel
    {
        public ObservableCollection<Item> itemSource = new ObservableCollection<Item>();
        public MainViewModel()
        {
            itemSource.Add(new Item { Content = "NicoZhu", IsCheck = false });
            itemSource.Add(new Item { Content = "SunteenWu", IsCheck = false });
            itemSource.Add(new Item { Content = "Shengyang", IsCheck = false });
            itemSource.Add(new Item { Content = "LiuSong", IsCheck = false });
            itemSource.Add(new Item { Content = "Zhagu", IsCheck = false });
        }

    }
    public class Item : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyname = null)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
        public string Content { get; set; }

        private bool _isChick;
        public bool IsCheck
        {
            get
            {
                return _isChick;
            }
            set
            {
                _isChick = value;
                OnPropertyChanged();
            }
        }
    }
}
