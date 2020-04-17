using System;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace HubTile_Data_Binding
{
    /// <summary>
    /// Represents a converter class
    /// </summary>
    public class ImageConverter : IValueConverter
    {
        /// <summary>
        /// Invoked when the string needs to be converted into ImagePath
        /// </summary>
        /// <param name="value">Specifies the image path</param>
        /// <param name="targetType">Specifies the target type </param>
        /// <param name="parameter">Specifies the object parameter</param>
        /// <param name="culture">Specifies the culture</param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                string str = value.ToString();
                var image = new Image();
                image.Source = new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                return image.Source;
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Method for convertback
        /// </summary>
        /// <param name="value">Specifies the image path </param>
        /// <param name="targetType">Specifies the target type</param>
        /// <param name="parameter">Speifies the object parameter</param>
        /// <param name="culture">Specifies the culture</param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }
    }
}

