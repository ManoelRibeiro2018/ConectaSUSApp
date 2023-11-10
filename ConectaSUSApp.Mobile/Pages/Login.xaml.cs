namespace ConectaSUSApp.Mobile.Pages;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnLogar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Home());
    }
}