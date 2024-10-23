namespace AperezDS2.Views;

public partial class VLogin : ContentPage
{
    private string[] users = { "Carlos", "Ana", "Jose" };
    private string[] passwords = { "carlos123", "ana123", "jose123" };
    public VLogin()
	{
		InitializeComponent();
	}
    private void OnLoginClicked(object sender, EventArgs e)
    {
        
        string enteredUser = UserEntry.Text;
        string enteredPass = PassEntry.Text;

        
        for (int i = 0; i < users.Length; i++)
        {
            if (users[i].Equals(enteredUser, StringComparison.OrdinalIgnoreCase) &&
                passwords[i].Equals(enteredPass))
            {
                
                DisplayAlert("Bienvenido", $"¡Bienvenido {users[i]}!", "Cerrar");

                
                Navigation.PushAsync(new vHome());
                return;
            }
        }

        
        LoginStatusLabel.Text = "Usuario o contraseña incorrectos";
    }
}

