namespace ElevatorModel
{
    public class Person
    {
        public Status Direction { get; set; }
        public int Floor { get; set; }

        public Person(Status state, int floor)
        {
            this.Direction = state;
            this.Floor = floor;
        }
    }
}
