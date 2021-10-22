using System;

namespace AvisosVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico general = new AvisosTrafico();
            general.mostrarAviso();

            AvisosTrafico carlosMadrid = new AvisosTrafico("Direccion General de Madrid", "Multa por exceso de velodicdad", "18/08/2020");
            carlosMadrid.mostrarAviso();

        }
    }
}
