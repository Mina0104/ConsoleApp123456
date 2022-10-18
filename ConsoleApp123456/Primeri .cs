namespace ConsoleApp123456
{
    public static class Primeri
    {
        public static double Delenie(int a, int b)
        {
            double c = (5 * a + b * b) / (b - a);
            return c;
        }

        public static void Deleniyeostatkom(int a, int b, out int result,out int fractionResult)
        {
            result = a / b;
            fractionResult = a % b;
        }

        public static int Podsctitat(int a, int b)
        {
            if (a > b)
            {
                return a + b;

            }
            else if (a == b)
            {
                return a * b;
            }
            else
            {
                return a - b;
            }

        }
        public static void LineEquation(int x1, int y1, int x2, int y2)
        {
            double a = (y2 -y1) / (x2 - x1);
            double b = y1 - a * x1 + y2;
            Console.WriteLine("y=" + a + "x" + b);
        }

    }    
     

}







 





