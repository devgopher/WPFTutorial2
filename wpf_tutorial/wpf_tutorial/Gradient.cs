using System;
using System.Reflection;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using System.Globalization;
using System.Windows.Media;

namespace wpf_tutorial
{
    public class Gradient : IValueConverter
    {
        public String Color1
        {
            get; set; 
        }

        public String Color2
        {
            get; set;
        }

        public Gradient()
        {
        }

        public object Convert(object input, Type type, object param, CultureInfo ci)
        {
            GradientBrush gb = null;

            gb = new LinearGradientBrush(
                (Color)ColorConverter.ConvertFromString(Color1),
                (Color)ColorConverter.ConvertFromString(Color2),
                10.5
               );

            return gb;
        }


        public object ConvertBack(object input, Type type, object param, CultureInfo ci)
        {
            return null;
        }
    }
}
