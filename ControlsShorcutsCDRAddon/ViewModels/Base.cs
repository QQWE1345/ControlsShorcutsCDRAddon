using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace ControlsShorcutsCDRAddon.ViewModels
{
    public class Base : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnNotifyPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
