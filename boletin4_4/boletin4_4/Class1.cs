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

        public int pesoRamonCaamano;
        public int alturaRamonCaamano;
        public string colorOjosRamonCaamano;
        public string colorPeloRamonCaamano;

        public void PonerLentillasRamonCaamano(string colorLentillas)
        {
            if (ComprobarColorRamonCaamano(colorLentillas))
                this.colorOjosRamonCaamano = colorLentillas;
        }
        public bool ComprobarColorRamonCaamano(string colorLentillas)
        {
            return colorLentillas.Equals("azul") || colorLentillas.Equals("verde") || colorLentillas.Equals("marron");
        }
        public void EngordarRamonCaamano(int cantidad)
        {
            int nuevo_peso = this.pesoRamonCaamano + cantidad;

            if (nuevo_peso > 180)
            {
                Console.WriteLine("Cantidad incorrecta");
            }
            else
            {
                this.pesoRamonCaamano = nuevo_peso;
            }

        }

        public void AdelgazarRamonCaamano(int cantidad)
        {
            int nuevo_peso = this.pesoRamonCaamano - cantidad;

            if (nuevo_peso < 40)
            {
                Console.WriteLine("Cantidad incorrecta");
            }
            else
            {
                this.pesoRamonCaamano = nuevo_peso;
            }
        }
    }
}
