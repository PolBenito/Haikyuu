using Haikyuu.Models;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Haikyuu.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SplashPage : ContentPage
	{
        Image splashImage;
        public SplashPage ()
		{
			InitializeComponent();


            List<Personaje> listaPersonaje;

            listaPersonaje = App.Database.GetItemsAsyncPersonaje().Result;

            if (listaPersonaje.Count == 0)
            {
                Personaje personaje1 = new Personaje();

                personaje1.Name = "Shoyo Hinata";
                personaje1.Location = "Bloquejador central, Carnada";
                personaje1.Details = "Vol arribar a ser com el Petit Gegant";
                personaje1.numPuntuacion = "5";
                personaje1.Image = "https://vignette.wikia.nocookie.net/haikyuu/images/c/c2/Rostro_de_Hinata.png/revision/latest?cb=20160210050706&path-prefix=es";

                App.Database.SaveItemAsyncPersonaje(personaje1);


                Personaje personaje2 = new Personaje();

                personaje2.Name = "Tobio Kageyama";
                personaje2.Location = "Col·locador";
                personaje2.Details = "Juntament amb Hinata, un parella imparable";
                personaje2.numPuntuacion = "5";
                personaje2.Image = "https://vignette.wikia.nocookie.net/haikyuu-pedia/images/4/47/Tobio_Kageyama.jpg/revision/latest?cb=20140721131354";

                App.Database.SaveItemAsyncPersonaje(personaje2);


                Personaje personaje3 = new Personaje();

                personaje3.Name = "Daichi Sawamura";
                personaje3.Location = "Wing Spikers, Capità";
                personaje3.Details = "Especialista en la defensa i una persona necessària per al equip";
                personaje3.numPuntuacion = "5";
                personaje3.Image = "https://em.wattpad.com/8bd5055f8ed26c2660a747809f9d943e64c8cfe4/687474703a2f2f36382e6d656469612e74756d626c722e636f6d2f66376362663832383233613034633533343733666561376530336262393933302f74756d626c725f696e6c696e655f6e683373646f464d714a3172696e3631382e6a7067?s=fit&h=758&w=1583&q=80";

                App.Database.SaveItemAsyncPersonaje(personaje3);


                Personaje personaje4 = new Personaje();

                personaje4.Name = "Koshi Sugawara";
                personaje4.Location = "Segon col·locador, Segon capità";
                personaje4.Details = "No serà titular, però es un dels millors en la seva feina";
                personaje4.numPuntuacion = "5";
                personaje4.Image = "https://vignette.wikia.nocookie.net/haikyuu/images/8/8d/Sugawara.png/revision/latest?cb=20150821230947&path-prefix=es";

                App.Database.SaveItemAsyncPersonaje(personaje4);


                Personaje personaje5 = new Personaje();

                personaje5.Name = "Asahi Azumane";
                personaje5.Location = "Estrella";
                personaje5.Details = "A qui pots recórrer quan estàs en problemes";
                personaje5.numPuntuacion = "5";
                personaje5.Image = "https://vignette.wikia.nocookie.net/haikyuu-pedia/images/c/c4/Asahi_Azumane.jpg/revision/latest?cb=20140721131410";

                App.Database.SaveItemAsyncPersonaje(personaje5);


                Personaje personaje6 = new Personaje();

                personaje6.Name = "Yu Nishinoya";
                personaje6.Location = "Libero";
                personaje6.Details = "El millor en salvar les pilotes impossibles";
                personaje6.numPuntuacion = "5";
                personaje6.Image = "https://vignette.wikia.nocookie.net/haikyuu/images/8/80/Y%C5%AB_Nishinoya.png/revision/latest?cb=20170809205325&path-prefix=es";

                App.Database.SaveItemAsyncPersonaje(personaje6);


                Personaje personaje7 = new Personaje();

                personaje7.Name = "Ryunosuke Tanaka";
                personaje7.Location = "Wing Spikers";
                personaje7.Details = "Vol ser la estrella i té le poder per ser-ho";
                personaje7.numPuntuacion = "5";
                personaje7.Image = "https://vignette.wikia.nocookie.net/haikyuu/images/e/e7/RyuTanaka.png/revision/latest?cb=20150107144228&path-prefix=es";

                App.Database.SaveItemAsyncPersonaje(personaje7);


                Personaje personaje8 = new Personaje();

                personaje8.Name = "Kei Tsukishima";
                personaje8.Location = "Bloquejador central";
                personaje8.Details = "No creguis que només bloqueja, també pensa";
                personaje8.numPuntuacion = "5";
                personaje8.Image = "https://vignette.wikia.nocookie.net/haikyuu/images/f/f9/Kei_Tsukishima.png/revision/latest?cb=20170822215947&path-prefix=es";

                App.Database.SaveItemAsyncPersonaje(personaje8);


                Personaje personaje9 = new Personaje();

                personaje9.Name = "Tadashi Yamaguchi";
                personaje9.Location = "Pinch Server";
                personaje9.Details = "Encara que pensis que no fa res, ell es qui crea oportunitats";
                personaje9.numPuntuacion = "5";
                personaje9.Image = "https://pbs.twimg.com/media/C2VZ_kGXcAE3oS2.jpg";

                App.Database.SaveItemAsyncPersonaje(personaje9);


                Personaje personaje10 = new Personaje();

                personaje10.Name = "Keishin Ukai";
                personaje10.Location = "Entrenador";
                personaje10.Details = "Antic jugador del Karasuno i el seu avi va entrenar al Petit Gegant";
                personaje10.numPuntuacion = "5";
                personaje10.Image = "https://vignette.wikia.nocookie.net/haikyuu/images/4/44/KeishinUkai.png/revision/latest?cb=20140616134254";

                App.Database.SaveItemAsyncPersonaje(personaje10);

                Personaje personaje11 = new Personaje();

                personaje11.Name = "Ittetsu Takeda";
                personaje11.Location = "Professor";
                personaje11.Details = "Gràcies a ell Karasuno obté la seva força";
                personaje11.numPuntuacion = "5";
                personaje11.Image = "https://vignette.wikia.nocookie.net/haikyuu/images/d/da/Takeda-sensei.png/revision/latest?cb=20140616135813";

                App.Database.SaveItemAsyncPersonaje(personaje11);
            }



            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "splashHaikyuu.jpg",
                Aspect = Aspect.Fill,
                WidthRequest = 380
            };

            AbsoluteLayout.SetLayoutFlags(splashImage,
                AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
                new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("#F1913A");
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await splashImage.ScaleTo(1, 2000);
            //await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
            //await splashImage.ScaleTo(150, 1200, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new CustomCellView(null));
        }

    }
}