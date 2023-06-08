namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dZahl1;
            double dZahl2;
            double dErgebniss;
            bool bAbfrage = true;

            Console.WriteLine("Bitte Zahl 1 Eingeben:");
            dZahl1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte Zahl 2 Eingeben:");
            dZahl2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nBitte Operator auswählen:\n[1] +\n[2] -\n[3] *\n[4] /\n[5] stop!");

            while (bAbfrage = true)
            {


                int iAuswahl = Convert.ToInt32(Console.ReadLine());
                switch (iAuswahl)
                {
                    case 1:
                        dErgebniss = dZahl1 + dZahl2;
                        Console.WriteLine("\n{0} + {1} = {2}", dZahl1, dZahl2, dErgebniss);
                        break;

                    case 2:
                        dErgebniss = dZahl1 - dZahl2;
                        Console.WriteLine("\n{0} - {1} = {2}", dZahl1, dZahl2, dErgebniss);
                        break;

                    case 3:
                        dErgebniss = dZahl1 * dZahl2;
                        Console.WriteLine("\n{0} * {1} = {2}", dZahl1, dZahl2, dErgebniss);
                        break;

                    case 4:
                        dErgebniss = dZahl1 / dZahl2;
                        Console.WriteLine("\n{0} / {1} = {2}", dZahl1, dZahl2, dErgebniss);
                        break;

                    case 5:
                        bAbfrage = false;
                        Console.WriteLine("Programm wird beendet!");
                        break;

                    default:
                        Console.WriteLine("FALSCHE ANGABE!");
                        break;
                }



            }






        }
    }
}