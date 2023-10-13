using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact dueño = new("Luffy", "", "kingofthepirates@gmail.com");

            // Crear la lista de contactos
            Phonebook listaContactos = new Phonebook(dueño);

            // Agregar contactos a la lista
            Contact contactoEjemplo1 = new("Zoro", "+59893513457", "kingofhell@gmail.com");
            Contact contactoEjemplo2 = new("Sanji", "", "ifritjamble@gmail.com");
            Contact contactoEjemplo3 = new("Nami", "", "masterthief@gmail.com");
            Contact contactoEjemplo4 = new("Usopp", "", "seaemperor@gmail.com");
            Contact contactoEjemplo5 = new("Chopper", "", "emergencyfood@gmail.com");
            Contact contactoEjemplo6 = new("Robin", "", "archeologyst@gmail.com");

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos
            string[] destinatarios = new string[1]{"Zoro"};
            listaContactos.SendMessage(destinatarios, "Probando la API de Whatsapp :)");

            // Enviar un SMS a algunos contactos
        }
    }
}
