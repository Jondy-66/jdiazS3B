namespace jdiazS3B.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		string usuario = txtUsuarior.Text;
		string contraseña = txtContraseñar.Text;

		Navigation.PushAsync(new Views.Login(usuario, contraseña));
    }
}