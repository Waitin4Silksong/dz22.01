Console.OutputEncoding = System.Text.Encoding.UTF8;

Website web = new Website(); 
web.input("YouTube", "https://www.youtube.com", "Відео хостинг", "216.58.206.46");
web.print();
internal class Website
{
    private string name;
    private string url;
    private string description;
    private string ip;

    public void input(string name, string url, string description, string ip)
    {
        this.name = name;
        this.url = url;
        this.description = description;
        this.ip = ip;
    }
    public string getName()
    {
        return name;
    }
    public string getUrl()
    {
        return url;
    }
    public string getDescription()
    {
        return description;
    }
    public string getIp()
    {
        return ip;
    }
    public void print() => Console.Out.WriteLine($"Name: {name}\nURL: {url}\nDescription: {description}\nIP-adress: {ip}");
}





