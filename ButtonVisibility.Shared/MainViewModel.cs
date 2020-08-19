using System;
using System.ComponentModel;

namespace ButtonVisibility.Shared
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private bool isModifiable = true;
        public bool IsModifiable
        {
            get => isModifiable;
            set
            {
                isModifiable = value;
                RaisePropertyChanged(nameof(IsModifiable));
            }
        }

        public MainViewModel()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
