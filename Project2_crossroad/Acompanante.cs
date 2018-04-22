using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_crossroad
{
    class Acompanante: Pieza
    {
        public String nombre { get; set; }

        public Acompanante (String nombre, int posX, int posY)
        {
            this.nombre = nombre;
            this.tipo = "Acompanante";
            this.posX = posX;
            this.posY = posY;

            if (nombre == "Anciano")
            {
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/personaje5.png");
                figura.Size = new Size(60, 50);
                figura.SizeMode = PictureBoxSizeMode.StretchImage;
                figura.BackColor = Color.Transparent;
            }
            if (nombre == "Mascota")
            {
                figura = new PictureBox();
                figura.Image = Image.FromFile("../../imagenes/mascota.png");
                figura.Size = new Size(60, 50);
                figura.SizeMode = PictureBoxSizeMode.StretchImage;
                figura.BackColor = Color.Transparent;
            }
        }
    }
}
