namespace MatrizBi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int position4 = 0;
            int position5 = 0;
            int terminar;
            int position2 = 0, position3=0;
            int[,] tablero = new int[8, 8];

            int posicionF, posicionC;
            Console.WriteLine("Ingresa la posicion en Fila");

            posicionF = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa la posicion en Columna");

            posicionC = Convert.ToInt32(Console.ReadLine());
            tablero[posicionF, posicionC] = 2;

            for (int fila = 0; fila < tablero.GetLength(0); fila++)
            {

                for (int columna = 0; columna < tablero.GetLength(0); columna++)
                {


                    // Console.Write(tablero[fila, columna]);
                    Console.Write(tablero[fila, columna]);
                    // Console.Write(tablero[posicionF, posicionC]);


                }
                Console.WriteLine();

            }
            //tablero[posicionF,0] = 1;
            do 
            
            { 
            Console.WriteLine("Quiere moverse a izquierda o derecha");
            string decision=Console.ReadLine();
            if (decision =="derecha")
            {   
               
                   
                    position2 +=posicionF +2;
                position3+=posicionC +1;
                    // position4 += position2;
                    //position5 += position3;
                    // tablero[position4, position5] = 2;
                    tablero[position2, position3] = 2;

                    for (int fila = 0; fila < tablero.GetLength(0); fila++)
                {

                    for (int columna = 0; columna < tablero.GetLength(0); columna++)
                    {


                        // Console.Write(tablero[fila, columna]);
                        Console.Write(tablero[fila, columna]);
                        // Console.Write(tablero[posicionF, posicionC]);


                    }
                    Console.WriteLine();

                }
            }
            else if (decision =="izquierda")
            {
                position2 += posicionF +2;
                position3 += posicionC - 1;
                tablero[position2, position3] = 2;
                for (int fila = 0; fila < tablero.GetLength(0); fila++)
                {

                    for (int columna = 0; columna < tablero.GetLength(0); columna++)
                    {


                        // Console.Write(tablero[fila, columna]);
                        Console.Write(tablero[fila, columna]);
                        // Console.Write(tablero[posicionF, posicionC]);


                    }
                    Console.WriteLine();

                }
                }
            Console.WriteLine("Presiona 1 para salir o cualquier tecla para continuar");
                 terminar = Convert.ToInt32(Console.ReadLine());

            } while (terminar != 1);




        }
    }
}