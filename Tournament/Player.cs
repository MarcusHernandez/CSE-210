public class Player
{
    private string _firstname;
    private string _lastname;
    private int _jersey;

    public Player(string firstName, string lastName, int jerseyNumber)
    {
        _firstname = firstName;
        _lastname = lastName;
        _jersey = jerseyNumber;
    }

    public void UpdateJersey(int NewNumber)
    {
        _jersey = NewNumber;
    }

    public void Display()
    {
        Console.WriteLine($"{_firstname}, {_lastname}, {_jersey}");
    }
}