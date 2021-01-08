using ArbolB;
using System;

namespace ArbolGenealogico
{
    class Program
    {
        static void Main(string[] args)
        {

            var opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Programa de Arboles en C#");
                Console.WriteLine("(1) Metodo Arbol Binario");
                Console.WriteLine("(2) Metodo Arbol Multiples Hijos");
                Console.WriteLine("(3) Metodo Contar Niveles");
                Console.WriteLine("(4) Metodo Contar Hojas");
                Console.WriteLine("(5) Metodo Contar Nodos");
                Console.WriteLine("(6) Metodo de Navegación Horizontal");
                Console.WriteLine("(7) Calcular Expresión matemática con +-*/");
                Console.WriteLine("(8) Salir del programa");
                Console.WriteLine("Seleccione una opción del menú: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Seleccionar el Arbol binario");
                        Program.construirArbolB();
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Seleccionar el Arbol multiples Hijos");
                        Program.construirArbolMultiplesHijos();
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Seleccionaste los niveles Arbol Mutiples Hijos");
                        Program.contarNiveles();
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Seleccionas contar hojas Arbol Mutiples Hijos");
                        Program.contarHojas();
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Seleccionaste contar nodos Arbol Mutiples Hijos");
                        Program.contarNodos();
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Seleccionaste navegación horizontal POSTORDEN");
                        Program.NavegarHorizontalmente();
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Seleccionaste operar mediante expresión matematica");
                        Program.OperarExpresion();
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("Muchas gracias");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        opcion = 8;
                        break;
                    default:
                        Console.WriteLine("La opción escogida no esta dentro del menú vuelve a digitarlo porfavor");
                        Console.WriteLine("Presiona una tecla para continuar");
                        Console.ReadLine();
                        break;
                }
            } while (opcion != 8);


        }
        public static void construirArbolB()
        {
            var raiz = new Nodo("*",
            new Nodo("0",
                new Nodo("00",
                    new Nodo("000"),
                    new Nodo("001")),
                new Nodo("01",
                    new Nodo("010"),
                    new Nodo("011"))),
            new Nodo("1",
                new Nodo("10",
                    new Nodo("100"),
                    new Nodo("101")),
                new Nodo("11",
                    new Nodo("110"),
                    new Nodo("111"))));


            Administrador admin = new Administrador();
            admin.RecorrerArbol(raiz);
        }
        public static void construirArbolMultiplesHijos()
        {
            NodoExt nodoA = new NodoExt("A");
            NodoExt nodoB = new NodoExt("B");
            NodoExt nodoC = new NodoExt("C");
            NodoExt nodoD = new NodoExt("D");
            NodoExt nodoE = new NodoExt("E");
            NodoExt nodoF = new NodoExt("F");
            NodoExt nodoG = new NodoExt("G");

            //Raiz
            nodoA.Hijos.Add(nodoB);
            nodoA.Hijos.Add(nodoC);

            //
            nodoB.Hijos.Add(nodoD);
            nodoB.Hijos.Add(nodoE);
            //
            nodoC.Hijos.Add(nodoF);
            nodoC.Hijos.Add(nodoG);
            //
            nodoD.Hijos.Add(new NodoExt("H"));
            nodoD.Hijos.Add(new NodoExt("I"));
            nodoE.Hijos.Add(new NodoExt("J"));
            nodoE.Hijos.Add(new NodoExt("K"));

            nodoF.Hijos.Add(new NodoExt("L"));
            nodoF.Hijos.Add(new NodoExt("M"));
            nodoG.Hijos.Add(new NodoExt("N"));
            nodoG.Hijos.Add(new NodoExt("Ñ"));

            NodoExt.ImprmirArbolMultiplesHijos(nodoA);
        }
        public static void contarNiveles()
        {
            NodoExt nodoA = new NodoExt("A");
            NodoExt nodoB = new NodoExt("B");
            NodoExt nodoC = new NodoExt("C");
            NodoExt nodoD = new NodoExt("D");
            NodoExt nodoE = new NodoExt("E");
            NodoExt nodoF = new NodoExt("F");
            NodoExt nodoG = new NodoExt("G");

            NodoExt nodoN = new NodoExt("N");
            NodoExt nodoX = new NodoExt("X");

            //Raiz
            nodoA.Hijos.Add(nodoB);
            nodoA.Hijos.Add(nodoC);

            //
            nodoB.Hijos.Add(nodoD);
            nodoB.Hijos.Add(nodoE);
            //
            nodoC.Hijos.Add(nodoF);
            nodoC.Hijos.Add(nodoG);
            //
            nodoD.Hijos.Add(new NodoExt("H"));
            nodoD.Hijos.Add(new NodoExt("I"));
            nodoE.Hijos.Add(new NodoExt("J"));
            nodoE.Hijos.Add(new NodoExt("K"));

            nodoF.Hijos.Add(new NodoExt("L"));
            nodoF.Hijos.Add(new NodoExt("M"));
            nodoG.Hijos.Add(nodoN);
            nodoG.Hijos.Add(new NodoExt("Ñ"));

            nodoN.Hijos.Add(nodoX);

            NodoExt.ImprmirArbolMultiplesHijos(nodoA);

            Console.WriteLine("EL ARBOL TIENE {0} NIVELES !!!", NodoExt.ContarNiveles(nodoA));
        }
        public static void contarHojas()
        {
            NodoExt nodoA = new NodoExt("A");
            NodoExt nodoB = new NodoExt("B");
            NodoExt nodoC = new NodoExt("C");
            NodoExt nodoD = new NodoExt("D");
            NodoExt nodoE = new NodoExt("E");
            NodoExt nodoF = new NodoExt("F");
            NodoExt nodoG = new NodoExt("G");

            //Raiz
            nodoA.Hijos.Add(nodoB);
            nodoA.Hijos.Add(nodoC);

            //
            nodoB.Hijos.Add(nodoD);
            nodoB.Hijos.Add(nodoE);
            //
            nodoC.Hijos.Add(nodoF);
            nodoC.Hijos.Add(nodoG);
            //
            nodoD.Hijos.Add(new NodoExt("H"));
            nodoD.Hijos.Add(new NodoExt("I"));
            nodoE.Hijos.Add(new NodoExt("J"));
            nodoE.Hijos.Add(new NodoExt("K"));

            nodoF.Hijos.Add(new NodoExt("L"));
            nodoF.Hijos.Add(new NodoExt("M"));
            nodoG.Hijos.Add(new NodoExt("N"));
            nodoG.Hijos.Add(new NodoExt("Ñ"));

            NodoExt.ImprmirArbolMultiplesHijos(nodoA);
            Console.WriteLine("EL ARBOL TIENES {0} HOJAS !!!", NodoExt.ContarHojas(nodoA));

        }
        public static void contarNodos()
        {
            NodoExt nodoA = new NodoExt("Angel");
            NodoExt nodoB = new NodoExt("Mari");
            NodoExt nodoC = new NodoExt("Paola");
            NodoExt nodoD = new NodoExt("Aleja");
            NodoExt nodoE = new NodoExt("Majo");
            NodoExt nodoF = new NodoExt("Francis");
            NodoExt nodoG = new NodoExt("Juan");

            //Raiz
            nodoA.Hijos.Add(nodoB);
            nodoA.Hijos.Add(nodoC);

            //
            nodoB.Hijos.Add(nodoD);
            nodoB.Hijos.Add(nodoE);
            //
            nodoC.Hijos.Add(nodoF);
            nodoC.Hijos.Add(nodoG);
            //
            nodoD.Hijos.Add(new NodoExt("H"));
            nodoD.Hijos.Add(new NodoExt("I"));
            nodoE.Hijos.Add(new NodoExt("J"));
            nodoE.Hijos.Add(new NodoExt("K"));

            nodoF.Hijos.Add(new NodoExt("L"));
            nodoF.Hijos.Add(new NodoExt("M"));
            nodoG.Hijos.Add(new NodoExt("N"));
            nodoG.Hijos.Add(new NodoExt("Ñ"));

            NodoExt.ImprmirArbolMultiplesHijos(nodoA);
            Console.WriteLine("EL ARBOL TIENE {0} NODOS!!", NodoExt.ContarNodos(nodoA));
        }
        public static void NavegarHorizontalmente()
        {
            var raiz = new Nodo("*",
            new Nodo("1",
                new Nodo("1.1",
                    new Nodo("1.1.2"),
                    new Nodo("1.1.3")),
                new Nodo("1.2",
                    new Nodo("1.2.1"),
                    new Nodo("1.2.2"))),
            new Nodo("2",
                new Nodo("2.1",
                    new Nodo("2.1.1"),
                    new Nodo("2.1.2")),
                new Nodo("2.2",
                    new Nodo("2.2.1"),
                    new Nodo("2.2.2"))));


            Administrador admin = new Administrador();
            admin.NavegarHorizontal(raiz);
        }
        public static void OperarExpresion()
        {

            Administrador admin = new Administrador();

            //Crear arbol manual 
            var arbolOperaciones = new Nodo("+",
                new Nodo("5"),
                new Nodo("+",
                    new Nodo("6"),
                    new Nodo("+",
                        new Nodo("-2"),
                            new Nodo("-1"))));
            Console.WriteLine("LA SUMA DEL ARBOL ES: " + admin.SumarArbol(arbolOperaciones));
            Console.WriteLine("\n");

            //Crear arbol apartir de un string
            Nodo nodoOperacion = new Nodo();
            admin.CrearArbol(nodoOperacion, "5+6+2+1");
            admin.RecorrerArbol(nodoOperacion);
            
        }
    }
}
