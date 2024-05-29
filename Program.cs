// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;


Console.InputEncoding = Encoding.UTF8; 




Console.WriteLine("mời bạn nhập tên vào");
string names = Console.ReadLine();
//Console.WriteLine($"teen cua ban la : {names}");
Console.WriteLine(names);
string tuoi= Console.ReadLine();
Console.WriteLine("mời bạn nhập tuổi vào : ");
Console.WriteLine(tuoi);
//Console.WriteLine($"tuổi của bạn là {tuoi}");
string diachi = Console.ReadLine();
Console.WriteLine(diachi);
//Console.WriteLine($"địa chỉ của bạn là {diachi} ");
Console.WriteLine($"tên của bạn là  {names}, Tuối{tuoi},địa chỉ của bạm{diachi}");

Console.ReadKey();  