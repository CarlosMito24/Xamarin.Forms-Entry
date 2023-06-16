namespace Xamarin.Forms_Entry;

///<Summary>
///<Createddate> 2022/06/16 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2022/06/16 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el diseño y se configuró el código cs de la app
///</lastmodificationdescription>
///<lastmodifierautor> Carlos Mito </lastmodifierautor>
///</Summary>

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void Entry_Changed (object sender, TextChangedEventArgs e)
	{
		string pasado = e.OldTextValue;
		string nuevo = e.NewTextValue;
	}

    private void Entry_Completed(object sender, EventArgs e)
    {
		string text = ((Entry)sender).Text;
    }
}