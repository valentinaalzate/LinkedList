using LinkedListt.core;
using System.ComponentModel.Design;
var list = new SinglyLinkedList<string>();
/*list.InsertAtBeginning("Perro");
list.InsertAtBeginning("gato");
list.InsertAtBeginning("cabra");
list.InsertAtBeginning("vaca");
list.InsertAtEnd("tigre");
list.InsertAtEnd("hiena");
list.InsertAtEnd("ñu");
list.InsertAtEnd("cocodrilo");
list.PrintList();
*/

//menu
var opc = string.Empty;

do {
    opc = Menu();
    switch (opc) {
        case "0":
            Console.WriteLine("Bye");
            break;
        case "1":
            Console.WriteLine("Enter the value: ");
            list.InsertAtBeginning(Console.ReadLine()!);
            break;

        case "2":
            Console.WriteLine("Enter the value: ");
            list.InsertAtEnd(Console.ReadLine()!);
            break;
        case "3":
            list.PrintList();
            break;
        default:
            Console.WriteLine("Invalid option");
            break;

    }

} while (opc != "0");

string Menu() {
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("1. Insert at beginning");//insertar al inicio
    Console.WriteLine("2. Insert at end");
    Console.WriteLine("3. print the list");
    Console.WriteLine("0. exit");
    Console.Write("Select an option: ");
    return Console.ReadLine()!;
}