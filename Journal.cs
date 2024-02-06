Console.OutputEncoding = System.Text.Encoding.UTF8;

Journal jour = new Journal();
jour.input("Журнал по програмуванню", "2024", "Нотатки", "+380661234554", "mymail@gmail.com");
jour.print();
internal class Journal
{
    private string name;
    private string year;
    private string description;
    private string number;
    private string email;

    public void input(string name, string year, string description, string number, string email)
    {
        this.name = name;
        this.year = year;
        this.description = description;
        this.number = number;
        this.email = email;
    }
    public string getName()
    {
        return name;
    }
    public string getYear()
    {
        return year;
    }
    public string getDescription()
    {
        return description;
    }
    public string getNumber()
    {
        return number;
    }
    public string getEmail()
    {
        return email;
    }
    public void print() => Console.Out.WriteLine($"Name: {name}\nCreation date: {year}\nDescription: {description}\nContact number: {number}\nEmail adress: {email}");
}
