namespace Test3_Mounika_1.ArithmaticException
{
    public class ArithmaticException1
    {
        public int Id { get; set; }
        public float FirstNumber { get; set; }

        public float SecondNumber { get; set; }
        public float ThirdNumber { get; set; }
        public float Result { get; set; }
        public void Method()
        {
            int number1 = 10;
            int number2 = 0;
            try
            {
                Console.WriteLine(number1 / number2);
            }
            catch (Exception)
            {
                Console.WriteLine("Division of {0} by Zero is an Exception", number1);
            }
            finally
            {
                Console.WriteLine("Arithmatic Exceptions Are Occured");
            }
        }
        public void Method2()
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("Enter Your Id:");
            try
            {
                
                Id = Int32.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("You have entered non-numeric characters");

            }
            finally
            {
                Console.WriteLine("Only NumericValue is Taken");
            }


        }
        
        public void Multiplication()
        {
            try
            {
                int x;
                int y;
                int z;
                int u;
                Console.WriteLine("***********************************************");
                Console.WriteLine("Enter a value:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b value:");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter c value:");
                z = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter d value:");
                u = Convert.ToInt32(Console.ReadLine());
                int e = x * y * z * u;
                Console.WriteLine("The Result is :" + e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


    }
}   
