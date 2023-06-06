using Times_do_Brasil.ViewModels;

namespace Times_do_Brasil;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}
