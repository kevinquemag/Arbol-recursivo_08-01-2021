using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArbolB
{
    public class Administrador
    {
        public void CrearArbol(Nodo nodo, string Mate)
        {
            if (Mate.Length == 1)
            {
                nodo.Nombre = Mate.Substring(0, 1);
            }
            else
            {
                int Operador = BuscarOperador(Mate);
                Console.WriteLine("indice operador" + Operador);
                var operandoIzquierdo = Mate.Substring(0,Operador);
                Console.WriteLine("operando izquierdo" + operandoIzquierdo);
                nodo.Nombre = Mate.Substring(Operador,0);
                nodo.Izquierdo = new Nodo(operandoIzquierdo);

                nodo.Derecho = new Nodo();
                Console.WriteLine("indice operador mas " + Mate.Substring(Operador + 1));

                CrearArbol(nodo.Derecho, Mate.Substring(Operador + 1));
            }

        }
        private int BuscarOperador(string Matematica)
        {

            char[] expresionMatematicaPO = Matematica.ToCharArray();
            int iterador;
            int posicion=0;
            for(iterador=0; iterador < expresionMatematicaPO.Length; iterador++)
            {
                if (Matematica[iterador] == '+' || Matematica[iterador] == '-')
                {
                    posicion = iterador;
                    return posicion;
                }
            }
            return posicion;
        }
        public void RecorrerArbol(Nodo nodo)
        {
            if(nodo == null)
                return;

            Console.WriteLine(nodo.Nombre);
            RecorrerArbol(nodo.Izquierdo);
            RecorrerArbol(nodo.Derecho);
        }
        public bool EsNumero(string nombre)
        {
            if (nombre != "+") 
                return true;
            else
                return false;
        }
        public int ConvertirEnNumero(string numero)
        {
            return int.Parse(numero);
        }
        
        public int SumarArbol(Nodo nodo)
        {
            if(!EsNumero(nodo.Nombre) || nodo==null){
                int izquierdo = SumarArbol(nodo.Derecho);
                int derecho = SumarArbol(nodo.Izquierdo);
                return (izquierdo + derecho);
            }
            else
            {
                return (ConvertirEnNumero(nodo.Nombre));
            }
        }
        public void NavegarHorizontal(Nodo nodo)
        {
            if(nodo == null)
            {
                return; 
            }
            NavegarHorizontal(nodo.Derecho);
            NavegarHorizontal(nodo.Izquierdo);
            Console.WriteLine(nodo.Nombre);
        }
    }
}
