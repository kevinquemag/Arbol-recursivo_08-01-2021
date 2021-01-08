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

                Console.WriteLine("Seleccione una opción del menú: ");
                Console.WriteLine("1-Arbol Binario");
                Console.WriteLine("2-Navegación Horizontal");
                Console.WriteLine("3-Contar Nodos");
                Console.WriteLine("4-Contar Hojas");
                Console.WriteLine("5-Contar Niveles");
                Console.WriteLine("6-Arbol Multiples Hijos");
                Console.WriteLine("7-Expresión matemática con +-*/");
            
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Arbol binario");
                        Program.construirArbolB();

                        break;
                    case 2:
                        Console.WriteLine("Navegación horizontal Post-orden");
                        Program.NavegarHorizontalmente();
                        break;
                    case 3:
                        Console.WriteLine("contar nodos Arbol Mutiples Hijos");
                        Program.contarNodos();
                        break;
                    case 4:
                        Console.WriteLine("Contar hojas Arbol Mutiples Hijos");
                        Program.contarHojas();
                        break;
                    case 5:
                        Console.WriteLine("Niveles Arbol Mutiples Hijos");
                        Program.contarNiveles();
                        break;                    
                    case 6:
                        Console.WriteLine("Multiples Hijos");
                        Program.construirArbolMultiplesHijos();

                        break;

                    case 7:
                        Console.WriteLine("Operar mediante expresión matematica");
                        Program.OperarExpresion();
                       
                        break;
                
                }
            } while (opcion != 8);


        }
        public static void construirArbolB()
        {
            var raiz = new Nodo("*",
            new Nodo("0",new Nodo("00",new Nodo("000"),new Nodo("001")),new Nodo("01",new Nodo("010"),new Nodo("011"))),new Nodo("1",new Nodo("10",new Nodo("100"),
                    new Nodo("101")),new Nodo("11",new Nodo("110"),new Nodo("111"))));

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
     
            nodoA.Hijos.Add(nodoB);
            nodoA.Hijos.Add(nodoC);
    
            nodoB.Hijos.Add(nodoD);
            nodoB.Hijos.Add(nodoE);
           
            nodoC.Hijos.Add(nodoF);
            nodoC.Hijos.Add(nodoG);
       
            nodoD.Hijos.Add(new NodoExt("P"));
            nodoD.Hijos.Add(new NodoExt("Q"));
            nodoE.Hijos.Add(new NodoExt("R"));
            nodoE.Hijos.Add(new NodoExt("S"));
            nodoF.Hijos.Add(new NodoExt("T"));
            nodoF.Hijos.Add(new NodoExt("U"));
            nodoG.Hijos.Add(new NodoExt("V"));
            nodoG.Hijos.Add(new NodoExt("M"));

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
            NodoExt nodoU = new NodoExt("U");
            NodoExt nodoI = new NodoExt("I");
     
            nodoA.Hijos.Add(nodoB);
            nodoA.Hijos.Add(nodoC);
        
            nodoB.Hijos.Add(nodoD);
            nodoB.Hijos.Add(nodoE);
         
            nodoC.Hijos.Add(nodoF);
            nodoC.Hijos.Add(nodoG);
         
            nodoD.Hijos.Add(new NodoExt("H"));
            nodoD.Hijos.Add(new NodoExt("I"));
            nodoE.Hijos.Add(new NodoExt("J"));
            nodoE.Hijos.Add(new NodoExt("K"));

            nodoF.Hijos.Add(new NodoExt("L"));
            nodoF.Hijos.Add(new NodoExt("M"));
            nodoG.Hijos.Add(nodoU);
            nodoG.Hijos.Add(new NodoExt("Ñ"));

            nodoU.Hijos.Add(nodoI);

            NodoExt.ImprmirArbolMultiplesHijos(nodoA);

            Console.WriteLine("El arbol tiene {0} niveles", NodoExt.ContarNiveles(nodoA));
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
    
            nodoA.Hijos.Add(nodoB);
            nodoA.Hijos.Add(nodoC);         
            nodoB.Hijos.Add(nodoD);
            nodoB.Hijos.Add(nodoE);        
            nodoC.Hijos.Add(nodoF);
            nodoC.Hijos.Add(nodoG);  
            nodoD.Hijos.Add(new NodoExt("H"));
            nodoD.Hijos.Add(new NodoExt("I"));
            nodoE.Hijos.Add(new NodoExt("J"));
            nodoE.Hijos.Add(new NodoExt("K"));
            nodoF.Hijos.Add(new NodoExt("L"));
            nodoF.Hijos.Add(new NodoExt("M"));
            nodoG.Hijos.Add(new NodoExt("N"));
            nodoG.Hijos.Add(new NodoExt("Ñ"));

            NodoExt.ImprmirArbolMultiplesHijos(nodoA);
            Console.WriteLine(NodoExt.ContarHojas(nodoA));
        }
        public static void contarNodos()
        {
            NodoExt nodoA = new NodoExt("A");
            NodoExt nodoB = new NodoExt("B");
            NodoExt nodoC = new NodoExt("C");
            NodoExt nodoD = new NodoExt("D");
            NodoExt nodoE = new NodoExt("E");
            NodoExt nodoF = new NodoExt("F");
            NodoExt nodoG = new NodoExt("G");

            nodoA.Hijos.Add(nodoB);
            nodoA.Hijos.Add(nodoC);
            nodoB.Hijos.Add(nodoD);
            nodoB.Hijos.Add(nodoE);
            nodoC.Hijos.Add(nodoF);
            nodoC.Hijos.Add(nodoG);
            nodoD.Hijos.Add(new NodoExt("H"));
            nodoD.Hijos.Add(new NodoExt("I"));
            nodoE.Hijos.Add(new NodoExt("J"));
            nodoE.Hijos.Add(new NodoExt("K"));
            nodoF.Hijos.Add(new NodoExt("L"));
            nodoF.Hijos.Add(new NodoExt("M"));
            nodoG.Hijos.Add(new NodoExt("N"));
            nodoG.Hijos.Add(new NodoExt("Ñ"));

            NodoExt.ImprmirArbolMultiplesHijos(nodoA);
            Console.WriteLine("El arbol tiene {0} nodos", NodoExt.ContarNodos(nodoA));
        }
        public static void NavegarHorizontalmente()
        {
            var raiz = new Nodo("*",
            new Nodo("0",
                new Nodo("00",new Nodo("000"),new Nodo("001")),new Nodo("01",new Nodo("010"),new Nodo("011"))),new Nodo("1",new Nodo("10",
                    new Nodo("100"),new Nodo("101")),new Nodo("11",new Nodo("110"),new Nodo("111"))));

            Administrador admin = new Administrador();
            admin.NavegarHorizontal(raiz);
        }
        public static void OperarExpresion()
        {

            Administrador admin = new Administrador();

            var arbolOperaciones = new Nodo("+",new Nodo("5"),new Nodo("+",new Nodo("6"),new Nodo("+",new Nodo("-2"),new Nodo("-1"))));
            Console.WriteLine("La suma del arbol es: " + admin.SumarArbol(arbolOperaciones));
            Console.WriteLine("\n");
          
            Nodo nodoOperacion = new Nodo();
            admin.CrearArbol(nodoOperacion, "5+6+2+1");
            admin.RecorrerArbol(nodoOperacion);      
        }
    }
}
