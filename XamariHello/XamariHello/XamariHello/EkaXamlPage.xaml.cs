using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamariHello
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EkaXamlPage : ContentPage
	{
		public EkaXamlPage ()
		{
			InitializeComponent ();
		}
	}
}