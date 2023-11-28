namespace FindBiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myNumbers= { 2, 1, 7, 4, 9, 5 };
           int biggest= Numbers.BiggestNumber(myNumbers);
            int SecondBiggestNumber = Numbers.SecondBiggestNumber(myNumbers);
            Console.WriteLine("The biggest number is " + biggest);
            Console.WriteLine("The second biggest number is " + SecondBiggestNumber);
            string capitalized = Words.CapitalizeFirstWords( "I hope you had a good weekend?");
            Console.WriteLine(capitalized);
        }
    }
}