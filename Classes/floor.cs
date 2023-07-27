namespace Classes{
    public class Floor{
        public int firstElevatorPosition = 1;
        public string firstElevatorStatus = "";
        public int secondElevatorPosition = 1;
        public string secondElevatorStatus = "";

        public string buttonStatus = "";
        private Elevator firstElevator, secondElevator; 

        Floor(Elevator firstElevator, Elevator secondElevator){
            this.firstElevator = firstElevator;
            this.secondElevator = secondElevator;
        }

        public void callUp(int floor, int elevatorNumber){
            switch(elevatorNumber){
                case 1:{
                    firstElevator.callUp(floor);
                    buttonStatus = "вызван";
                    Console.WriteLine(buttonStatus);
                    break;
                }
                case 2:{
                    secondElevator.callUp(floor);
                    buttonStatus = "вызван";
                    Console.WriteLine(buttonStatus);
                    break;
                }
                default:{
                    Console.WriteLine("Нельзя вызвать не существующий лифт");
                    break;
                }
            }
        }
    }
}