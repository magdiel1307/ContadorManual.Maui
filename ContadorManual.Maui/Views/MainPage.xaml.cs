using ContadorManual.Maui.Models;

namespace ContadorManual.Maui.Views;

public partial class MainPage : ContentPage
{
    private Contador _contador;

    public MainPage()
    {
        InitializeComponent();
        _contador = new Contador();
        LabelConteo.Text = _contador.conteo.ToString();
    }

    private void OnContarButtonClicked(object sender, EventArgs e)
    {
        _contador.Contar();
        LabelConteo.Text = _contador.conteo.ToString();
    }

    private void OnReiniciarButtonClicked(object sender, EventArgs e)
    {
        _contador.Reiniciar ();
        LabelConteo.Text = _contador.conteo.ToString();

    }

}