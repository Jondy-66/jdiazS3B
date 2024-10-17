namespace jdiazS3B.Views;

public partial class Login : ContentPage
{
    string user = "x", pass = "y";
    public Login()
	{
		InitializeComponent();
	}

    public Login(string usuario, string contraseña )
    {
        InitializeComponent();
        user = usuario;
        pass = contraseña;
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        if (user == txtUsuario.Text && pass == txtContraseña.Text) 
        {
            Navigation.PushAsync(new Views.Home());
        }
        else
        {
            DisplayAlert("ERROR", "Usuario/Contraseña Incorrectos", "Cerrar");
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.Registro());
    }
}