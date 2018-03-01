using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CustomRenderer
{
    internal class HybridWebViewModel : INotifyPropertyChanged
    {
        bool _isBusy = true;
        public bool IsVisibleWeb
        {
            get
            {
                return _isBusy;
            }
            set
            {
                _isBusy = value;
                OnPropertyChanged(nameof(IsVisibleWeb));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}