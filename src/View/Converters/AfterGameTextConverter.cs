using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace View.Converters
{
    class AfterGameTextConverter : IValueConverter
    {
        public object InProgress { get; set; }
        public object Won { get; set; }
        public object Lost { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var text = (GameStatus)value;
            switch (text)
            {
                case GameStatus.InProgress:
                    return InProgress;
                case GameStatus.Won:
                    return Won;
                case GameStatus.Lost:
                    return Lost;
                default:
                    throw new InvalidCastException();
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
