using System.Text.Json;

namespace CTApucarana;

public partial class MainPage : ContentPage
{
	const string url="https://api.hgbrasil.com/weather?woeid=455927&key=4e5acb36";
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
						PreencherTela();
			
					}
			}
					
            catch(Exception e)
            {
				
            }

	}


	public MainPage()
	{
		InitializeComponent();

		UpdateTime();

	}
	

		void PreencherTela()
			{
				Labeltemp.Text = resposta.results.temp.ToString();
				//Ceu.Text= resposta.results.description;
				Cidade.Text= resposta.results.city;
				Rain.Text= resposta.results.rain.ToString();
				Umidade.Text= resposta.results.humidity.ToString();
				HoraDoAmanhecer.Text= resposta.results.sunrise;
				HoraDoAnoitecer.Text= resposta.results.sunset;
				ForcaDoVento.Text= resposta.results.windSpeed.ToString();
				DirecaoDoVento.Text= resposta.results.windDirection.ToString();
				//labelWindCardinal.text=resposta.results.windCardinal;
				FaseDaLua.Text= resposta.results.moonPhase;
				//labelCloudness.text= resposta.results.cloudness;
                
					
					
					if (resposta.results.currently=="dia")
					{
						if (resposta.results.rain>=10)
							background.Source="diachuva.png";
						else if (resposta.results.cloudness>=10)
							background.Source="dianublado.png";
						else
							background.Source="diaclaro.png";
					}
				else
					{
						if (resposta.results.rain>=10)
							background.Source="noitechuva.png";
						else if (resposta.results.cloudness>=10)
							background.Source="noitenublada.png";
						else
							background.Source="noiteestrelada.png";
					}
			}
			


	}

