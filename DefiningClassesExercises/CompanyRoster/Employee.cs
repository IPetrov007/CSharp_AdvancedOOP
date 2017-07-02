class Employee
{
    public string name;
    public double salary;
    public string position;
    public string department;
    public string email;
    public int age;

    public Employee(string name, double salary, string position, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = "n/a";
        this.age = -1;
    }
    public string Email
    {
        get
        {
            return this.email;
        }
        set
        {
            this.email = value;
        }
    }
    public int Age
    {
        get
        {
            return this.age;
        }
        set
        {
            this.age = value;
        }
    }
}

