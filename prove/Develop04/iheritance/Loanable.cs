public class Loanable
{
    private bool _isCheckedIn = true;
    public void CheckedOut()
    {
        _isCheckedIn = false;
    }

    public void CheckedIn()
    {
        _isCheckedIn = true;
    }
    public virtual void Display()
    {
        Console.WriteLine($"Available: {_isCheckedIn}");
    }
}