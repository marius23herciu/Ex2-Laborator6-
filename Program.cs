using System;

namespace Ex2_Laborator6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Autoturism dacia = new Autoturism("Dacia", "BC 01 BCB", 1400);
            Autoturism fiat = new Autoturism("Fiat", "CJ 01 CJC", 1500);

            dacia.Tipareste();
            fiat.Tipareste();
        }
    }
}
