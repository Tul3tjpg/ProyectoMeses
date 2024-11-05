namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número");
            string[] mesesA = new string[12];

            mesesA[0] = "Enero";
            mesesA[1] = "Febrero";
            mesesA[2] = "Marzo";
            mesesA[3] = "Abril";
            mesesA[4] = "Mayo";
            mesesA[5] = "Junio";
            mesesA[6] = "Julio";
            mesesA[7] = "Agosto";
            mesesA[8] = "Septiembre";
            mesesA[9] = "Octubre";
            mesesA[10] = "Noviembre";
            mesesA[11] = "Diciembre";


            string input = Console.ReadLine();
            int.TryParse(input, out int result);

            if (result > 0 && result <= 12)
            {
                Console.WriteLine(mesesA[result - 1]);
            }
            else
            {
                Console.WriteLine("Dato Incorrecto");
            }
        }
    }
}

