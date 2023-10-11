using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact dueño = new("Luffy");

            // Crear la lista de contactos
            Phonebook listaContactos = new Phonebook(dueño);

            // Agregar contactos a la lista
            Contact contactoEjemplo1 = new("Zoro");
            Contact contactoEjemplo2 = new("Sanji");

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            // Enviar un SMS a algunos contactos
        }
    }
}
