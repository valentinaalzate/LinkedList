using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListt.core
{
    // clase generica
    public class SinglyLinkedList<T>
    {
        // atributos privado
        private SimpleNode<T>? _head;

        public SinglyLinkedList()
        {
            // apunta a nulo
            _head = null;
        }

        // insertar un nuevo nodo al inicio de la lista
        public void InsertAtBeginning(T data)
        {
            // creo una nueva variable newNode es igual a un nuevo 
            var newNode = new SimpleNode<T>(data);
            newNode.Next = _head; // la siguiente referencia de nuevo nodo  apunta a la cabecera actual

            // actualiza la cabecera al nuevo nodo
            _head = newNode;
        }

        //insertar al final
        public void InsertAtEnd(T data)
        {
            var newNode= new SimpleNode<T>(data);
            if (_head == null)
            {
                _head = newNode;

            }
            else {
                var  current = _head; // current local
                while (current.Next !=null) {
                
                    current= current.Next; // current.next  queda apuntando a la direccion de memoria del gato
                    //_head.next direccion donde apunta gallo
                    //_head.next.data es gato
                }
                current.Next = newNode;

            }
        }

        // imprimir la lista
        public void PrintList() { 
            var current = _head;//cabesa de mi lista
            while (current !=null) {
                
                Console.Write($"{current.Data}  -> ");
                current = current.Next;
            }
            Console.WriteLine("null");



        }

    }
}
