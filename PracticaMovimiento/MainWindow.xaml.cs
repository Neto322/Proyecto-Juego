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
        bool jugando = true;
        /// Jugador //
        Jugador player;
        ///         ///
        /// Enemigos //        
        Enemigo enemigo1;
        Enemigo enemigo2;
        Enemigo enemigo3;
        Enemigo enemigo4;
        Enemigo enemigo5;
        Enemigo enemigo6;
        Enemigo enemigo7;
        ///         ///
        /// Tiles   // 
        Tile tiles1;
        Tile tiles2;
        Tile tiles3;
        Tile tiles4;
        Tile tiles5;
        Tile tiles6;
        Tile tiles7;
        Tile tiles8;
        Tile tiles9;
        Tile tiles10;
        Tile tiles11;
        Tile tiles12;
        Tile tiles13;
        Tile tiles14;
        Tile tiles15;
        Tile tiles16;
        Tile tiles17;
        Tile tiles18;
        Tile tiles19;
        Tile tiles20;
        Tile tiles21;
        Tile tiles22;
        Tile tiles23;
        Tile tiles24;
        Tile tiles25;
        Tile tiles26;
        Tile tiles27;
        Tile tiles28;
        Tile tiles29;
        Tile tiles30;
        Tile tiles31;
        Tile tiles32;
        Tile tiles33;
        Tile tiles34;
        Tile tiles35;
        Tile tiles36;
        Tile tiles37;
        Tile tiles38;
        Tile tiles39;
        Tile tiles40;
        Tile tiles41;
        Tile tiles42;
        Tile tiles43;
        Tile tiles44;
        Tile tiles45;
        Tile tiles46;
        Tile tiles47;
        Tile tiles48;
        Tile tiles49;
        Tile tiles50;
        Tile tiles51;
        Tile tiles52;
        Tile tiles53;
        Tile tiles54;
        Tile tiles55;
        Tile tiles56;
        Tile tiles57;
        Tile tiles58;
        Tile tiles59;
        Tile tiles60;
        Tile tiles61;
        Tile tiles62;
        Tile tiles63;
        Tile tiles64;
        Tile tiles66;
        Tile tiles67;
        Tile tiles68;
        Tile tiles69;
        Tile tiles70;
        Tile tiles71;
        Tile tiles72;
        Tile tiles73;
        Tile tiles74;
        Tile tiles75;
        Tile tiles76;
        Tile tiles77;
        Tile tiles78;
        Tile tiles79;
        Tile tiles80;
        Tile tiles81;
        Tile tiles82;
        Tile tiles84;
        Tile tiles86;
        Tile tiles87;
        Tile tiles88;
        Tile tiles89;
        Warp Derecha;
        Warp Izquierda;
        ///         ///

        Dinero Dinero1;
        Dinero Dinero2;
        Dinero Dinero3;
        Dinero Dinero4;
        Dinero Dinero5;
        Dinero Dinero6;
        Dinero Dinero7;
        Dinero Dinero8;
        Dinero Dinero9;
        Dinero Dinero10;
        Dinero Dinero11;
        Dinero Dinero12;
        Dinero Dinero13;
        Dinero Dinero14;
        Dinero Dinero15;
        Dinero Dinero16;
        Dinero Dinero17;
        Dinero Dinero18;
        Dinero Dinero19;
        Dinero Dinero20;
        Dinero Dinero21;
        Dinero Dinero22;
        Dinero Dinero23;
        Dinero Dinero24;
        Dinero Dinero25;
        Dinero Dinero26;
        Dinero Dinero27;
        Dinero Dinero28;
        Dinero Dinero29;
        Dinero Dinero30;
        Dinero Dinero31;
        Dinero Dinero32;
        Dinero Dinero33;
        Dinero Dinero34;
        Dinero Dinero35;
        Dinero Dinero36;
        Dinero Dinero37;
        Dinero Dinero38;
        Dinero Dinero39;
        Dinero Dinero40;
        Dinero Dinero41;
        Dinero Dinero42;
        Dinero Dinero43;
        Dinero Dinero44;
        Dinero Dinero45;
        Dinero Dinero46;
        Dinero Dinero47;
        Dinero Dinero48;
        Dinero Dinero49;
        Dinero Dinero50;
        Dinero Dinero51;
        Dinero Dinero52;
        Dinero Dinero53;
        Dinero Dinero54;
        Dinero Dinero55;
        Dinero Dinero56;
        Dinero Dinero57;
        Dinero Dinero58;
        Dinero Dinero59;
        Dinero Dinero60;
        Dinero Dinero61;
        Dinero Dinero62;
        Dinero Dinero63;
        Dinero Dinero64;
        Dinero Dinero65;
        Dinero Dinero66;



        int puntuacion = 0;


        enum EstadoJuego { Gameplay, Gameover,Menu};
        EstadoJuego estadoActual = EstadoJuego.Menu;



        List<Enemigo> enemigos = new List<Enemigo>();

        List<Tile> tiles = new List<Tile>();

        List<Dinero> Dineros = new List<Dinero>();

        public MainWindow()
        {
            
            InitializeComponent();
            canvasPrincipal.Focus();

            stopwatch = new Stopwatch();
            stopwatch.Start();
            tiempoAnterior = stopwatch.Elapsed;


           

            player = new Jugador(rectjugador);
            

            enemigo1 = new Enemigo(rectenemigo);
            enemigo2 = new Enemigo(rectenemigo_Copy);
            enemigo3 = new Enemigo(rectenemigo_Copy1);
            enemigo4 = new Enemigo(rectenemigo_Copy2);
            enemigo5 = new Enemigo(rectenemigo_Copy3);
            enemigo6 = new Enemigo(rectenemigo_Copy4);
            enemigo7 = new Enemigo(rectenemigo_Copy5);

            Izquierda = new Warp(IzquierdaWarp);

            Derecha = new Warp(DerechaWarp);

          

            Dinero1 = new Dinero(dinero_Copy);
            Dinero2 = new Dinero(dinero_Copy1);
            Dinero3 = new Dinero(dinero_Copy2);
            Dinero4 = new Dinero(dinero_Copy3);
            Dinero5 = new Dinero(dinero_Copy4);
            Dinero6 = new Dinero(dinero_Copy5);
            Dinero7 = new Dinero(dinero_Copy6);
            Dinero8 = new Dinero(dinero_Copy7);
            Dinero9 = new Dinero(dinero_Copy8);
            Dinero10 = new Dinero(dinero_Copy9);
            Dinero11 = new Dinero(dinero_Copy10);
            Dinero12 = new Dinero(dinero_Copy11);
            Dinero13 = new Dinero(dinero_Copy12);
            Dinero14 = new Dinero(dinero_Copy13);
            Dinero15 = new Dinero(dinero_Copy14);
            Dinero16 = new Dinero(dinero_Copy15);
            Dinero17 = new Dinero(dinero_Copy16);
            Dinero18 = new Dinero(dinero_Copy17);
            Dinero19 = new Dinero(dinero_Copy18);
            Dinero20 = new Dinero(dinero_Copy19);
            Dinero21 = new Dinero(dinero_Copy20);
            Dinero22 = new Dinero(dinero_Copy21);
            Dinero23 = new Dinero(dinero_Copy22);
            Dinero24 = new Dinero(dinero_Copy23);
            Dinero25 = new Dinero(dinero_Copy24);
            Dinero26 = new Dinero(dinero_Copy25);
            Dinero27 = new Dinero(dinero_Copy26);
            Dinero28 = new Dinero(dinero_Copy27);
            Dinero29 = new Dinero(dinero_Copy28);
            Dinero30 = new Dinero(dinero_Copy29);
            Dinero31 = new Dinero(dinero_Copy30);
            Dinero32 = new Dinero(dinero_Copy31);
            Dinero33 = new Dinero(dinero_Copy32);
            Dinero34 = new Dinero(dinero_Copy33);
            Dinero35 = new Dinero(dinero_Copy34);
            Dinero36 = new Dinero(dinero_Copy35);
            Dinero37 = new Dinero(dinero_Copy36);
            Dinero38 = new Dinero(dinero_Copy37);
            Dinero39 = new Dinero(dinero_Copy38);
            Dinero40 = new Dinero(dinero_Copy39);
            Dinero41 = new Dinero(dinero_Copy40);
            Dinero42 = new Dinero(dinero_Copy41);
            Dinero43 = new Dinero(dinero_Copy42);
            Dinero44 = new Dinero(dinero_Copy43);
            Dinero45 = new Dinero(dinero_Copy44);
            Dinero46 = new Dinero(dinero_Copy45);
            Dinero47 = new Dinero(dinero_Copy46);
            Dinero48 = new Dinero(dinero_Copy47);
            Dinero49 = new Dinero(dinero_Copy48);
            Dinero50 = new Dinero(dinero_Copy49);
            Dinero51 = new Dinero(dinero_Copy50);
            Dinero52 = new Dinero(dinero_Copy51);
            Dinero53 = new Dinero(dinero_Copy52);
            Dinero54 = new Dinero(dinero_Copy53);
            Dinero55 = new Dinero(dinero_Copy54);
            Dinero56 = new Dinero(dinero_Copy55);
            Dinero57 = new Dinero(dinero_Copy56);
            Dinero58 = new Dinero(dinero_Copy57);
            Dinero59 = new Dinero(dinero_Copy58);
            Dinero60 = new Dinero(dinero_Copy59);
            Dinero61 = new Dinero(dinero_Copy60);
            Dinero62 = new Dinero(dinero_Copy61);
            Dinero63 = new Dinero(dinero_Copy62);
            Dinero64 = new Dinero(dinero_Copy63);
            Dinero65 = new Dinero(dinero_Copy64);
            Dinero66 = new Dinero(dinero_Copy65);

       

            tiles1 = new Tile(tile1);
            tiles2 = new Tile(tile2);
            tiles3 = new Tile(tile3);
            tiles4 = new Tile(tile4);
            tiles5 = new Tile(tile5);
            tiles6 = new Tile(tile6);
            tiles7 = new Tile(tile7);
            tiles8 = new Tile(tile8);
            tiles9 = new Tile(tile9);
            tiles10 = new Tile(tile10);
            tiles11= new Tile(tile11);
            tiles12 = new Tile(tile12);
            tiles13 = new Tile(tile13);
            tiles14 = new Tile(tile14);
            tiles15 = new Tile(tile15);
            tiles16 = new Tile(tile16);
            tiles17 = new Tile(tile17);
            tiles18 = new Tile(tile18);
            tiles19 = new Tile(tile19);
            tiles20 = new Tile(tile20);
            tiles21 = new Tile(tile21);
            tiles22 = new Tile(tile22);
            tiles23 = new Tile(tile23);
            tiles24 = new Tile(tile24);
            tiles25 = new Tile(tile25);
            tiles26 = new Tile(tile26);
            tiles27 = new Tile(tile27);
            tiles28 = new Tile(tile28);
            tiles29 = new Tile(tile29);
            tiles30 = new Tile(tile30);
            tiles31 = new Tile(tile31);
            tiles32 = new Tile(tile32);
            tiles33 = new Tile(tile33);
            tiles34 = new Tile(tile34);
            tiles35 = new Tile(tile35);
            tiles36 = new Tile(tile36);
            tiles37 = new Tile(tile37);
            tiles38 = new Tile(tile38);
            tiles39 = new Tile(tile39);
            tiles40 = new Tile(tile40);
            tiles41 = new Tile(tile41);
            tiles42 = new Tile(tile42);
            tiles43 = new Tile(tile43);
            tiles44 = new Tile(tile44);
            tiles45 = new Tile(tile45);
            tiles46 = new Tile(tile46);
            tiles47 = new Tile(tile47);
            tiles48 = new Tile(tile48);
            tiles49 = new Tile(tile49);
            tiles50 = new Tile(tile50);
            tiles51 = new Tile(tile51);
            tiles52 = new Tile(tile52);
            tiles53 = new Tile(tile53);
            tiles54 = new Tile(tile54);
            tiles55 = new Tile(tile55);
            tiles56 = new Tile(tile56);
            tiles57 = new Tile(tile57);
            tiles58 = new Tile(tile58);
            tiles59 = new Tile(tile59);
            tiles60 = new Tile(tile60);
            tiles61 = new Tile(tile61);
            tiles62 = new Tile(tile62);
            tiles63 = new Tile(tile63);
            tiles64 = new Tile(tile64);
        
            tiles66 = new Tile(tile66);
            tiles67 = new Tile(tile67);
            tiles68 = new Tile(tile68);
            tiles69 = new Tile(tile69);
            tiles70 = new Tile(tile70);
            tiles71 = new Tile(tile71);
            tiles72 = new Tile(tile72);
            tiles73 = new Tile(tile73);
            tiles74 = new Tile(tile74);
            tiles75 = new Tile(tile75);
            tiles76 = new Tile(tile76);
            tiles77 = new Tile(tile77);
            tiles78 = new Tile(tile78);
            tiles79 = new Tile(tile79);
            tiles80 = new Tile(tile80);
            tiles81 = new Tile(tile81);
            tiles82 = new Tile(tile82);
      
            tiles84 = new Tile(tile84);
            tiles86 = new Tile(tile86);
            tiles87 = new Tile(tile87);
            tiles88 = new Tile(tile88);
            tiles89 = new Tile(tile89);



            enemigos.Add(enemigo1);
            enemigos.Add(enemigo2);
            enemigos.Add(enemigo3);
            enemigos.Add(enemigo4);
            enemigos.Add(enemigo5);
            enemigos.Add(enemigo6);
            enemigos.Add(enemigo7);



            tiles.Add(tiles1);
            tiles.Add(tiles2);
            tiles.Add(tiles3);
            tiles.Add(tiles4);
            tiles.Add(tiles5);
            tiles.Add(tiles6);
            tiles.Add(tiles7);
            tiles.Add(tiles8);
            tiles.Add(tiles9);
            tiles.Add(tiles10);
            tiles.Add(tiles11);
            tiles.Add(tiles12);
            tiles.Add(tiles13);
            tiles.Add(tiles14);
            tiles.Add(tiles15);
            tiles.Add(tiles16);
            tiles.Add(tiles17);
            tiles.Add(tiles18);
            tiles.Add(tiles19);
            tiles.Add(tiles20);
            tiles.Add(tiles21);
            tiles.Add(tiles22);
            tiles.Add(tiles23);
            tiles.Add(tiles24);
            tiles.Add(tiles25);
            tiles.Add(tiles26);
            tiles.Add(tiles27);
            tiles.Add(tiles28);
            tiles.Add(tiles29);
            tiles.Add(tiles30);
            tiles.Add(tiles31);
            tiles.Add(tiles32);
            tiles.Add(tiles33);
            tiles.Add(tiles34);
            tiles.Add(tiles35);
            tiles.Add(tiles36);
            tiles.Add(tiles37);
            tiles.Add(tiles38);
            tiles.Add(tiles39);
            tiles.Add(tiles40);
            tiles.Add(tiles41);
            tiles.Add(tiles42);
            tiles.Add(tiles43);
            tiles.Add(tiles44);
            tiles.Add(tiles45);
            tiles.Add(tiles46);
            tiles.Add(tiles47);
            tiles.Add(tiles48);
            tiles.Add(tiles49);
            tiles.Add(tiles50);
            tiles.Add(tiles51);
            tiles.Add(tiles52);
            tiles.Add(tiles53);
            tiles.Add(tiles54);
            tiles.Add(tiles55);
            tiles.Add(tiles56);
            tiles.Add(tiles57);
            tiles.Add(tiles58);
            tiles.Add(tiles59);
            tiles.Add(tiles60);
            tiles.Add(tiles61);
            tiles.Add(tiles62);
            tiles.Add(tiles63);
            tiles.Add(tiles64);
            tiles.Add(tiles66);
            tiles.Add(tiles67);
            tiles.Add(tiles68);
            tiles.Add(tiles69);
            tiles.Add(tiles70);
            tiles.Add(tiles71);
            tiles.Add(tiles72);
            tiles.Add(tiles73);
            tiles.Add(tiles74);
            tiles.Add(tiles75);
            tiles.Add(tiles76);
            tiles.Add(tiles77);
            tiles.Add(tiles78);
            tiles.Add(tiles79);
            tiles.Add(tiles80);
            tiles.Add(tiles81);
            tiles.Add(tiles82);
       
            tiles.Add(tiles84);
            tiles.Add(tiles86);
            tiles.Add(tiles87);
            tiles.Add(tiles88);
            tiles.Add(tiles89);



            tiles.Add(Derecha);
            tiles.Add(Izquierda);

            Dineros.Add(Dinero1);
            Dineros.Add(Dinero2);
            Dineros.Add(Dinero3);
            Dineros.Add(Dinero4);
            Dineros.Add(Dinero5);
            Dineros.Add(Dinero6);
            Dineros.Add(Dinero7);
            Dineros.Add(Dinero8);
            Dineros.Add(Dinero9);
            Dineros.Add(Dinero10);
            Dineros.Add(Dinero11);
            Dineros.Add(Dinero12);
            Dineros.Add(Dinero13);
            Dineros.Add(Dinero14);
            Dineros.Add(Dinero15);
            Dineros.Add(Dinero16);
            Dineros.Add(Dinero17);
            Dineros.Add(Dinero18);
            Dineros.Add(Dinero19);
            Dineros.Add(Dinero20);
            Dineros.Add(Dinero21);
            Dineros.Add(Dinero22);
            Dineros.Add(Dinero23);
            Dineros.Add(Dinero24);
            Dineros.Add(Dinero25);
            Dineros.Add(Dinero26);
            Dineros.Add(Dinero27);
            Dineros.Add(Dinero28);
            Dineros.Add(Dinero29);
            Dineros.Add(Dinero30);
            Dineros.Add(Dinero31);
            Dineros.Add(Dinero32);
            Dineros.Add(Dinero33);
            Dineros.Add(Dinero34);
            Dineros.Add(Dinero35);
            Dineros.Add(Dinero36);
            Dineros.Add(Dinero37);
            Dineros.Add(Dinero38);
            Dineros.Add(Dinero39);
            Dineros.Add(Dinero40);
            Dineros.Add(Dinero41); 
            Dineros.Add(Dinero42);
            Dineros.Add(Dinero43);
            Dineros.Add(Dinero44);
            Dineros.Add(Dinero45);
            Dineros.Add(Dinero46);
            Dineros.Add(Dinero47);
            Dineros.Add(Dinero48);
            Dineros.Add(Dinero49);
            Dineros.Add(Dinero50);
            Dineros.Add(Dinero51);
            Dineros.Add(Dinero52);
            Dineros.Add(Dinero53);
            Dineros.Add(Dinero54);
            Dineros.Add(Dinero55);
            Dineros.Add(Dinero56);
            Dineros.Add(Dinero57);
            Dineros.Add(Dinero58);
            Dineros.Add(Dinero59);
            Dineros.Add(Dinero60); 
            Dineros.Add(Dinero61);
            Dineros.Add(Dinero62);
            Dineros.Add(Dinero63);
            Dineros.Add(Dinero64);
            Dineros.Add(Dinero65);
            Dineros.Add(Dinero66);



        


            ThreadStart threadStart =
                new ThreadStart(actualizar);
          
            Thread threadMoverEnemigos =
                new Thread(threadStart);

            threadMoverEnemigos.Start();

           
            
        }


        void Rockola()
        {
            if (estadoActual == EstadoJuego.Gameplay)
            {
            
            }
            if (estadoActual == EstadoJuego.Gameover)
            {
             
            }

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

                                estadoActual = EstadoJuego.Gameover;

                            }
                            else
                            {
                            }
             
                                foreach (Tile tile in tiles)
                                {
                                    if (player.PosicionX + player.Imagen.Width >= tile.PosicionX &&
                         player.PosicionX <= tile.PosicionX + tile.Imagen.Width &&
                         player.PosicionY + player.Imagen.Height >= tile.PosicionY &&
                         player.PosicionY <= tile.PosicionY + tile.Imagen.Height)
                                    {


                                        if (tile.GetType() == typeof(Warp))
                                        {
                                            if (tile.Imagen.Name == "DerechaWarp")
                                            {
                                                player.PosicionX = player.PosicionX - 850;

                                            }
                                            else
                                            {
                                              
                                                player.PosicionX = player.PosicionX + 850;

                                            }




                                        }

                                        if (player.DireccionActual == Jugador.Direccion.Derecha)
                                        {

                                            player.PosicionX = player.PosicionX - 5;



                                        }
                                        if (player.DireccionActual == Jugador.Direccion.Izquierda)
                                        {

                                            player.PosicionX = player.PosicionX + 5;
                                        }
                                        if (player.DireccionActual == Jugador.Direccion.Arriba)
                                        {

                                            player.PosicionY = player.PosicionY + 5;

                                        }
                                        if (player.DireccionActual == Jugador.Direccion.Abajo)
                                        {

                                            player.PosicionY = player.PosicionY - 5;
                                        }


                                    }
                                    if (enemigo.PosicionX + enemigo.Imagen.Width >= tile.PosicionX &&
                         enemigo.PosicionX <= tile.PosicionX + tile.Imagen.Width &&
                         enemigo.PosicionY + enemigo.Imagen.Height >= tile.PosicionY &&
                         enemigo.PosicionY <= tile.PosicionY + tile.Imagen.Height)
                                    {
                                        if (tile.GetType() == typeof(Warp))
                                        {
                                            if (tile.Imagen.Name == "DerechaWarp")
                                            {
                                                enemigo.PosicionX = enemigo.PosicionX - 850;

                                            }
                                            else
                                            {
                                         
                                                enemigo.PosicionX = enemigo.PosicionX + 850;

                                            }




                                        }
                                        if (enemigo.DireccionActual == Enemigo.Direccion.Derecha)
                                        {

                                            enemigo.PosicionX = enemigo.PosicionX - 5;
                                              enemigo.Random();
                                            


                                        }
                                        if (enemigo.DireccionActual == Enemigo.Direccion.Izquierda)
                                        {

                                            enemigo.PosicionX = enemigo.PosicionX + 5;
                                              enemigo.Random();
                                          

                                        }
                                        if (enemigo.DireccionActual == Enemigo.Direccion.Arriba)
                                        {

                                            enemigo.PosicionY = enemigo.PosicionY + 5;
                                              enemigo.Random();
                                           


                                        }
                                        if (enemigo.DireccionActual == Enemigo.Direccion.Abajo)
                                        {

                                            enemigo.PosicionY = enemigo.PosicionY - 5;
                                              enemigo.Random();
                                           
                                        }
                                    }

                                }
                            }

                        foreach (Dinero dinero in Dineros)
                        {
                            
                            if (player.PosicionX + player.Imagen.Width >= dinero.PosicionX &&
                   player.PosicionX <= dinero.PosicionX + dinero.Imagen.Width &&
                   player.PosicionY + player.Imagen.Height >= dinero.PosicionY &&
                   player.PosicionY <= dinero.PosicionY + dinero.Imagen.Height)
                            {
                                
                                puntuacion = puntuacion + dinero.Puntos;
                                PuntuacionTotal.Text = "Puntos " + puntuacion;
                                dinero.Destruir();
                               
                            }
                            else
                            {

                            }


                        }

                     



                        if(puntuacion == 66000)
                        {
                            estadoActual = EstadoJuego.Gameover;
                        }



                    } else if (estadoActual == EstadoJuego.Gameover)
                    {
                      
                        canvasPrincipal.Visibility = Visibility.Collapsed;
                        canvasGameOver.Visibility = Visibility.Visible;
                        PuntuacionTotal2.Text = "Puntos Totales " + puntuacion; 
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

        private void canvasPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
   
            
        }

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            media.Position = TimeSpan.Zero;
            media.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            canvasMenu.Visibility = Visibility.Collapsed;
            canvasPrincipal.Visibility = Visibility.Visible;
            canvasPrincipal.Focus();
            estadoActual = EstadoJuego.Gameplay;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();

        }
    }
}
