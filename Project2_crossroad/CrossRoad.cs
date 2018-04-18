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

        public void CreaTablero()
        {

            tablero = new Tablero(12, 10);
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

            tablero.personaje = new Personaje("Kirito", 5, 9);
            punteo.Text = "" + tablero.personaje.punteo;

            //creacion de carros
            tablero.carros = new List<Carro>();
            Carro carro = new Carro("Azul", 9, 2);
            carro.direccion = "Izquierda";
            tablero.carros.Add(carro);

            Carro carro1 = new Carro("Azulregreso", 0, 3);
            carro1.direccion = "Derecha";
            tablero.carros.Add(carro1);

            Carro carro2 = new Carro("Amarillo", 7, 2);
            carro2.direccion = "Izquierda";
            tablero.carros.Add(carro2);

            Carro carro3 = new Carro("Amarilloregreso", 3, 3);
            carro3.direccion = "Derecha";
            tablero.carros.Add(carro3);

            Carro carro4 = new Carro("Rojo", 9, 6);
            carro4.direccion = "Izquierda";
            tablero.carros.Add(carro4);

            Carro carro5 = new Carro("Rojoregreso", 0, 7);
            carro5.direccion = "Derecha";
            tablero.carros.Add(carro5);

            Carro carro6 = new Carro("Verde", 5, 6);
            carro6.direccion = "Izquierda";
            tablero.carros.Add(carro6);

            Carro carro7 = new Carro("Verderegreso", 3, 7);
            carro7.direccion = "Derecha";
            tablero.carros.Add(carro7);

            Carro carro8 = new Carro("Negro", 2, 6);
            carro8.direccion = "Izquierda";
            tablero.carros.Add(carro8);

            Carro carro9 = new Carro("Negroregreso", 5, 7);
            carro9.direccion = "Derecha";
            tablero.carros.Add(carro9);

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

            //dibujar personaje
            posX = 10 + (tablero.personaje.posX * 60);
            posY = 40 + (tablero.personaje.posY * 50);
            tablero.personaje.figura.Location = new Point(posX, posY);
            this.Controls.Add(tablero.personaje.figura);
            tablero.personaje.figura.BackColor = Color.Transparent;
            tablero.personaje.figura.BringToFront();

            //dibujar carros
            foreach (Carro carron in tablero.carros)
            {
                posX = 10 + (carron.posX * 60);
                posY = 40 + (carron.posY * 50);
                carron.figura.Location = new Point(posX, posY);
                this.Controls.Add(carron.figura);
                carron.figura.BackColor = Color.Transparent;
                carron.figura.BringToFront();
            }
        }
        public CrossRoad()
        {
            InitializeComponent();
            CreaTablero();

        }
        private void dibujarCarro(Carro carro)
        {
            int posX = 10 + (carro.posX * 60);
            int posY = 40 + (carro.posY * 50);
            carro.figura.Location = new Point(posX, posY);
            carro.figura.BackColor = Color.Transparent;
            carro.figura.BringToFront();
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            SubirPersonaje();
        }
        private void SubirPersonaje()
        {
            tablero.personaje.moverAdelante();
            dibujarPersonaje(tablero.personaje.posX, tablero.personaje.posY);
            personajeAtropellado();
            personajeCruzoCalleArriba();
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            MoverPersonajeIzquierda();
        }
        private void MoverPersonajeIzquierda()
        {
            tablero.personaje.moverIzquierda();
            dibujarPersonaje(tablero.personaje.posX, tablero.personaje.posY);
            personajeAtropellado();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            MoverPersonajeDerecha();
        }
        private void MoverPersonajeDerecha()
        {
            tablero.personaje.moverDerecha();
            dibujarPersonaje(tablero.personaje.posX, tablero.personaje.posY);
            personajeAtropellado();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            BajarPersonaje();
        }
        private void BajarPersonaje()
        {
            tablero.personaje.moverAtras();
            dibujarPersonaje(tablero.personaje.posX, tablero.personaje.posY);
            personajeAtropellado();
            personajeCruzoCalleAbajo();
        }
        private void dibujarPersonaje(int x, int y)
        {
            int posX = 10 + (x * 60);
            int posY = 40 + (y * 50);
            tablero.personaje.figura.Location = new Point(posX, posY);
            tablero.personaje.figura.BackColor = Color.Transparent;
            tablero.personaje.figura.BringToFront();
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

        private bool personajeAtropellado()
        {
            if (tablero.carros.Any(carro => carro.posX == tablero.personaje.posX && carro.posY == tablero.personaje.posY))
            {
                mensaje.Text = "Game Over, Fuiste atropellado";
                tablero.personaje.punteo = tablero.personaje.punteo - 10;
                punteo.Text = "" + tablero.personaje.punteo;
                timerCarro1.Enabled = false;
                return true;
            }
            return false;
        }

        private bool personajeCruzoCalleArriba()
        {
            if (tablero.piezas.Any(pieza => pieza.tipo == "Pasto" && pieza.posY == tablero.personaje.posY && (pieza.posY == 1 || pieza.posY == 5)))
            {
                mensaje.Text = "Exitos, Entraste en área segura";
                tablero.personaje.punteo = tablero.personaje.punteo + 2;
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
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            tablero.personaje.posX = 5;
            tablero.personaje.posY = 9;
            dibujarPersonaje(tablero.personaje.posX, tablero.personaje.posY);
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
        }

        
    }
}
