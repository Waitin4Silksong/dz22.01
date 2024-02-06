Console.OutputEncoding = System.Text.Encoding.UTF8;

Shop shop = new Shop();
shop.input("Продукти", "Гетьмана Мазепи 13", "Продуктовий магазин", "+380661234554", "shop@gmail.com");
shop.print();
internal class Shop
{
    private string name;
    private string adress;
    private string description;
    private string number;
    private string email;

    public void input(string name, string adress, string description, string number, string email)
    {
        this.name = name;
        this.adress = adress;
        this.description = description;
        this.number = number;
        this.email = email;
    }
    public string getName()
    {
        return name;
    }
    public string getAdress()
    {
        return adress;
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
    public void print() => Console.Out.WriteLine($"Name: {name}\nAdress: {adress}\nDescription: {description}\nContact number: {number}\nEmail adress: {email}");
}