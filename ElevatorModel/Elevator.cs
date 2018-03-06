namespace ElevatorModel
{
    public class Elevator
    {
        public State Direction { get; set; }
        public int CurrentFloor { get; set; }
        public int ResultFloor { get; set; }

        public Elevator(int currentFloor, int resultFloor)
        {
            this.CurrentFloor = currentFloor;
            this.ResultFloor = resultFloor;
            if (CurrentFloor - ResultFloor > 0)
            {
                Direction = State.Down;
            }
            else if (CurrentFloor - ResultFloor < 0)
            {
                Direction = State.Up;
            }
            else
            {
                Direction = State.Static;
            }
        }

        public override string ToString()
        {
            return string.Join(" ", CurrentFloor, ResultFloor);
        }
    }
}
