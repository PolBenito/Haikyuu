﻿using Haikyuu.Models;
using Haikyuu.ViewModels.Base;
using System.Collections.ObjectModel;

namespace Haikyuu.ViewModels
{
    public class CustomCellViewModel : ViewModelBase
    {
        public ObservableCollection<Personaje> Personajes { get; set; }

        public CustomCellViewModel()
        {
            Personajes = new ObservableCollection<Personaje>
            {
                new Personaje
                {
                    Name = "Shoyo Hinata",
                    Location = "Bloquejador central, Carnada",
                    Details =
                        "Vol arribar a ser com el Petit Gegant",
                    Image =
                        "https://vignette.wikia.nocookie.net/haikyuu/images/c/c2/Rostro_de_Hinata.png/revision/latest?cb=20160210050706&path-prefix=es"
                },
                new Personaje
                {
                    Name = "Tobio Kageyama",
                    Location = "Col·locador",
                    Details =
                        "Juntament amb Hinata, un parella imparable",
                    Image =
                        "https://vignette.wikia.nocookie.net/haikyuu-pedia/images/4/47/Tobio_Kageyama.jpg/revision/latest?cb=20140721131354"
                },
                new Personaje
                {
                    Name = "Daichi Sawamura",
                    Location = "Wing Spikers, Capità",
                    Details =
                        "Especialista en la defensa i una persona necessària per al equip",
                    Image =
                        "https://em.wattpad.com/8bd5055f8ed26c2660a747809f9d943e64c8cfe4/687474703a2f2f36382e6d656469612e74756d626c722e636f6d2f66376362663832383233613034633533343733666561376530336262393933302f74756d626c725f696e6c696e655f6e683373646f464d714a3172696e3631382e6a7067?s=fit&h=758&w=1583&q=80"
                },
                new Personaje
                {
                    Name = "Koshi Sugawara",
                    Location = "Segon col·locador, Segon capità",
                    Details =
                        "No serà titular, però es un dels millors en la seva feina",
                    Image =
                        "https://vignette.wikia.nocookie.net/haikyuu/images/8/8d/Sugawara.png/revision/latest?cb=20150821230947&path-prefix=es"
                },
                new Personaje
                {
                    Name = "Asahi Azumane",
                    Location = "Estrella",
                    Details =
                        "A qui pots recórrer quan estàs en problemes",
                    Image =
                        "https://vignette.wikia.nocookie.net/haikyuu-pedia/images/c/c4/Asahi_Azumane.jpg/revision/latest?cb=20140721131410"
                },
                new Personaje
                {
                    Name = "Yu Nishinoya",
                    Location = "Libero",
                    Details =
                        "El millor en salvar les pilotes impossibles",
                    Image =
                        "https://vignette.wikia.nocookie.net/haikyuu/images/8/80/Y%C5%AB_Nishinoya.png/revision/latest?cb=20170809205325&path-prefix=es"
                },
                new Personaje
                {
                    Name = "Ryunosuke Tanaka",
                    Location = "Wing Spikers",
                    Details =
                        "Vol ser la estrella i té le poder per ser-ho",
                    Image =
                        "https://vignette.wikia.nocookie.net/haikyuu/images/e/e7/RyuTanaka.png/revision/latest?cb=20150107144228&path-prefix=es"
                },
                new Personaje
                {
                    Name = "Kei Tsukishima",
                    Location = "Bloquejador central",
                    Details =
                        "No creguis que només bloqueja, també pensa",
                    Image =
                        "https://vignette.wikia.nocookie.net/haikyuu/images/f/f9/Kei_Tsukishima.png/revision/latest?cb=20170822215947&path-prefix=es"
                },
                new Personaje
                {
                    Name = "Tadashi Yamaguchi",
                    Location = "Pinch Server",
                    Details =
                        "Encara que pensis que no fa res, ell es qui crea oportunitats",
                    Image =
                        "https://pbs.twimg.com/media/C2VZ_kGXcAE3oS2.jpg"
                },
                new Personaje
                {
                    Name = "Keishin Ukai",
                    Location = "Entrenador",
                    Details =
                        "Antic jugador del Karasuno i el seu avi va entrenar al Petit Gegant",
                    Image =
                        "https://vignette.wikia.nocookie.net/haikyuu/images/4/44/KeishinUkai.png/revision/latest?cb=20140616134254"
                },
                new Personaje
                {
                    Name = "Ittetsu Takeda",
                    Location = "Professor",
                    Details =
                        "Gràcies a ell Karasuno obté la seva força",
                    Image =
                        "https://vignette.wikia.nocookie.net/haikyuu/images/d/da/Takeda-sensei.png/revision/latest?cb=20140616135813"
                }
            };
        }
    }
}
