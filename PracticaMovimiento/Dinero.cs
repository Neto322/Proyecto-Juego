using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PracticaMovimiento
{
    class Dinero
    {
        public double PosicionX { get; set; }
        public double PosicionY { get; set; }

        List<BitmapImage> estado = new List<BitmapImage>();

        public Image Imagen;

        public int Puntos { get; set; }

        int numerorandom { get; set; }

        Random rnd;

        public Dinero(Image imagen)
        {

            Imagen = imagen;

            PosicionX = Canvas.GetLeft(imagen);

            PosicionY = Canvas.GetTop(imagen);

            estado.Add(new BitmapImage(new Uri("Dinero.png", UriKind.Relative)));

            estado.Add(new BitmapImage(new Uri("Joya.png", UriKind.Relative)));

            Puntos = 1000;

        
            imagen.Source = estado[1];


        }

        public void Destruir()
        {
            Imagen.Source = null;
            Puntos = 0;
        }

    }
}
