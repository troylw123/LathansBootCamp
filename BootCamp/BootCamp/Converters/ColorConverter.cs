using System;
using System.Globalization;
using Xamarin.Forms;

namespace BootCamp.Converters
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var colorValue = (value as string).ToUpper();

            Color color = Color.FromHex(colorValue);

            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
