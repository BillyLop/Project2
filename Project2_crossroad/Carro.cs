using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_crossroad
{
    class Carro : Pieza
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int punteoARestar { get; set; }

        public Carro (string nombre, int posX, int posY)
        {
            this.nombre = nombre;
            this.tipo = "Carro";
            this.posX = posX;
            this.posY = posY;
            this.punteoARestar = 10;

            if (nombre == "Azul")
            {
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/azul.png");
                figura.Size = new Size(60, 50);
                figura.SizeMode = PictureBoxSizeMode.StretchImage;
                figura.BackColor = Color.Transparent;

            }
            if (nombre == "Azulregreso")
            {
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/azulregreso.png");
                figura.Size = new Size(60, 50);
                figura.SizeMode = PictureBoxSizeMode.StretchImage;
                figura.BackColor = Color.Transparent;
            }
            if (nombre == "Amarillo")
            {
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/amarillo.png");
                figura.Size = new Size(60, 50);
                figura.SizeMode = PictureBoxSizeMode.StretchImage;
                figura.BackColor = Color.Transparent;
            }

            if (nombre == "Amarilloregreso")
            {
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/amarilloregreso.png");
                figura.Size = new Size(60, 50);
                figura.SizeMode = PictureBoxSizeMode.StretchImage;
                figura.BackColor = Color.Transparent;
            }
            if (nombre == "Rojo")
            {
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/rojo.png");
                figura.Size = new Size(60, 50);
                figura.SizeMode = PictureBoxSizeMode.StretchImage;
                figura.BackColor = Color.Transparent;
            }

            if (nombre == "Rojoregreso")
            {
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/rojoregreso.png");
                figura.Size = new Size(60, 50);
                figura.SizeMode = PictureBoxSizeMode.StretchImage;
                figura.BackColor = Color.Transparent;
            }
            if (nombre == "Verde")
            {
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/verde.png");
                figura.Size = new Size(60, 50);
                figura.SizeMode = PictureBoxSizeMode.StretchImage;
                figura.BackColor = Color.Transparent;
            }

            if (nombre == "Verderegreso")
            {
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/verderegreso.png");
                figura.Size = new Size(60, 50);
                figura.SizeMode = PictureBoxSizeMode.StretchImage;
                figura.BackColor = Color.Transparent;
            }
            if (nombre == "Negro")
            {
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/negro.png");
                figura.Size = new Size(60, 50);
                figura.SizeMode = PictureBoxSizeMode.StretchImage;
                figura.BackColor = Color.Transparent;
            }

            if (nombre == "Negroregreso")
            {
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/negroregreso.png");
                figura.Size = new Size(60, 50);
                figura.SizeMode = PictureBoxSizeMode.StretchImage;
                figura.BackColor = Color.Transparent;
            }
        }

        public void avanzar()
        {
            if (direccion == "Izquierda")
            {
                if (posX == 0)
                {
                    posX = 9;
                }
                else
                {
                    posX = posX - 1;
                }
            }
            else
            {
                if (posX == 9)
                {
                    posX = 0;
                }
                else
                {
                    posX = posX + 1;
                }
            }
            
        }

    }
}
