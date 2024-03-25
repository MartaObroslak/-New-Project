// Klasa dla wiadomości Email, dziedzicząca z Message.
public class EmailMessage : Message
{
    // Konstruktor przekazujący treść wiadomości do klasy bazowej.
    public EmailMessage(string content) : base(content) {}

    // Implementacja metody PrepareText, konwertująca znaki nowej linii na tagi <br> dla HTML.
    public override string PrepareText()
    {
        return Content.Replace("\n", "<br>");
    }
}

