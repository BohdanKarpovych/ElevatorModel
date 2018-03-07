namespace ElevatorModel
{
    public class Elevator
    {
        public Status Direction { get; set; }
        public int CurrentFloor { get; set; }
        public int ResultFloor { get; set; }

        public Elevator(int currentFloor, int resultFloor)
        {
            this.CurrentFloor = currentFloor;
            this.ResultFloor = resultFloor;
            if (CurrentFloor - ResultFloor > 0)
            {
                Direction = Status.Down;
            }
            else if (CurrentFloor - ResultFloor < 0)
            {
                Direction = Status.Up;
            }
            else
            {
                Direction = Status.Stop;
            }
        }

        public override string ToString()
        {
            return string.Join(" ", CurrentFloor, ResultFloor);
        }

        public override bool Equals(object obj)
        {
            return CurrentFloor == ((Elevator)obj).CurrentFloor && ResultFloor == ((Elevator)obj).ResultFloor;
        }

        public override int GetHashCode()
        {
            return CurrentFloor.GetHashCode() + ResultFloor.GetHashCode();
        }
    }
}
