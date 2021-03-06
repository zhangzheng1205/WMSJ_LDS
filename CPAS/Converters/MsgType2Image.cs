﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Media.Imaging;
namespace CPAS.Converters
{
    public class MsgType2Image : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            CPAS.Models.MSGTYPE msg = (CPAS.Models.MSGTYPE)value;
            BitmapImage bitmap = null;
            switch (msg)
            { 
                case Models.MSGTYPE.INFO:
                    bitmap = new BitmapImage(new Uri(@"..\Images\Info24_24.png",UriKind.Relative));
                    break;
                case Models.MSGTYPE.WARNING:
                    bitmap = new BitmapImage(new Uri(@"..\Images\Warning24_24.png", UriKind.Relative));
                    break;
                case Models.MSGTYPE.ERROR:
                    bitmap = new BitmapImage(new Uri(@"..\Images\Error24_24.png", UriKind.Relative));
                    break;
                default:
                    break;
            }
            return bitmap;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
