using ArbolB;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ArbolTest
{
    [TestClass]
    public class ArbolTest
    {
        [TestMethod]
        public void TestArbolSuma()
        {
            var Operaciones = new Nodo("+",
                new Nodo("5"),
                new Nodo("+",
                    new Nodo("6"),
                    new Nodo("+",
                        new Nodo("-2"),
                            new Nodo("-1"))));
            var inicio = new Administrador();
            var resultado = 8;

            var resultadoObtenido = inicio.SumarArbol(Operaciones);

            Assert.AreEqual(resultado, resultadoObtenido);
        }



        [TestMethod]
        public void TestContarNiveles()
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
            nodoG.Hijos.Add(nodoN);
            nodoG.Hijos.Add(new NodoExt("Ñ"));

            nodoN.Hijos.Add(nodoX);

            int resultadoEsperado = 5;
            int resultado = NodoExt.ContarNiveles(nodoA);

            Assert.AreEqual(resultadoEsperado, resultado);
        }



        [TestMethod]
        public void TestContarNodos()
        {
            NodoExt nodo = new NodoExt();
            int resultadoObtenido = 1;
            int resultado = NodoExt.ContarNodos(nodo);

            Assert.AreEqual(resultadoObtenido, resultado);
        }
        [TestMethod]
        public void TestContarNodosSiRetorno0()
        {
            NodoExt nodo=null;

            int resultadoEsperado = 0;
            int resultado = NodoExt.ContarNodos(nodo);

            Assert.AreEqual(resultadoEsperado, resultado);
        }





        [TestMethod]
        public void TestContarNodosConHijos()
        {
            NodoExt nodo = new NodoExt();

            nodo.Hijos = new List<NodoExt>();
            nodo.Hijos.Add(new NodoExt());

            int resultadoEsperado = 2;
            int resultado = NodoExt.ContarNodos(nodo);

            Assert.AreEqual(resultadoEsperado, resultado);
        }
       
       
    }
}
