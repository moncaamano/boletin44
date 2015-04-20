using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4_4_X
{
    public class PersonaRamonCaamano
    {
        public PersonaRamonCaamano(int altura, int peso, string colorOjos, string colorPelo)
        {
            this.alturaRamonCaamano = altura;
            this.colorOjosRamonCaamano = colorOjos;
            this.colorPeloRamonCaamano = colorPelo;
            this.pesoRamonCaamano = peso;
        }

        private int pesoRamonCaamano;

        public int PesoRamonCaamano
        {
            get { return pesoRamonCaamano; }
            set { pesoRamonCaamano = value; }
        }
        private int alturaRamonCaamano;

        public int AlturaRamonCaamano
        {
            get { return alturaRamonCaamano; }
            set { alturaRamonCaamano = value; }
        }
        private string colorOjosRamonCaamano;

        public string ColorOjosRamonCaamano
        {
            get { return colorOjosRamonCaamano; }
            set { colorOjosRamonCaamano = value; }
        }
        private string colorPeloRamonCaamano;

        public string ColorPeloRamonCaamano
        {
            get { return colorPeloRamonCaamano; }
            set { colorPeloRamonCaamano = value; }
        }

        public void PonerLentillasRamonCaamano(string colorLentillas)
        {
            if (ComprobarColorRamonCaamano(colorLentillas))
                this.ColorOjosRamonCaamano = colorLentillas;
        }
        public bool ComprobarColorRamonCaamano(string colorLentillas)
        {
            return colorLentillas.Equals("azul") || colorLentillas.Equals("verde") || colorLentillas.Equals("marron");
        }
        public void EngordarRamonCaamano(int cantidad)
        {
            int nuevo_peso = this.PesoRamonCaamano + cantidad;

            if (nuevo_peso > 180)
            {
                Console.WriteLine("Cantidad incorrecta");
            }
            else
            {
                this.PesoRamonCaamano = nuevo_peso;
            }

        }

        public void AdelgazarRamonCaamano(int cantidad)
        {
            int nuevo_peso = this.PesoRamonCaamano - cantidad;

            if (nuevo_peso < 40)
            {
                Console.WriteLine("Cantidad incorrecta");
            }
            else
            {
                this.PesoRamonCaamano = nuevo_peso;
            }
        }
    }
}
