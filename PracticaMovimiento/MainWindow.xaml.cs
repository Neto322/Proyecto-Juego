using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Diagnostics;
using System.Windows.Threading;


namespace PracticaMovimiento
{
   
    public partial class MainWindow : Window
    {

        Stopwatch stopwatch;
        TimeSpan tiempoAnterior;
    
        /// Jugador //
        Jugador player;
        ///         ///
        /// Enemigos //        
        Enemigo enemigo1;
        ///         ///
        /// Tiles   // 
        Tile tiles1;
        Tile tiles2;
        Tile tiles3;
        ///         ///




        enum EstadoJuego { Gameplay, Gameover };
        EstadoJuego estadoActual = EstadoJuego.Gameplay;



        List<Enemigo> enemigos = new List<Enemigo>();

        List<Tile> tiles = new List<Tile>();

        public MainWindow()
        {
            
            InitializeComponent();
            canvasPrincipal.Focus();

            stopwatch = new Stopwatch();
            stopwatch.Start();
            tiempoAnterior = stopwatch.Elapsed;


            player = new Jugador(rectjugador);
            

            enemigo1 = new Enemigo(rectenemigo);

            tiles1 = new Tile(tile1);
            tiles2 = new Tile(tile2);
            tiles3 = new Tile(tile3);

            enemigos.Add(enemigo1);
            tiles.Add(tiles1);
            tiles.Add(tiles2);
            tiles.Add(tiles3);

            ThreadStart threadStart =
                new ThreadStart(actualizar);
          
            Thread threadMoverEnemigos =
                new Thread(threadStart);

            threadMoverEnemigos.Start();

           
            
        }

 

        void actualizar()
        {
            while (true)
            {
                Dispatcher.Invoke(
                () =>
                {
                 
            
                    TimeSpan tiempoActual = stopwatch.Elapsed;


                    double deltaTime = tiempoActual.TotalSeconds - tiempoAnterior.TotalSeconds;


                    if (estadoActual == EstadoJuego.Gameplay)
                    {
                       
             
                        player.Mover(deltaTime);
                        // CHECAR COLISIONES EN TODOS LOS OBJETOS//
                        foreach (Enemigo enemigo in enemigos)
                        {
                            enemigo.Mover(deltaTime);

                           
                            if (player.PosicionX + player.Imagen.Width >= enemigo.PosicionX &&
                        player.PosicionX <= enemigo.PosicionX + enemigo.Imagen.Width &&
                        player.PosicionY + player.Imagen.Height >= enemigo.PosicionY &&
                        player.PosicionY <= enemigo.PosicionY + enemigo.Imagen.Height)
                            {
                                lblColision.Text =
                                    "HAY COLISION!!!";
                         
                            }
                            else
                            {
                                lblColision.Text = "NOOO -HAY COLISION!!!";
                            }
                            foreach (Tile tile in tiles)
                            {
                                if (player.PosicionX + player.Imagen.Width >= tile.PosicionX &&
                     player.PosicionX <= tile.PosicionX + tile.Imagen.Width &&
                     player.PosicionY + player.Imagen.Height >= tile.PosicionY &&
                     player.PosicionY <= tile.PosicionY + tile.Imagen.Height)
                                {
                                    lblInterseccionX.Text =
                                      "HAY COLISION DE TILES ";
                                    if(player.DireccionActual == Jugador.Direccion.Derecha)
                                    {

                                        player.PosicionX = player.PosicionX - 1;



                                    }
                                    if (player.DireccionActual == Jugador.Direccion.Izquierda)
                                    {

                                        player.PosicionX = player.PosicionX + 1;
                                    }
                                    if (player.DireccionActual == Jugador.Direccion.Arriba)
                                    {

                                        player.PosicionY = player.PosicionY + 1;

                                    }
                                    if (player.DireccionActual == Jugador.Direccion.Abajo)
                                    {

                                        player.PosicionY = player.PosicionY - 1;
                                    }


                                }
                                if (enemigo.PosicionX + enemigo.Imagen.Width >= tile.PosicionX &&
                     enemigo.PosicionX <= tile.PosicionX + tile.Imagen.Width &&
                     enemigo.PosicionY + enemigo.Imagen.Height >= tile.PosicionY &&
                     enemigo.PosicionY <= tile.PosicionY + tile.Imagen.Height)
                                {
                                    lblInterseccionY.Text =
                                        "HAY COLISION DE TILES DEL ENEMIGO!!";
                                    if (enemigo.DireccionActual == Enemigo.Direccion.Derecha)
                                    {

                                        enemigo.PosicionX = enemigo.PosicionX - 1;
                                        enemigo.Random();


                                    }
                                    if (enemigo.DireccionActual == Enemigo.Direccion.Izquierda)
                                    {

                                        enemigo.PosicionX = enemigo.PosicionX + 1;
                                        enemigo.Random();

                                    }
                                    if (enemigo.DireccionActual == Enemigo.Direccion.Arriba)
                                    {

                                        enemigo.PosicionY = enemigo.PosicionY + 1;
                                        enemigo.Random();


                                    }
                                    if (enemigo.DireccionActual == Enemigo.Direccion.Abajo)
                                    {

                                        enemigo.PosicionY = enemigo.PosicionY - 1;
                                        enemigo.Random();

                                    }
                                }
                            }

                        }









                    } else if (estadoActual == EstadoJuego.Gameover)
                    {

                    }

                    

                    


                    tiempoAnterior = tiempoActual;
                   

                }
                );
            }
            
        }

        private void canvasPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (estadoActual == EstadoJuego.Gameplay)
            {
                if (!e.IsRepeat)
                {
              
                    if (e.Key == Key.Up)
                {
                    player.CambiarDireccion(Jugador.Direccion.Arriba, Jugador.Orientacion.Arriba);
                }
                if (e.Key == Key.Down)
                {
                    player.CambiarDireccion(Jugador.Direccion.Abajo, Jugador.Orientacion.Abajo);
                }
                if (e.Key == Key.Left)
                {
                    player.CambiarDireccion(Jugador.Direccion.Izquierda, Jugador.Orientacion.Izquierda);
                }
                if (e.Key == Key.Right)
                {
                    player.CambiarDireccion(Jugador.Direccion.Derecha, Jugador.Orientacion.Derecha);
                }
                }
            }
        }

        
    }
}
