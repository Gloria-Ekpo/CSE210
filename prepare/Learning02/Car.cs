public class Car {

//instances
public string brand ;
public int miles;
public string color;

//constructor
public Car(){

}

//Methods (functions)
public void move_forward(){

    Console.WriteLine("is running");
}

public void displayInfo(){
    Console.WriteLine($" brand: {brand} Miles:{miles} color: {color}");
}

}
