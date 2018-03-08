using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Console.WriteLine("Welcome \nto \nC# \nProgramming!");
            int number1, number2, sum;

            Console.Write("Enter First integer!");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second integer!");
            number2 = Convert.ToInt32(Console.ReadLine());  // convert

            sum = number1 + number2;
            Console.WriteLine("Sum is {0}", sum);
            Console.WriteLine("Sum is {0}", number1 + number2);

            string message = "Buen día!";
            message = message.ToUpper();
            Console.WriteLine(message);

            Unitconverter feetToInchesConverter = new Unitconverter(12);
            Unitconverter milesToFeetConverte = new Unitconverter(5280);

            Console.WriteLine (feetToInchesConverter.convert(30));
            Console.WriteLine (milesToFeetConverte.convert(100));
            Console.WriteLine(feetToInchesConverter.convert(
                                milesToFeetConverte.convert(100)));
            
            // obtiene el tipo de dato
            Console.WriteLine(1.0.GetType());
            Console.WriteLine(1E06.GetType());
            Console.WriteLine(1.GetType());
            Console.WriteLine(0xF0000000.GetType());

            // crea las instancias pa1, pa2, pa3, pa4  
            // Y pasa como parametro al constructor de la clase el nombre del animal
            Panda pa1 = new Panda("Pan dee");
            Panda pa2 = new Panda("Pan Dah");
            Panda pa3 = new Panda("Pan Dih");
            Panda pa4 = new Panda("Pan Duh");

            //muestra el nombre del panda cargado en la instancia
            Console.WriteLine(pa1.Name);
            Console.WriteLine(pa2.Name);

            //como se crearon 4 instancias y cada vez que se creo una instancia
            // la variable static field Population aumenta +1 cada vez que se inicializa un instancia en el constructor
            Console.WriteLine(Panda.Population);

            //*************** PASO POR VALOR ************************
            Point p1 = new Point();
            p1.X = 7;

            Point p2 = p1;  //la asignacion causa copia

            Console.WriteLine(p1.X);
            Console.WriteLine(p2.X);
            
            p1.X = 9; // cambia p1.X

            Console.WriteLine(p1.X);
            Console.WriteLine(p2.X);

            //************** PASO POR REFERENCIA ********************

            Point2 p11 = new Point2();
            p11.X = 17;

            Point2 p22 = p11; // asignando una varianle de tipo referencia  copia la referencia,
            //no la instancia del objeto, esto permite a multiples variables a referirse al mismo objeto

            Console.WriteLine(p11.X);
            Console.WriteLine(p22.X);
            p11.X = 27;

            Console.WriteLine(p11.X);
            Console.WriteLine(p22.X);

            //********** Habilitar y deshabilitar excepcion por
            //*********Desbordamiento por sobre carga de Type int = 32 Bytes
            int c_A = 1000000;
            int c_B = 1000000;

            int c_C = unchecked(c_A * c_B); //habilita la excepcion con checked en lugar de uncheked
            unchecked {
                c_C = c_A * c_B;
            }
            
            int uc_X = int.MaxValue;
            int uc_Y = unchecked (uc_X + 1) ; // deshabilita la excepcion
            unchecked { int z = uc_X + 1; }

            uc_Y = 12;

            //*********MANEJO DE LOS INFINITOS -INFINITOS Y NO UN NUMERO NAN

            Console.WriteLine(double.NegativeInfinity); // - Infinito
            Console.WriteLine(1.0 / 0.0); // infinito
            Console.WriteLine(-1.0 / 0.0); // -infinito
            Console.WriteLine(1.0 / -0.0); // -infinito
            Console.WriteLine(-1.0 / -0.0); // infinito

            Console.WriteLine(0.0 / 0.0); // NaN "Not a Number"
            Console.WriteLine((1.0 / 0.0) - (1.0 / 0.0)); // NaN "Not a number"

            /* La diferencias entre doubel y decimal
             *                                Double                       Decimal
             *   uso                           cientifico                    financiero         
             * representacion interna         Base 2                      Base 10
             * rango                  +/-(~10e-324 a ~10e308)           +/-(~10e-28 a ~10e28)
             * valores especiales     +0, -0, +inf, -inf                    None
             * velocidad                nativa al procesador                10 veces double            
             */
            /*
            //*******REDONDEANDO float y Double**********
            float tenth = 0.1f;
            float one = 1f;
            Console.WriteLine(one - tenth * 10f); // el resultado es -1,490116E-08 cuando deberia ser 0
            //por esta razon float y doble son malos para calculos financieros y Decimal es el indicado

            //prueba de la clase Maxino
            Maximo Num = new Maximo();
            Console.WriteLine("el maximo numero es:{0}",Num.Max(3, 4));
            
            // arreglos de cadenas de caracteres
            char[] vowels = new char[5];

            char[] vocales = new char [] { 'a', 'e', 'i', 'o', 'u' };

            vowels[0] = 'a';
            vowels[1] = 'e';
            vowels[2] = 'i';
            vowels[3] = 'o';
            vowels[4] = 'u';

            for (int i = 0; i < vowels.Length; i++) { 
            Console.Write("{0}\n",vowels[i]);
            }


            //  Al un pasar un elemento por Value (struct) el arreglo se llena de cero
            //  Pero al pasar un elemento por referencia (class) se llena de Null y se dispara una excepcion
            //  para solicionar esto se debe instanciar todos los elementos del arreglo
            Punto[] aaa = new Punto[1000];
            for(int i2=0 ; i2< aaa.Length; i2++)
                aaa[i2] = new Punto();              // se establece el elemento i del arreglo con new Punto
            int xx = aaa[500].X;
            Console.WriteLine( "El valor es:{0}", xx); 

            //*** arreglos multidimensionales *****
            

            int[,] Matriz = new int[3, 3]  {{2 , 5 , 7 }, {8,  9 , 3}, { 8 , 1 , 8 }};
            int[,] Matriz_2 = new int[3, 3] { { 4, 5, 7 }, { 2, 9, 3 }, { 8, 1, 8 } };
            int temporal =0;
            


            /*for (int i = 0; i < Matriz.GetLength(0); i++) {
                for (int j = 0; j < Matriz.GetLength(1); j++) {
                    
                    Console.WriteLine("inserte el numero de la matriz en la posicion {0},{1}", i, j);
                    Matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }*/
            /*Console.WriteLine("la matriz1 es:");
            for (int i = 0; i < Matriz.GetLength(0); i++) {
                for (int j = 0; j < Matriz.GetLength(1); j++) { 
                    Console.Write(Matriz [i,j]);
                    Matriz_2[i, j] = Matriz[i, j];
                }
                Console.WriteLine ();
            }


                for (int i = 0; i < Matriz_2.GetLength(0); i++)
                {
                    for (int j = 0;  j < Matriz_2.GetLength(1); j++)
                    {
                        for (int m = 0; m < Matriz.GetLength(0) ; m++) 
                        {
                            for (int n = 0; n < Matriz.GetLength(1) ; n++) 
                            {
                                if (Matriz[m, n] <= Matriz[i, j])
                                {
                                    temporal = Matriz[m, n];
                                    Matriz[m, n] = Matriz[i, j];
                                    Matriz[i, j] = temporal;
                                }
                                
                            }
                        }
                        
                    }
                
                }
            

                /* for (int i = 0; i < Matriz_2.GetLength(0); i++)
                 {
                     for (int j = 0; j < Matriz_2.GetLength(1); j++)
                     {
                         for (int k = 0; k < Matriz.GetLength(0); k++)
                         {
                             for (int l = 0; l < Matriz.GetLength(1); l++)
                             {
                            
                                 if (Matriz[k, l] >= Matriz_2 [i, j] && Matriz [k,l] > mayor_Temporal)
                                 {
                                     Matriz_2[i, j] = Matriz[k, l];
                                     mayor_Temporal = Matriz_2[i, j];
                                     Console.WriteLine("el valor de numero es {0}", mayor_Temporal);
                                     for (int m = 0; m < Matriz.GetLength(0); m++) {
                                         for (int n = 0; n < Matriz.GetLength(1); n++)
                                         {
                                             if (Matriz[k, l] == mayor_Temporal)
                                             {
                                                 Console.WriteLine("Matriz {0} {1} es igual a temporal {2}", k, l, mayor_Temporal);
                                                 Matriz[m, m] = 0;
                                             }
                                         }
                                     }
                                     }
                            
                                 else {
                                     Console.WriteLine("matriz {0} {1} = {3} no es mayor que {2}", k,l, mayor_Temporal, Matriz[k,l] );
                                     if(Matriz[k,l] == mayor_Temporal){
                                         Console.WriteLine("Matriz {0} {1} es igual a temporal {2}", k, l, mayor_Temporal);
                                     }
                                 }
  
                             }
                         }
                    
                         Console.WriteLine("el mayor ahora es {0}", mayor_Temporal);
                     }
                 }*//*
            Console.WriteLine();
            Console.WriteLine("la matriz2 es:");
            for (int i = 0; i < Matriz_2.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz_2.GetLength(1); j++)
                {
                    Console.Write(Matriz_2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("la matriz1 es:");
            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    Console.Write(Matriz[i, j]);
                }
                Console.WriteLine();
            }

            /*int [][] Matrix = new int [][] 
            {
            new int [] {1,2,3},
            new int [] {4,5,6},
            new int [] {7,8,9,10}
            };*/

            // ***********crear un inner array*********
            /*int[][] Matrix = new int[3][];
            for (int i = 0; i < Matrix.Length; i++) 
            { 
                Matrix[i] = new int[3];
                for(int j = 0; j < Matrix[i].Length; j++) 
                {
                    Matrix[i][j] = i * 3 + j;
                }
            }

            Console.WriteLine("The Matrix es:");
            for (int i = 0; i < Matrix.Length; i++)
            {   
                for (int j = 0; j < Matrix[i].Length; j++)
                {
                    Console.Write(Matrix[i][j]);
                }
                Console.WriteLine();
            }

            // Inicialización simplificada de variables omitiendo el operador new

            char [] vocales_new = new char[5];
            vocales_new[0] = 'a';
            vocales_new[1] = 'e';
            vocales_new[2] = 'i';
            vocales_new[3] = 'o';
            vocales_new[4] = 'u';

            char[] vocales_sin_new = { 'a', 'e', 'i', 'o', 'u' };

            int numerin = 3;
            var numerin_var = 3;
            Console.WriteLine("tipo1 -> {0}, tipo2 -> {1}",numerin.GetType(), numerin_var.GetType());

            string alimento = "salchichon";
            var comida= "salchicha";
            Console.WriteLine("tipo1 -> {0}, tipo2 -> {1}", alimento.GetType(), comida.GetType());

            int [,] matrizado = new int[3, 3] { { 1, 2, 3 }, { 5, 7, 9 }, { 11, 13, 17 } };
            int[,] matrizita = { { 2, 4, 6 }, { 8, 10, 12 }, { 14, 16, 18 } };
            int[][] matrizz = 
            {
            new int [] {0,5,10,15},
            new int [] {5,6},
            new int [] {2,3,4},
            };



            Console.WriteLine("The Matrizz es:");
            for (int i = 0; i < matrizz.Length; i++)
            {
                for (int j = 0; j < matrizz[i].Length; j++)
                {
                    Console.Write(matrizz[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("el matrizado es:");
            for (int i = 0; i < matrizado.GetLength(0); i++)
            {
                for (int j = 0; j < matrizado.GetLength(1); j++)
                {
                    Console.Write(matrizado[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("la matrizita es:");
            for (int i = 0; i < matrizita.GetLength(0); i++)
            {
                for (int j = 0; j < matrizita.GetLength(1); j++)   
                {
                    Console.Write(matrizita[i, j]);
                }
                Console.WriteLine();
            }

            var rectMatriz = new int[,] { {3,5,2 }, {6,8,1 }, {9,0,3} };
            var jaggedMatriz = new int[][] { new int [] { 3, 5, 1 }, new int [] { 1, 5, 7, 8, 2 }, new int []{ 2, 6, 8, 6 } };

            // Stack y Heap

            // Stack es un bloque de memoria para almacenar variables locales y parametros. 
            // un metodo recursivo ser llama a si mismo
            */
            int parametros = 5;
            Console.WriteLine("el factorial:{0}",Factorial(parametros));

            // En el heap se localizan objetos (instancias de tipo-referencia). al crearse un objeto una referencia es retornada
            //el colector de basura limpia obetos del heap para no quedarse sin memoria 
            // un objeto se puede limpiar una vez no es referenciado por algun objeto 

            StringBuilder ref1 = new StringBuilder ("object1");
            Console.WriteLine("el objeto ref1: {0} es elegible para colector de basura", ref1);

            StringBuilder ref2 = new StringBuilder("object2");
            StringBuilder ref3 = ref2;
            // el StringBuilder referenciado por ref2 no es elegible para garbage colector hasta que se haya terminado de usar ref3

            Console.WriteLine("El valor de la referencia de ref2 es {0} y de ref3 es {1}", ref2, ref3);

           // la instancia de tipo valor (y las referencias a objetos) residen donde la variable fue declarada
           //tambien si la instancia fue declarada como un instance field entre un objeto o como un elemento de arreglo,esa instanci reside en el heap
          // el heap tambien almacena static field y constantes. pero estas residen en el heap hasta que la aplicación se finaliza
           

            //Valores por defecto
            /*tipo                                  Valor por defecto
             * todos los tipos por referencia         null
             * todos los tipos numericos y enum         0
             * tipo char                                '\0'
             * bool                                    false
             *
             * 
             * Se puede obtener el valor por defecto de cualquier tipo con la keyword default
             * /

             */

            decimal d = default(decimal);
            Console.WriteLine("el valor por defecto de decimal es {0}" ,d);

            //Parametros

            //un metodo es una secuencia de parametros.
            //los parametros definen el set de argumentos que deben ser proporcionados para ese metodo

            //control de los parametros que son pasados 

            //modificador de parametros     pasado por      la variable debe ser deinitivamente assignada
            /* ninguno                      value               going in
             * ref                          Reference           goin in
             * out                          Reference           going out
             
             por defecto los parametros son pasados por value o valor. Osea una copia del valor cuando se pasa a un metodo
             * 
             */
            int x = 8;
            Foo(x);                //hace una copia de x
            Console.WriteLine(x); //x seguira siendo 9 porque al asignar un 


            StringBuilder sb = new StringBuilder();
            Foo(sb);
            Console.WriteLine(sb.ToString()); //test El valor no cambia porque fooSB es una copia de una referencia, al colocarlo como null no hace a sb null
            //sin embargo , si se declarara fooSB y se llamara con el modificador ref, sb se convertiria en null.

            int xx = 8;
            Foo (ref xx);
            Console.WriteLine(xx);

            string xxx = "Penn";
            string yyy = "Teller";

            Swap(ref xxx, ref yyy);
            Console.WriteLine(xxx);
            Console.WriteLine(yyy);




            
        } // end main

        static int Factorial(int x)
        {
            if (x == 0) return 1;
            return x * Factorial(x - 1);
        }

        static void Swap(ref string a, ref string b) {
            string temp = a;
            a = b;
            b = temp; 
        }

        static void Foo(int p)
        {
            p = p + 1;
            Console.WriteLine(p);
        }

        static void Foo(StringBuilder fooSB)
        {
            fooSB.Append("test");
            fooSB = null;
        
        }

        static void Foo (ref int p){
            p = p + 1;
            Console.WriteLine(p);
        }


    } // end class Welcome1

    

    public class Punto { public int X, Y;}
    public struct Punto2 { public int X, Y;}

    class Maximo {
        public int Max(int am, int pm) {
            return (am > pm) ? am : pm; // si la expresion antes de ? es true se evalua am, sino se evalua pm
        }
    }
    class Unitconverter
    {
        int ratio;  // {data member}
        public Unitconverter(int unitRadio) { ratio = unitRadio; }  // constructor {function member} 
        public int convert(int unit) { return ratio * unit; }  //  method {function member}  {instance member}
    
    }
    public class Panda {
        public string Name; // instance field
        public static int Population;  //Static Field

        public Panda(string n)  //constructor
        {
            Name = n;   // Instance Field
            Population = Population + 1;  //  Increment the static Population Field
        }
    }  // end Panda
    public struct Point { public int X, Y; }
    public class Point2 { public int X, Y; }

}