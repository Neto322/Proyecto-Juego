using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PracticaMovimiento
{
    public class Tile
    {



        public double PosicionX { get; set; }
        public double PosicionY { get; set; }


        public Image Imagen;



        public Tile(Image imagen)
        {

            Imagen = imagen;

            PosicionX = Canvas.GetLeft(imagen);
            PosicionY = Canvas.GetTop(imagen);

            


        }


    }
}
