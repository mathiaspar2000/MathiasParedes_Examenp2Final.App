namespace MathiasParedes_Examenp2Final;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnAlertYesNoClicked(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Sistema de validacion", "Desea realizar la recargar?", "Si", "No");
        await DisplayAlert("Correcto", "La Recarga se hizo de manera exitosa", "Continuar");
    }
}

