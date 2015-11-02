using System;
using System.Globalization;
using System.Windows.Data;
using Caliburn.Micro;

namespace CShell.Framework.Converters
{
	public class LayoutItemViewConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var view = ViewLocator.LocateForModel(value, null, null);
			Bind.SetModel(view, value);
			return view;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
		    return null;
		    //throw new NotImplementedException();
		}
	}
}