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
        public object Uncovered { get; set; }
        public object Covered { get; set; }
        public object Mine { get; set; }
        public object Flagged { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var squareStatus = (SquareStatus)value;
            switch (squareStatus)
            {
                case SquareStatus.Uncovered:
                    return Uncovered;
                case SquareStatus.Flagged:
                    return Flagged;
                case SquareStatus.Covered:
                    return Covered;
                case SquareStatus.Mine:
                    return Mine;
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
