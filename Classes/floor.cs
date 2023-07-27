namespace Classes{
    public class Floor{
        public int firstElevatorPosition = 1;
        public string firstElevatorStatus = "";
        public int secondElevatorPosition = 1;
        public string secondElevatorStatus = "";

        public string buttonStatus = "";

        void callUp(int floor){
            if(buttonStatus!="вызван"){
                buttonStatus = "вызван";
                Console.WriteLine("Лифт вызван");
            }
        }
    }
}