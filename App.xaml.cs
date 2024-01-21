namespace pcaceresS4;

public partial class App : Application
{	
	public static PersonaRepository personRepo { get; set; }

	public App( PersonaRepository personaRepository)
	{
		InitializeComponent();

		MainPage = new Vistas.vPrincipal();
		personRepo = personaRepository;
	}
}
