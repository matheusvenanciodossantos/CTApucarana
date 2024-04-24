using System.Text.Json;

namespace CTApucarana;

public partial class MainPage : ContentPage
{
	const string url="https://api.hgbrasil.com/weather?woeid=455927&key=4e5acb36";
	Results results;
	Resposta resposta;
	async void UpdateTime()
    {
            try
            {
                var HttpClient = new HttpClient();
                var Response = await HttpClient.GetAsync(url);
                if (Response.IsSuccessStatusCode)
                    {
                        var content = await Response.Content.ReadAsStringAsync();
                        resposta = JsonSerializer.Deserialize<Resposta>(content);
					}
						PreencherTela();
			
            }
            catch(Exception e)
            {
				//Erro
            }
    }



	public MainPage()
	{
		InitializeComponent();

		 
		 LayoutTest();
		 PreencherTela();
		 UpdateTime();

	}
	
		void LayoutTest()
			{
				resposta.temp=21;
				resposta.description="Nublado";
				resposta.city="Apucarana-PR";
				resposta.humidity=88;
				resposta.rain=88.2;
				resposta.sunrise="6:22";
				resposta.sunset="18:44";
				resposta.windSpeed="Norte";
				resposta.windDirection=300;
				resposta.moonPhase="Nov";
				resposta.cloudness=10;
				resposta.windCardinal="Leste";
				resposta.currently="Dia";

			}

		void PreencherTela()
			{
				Labeltemp.Text = resposta.temp.ToString();
				//Ceu.Text= resposta.description;
				Cidade.Text= resposta.city;
				Rain.Text= resposta.rain.ToString();
				Umidade.Text= resposta.humidity.ToString();
				HoraDoAmanhecer.Text= resposta.sunrise;
				HoraDoAnoitecer.Text= resposta.sunset;
				ForcaDoVento.Text= resposta.windSpeed.ToString();
				DirecaoDoVento.Text= resposta.windDirection.ToString();
				//labelWindCardinal.text=resposta.windCardinal;
				FaseDaLua.Text= resposta.moonPhase;
				//labelCloudness.text= resposta.cloudness;
                Rain.Text=resposta.rain.ToString();
					
					
					if(resposta.currently=="dia")
					{
						if (resposta.rain>=10)
							background.Source = "diachuva.jpg";
						else if (resposta.cloudness>=10)
							background.Source="dianublado.jpg";
						else
							background.Source="dia.jpg";

					}
			


	}
}