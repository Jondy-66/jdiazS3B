namespace jdiazS3B.Views;

public partial class Login : ContentPage
{
    string user = "x", pass = "y";
    public Login()
	{
		InitializeComponent();
	}

    public Login(string usuario, string contrase�a )
    {
        InitializeComponent();
        user = usuario;
        pass = contrase�a;
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        if (user == txtUsuario.Text && pass == txtContrase�a.Text) 
        {
            Navigation.PushAsync(new Views.Home());
        }
        else
        {
            DisplayAlert("ERROR", "Usuario/Contrase�a Incorrectos", "Cerrar");
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.Registro());
    }
}