using System; 

public class Program {

  public static void Main(string[] args) {
    System.Console.OutputEncoding = System.Text.Encoding.UTF8;
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
     if ((a<=3) && (a>=1) ) Console.WriteLine($"Число {a} входит в интервал ");
     else Console.WriteLine($"Число {a} не входит в интервал");
      if ((b<=3) && (b>=1) ) Console.WriteLine($"Число {b} входит в интервал ");
     else Console.WriteLine($"Число {b} не входит в интервал");
      if ((c<=3) && (c>=1) ) Console.WriteLine($"Число {c} входит в интервал ");
     else Console.WriteLine($"Число {c} не входит в интервал");
      

  }
}
