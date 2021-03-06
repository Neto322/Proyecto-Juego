﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PracticaMovimiento
{
    public class Jugador
    {



        List<BitmapImage> arriba = new List<BitmapImage>();
        List<BitmapImage> abajo = new List<BitmapImage>();
        List<BitmapImage> izquierda = new List<BitmapImage>();
        List<BitmapImage> derecha = new List<BitmapImage>();






        public Image Imagen { get; set; }

        public enum Direccion { Izquierda, Derecha, Arriba, Abajo, Ninguna };
        public Direccion DireccionActual { get; set; }

        public enum Orientacion { Izquierda, Derecha, Arriba, Abajo }
        public Orientacion OrientacionActual { get; set; }



        public double PosicionX { get; set; }
        public double PosicionY { get; set; }


        public double Velocidad { get; set; }




        int spriteActual = 0;

        public double tiempoTranscurridoEnSprite = 0;

        double tiempoPorSprite = 0.25;

        public double tiempoTranscurrido = 0;











        public Jugador(Image imagen)
        {


            Imagen = imagen;
            arriba.Add(new BitmapImage(new Uri("JugadorMoviendoseArriba1.png", UriKind.Relative)));
            arriba.Add(new BitmapImage(new Uri("JugadorMoviendoseArriba2.png", UriKind.Relative)));

            abajo.Add(new BitmapImage(new Uri("JugadorMoviendoseAbajo1.png", UriKind.Relative)));
            abajo.Add(new BitmapImage(new Uri("JugadorMoviendoseAbajo2.png", UriKind.Relative)));

            izquierda.Add(new BitmapImage(new Uri("JugadorMoviendoseIzquierda1.png", UriKind.Relative)));
            izquierda.Add(new BitmapImage(new Uri("JugadorMoviendoseIzquierda2.png", UriKind.Relative)));

            derecha.Add(new BitmapImage(new Uri("JugadorMoviendoseDerecha1.png", UriKind.Relative)));
            derecha.Add(new BitmapImage(new Uri("JugadorMoviendoseDerecha2.png", UriKind.Relative)));
            Imagen.Source = derecha[0];
            DireccionActual = Direccion.Ninguna;
            OrientacionActual = Orientacion.Derecha;





            PosicionX = Canvas.GetLeft(imagen);
            PosicionY = Canvas.GetTop(imagen);

            Velocidad = 80;



        }


        public void CambiarDireccion(Direccion nuevaDireccion, Orientacion nuevaorientacion)
        {
            DireccionActual = nuevaDireccion;
            switch (DireccionActual)
            {
                case Direccion.Abajo:
                    Imagen.Source = abajo[0];
                    break;
                case Direccion.Arriba:
                    Imagen.Source = arriba[0];
                    break;
                case Direccion.Izquierda:
                    Imagen.Source = izquierda[0];
                    break;
                case Direccion.Derecha:
                    Imagen.Source = derecha[0];
                    break;
                default:
                    break;
            }
        }



        public void Mover(double deltaTime)
        {
            tiempoTranscurridoEnSprite += deltaTime;
            int spriteAnterior = spriteActual;
            if (tiempoTranscurridoEnSprite >= tiempoPorSprite)
            {
                spriteActual++;
                tiempoTranscurridoEnSprite -= tiempoPorSprite;
                if (spriteActual > 1)
                {
                    spriteActual = 0;
                }
            }
            BitmapImage sprite = null;
            switch (DireccionActual)
            {

                case Direccion.Abajo:
                    PosicionY += Velocidad * deltaTime;
                    sprite = abajo[spriteActual];

                    break;
                case Direccion.Arriba:
                    PosicionY -= Velocidad * deltaTime;
                    sprite = arriba[spriteActual];

                    break;
                case Direccion.Izquierda:
                    PosicionX -= Velocidad * deltaTime;
                    sprite = izquierda[spriteActual];
                    break;
                case Direccion.Derecha:
                    PosicionX += Velocidad * deltaTime;
                    sprite = derecha[spriteActual];
                    break;
                default:
                    break;
            }
            if (spriteAnterior != spriteActual && sprite != null)
            {
                Imagen.Source = sprite;
            }
            Canvas.SetLeft(Imagen, PosicionX);
            Canvas.SetTop(Imagen, PosicionY);
        }




    }
}
