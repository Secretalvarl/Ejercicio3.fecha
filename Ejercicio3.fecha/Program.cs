namespace Ejercicio3.fecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaActual = DateTime.Now;
            Random random = new Random();

            Console.WriteLine(fechaActual.ToString("dd-MM-yyyy"));

            DateTime fechaDia = fechaActual.AddDays(1);

            DateTime fechaMes = fechaDia.AddMonths(-24);

            DateTime fechaAño = fechaMes.AddYears(random.Next(0, 4));

            Console.WriteLine(fechaAño.ToString("dd-MM-yyyy"));

            if(fechaActual > fechaAño) 
            {
                Console.WriteLine("El hoy es más grande");
            }
            else
            {
                Console.WriteLine("El mañana es mas pequeño");
            }
            

           
        }
    }
}