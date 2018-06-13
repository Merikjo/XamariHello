using System;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamariHello
{
	public partial class App : Application
	{
        private Entry sy�tekentt�;
        private Label arvauksenTulosLabel;

        private int oikeaLuku;
        private int arvaustenLukum��r�;

        public App()
        {
            Random rnd = new Random();
            oikeaLuku = rnd.Next(1, 21);
            arvaustenLukum��r� = 0;

            // painonapin alustus
            Button arvaaNappi = new Button();
            arvaaNappi.Text = "Arvaa";
            arvaaNappi.Clicked += ArvaaNappi_Clicked;

            sy�tekentt� = new Entry
            {
                Keyboard = Keyboard.Numeric,
                Text = ""
            };

            arvauksenTulosLabel = new Label();
            arvauksenTulosLabel.Text = "";

            // esimerkki XAML-sivun k�yt�st�
            //MainPage = new EkaXamlSivu();

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Hello Xamarin!",
                            TextColor = Color.Blue
                        },
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Sovellusversio 0.10",
                            TextColor = Color.Silver
                        },

                    //Arvaa luku -pelin koodit:
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Arvaa luku -peli",
                            TextColor = Color.Gray
                        },
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Arvaa luku 1 -21 v�lill�",
                            TextColor = Color.Silver
                        },
                        sy�tekentt�,
                        arvaaNappi,
                        arvauksenTulosLabel
                    }   // Arvaa luku -pelin koodit
                }
                
            };        
        }

        //private async void ArvaaNappi_Clicked(object sender, EventArgs e)
        private void ArvaaNappi_Clicked(object sender, EventArgs e)
        {
            int arvaus = int.Parse(sy�tekentt�.Text);
            if (arvaus < oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Luku on suurempi.";
                arvaustenLukum��r�++;
            }
            else if (arvaus > oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Luku on pienempi.";
                arvaustenLukum��r�++;
            }
            else if (arvaus == oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Jee! T�sm�lleen oikein!";
                Random rnd = new Random();
                oikeaLuku = rnd.Next(1, 21);

                //HttpClient webClient = new HttpClient();
                //string url = "http://localhost:2440/home/TallennaEnnatys/" + arvaustenLukum��r�;
                //string jsonVastaus = await webClient.GetStringAsync(url); //await = viittaus asynkroniseen metodiin GetStrinAsync

                arvaustenLukum��r� = 0;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
