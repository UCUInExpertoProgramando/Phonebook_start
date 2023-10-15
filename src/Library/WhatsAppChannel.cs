using WhatsAppApiUCU;

namespace Library;
public class WhatsAppChannel : IMessageChannel
{
    public void Send(Message message)
    {
        var whatsApp = new WhatsAppApi();
        whatsApp.Send(message.To, message.Text);
    }

    public Message CreateMessage(Contact from, Contact to, string texto)
    {
        return new WhatsAppMessage(to, texto);
    }
}