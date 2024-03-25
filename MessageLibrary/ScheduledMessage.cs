// Generyczna klasa ScheduledMessage, która zapewnia funkcjonalność zaplanowanego wysyłania wiadomości.
// Ograniczenie 'where T : Message' zapewnia, że T musi być typem pochodzącym od klasy Message.
public class ScheduledMessage<T> where T : Message
{
    // Prywatne pole 'message' typu T przechowuje instancję wiadomości do wysłania.
    private T message;
    
    // Prywatne pole 'sendTime' przechowuje czas, kiedy wiadomość ma zostać wysłana.
    private DateTime sendTime;

    // Konstruktor przyjmujący dwa argumenty: 'message' - instancję wiadomości, 'sendTime' - czas wysyłki.
    // Te argumenty są przypisywane do odpowiadających im pól klasy.
    public ScheduledMessage(T message, DateTime sendTime)
    {
        this.message = message;
        this.sendTime = sendTime;
    }

    // Metoda TryToSend sprawdza, czy obecny czas jest równy lub późniejszy niż zaplanowany czas wysyłki.
    // Zwraca wartość boolowską: 'true', jeśli czas wysyłki nadszedł i wiadomość jest wysyłana, 
    // lub 'false', jeśli czas jeszcze nie nadszedł.
    public bool TryToSend()
    {
        if (DateTime.Now >= sendTime)
        {
            // Jeśli nadszedł czas wysyłki, metoda PrepareText z klasy Message jest wywoływana
            // w celu przygotowania wiadomości, a następnie wynik jest wyświetlany na konsoli.
            Console.WriteLine(message.PrepareText());
            return true; // Wiadomość została "wysłana", zwracamy 'true'.
        }
        return false; // Czas wysyłki jeszcze nie nadszedł, zwracamy 'false'.
    }
}
