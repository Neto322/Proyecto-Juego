using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PracticaMovimiento
{
    class Warp : Tile
    {
        public Warp(Image imagen) : base(imagen)
        {
            imagen.Source = new BitmapImage(new Uri("Textura1.png", UriKind.Relative));
        }
    }

}
