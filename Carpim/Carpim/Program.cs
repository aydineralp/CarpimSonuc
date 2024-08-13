namespace Carpim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci sayiyi giriniz: ");  //birinci sayiyi kullanıcıdan isteriz.
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("İkinci sayiyi giriniz: ");  //ikinci sayiyi kullanicidan ister.
            int number2 = int.Parse(Console.ReadLine());

            int sonuc = number1 * number2;  //carpim yapilir
                                            
            Console.WriteLine($"Girilen sayilarin carpimi: {sonuc}");
        }
    }
}
