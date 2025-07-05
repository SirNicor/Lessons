class Cat
{
    public int age{ get; set; }
    public string Name{ get; set; }

    public Cat(string name)
    {
        Name = name;
    }
    public Cat()
    {
        
    }

    public void Print()
    {
        Console.WriteLine("Name: " + Name + " age: " + age);
    }
}

class Person2
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Address Address { get; set; }

    public void Print()
    {
        Console.WriteLine("Name: " + FirstName + " " + LastName);
        Console.WriteLine("Address: " + Address.Country + " "  + Address.City + " " + Address.Region);
    }
}

class Address
{
    public string Country { get; set; }
    public string Region { get; set; }
    public string City { get; set; }
}