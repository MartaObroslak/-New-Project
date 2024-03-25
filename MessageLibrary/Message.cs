// Abstrakcyjna klasa bazowa dla wszystkich typów wiadomości.
// Zawiera treść wiadomości oraz wymaga zaimplementowania metody PrepareText w klasach pochodnych.
public abstract class Message
{
    // Pole chronione przechowujące treść wiadomości.
    protected string Content;

    // Konstruktor przyjmujący treść wiadomości.
    public Message(string content)
    {
        Content = content;
    }

    // Abstrakcyjna metoda do przygotowania tekstu wiadomości.
    public abstract string PrepareText();
}

