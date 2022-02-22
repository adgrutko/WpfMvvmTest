using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfMvvmTest
{
    class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var c = (Core.Helpers.Color)value;
            return c switch
            {
                Core.Helpers.Color.DARKBLUE => Brushes.DarkBlue,
                Core.Helpers.Color.GREEN => Brushes.Green,
                Core.Helpers.Color.YELLOW => Brushes.Yellow,
                _ => Brushes.DeepPink,
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
