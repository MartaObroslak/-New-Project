// Klasa dla wiadomości SMS, dziedzicząca z Message.
public class SMSMessage : Message
{
    // Konstruktor przekazujący treść wiadomości do klasy bazowej.
    public SMSMessage(string content) : base(content) {}

    // Implementacja metody PrepareText, która rzuca wyjątek, jeśli długość wiadomości przekracza 140 znaków.
    public override string PrepareText()
    {
        if (Content.Length > 140)
            throw new ArgumentException("SMS message cannot exceed 140 characters.");
        
        return Content;
    }
}
