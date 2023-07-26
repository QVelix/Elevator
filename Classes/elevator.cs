namespace Classes{
    public class Elevator{
        private string elevatorStatus = "";
        private int position = 1;
        private bool doorClose = true;

        void callUp(int floor){
            if(this.position == floor){
                Console.WriteLine("Лифт уже на этаже");
            }else if(floor>20||floor<1){
                Console.WriteLine("Ошибка, нельзя вызвать лифт на несуществующий этаж");
            }else{
                Console.WriteLine("Лифт едет, подождите");
                Thread.Sleep(1000*Math.Abs(position-floor));
                this.position = floor;
                Console.WriteLine("Лифт приехал");
            }
        }
        
        void openDoor(){
            this.doorClose = false;
            Console.WriteLine("Дверь открыта");
        }

        void closeDoor(){
            this.doorClose = true;
            Console.WriteLine("Дверь закрыта");
        }
    }
}