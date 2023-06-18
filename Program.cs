namespace faktoriyelH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi, fakt=1;
            Console.Write("Lütfen Sayıyı Giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            for(int i=sayi; i>0; i--)
            {
                fakt = fakt * i;
            }
            Console.WriteLine("Faktöriyel Sonucu: " + fakt);
            Console.ReadLine(); 
        }
    }
}