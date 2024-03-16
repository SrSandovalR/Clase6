//definir espacios en memoria
//int {3} notas;
// para acceder a cada nota vamos a acceder por su indice
//Todos los elementos deben ser el mismo tipo de datos.

static void ejemplo1()
{
    int [] calificaciones;
    calificaciones = new int[] {85,77,68,74,96,99};

    /*Console.WriteLine(calificaciones[calificaciones.Length - 1]);*/
        Console.WriteLine(calificaciones[2]);


}


//Que hace new? es una palabra clave que se usa para crear una nueva caja o contenedor en la memoria del programa
//int[] valor;
//valor = new int[5];
//valor[5] = 10;

static void ejemplo2()
{
    string[] nombres = new string[3];
    nombres[0] = "Juan";
    nombres[1] = "Ana";
    nombres[2] = "Pedro";
    
    foreach (string nombre in nombres)
    {
        Console.WriteLine("nombre=" +nombre);
    }

} 


static void promedio()
{
    int[] notas = { 80, 75, 90, 95, 73, 79 };
    int promedio = 0;
    int total = 0;
    //calcular el promedio usando foreach
    foreach (int nota in notas) { 
        total += nota;
     
    
    }
    promedio = total / 6;
    Console.WriteLine(promedio);

    for (int i = 0;i <notas.Length; i++)
    {



    }


    Array.Sort(notas);
    foreach (int nota in notas)
    {
        total += nota;


    }
    Console.WriteLine(notas);
    
    Array.Reverse(notas);
    bool hayaprobados = Array.Exists(notas, calif => calif >= 60);
    Console.WriteLine(hayaprobados);
    //int primernumeromayor = Array.Find;


}

static void propiedadleng()
{
    int [] calificacines = {1,2,3,4,5,6 };
    for (int i = 0; i < calificacines.Length; i++)
    {
        Console.WriteLine($"calificacines{i + 1}: {calificacines[i]}");

    }



}

static void arrayreverse()
{
    string[] nombres = new string[5];
    nombres[0] = "Juan";
    nombres[1] = "Ana";
    nombres[2] = "Pedro";
    nombres[3] = "Monica";
    nombres[4] = "Andrea";

      

   





}