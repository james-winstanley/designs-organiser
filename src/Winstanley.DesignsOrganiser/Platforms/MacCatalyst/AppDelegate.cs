using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Winstanley.DesignsOrganiser
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}