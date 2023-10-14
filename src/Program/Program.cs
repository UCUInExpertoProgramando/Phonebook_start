using System;
using WhatsAppApiUCU;

namespace TuNombreDelProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crea una instancia de WhatsAppApi
            WhatsAppApi api = new WhatsAppApi();

            // mensaje que envia
            string mensaje = "Hola, este es un mensaje de prueba.";

            string numeroDestino = "+59896043449";

            // Llama al método Send para enviar el mensaje
            string resultado = api.Send(numeroDestino, mensaje);

            Console.WriteLine(resultado);

        }
    }
}