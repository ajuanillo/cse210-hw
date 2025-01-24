public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public void Display()
    {
            Console.WriteLine("Plese select one of the following choices:");
            Console.WriteLine("1. Write");  // Showing the menu
            Console.WriteLine("2. Display");  //
            Console.WriteLine("3. Load");   //
            Console.WriteLine("4. Save");  //
            Console.WriteLine("5. Quit");  //
    }
}