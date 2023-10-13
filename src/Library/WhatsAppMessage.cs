namespace Library;

public class WhatsAppMessage : Message
{
    public WhatsAppMessage(Contact contact, string mensaje) :
        base(null, contact.Phone, mensaje)
    {
        // Intencionalmente en blanco
    }
}