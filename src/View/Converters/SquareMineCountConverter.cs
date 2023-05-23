using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace View.Converters
{
    class SquareMineCountConverter : IValueConverter
    {
        public object Zero { get; set; }
        public object One { get; set; }
        public object Two { get; set; }
        public object Three { get; set; }
        public object Four { get; set; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var squareMineCount = (int)value;
            switch (squareMineCount)
            {
                case 0:
                    return Zero;
                case 1:
                    return One;
                case 2:
                    return Two;
                case 3:
                    return Three;
                case 4:
                    return Four;
                default:
                    return Zero;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
