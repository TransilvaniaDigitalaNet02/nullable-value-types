namespace NullableValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<bool> flag = false;

            Console.WriteLine(flag.GetValueOrDefault(true));


            int? nullableInt = null;
            nullableInt.GetValueOrDefault(-10);


        }
    }
}