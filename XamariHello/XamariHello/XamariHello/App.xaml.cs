using System;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamariHello
{
	public partial class App : Application
	{
        private Entry syötekenttä;
        private Label arvauksenTulosLabel;

        private int oikeaLuku;
        private int arvaustenLukumäärä;

        public App()
        {
            Random rnd = new Random();
            oikeaLuku = rnd.Next(1, 21);
            arvaustenLukumäärä = 0;

            // painonapin alustus
            Button arvaaNappi = new Button();
            arvaaNappi.Text = "Arvaa";
            arvaaNappi.Clicked += ArvaaNappi_Clicked;

            syötekenttä = new Entry
            {
                Keyboard = Keyboard.Numeric,
                Text = ""
            };

            arvauksenTulosLabel = new Label();
            arvauksenTulosLabel.Text = "";

            // esimerkki XAML-sivun käytöstä
            //MainPage = new EkaXamlSivu();

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    //VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Arvaa luku -peli",
                            TextColor = Color.Yellow
                        },
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Sovellusversio 0.10",
                            TextColor = Color.Silver
                        },
                        syötekenttä,
                        arvaaNappi,
                        arvauksenTulosLabel
                    }
                }
            };
        }

        //private async void ArvaaNappi_Clicked(object sender, EventArgs e)
        private void ArvaaNappi_Clicked(object sender, EventArgs e)
        {
            int arvaus = int.Parse(syötekenttä.Text);
            if (arvaus < oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Luku on suurempi.";
                arvaustenLukumäärä++;
            }
            else if (arvaus > oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Luku on pienempi.";
                arvaustenLukumäärä++;
            }
            else if (arvaus == oikeaLuku)
            {
                arvauksenTulosLabel.Text = "Jee! Täsmälleen oikein!";
                Random rnd = new Random();
                oikeaLuku = rnd.Next(1, 21);

                //HttpClient webClient = new HttpClient();
                //string url = "http://localhost:2440/home/TallennaEnnatys/" + arvaustenLukumäärä;
                //string jsonVastaus = await webClient.GetStringAsync(url); //await = viittaus asynkroniseen metodiin GetStrinAsync

                arvaustenLukumäärä = 0;
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
