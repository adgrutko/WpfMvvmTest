using System.Collections.ObjectModel;
using System.ComponentModel;
using WpfMvvmTest.Core.Helpers;

namespace WpfMvvmTest.Core.ViewModels
{
    public class InvokeCommandPageViewModel : INotifyPropertyChanged
    {
        public RelayCommand ColorCommand { get; private set; }

        private Color _currentColor = Color.DARKBLUE;
        public Color CurrentColor 
        {
            get => _currentColor;
            set
            {
                _currentColor = value;
                OnPropertyChanged(nameof(CurrentColor));
            }
        }

        private bool _isReleased = true;
        public bool IsReleased 
        { 
            get => _isReleased;
            set
            {
                _isReleased = value;
                OnPropertyChanged(nameof(IsReleased));
            }
        }

        public ObservableCollection<ColorPair> ColorPairs { get; private set; } = new ObservableCollection<ColorPair>
        {
            new ColorPair(Color.DEEPPINK, Color.DARKBLUE),
            new ColorPair(Color.GREEN, Color.YELLOW),
        };

        private ColorPair _selectedPair = new ColorPair(Color.DEEPPINK, Color.DARKBLUE);
        public ColorPair SelectedPair
        {
            get => _selectedPair;
            set
            {
                _selectedPair = value;
                OnPropertyChanged(nameof(SelectedPair));
            }
        }

        public InvokeCommandPageViewModel()
        {
            ColorCommand = new RelayCommand(
                (object? argument) => ChangeColor(), 
                (object? argument) => IsReleased);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private bool colorSwitch = false;
        public void ChangeColor()
        {
            if (colorSwitch)
                CurrentColor = SelectedPair.First;
            else
                CurrentColor = SelectedPair.Second;
            colorSwitch = !colorSwitch;
        }
    }
}
