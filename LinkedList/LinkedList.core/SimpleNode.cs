namespace LinkedListt.core
{
    public class SimpleNode <T>
    {
        //las propiedades tienen que ir despues de los constructores el orden es atributos privados, constructores, propiedades, metodos
        public SimpleNode(T data) {

            Data = data; // es un nodo
            Next = null; // el siguiente es nulo


        }

        // propiedad date ? si puede ser nulo
        public T? Data { get; set; }

        // propiedad next ? si puede ser nulo
        // es un apuntador a objetos de nodo simple de T
        public SimpleNode<T>? Next { get; set; }

       
    }
}
