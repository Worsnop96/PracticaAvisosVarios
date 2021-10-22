using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisosVarios
{
    class AvisosTrafico : IAvisos
    {

        public AvisosTrafico()
        {
            remitente = "DGT";
            mensaje = "Sancion comedita. Si paga en el mes correspondiente puede ahorrarse un 50% en sus multas";
            fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente= remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;

        }


        public string getFecha()
        {
            return fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine("Mensaje {0} enviado por {1} el dia {2}", mensaje, remitente, fecha);
        }

        private string remitente;
        private string mensaje;
        private string fecha;
    }
}
