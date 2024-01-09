

using System.Collections;
using System.ComponentModel.Design;
using System.Runtime.Serialization;

string Welcome = "  _      _________________  __  _________\r\n | | /| / / __/ / ___/ __ \\/  |/  / __/ /\r\n | |/ |/ / _// / /__/ /_/ / /|_/ / _//_/ \r\n |__/|__/___/_/\\___/\\____/_/  /_/___(_)  \r\n                                         ";
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(Welcome);
string Option = "Option download:)";
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(Option);
Console.ResetColor();


Directory.CreateDirectory(@".\Product");
if (!File.Exists(@".\Product\product.txt"))
{
    File.Create(@".\Product\product.txt");
}
bool run = true;
while (run)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("1 - Create Product \n" +
                      "2 - Show All\n" +
                      "0 - Close");
    Console.ResetColor();


    string? option = Console.ReadLine();
    int optionNumber;
    bool isInt = int.TryParse(option, out optionNumber);
    if (isInt)
    {
        if (optionNumber >= 0 && optionNumber <= 2)
        {
            switch (optionNumber)
            {
                case (int)Menu.CreateProduct:
                    try
                    {
                        Console.Write("Enter product's id: ");
                        int Id;
                        while (!int.TryParse(Console.ReadLine(), out Id) || (Id < 0))
                        {
                            throw new IncorrectFormatException("incorrect format id! Please try again");
                        }

                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine(ex.Message);
                    }   
                break;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPlease enter correct number!\n");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nPlease enter correct format!\n");
        Console.ResetColor();
    }
}

[Serializable]
private class IncorrectFormatException : Exception
{
    public IncorrectFormatException()
    {
    }

    public IncorrectFormatException(string? message) : base(message)
    {
    }

    public IncorrectFormatException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected IncorrectFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public override IDictionary Data => base.Data;

    public override string? HelpLink { get => base.HelpLink; set => base.HelpLink = value; }

    public override string Message => base.Message;

    public override string? Source { get => base.Source; set => base.Source = value; }

    public override string? StackTrace => base.StackTrace;

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override Exception GetBaseException()
    {
        return base.GetBaseException();
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        base.GetObjectData(info, context);
    }

    public override string ToString()
    {
        return base.ToString();
    }
}