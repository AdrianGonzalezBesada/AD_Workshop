using System.IO;

namespace T1_P_Ficheros
{
    internal class Program
    {

        public enum Ejercicios
        {
            Escribir_en_consola = 1,
            Leer_en_consola = 2,
            Agregar_texto_consola = 3,
        }

        static void Main(string[] args)
        {

            string ejerciciosEjecutables = "Actividad a ejectuar:";


            foreach (Ejercicios ejercicio in Enum.GetValues(typeof(Ejercicios)))
            {
                ejerciciosEjecutables += $"\n{(int)ejercicio} - {ejercicio}";
            }

            string userInput = "";
            Ejercicios ejecutarEjercicio;

            while (userInput != "n")
            {

                Console.WriteLine("\n" + ejerciciosEjecutables + "\n");
                userInput = Console.ReadLine();
                Console.WriteLine();

                if (int.TryParse(userInput, out int opcion))
                {
                    ejecutarEjercicio = (Ejercicios)int.Parse(userInput);

                    switch (ejecutarEjercicio)
                    {
                        case Ejercicios.Escribir_en_consola:
                            EscribirEnConsola();
                            break;

                        case Ejercicios.Leer_en_consola:
                            LeerEnConsola();
                            break;

                        case Ejercicios.Agregar_texto_consola:
                            AgregarTextoConsola();
                            break;

                    }
                }

            }
        }

        #region Ejercicios

        public static void EscribirEnConsola()
        {
            //StreamWriter ficheroConConstructor = new StreamWriter("ficheroConConstructor.txt");
            //StreamWriter fichero;

            //fichero = File.CreateText("HelloWorld.txt");
            //fichero.WriteLine("Línea");
            //fichero.WriteLine("Línea");
            //fichero.Write(" Continuación de línea");
            //fichero.Close();

            //using (ficheroConConstructor)
            //{
            //    ficheroConConstructor.WriteLine("Línea");
            //    ficheroConConstructor.WriteLine("Línea");
            //    ficheroConConstructor.Write(" Continuación de línea");
            //}

            string userInput = string.Empty;

            using (StreamWriter fichero = new StreamWriter("userInput.txt"))
            {
                while (userInput != "END")
                {
                    Console.WriteLine("Introduzca un texto");
                    userInput = Console.ReadLine();

                    if (userInput != "END")
                    {


                        fichero.WriteLine(userInput);
                    }
                }
            }
        }

        public static void LeerEnConsola()
        {
            //StreamReader ficheroManual;

            //ficheroManual = File.OpenText("userInput.txt");
            //Console.WriteLine(ficheroManual.ReadLine());
            //ficheroManual.Close();

            using (StreamReader fichero = new StreamReader("userInput.txt"))
            {
                Console.WriteLine(fichero.ReadToEnd());
                Console.WriteLine(fichero.ReadLine());
            }
        }

        public static void AgregarTextoConsola()
        {
            StreamWriter fichero;

            fichero = File.AppendText("userInput.txt");
            fichero.WriteLine("AppendLine");
            fichero.Close();

            // (Fichero, isAppend)
            using (StreamWriter streamWriter = new StreamWriter("userInput.txt", true))
            {
                streamWriter.WriteLine("LineFromUsing");
            }
        }


        #endregion
    }
}
