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
            Contact contactoEjemplo2 = new("Sanji", "+59896043449", "ifritjamble@gmail.com");
            Contact contactoEjemplo3 = new("Nami", "+59894799058", "masterthief@gmail.com");
            Contact contactoEjemplo4 = new("Usopp", "+59895358600", "seaemperor@gmail.com");
            Contact contactoEjemplo5 = new("Chopper", "", "emergencyfood@gmail.com");
            Contact contactoEjemplo6 = new("Robin", "", "archeologyst@gmail.com");
            listaContactos.AddContact(contactoEjemplo1);
            listaContactos.AddContact(contactoEjemplo2);
            listaContactos.AddContact(contactoEjemplo3);
            listaContactos.AddContact(contactoEjemplo4);
            listaContactos.AddContact(contactoEjemplo5);
            listaContactos.AddContact(contactoEjemplo6);

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos
            string[] destinatarios = new string[2]{"Zoro", "Sanji"};
            listaContactos.SendWhatsappMessage(destinatarios, "Este mensaje solo le llegará a Zoro y a Sanji.");
            destinatarios = new string[2]{"Nami", "Usopp"};
            listaContactos.SendWhatsappMessage(destinatarios, "Este mensaje solo le llegará a Nami y a Usopp.");
            destinatarios = new string[2]{"Zoro", "Nami"};
            listaContactos.SendWhatsappMessage(destinatarios, "Este mensaje solo le llegará a Zoro y a Nami.");
            destinatarios = new string[2]{"Sanji", "Usopp"};
            listaContactos.SendWhatsappMessage(destinatarios, "Este mensaje solo le llegará a Sanji y a Usopp.");
            destinatarios = new string[2]{"Zoro", "Usopp"};
            listaContactos.SendWhatsappMessage(destinatarios, "Este mensaje solo le llegará a Zoro y a Usopp.");

            // Enviar un SMS a algunos contactos
        }
    }
}
