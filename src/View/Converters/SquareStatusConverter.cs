using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace View.Converters
{
    class SquareStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var squareStatus = (SquareStatus)value;
            switch (squareStatus)
            {
                case SquareStatus.Uncovered:
                    return Brushes.Red;
                case SquareStatus.Flagged:
                    return Brushes.Orange;
                case SquareStatus.Covered:
                    return Brushes.Transparent;
                case SquareStatus.Mine:
                    return Brushes.Black;
                default:
                    throw new InvalidCastException();
            }

            return Brushes.Red;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
