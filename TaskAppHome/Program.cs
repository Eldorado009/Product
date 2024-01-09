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
