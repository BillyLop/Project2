using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_crossroad
{
    class Tablero
    {
        int tamanoX;
        int tamanoY;
        public List<Pieza> piezas { get; set; }
        public List<Carro> carros { get; set; }
        public Personaje personaje { get; set; }
        public List<Acompanante> acompanantes { get; set; }
        public String modo { get; set; }
        public int tiempo { get; set; }

        public Tablero(int tamanoX, int tamanoY, int tiempo)
        {
            this.tamanoX = tamanoX;
            this.tamanoY = tamanoY;
            this.tiempo = tiempo;
        }



    }
}
