using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ClinicApp.HelperClasses
{
    internal class AgeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            var now = DateTime.Now;
            var age = now.Year - ((DateTime)value).Year;
            if ((DateTime)value > now.AddYears(-age)) age--;
            return age;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
