using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_crossroad
{
    public partial class CrossRoad : Form
    {
        Tablero tablero;

        public CrossRoad()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            pnlMnu1.Dock = DockStyle.Fill;
            pnlMnu1.Visible = true;
            pnlMnu1.BringToFront();
        }

        public void CreaTablero()
        {

            tablero = new Tablero(12, 10, 20);
            tablero.piezas = new List<Pieza>();
            //llenar tablero
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    Pieza pieza = new Pieza("Pasto", x, y);
                    tablero.piezas.Add(pieza);
                }
            }

            for (int x = 0; x < 10; x++)
            {
                Pieza pieza = new Pieza("Carretera", x, 2);
                tablero.piezas.Add(pieza);
            }
            for (int x = 0; x < 10; x++)
            {
                Pieza pieza = new Pieza("Carreteraabajo", x, 3);
                tablero.piezas.Add(pieza);
            }
            for (int x = 0; x < 10; x++)
            {
                for (int y = 4; y < 6; y++)
                {
                    Pieza pieza = new Pieza("Pasto", x, y);
                    tablero.piezas.Add(pieza);
                }
            }
            for (int x = 0; x < 10; x++)
            {
                Pieza pieza = new Pieza("Carretera", x, 6);
                tablero.piezas.Add(pieza);
            }
            for (int x = 0; x < 10; x++)
            {
                Pieza pieza = new Pieza("Carreteraabajo", x, 7);
                tablero.piezas.Add(pieza);
            }
            for (int x = 0; x < 10; x++)
            {
                for (int y = 8; y < 10; y++)
                {
                    Pieza pieza = new Pieza("Pasto", x, y);
                    tablero.piezas.Add(pieza);
                }
            }


            int posX;
            int posY;
            //dibujar tablero
            foreach (Pieza pieza in tablero.piezas)
            {
                posX = 10 + (pieza.posX * 60);
                posY = 40 + (pieza.posY * 50);
                pieza.figura.Location = new Point(posX, posY);
                this.Controls.Add(pieza.figura);
            }
        }

        public void CrearPersonaje()
        {
            tablero.personaje = new Personaje("Kirito", 5, 9);
            punteo.Text = "" + tablero.personaje.punteo;
            this.Controls.Add(tablero.personaje.figura);

            //dibujar personaje
            dibujarPersonaje(6, 9);
        }

        public void CrearCarrosNivel1()
        {
            //creacion de carros
            tablero.carros = new List<Carro>();
            Carro carro = new Carro("Azul", 9, 2);
            carro.direccion = "Izquierda";
            tablero.carros.Add(carro);

            carro = new Carro("Amarilloregreso", 3, 3);
            carro.direccion = "Derecha";
            tablero.carros.Add(carro);

            carro = new Carro("Verde", 5, 6);
            carro.direccion = "Izquierda";
            tablero.carros.Add(carro);

            carro = new Carro("Verderegreso", 3, 7);
            carro.direccion = "Derecha";
            tablero.carros.Add(carro);

            //dibujar carros
            foreach (Carro carrito in tablero.carros)
            {
                this.Controls.Add(carrito.figura);
                dibujarCarro(carrito);
            }
        }

        public void CrearCarrosNivel2()
        {
            //creacion de carros
            tablero.carros = new List<Carro>();
            Carro carro = new Carro("Azul", 9, 2);
            carro.direccion = "Izquierda";
            tablero.carros.Add(carro);

            carro = new Carro("Azulregreso", 0, 3);
            carro.direccion = "Derecha";
            tablero.carros.Add(carro);

            carro = new Carro("Amarillo", 7, 2);
            carro.direccion = "Izquierda";
            tablero.carros.Add(carro);

            carro = new Carro("Amarilloregreso", 3, 3);
            carro.direccion = "Derecha";
            tablero.carros.Add(carro);

            carro = new Carro("Rojo", 9, 6);
            carro.direccion = "Izquierda";
            tablero.carros.Add(carro);

            carro = new Carro("Rojoregreso", 0, 7);
            carro.direccion = "Derecha";
            tablero.carros.Add(carro);

            carro = new Carro("Negro", 5, 6);
            carro.direccion = "Izquierda";
            tablero.carros.Add(carro);

            //dibujar carros
            foreach (Carro carrito in tablero.carros)
            {
                this.Controls.Add(carrito.figura);
                dibujarCarro(carrito);
            }
        }

        public void CrearCarrosNivel3()
        {
            //creacion de carros
            tablero.carros = new List<Carro>();
            Carro carro = new Carro("Azul", 9, 2);
            carro.direccion = "Izquierda";
            tablero.carros.Add(carro);

            carro = new Carro("Azulregreso", 0, 3);
            carro.direccion = "Derecha";
            tablero.carros.Add(carro);

            carro = new Carro("Amarillo", 7, 2);
            carro.direccion = "Izquierda";
            tablero.carros.Add(carro);

            carro = new Carro("Amarilloregreso", 3, 3);
            carro.direccion = "Derecha";
            tablero.carros.Add(carro);

            carro = new Carro("Rojo", 9, 6);
            carro.direccion = "Izquierda";
            tablero.carros.Add(carro);

            carro = new Carro("Rojoregreso", 0, 7);
            carro.direccion = "Derecha";
            tablero.carros.Add(carro);

            carro = new Carro("Negro", 2, 6);
            carro.direccion = "Izquierda";
            tablero.carros.Add(carro);

            carro = new Carro("Negroregreso", 5, 7);
            carro.direccion = "Derecha";
            tablero.carros.Add(carro);

            //dibujar carros
            foreach (Carro carrito in tablero.carros)
            {
                this.Controls.Add(carrito.figura);
                dibujarCarro(carrito);
            }
        }

        public void CrearAcompanantesNivel1(String nombre)
        {
            //creacion de carros
            tablero.acompanantes = new List<Acompanante>();
            for (int x = 0; x < 5; x++)
            {
                Acompanante acompanante = new Acompanante(nombre, x + 1, 9);
                tablero.acompanantes.Add(acompanante);
                this.Controls.Add(acompanante.figura);
                dibujarAcompanante(acompanante);
            }

        }

        public void CrearAcompanantesNivel2(String nombre)
        {
            //creacion de carros
            tablero.acompanantes = new List<Acompanante>();
            for (int x = 0; x < 4; x++)
            {
                Acompanante acompanante = new Acompanante(nombre, x + 1, 9);
                tablero.acompanantes.Add(acompanante);
                this.Controls.Add(acompanante.figura);
                dibujarAcompanante(acompanante);
            }

        }

        public void CrearAcompanantesNivel3(String nombre)
        {
            //creacion de carros
            tablero.acompanantes = new List<Acompanante>();
            for (int x = 0; x < 3; x++)
            {
                Acompanante acompanante = new Acompanante(nombre, x + 1, 9);
                tablero.acompanantes.Add(acompanante);
                this.Controls.Add(acompanante.figura);
                dibujarAcompanante(acompanante);
            }

        }

        private void dibujarPersonaje(int x, int y)
        {
            int posX = 10 + (x * 60);
            int posY = 40 + (y * 50);
            tablero.personaje.figura.Location = new Point(posX, posY);
            tablero.personaje.figura.BackColor = Color.Transparent;
            tablero.personaje.figura.BringToFront();
        }

        private void dibujarCarro(Carro carro)
        {
            int posX = 10 + (carro.posX * 60);
            int posY = 40 + (carro.posY * 50);
            carro.figura.Location = new Point(posX, posY);
            carro.figura.BackColor = Color.Transparent;
            carro.figura.BringToFront();
        }

        private void dibujarAcompanante(Acompanante acompanante)
        {
            int posX = 10 + (acompanante.posX * 60);
            int posY = 40 + (acompanante.posY * 50);
            acompanante.figura.Location = new Point(posX, posY);
            acompanante.figura.BackColor = Color.Transparent;
            acompanante.figura.BringToFront();
        }

        private bool personajeAtropellado()
        {
            if (tablero.carros.Any(carro => carro.posX == tablero.personaje.posX && carro.posY == tablero.personaje.posY))
            {
                mensaje.Text = "Fuiste atropellado";
                if (tablero.personaje.acompanante != null)
                {
                    if (tablero.personaje.acompanante.nombre == "Anciano")
                    {
                        tablero.personaje.punteo = tablero.personaje.punteo - 5;
                    }
                    else if (tablero.personaje.acompanante.nombre == "Mascota")
                    {
                        tablero.personaje.punteo = tablero.personaje.punteo - 5;
                    }
                }
                else
                {
                    tablero.personaje.punteo = tablero.personaje.punteo - 10;
                }
                if (tablero.personaje.punteo < 0)
                {
                    tablero.personaje.punteo = 0;
                }
                punteo.Text = "" + tablero.personaje.punteo;
                return true;
            }
            return false;
        }

        private bool personajeCruzoCalleArriba()
        {
            if (tablero.piezas.Any(pieza => pieza.tipo == "Pasto" && pieza.posY == tablero.personaje.posY && (pieza.posY == 1 || pieza.posY == 5)))
            {
                mensaje.Text = "Exitos, Entraste en área segura";
                
                if (tablero.personaje.acompanante != null)
                {
                    tablero.personaje.punteo = tablero.personaje.punteo + 2;
                    if (tablero.personaje.posY == 1 && tablero.personaje.acompanante.nombre == "Anciano")
                    {
                        tablero.personaje.punteo = tablero.personaje.punteo + 8;
                    }
                    if (tablero.personaje.posY == 1 && tablero.personaje.acompanante.nombre == "Mascota")
                    {
                        tablero.personaje.punteo = tablero.personaje.punteo + 8;
                    }
                }
                else
                {
                    tablero.personaje.punteo = tablero.personaje.punteo + 2;
                }
                
                punteo.Text = "" + tablero.personaje.punteo;
                return true;
            }
            return false;
        }
        private bool personajeCruzoCalleAbajo()
        {
            if (tablero.piezas.Any(pieza => pieza.tipo == "Pasto" && pieza.posY == tablero.personaje.posY && (pieza.posY == 4 || pieza.posY == 8)))
            {
                mensaje.Text = "Exitos, Entraste en área segura";
                tablero.personaje.punteo = tablero.personaje.punteo + 2;
                punteo.Text = "" + tablero.personaje.punteo;
                return true;
            }
            return false;
        }

        private bool personajeFinaliza()
        {
            if (tablero.piezas.Any(pieza => pieza.tipo == "Pasto" && pieza.posY == tablero.personaje.posY && (pieza.posY == 0)))
            {
                if (tablero.modo == "CruzarCalle") {
                    mensaje.Text = "Exitos, Llegaste!";
                    tablero.personaje.punteo = tablero.personaje.punteo + (5 * tablero.tiempo);
                    timerCarro1.Enabled = false;
                    timerTiempo.Enabled = false;
                }
                else if (tablero.modo == "AyudaAncianos")
                {
                    bool todosLlegaron = true;
                    foreach (Acompanante acompanante in tablero.acompanantes)
                    {
                        if (acompanante.posY != 0)
                        {
                            todosLlegaron = false;
                        }
                    }
                    if (todosLlegaron == true)
                    {
                        mensaje.Text = "Exitos, Llegaste!";
                        tablero.personaje.punteo = tablero.personaje.punteo + (5 * tablero.tiempo);
                        timerCarro1.Enabled = false;
                        timerTiempo.Enabled = false;
                    }
                    
                }
                else if (tablero.modo == "AyudaMascotas")
                {
                    bool todosLlegaron = true;
                    foreach (Acompanante acompanante in tablero.acompanantes)
                    {
                        if (acompanante.posY != 0)
                        {
                            todosLlegaron = false;
                        }
                    }
                    if (todosLlegaron == true)
                    {
                        mensaje.Text = "Exitos, Llegaste!";
                        tablero.personaje.punteo = tablero.personaje.punteo + (5 * tablero.tiempo);
                        timerCarro1.Enabled = false;
                        timerTiempo.Enabled = false;
                    }

                }
                
                
                punteo.Text = "" + tablero.personaje.punteo;
                return true;
            }
            return false;
        }

        private void TomarAcompanante()
        {
            if (tablero.tiempo > 0)
            {
                foreach (Acompanante acompanante in tablero.acompanantes)
                {
                    if (acompanante.posY == tablero.personaje.posY && acompanante.posX == tablero.personaje.posX)
                    {
                        tablero.personaje.acompanante = acompanante;
                        lblAcompanante.Text = acompanante.nombre;
                        this.Controls.Remove(acompanante.figura); //quita visualmente el acompanante
                        return;
                    }
                }
            }
        }

        private void SoltarAcompanante()
        {
            if (tablero.tiempo > 0)
            {
                Acompanante acompanante = tablero.personaje.acompanante;
                if (acompanante != null)
                {
                    lblAcompanante.Text = "";
                    acompanante.posX = tablero.personaje.posX;
                    acompanante.posY = tablero.personaje.posY;
                    this.Controls.Add(acompanante.figura); //agrega visualmente el acompanante
                    dibujarAcompanante(acompanante);
                    tablero.personaje.acompanante = null;
                    return;
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            SubirPersonaje();
        }
        private void SubirPersonaje()
        {
            if (tablero.tiempo > 0)
            {
                tablero.personaje.moverAdelante();
                dibujarPersonaje(tablero.personaje.posX, tablero.personaje.posY);
                personajeAtropellado();
                personajeCruzoCalleArriba();
                personajeFinaliza();
            }
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            MoverPersonajeIzquierda();
        }
        private void MoverPersonajeIzquierda()
        {
            if (tablero.tiempo > 0)
            {
                tablero.personaje.moverIzquierda();
                dibujarPersonaje(tablero.personaje.posX, tablero.personaje.posY);
                personajeAtropellado();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            MoverPersonajeDerecha();
        }
        private void MoverPersonajeDerecha()
        {
            if (tablero.tiempo > 0)
            {
                tablero.personaje.moverDerecha();
                dibujarPersonaje(tablero.personaje.posX, tablero.personaje.posY);
                personajeAtropellado();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            BajarPersonaje();
        }
        private void BajarPersonaje()
        {
            if (tablero.tiempo > 0)
            {
                tablero.personaje.moverAtras();
                dibujarPersonaje(tablero.personaje.posX, tablero.personaje.posY);
                personajeAtropellado();
                personajeCruzoCalleAbajo();
            }
        }

        void avanzarCarroAsync(Carro carro)
        {
            for (int x = 0; x < 2; x++)
            {
                carro.avanzar();
                dibujarCarro(carro);

            }
        }
        private void timerCarro1_Tick(object sender, EventArgs e)
        {
            foreach (Carro carro in tablero.carros)
            {
                avanzarCarroAsync(carro);
                personajeAtropellado();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            tablero.personaje.punteo = tablero.personaje.punteo - tablero.personaje.punteo;
            punteo.Text = "" + tablero.personaje.punteo;
            mensaje.Text = "";
            tablero.personaje.posX = 5;
            tablero.personaje.posY = 9;
            dibujarPersonaje(tablero.personaje.posX, tablero.personaje.posY);
            tablero.tiempo = 30;
            timerTiempo.Enabled = true;
            timerCarro1.Enabled = true;
        }

        private void CrossRoad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                SubirPersonaje();
            }
            if (e.KeyCode == Keys.Down)
            {
                BajarPersonaje();
            }
            if (e.KeyCode == Keys.Left)
            {
                MoverPersonajeIzquierda();
            }
            if (e.KeyCode == Keys.Right)
            {
                MoverPersonajeDerecha();
            }
            if (e.KeyCode == Keys.A) {
                TomarAcompanante();
            }
            if (e.KeyCode == Keys.S) {
                SoltarAcompanante();
            }
        }

        private void btnNpartida_Click(object sender, EventArgs e)
        {
            pnlMnu1.Visible = false;
            pnlModo.Dock = DockStyle.Fill;
            pnlModo.Visible = true;
            pnlModo.BringToFront();
        }

        private void btnModo1_Click(object sender, EventArgs e)
        {
            CreaTablero();
            tablero.modo = "CruzarCalle";
            pnlModo.Visible = false;
            pnlNivel1.Dock = DockStyle.Fill;
            pnlNivel1.Visible = true;
            pnlNivel1.BringToFront();
        }

        private void btnInstruciones_Click(object sender, EventArgs e)
        {
            pnlMnu1.Visible = false;
            pnlInstrucciones.Dock = DockStyle.Fill;
            pnlInstrucciones.Visible = true;
            pnlInstrucciones.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlInstrucciones_Paint(object sender, PaintEventArgs e)
        {
            lbInstruccion.Text = "Instrucciones";
            lbI1.Text = "Modo Cruzar la calle: a.Es el modo más simple, el personaje deberá cruzar la calle de un extremo a otro contra reloj y acumular puntos de acuerdo con lo siguiente:";
            lbI2.Text = "Acumulación de puntos: Eludir vehículos (+1 pts. por vehículo superado), +5 pts por cada segundo para que acabe el tiempo. Ganó: Si llega al otro extremo de la carretera en el tiempo pactado.";
            lbI3.Text = "Pérdida de puntos: Ser atropellado (-10 puntos por cada vez que es atropellado), Perdió: Si no cumple con el tiempo pactado, deberá iniciar el nivel.";
            lbI4.Text = "Modo Ayudar personas y Modo ayudar a mascotas: Estos modos consisten en trasportar ancianos o mascotas de un extremo a otro de la pantalla,para recoger a uno se deberá posicionar junto a este, ";
            lbI7.Text = "luego presionar la tecla “a” y para liberarlo se deberá presionar la tecla r.";
            lbI5.Text = "Acumulación de puntos: Eludir vehículos +1 punto, Eludir vehículos llevando uno consigo +2 puntos, Persona a salvo en el otro extremo de la carretera +10,";
            lbI8.Text = "+5 pts por cada segundo para que acabe el tiempo.Ganó: Si logra llevar todos los ancianos de un extremo a otro en el tiempo estipulado.";
            lbI6.Text = "Pérdida de puntos: Por ser atropellado -1, Por ser atropellado mientras se trasladaba a alguien -5, Por anciano no trasladado -10 puntos. Perdió: Si quedan ancianos pendientes.";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            pnlInstrucciones.Visible = false;
            pnlMnu1.Visible = true;
            pnlMnu1.BringToFront();
        }

        private void btnNiv11_Click(object sender, EventArgs e)
        {
            pnlNivel1.Visible = false;
            CrearPersonaje();
            CrearCarrosNivel1();
            if (tablero.modo == "AyudaAncianos")
            {
                CrearAcompanantesNivel1("Anciano");
                tablero.tiempo = 50;
            }
            else if (tablero.modo == "AyudaMascotas")
            {
                CrearAcompanantesNivel1("Mascota");
                tablero.tiempo = 50;
            }
            else {
                tablero.tiempo = 40;
            }
            timerCarro1.Interval = 1000;
            timerCarro1.Enabled = true;
            timerTiempo.Enabled = true;
        }

        private void btnNiv21_Click(object sender, EventArgs e)
        {
            pnlNivel1.Visible = false;
            CrearPersonaje();
            CrearCarrosNivel2();
            if (tablero.modo == "AyudaAncianos")
            {
                CrearAcompanantesNivel2("Anciano");
                tablero.tiempo = 70;
            }
            else if (tablero.modo == "AyudaMascotas")
            {
                CrearAcompanantesNivel2("Mascota");
                tablero.tiempo = 70;
            }
            else {
                tablero.tiempo = 30;
            }
            timerCarro1.Interval = 1000;
            timerCarro1.Enabled = true;
            timerTiempo.Enabled = true;
        }

        private void btnNiv31_Click(object sender, EventArgs e)
        {
            pnlNivel1.Visible = false;
            CrearPersonaje();
            CrearCarrosNivel3();
            if (tablero.modo == "AyudaAncianos")
            {
                CrearAcompanantesNivel3("Anciano");
                tablero.tiempo = 90;
            }
            else if (tablero.modo == "AyudaMascotas")
            {
                CrearAcompanantesNivel3("Mascota");
                tablero.tiempo = 90;
            }
            else
            {
                tablero.tiempo = 40;
            }
            timerCarro1.Interval = 1000;
            timerCarro1.Enabled = true;
            timerTiempo.Enabled = true;
        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            LimpiarCarros();
            LimpiarAcompanantes();
            timerCarro1.Enabled = false;
            pnlNivel1.Dock = DockStyle.Fill;
            pnlNivel1.Visible = true;
            pnlNivel1.BringToFront();
        }

        private void LimpiarCarros()
        {
            foreach (Carro carro in tablero.carros)
            {
                this.Controls.Remove(carro.figura);
            }
        }

        private void LimpiarAcompanantes()
        {
            if (tablero.acompanantes != null)
            {
                foreach (Acompanante acompanante in tablero.acompanantes)
                {
                    this.Controls.Remove(acompanante.figura);
                }
            }
            
        }

        private void btnModo2_Click(object sender, EventArgs e)
        {
            CreaTablero();
            tablero.modo = "AyudaAncianos";
            pnlModo.Visible = false;
            pnlNivel1.Dock = DockStyle.Fill;
            pnlNivel1.Visible = true;
            pnlNivel1.BringToFront();
        }

        private void btnModo3_Click(object sender, EventArgs e)
        {
            CreaTablero();
            tablero.modo = "AyudaMascotas";
            pnlModo.Visible = false;
            pnlNivel1.Dock = DockStyle.Fill;
            pnlNivel1.Visible = true;
            pnlNivel1.BringToFront();
        }

        private void btnTomarAcompanante_Click(object sender, EventArgs e)
        {
            TomarAcompanante();
        }

        private void btnSoltarAcompanante_Click(object sender, EventArgs e)
        {
            SoltarAcompanante();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timerTiempo_Tick(object sender, EventArgs e)
        {
            tablero.tiempo = tablero.tiempo - 1;
            lblTiempo.Text = "" + tablero.tiempo;
            if (tablero.tiempo <= 0)
            {
                timerTiempo.Enabled = false;
                timerCarro1.Enabled = false;

                if (tablero.modo == "AyudaAncianos")
                {
                    int cantidadNollegaron = 0;
                    foreach (Acompanante acompanante in tablero.acompanantes)
                    {
                        if (acompanante.posY != 0)
                        {
                            cantidadNollegaron = cantidadNollegaron + 1;
                        }
                    }
                    tablero.personaje.punteo = tablero.personaje.punteo - (10 * cantidadNollegaron);
                    
                }
                else if (tablero.modo == "AyudaMascotas")
                {
                    int cantidadNollegaron = 0;
                    foreach (Acompanante acompanante in tablero.acompanantes)
                    {
                        if (acompanante.posY != 0)
                        {
                            cantidadNollegaron = cantidadNollegaron + 1;
                        }
                    }
                    tablero.personaje.punteo = tablero.personaje.punteo - (10 * cantidadNollegaron);
                }
                if (tablero.personaje.punteo < 0)
                {
                    tablero.personaje.punteo = 0;
                }
                punteo.Text = "" + tablero.personaje.punteo;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNivel1.Visible = false;
            pnlModo.Dock = DockStyle.Fill;
            pnlModo.Visible = true;
            pnlModo.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlModo.Visible = false;
            pnlMnu1.Dock = DockStyle.Fill;
            pnlMnu1.Visible = true;
            pnlMnu1.BringToFront();
        }

        private void lblTiempo_Click(object sender, EventArgs e)
        {

        }



    }
}
