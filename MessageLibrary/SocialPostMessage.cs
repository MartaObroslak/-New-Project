// Klasa dla postów w mediach społecznościowych, dziedzicząca z Message.
public enum SocialMedium { Facebook, Instagram, Twitter }
public class SocialPostMessage : Message
{
    // Pole przechowujące typ medium społecznościowego.
    private SocialMedium Medium;
    
    // Słownik określający maksymalną długość wiadomości dla każdego medium.
    private IDictionary<SocialMedium, int> MaxLengths = new Dictionary<SocialMedium, int>
    {
        { SocialMedium.Facebook, 200 },
        { SocialMedium.Instagram, 220 },
        { SocialMedium.Twitter, 280 }
    };

    // Konstruktor przyjmujący treść wiadomości i typ medium społecznościowego.
    public SocialPostMessage(string content, SocialMedium medium) : base(content)
    {
        Medium = medium;
    }

    // Implementacja metody PrepareText, która obcina wiadomość do długości określonej dla danego medium.
    public override string PrepareText()
    {
        int maxLength = MaxLengths[Medium];
        return Content.Length > maxLength ? Content.Substring(0, maxLength) : Content;
    }
}
