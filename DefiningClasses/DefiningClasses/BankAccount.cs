class BankAccount
{
    private int id;
    private double balance;

    public int ID
    {
        get
        {
            return this.id;
        }
        set
        {
            this.id = value;
        }
    }
    public double Balance
    {
        get
        {
            return this.balance;
        }
        set
        {
            this.balance = value;
        }
    }
    public void Deposit(double amaunt)
    {
        this.balance += amaunt;
    }
    public void Withdraw(double amaunt)
    {
        if (this.balance < amaunt)
        {
            System.Console.WriteLine("Insufficient balance");
        }
        else
        {
            this.balance -= amaunt;
        }
    }
    public override string ToString()
    {
        return $"Account ID{this.id}, balance {this.balance:f2}";
    }
}

