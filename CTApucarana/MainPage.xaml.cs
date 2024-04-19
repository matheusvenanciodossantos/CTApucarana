namespace CTApucarana;

public partial class MainPage : ContentPage
{
	Results Resultados;



	public MainPage()
	{
		InitializeComponent();

		 Resultados = new Results();
		 LayoutTest();
		 PreencherTela();

	}
	
		void LayoutTest()
			{
				Resultados.temp=21;
				Resultados.description="Nublado";
				Resultados.city="Apucarana-PR";
				Resultados.humidity=88;
				Resultados.rain=88.2;
				Resultados.sunrise="6:22";
				Resultados.sunset="18:44";
				Resultados.windSpeed="Norte";
				Resultados.windDirection=300;
				Resultados.moonPhase="Nov";
				Resultados.cloudness=10;
				Resultados.windCardinal="Leste";
				Resltados.currently;

			}

		void PreencherTela()
			{
				Temperatura.Text= Resultados.temp.ToString();
				//Ceu.Text= Resultados.description;
				//Cidade.Text= Resultados.city;
				Rain.Text= Resultados.rain.ToString();
				Umidade.Text= Resultados.humidity.ToString();
				HoraDoAmanhecer.Text= Resultados.sunrise;
				HoraDoAnoitecer.Text= Resultados.sunset;
				ForcaDoVento.Text= Resultados.windSpeed.ToString();
				DirecaoDoVento.Text= Resultados.windDirection.ToString();
				//labelWindCardinal.text=Resultados.windCardinal;
				FaseDaLua.Text= Resultados.moonPhase;
				//labelCloudness.text= Resultados.cloudness;

				Rain.Text=Resultados.rain.ToString();
					if(Resultados.currently=="dia")
					{
						if (Resultados.Rain>=10)
							background.Source = "chuva.jpg";
						else if (Resultados.cloudness>=10)
							background.Source="nublado.jpg";
						else
							bacground.Source="diaclaro.jpg";

					}
			}
	


}