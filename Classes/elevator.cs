namespace Classes{
    public class Elevator{
        private int position = 1;
        private string status = "";

        void callUp(int floor){
            if(this.checkPositionEqualsFloor(floor)){
                Console.WriteLine("Лифт уже на этаже");
            }else if(this.checkFloorExist(floor)){
                Console.WriteLine("Ошибка, нельзя вызвать лифт на несуществующий этаж");
            }else{
                if(this.status.Equals("Двери открыты")){
                    Console.WriteLine("Нельзя ехать с открытыми дверями");
                }else{
                    this.drive(floor);
                }
            }
        }

        void openDoor(){
            this.status = "Двери открываются";
            Console.WriteLine(this.status);
            this.status = "Двери открыты";
            Console.WriteLine(this.status);
        }

        void closeDoor(){
            this.status = "Двери закрываются";
            Console.WriteLine(this.status);
            this.status = "Двери закрыты";
            Console.WriteLine(this.status);
        }

        private void drive(int floor){
            if(this.position>floor){
                this.status = "Едет вниз";
                Console.WriteLine("Лифт "+this.status.ToLower());
            }else{
                this.status = "Едет вверх";
                Console.WriteLine("Лифт "+this.status.ToLower());
            }
        }

        private bool checkPositionEqualsFloor(int floor){
            if(this.position==floor){
                return true;
            }else{
                return false;
            }
        }

        private bool checkFloorExist(int floor){
            if(floor>20||floor<1){
                return false;
            }else{
                return true;
            }
        }
    }
}