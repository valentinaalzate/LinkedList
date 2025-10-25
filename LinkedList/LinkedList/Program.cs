//-> lo mismo pasa con los arreglos
//int []arr = new int[15]; // es un apuntador a un arreglo de 15 posiciones

// para cuando servira hacer la definicion sin darle un numero? R/= si yo no se cual es el tamaño del arreglo o lo voy a pedir despues o depende de un calculo

//int[] arr; // yo lo podria definir asi primero

int n = 100; //luego me darian el dato

//arr = new int[n];

// o si yo lo quiero hacer todo en un solo paso

var arr = new int[n];
//el problema de los arreglos es que estoy desperdiciando el 90 posiciones de memoria. y cuando le ingrese una pila o una cola, necesitaria mas de 100 posiciones. Por eso es el problema de los arreglos por que tienen un tamaño fijo

//Fruit f1; // es un apuntador  que esta apuntando a un objeto tipo fruit
Fruit f1;
//f1.Name = "Apple"; // porque saca error. Porque yo le estoy asignando a una propiedad, a un objeto que es nulo
                   
Fruit f2 = new Fruit(); //creando un objeto en la clase fruta, es otro apuntador que esta apuntando a fruta, pero que ya tiene direccion de memoria

f2.Name = "Apple"; // funciona porque ya es un objeto de memoria ->

Console.WriteLine(arr[0]);

//ejemplo 2
class Fruit {

    public string Name { get; set; }

    //calorias
    public float Calories { get; set; }
}

//ejemplo un software de una tienda

