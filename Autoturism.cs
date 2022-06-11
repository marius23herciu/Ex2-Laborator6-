using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2_Laborator6_
{
    class Autoturism
    {
        private string marca;
        private string numarInmatriculare;
        private int capacitateCilindrica;

        /// <summary>
        /// Modeleaza un autoturism
        /// </summary>
        /// <param name="marca">Marca autoturismului</param>
        /// <param name="numarInmatriculare">Nuarul de inmatriculare</param>
        /// <param name="capacitateCilindrica">Capacitatea cilindrica</param>
        public Autoturism(string marca, string numarInmatriculare, int capacitateCilindrica)
        {
            this.marca = marca;
            this.numarInmatriculare = numarInmatriculare;
            this.capacitateCilindrica = capacitateCilindrica;
        }

        /// <summary>
        /// Formeaza un string cu descrierea autoturismului
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            string descriereAutoturism = $"Autoturismul {marca} are numarul de inmatriculare {numarInmatriculare} si capacitatea cilindrica {capacitateCilindrica}";
            return descriereAutoturism;
        }

        /// <summary>
        /// Tipareste caracteristicile autoturismului
        /// </summary>
        public void Tipareste()
        {
            Console.WriteLine(GetDescription());
        }
    }
}
