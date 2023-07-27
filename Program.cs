// See https://aka.ms/new-console-template for more information
using Classes;


Elevator firstElevator = new Elevator();
Elevator secondElevator = new Elevator();
Floor floor = new Floor(firstElevator, secondElevator);

class Person{
    public int position = 1;
    private Floor floor;

    public Person(Floor floor){
        this.floor = floor;
    }
    void callElevator(){
        Console.WriteLine("Подходит к кнопке");
        Console.WriteLine("Нажимает кнопку");
        Random rnd = new Random();
        floor.callUp(position,rnd.Next(1,2));
        //while()
    }
}