using ElevatorModel;
using NUnit.Framework;

namespace ElevatorModelTest
{
    [TestFixture]
    public class ElevatorModelUnitTest
    {
        [Test, TestCaseSource("TestCases")]
        public void ElevatorTest(Person person, ElevatorSelector elevatorSelector, Elevator expected)
        {
            Assert.AreEqual(expected, elevatorSelector.Find(person));
        }

        static object[] TestCases =
        {
        new object[] {new Person(Status.Up, 7), new ElevatorSelector(new Elevator(1, 6), new Elevator(8, 8), new Elevator(9, 6), new Elevator(9, 10)), new Elevator(8, 8)},
        new object[] {new Person(Status.Up, 7), new ElevatorSelector(new Elevator(10, 20), new Elevator(1, 8), new Elevator(6, 6)), new Elevator(1, 8) },
        new object[] {new Person(Status.Up, 7), new ElevatorSelector(new Elevator(1, 10), new Elevator(6, 8)), new Elevator(6, 8) },
        new object[] {new Person(Status.Down, 8), new ElevatorSelector(new Elevator(7, 8), new Elevator(10, 9), new Elevator(8, 8), new Elevator(10, 8)), new Elevator(10, 8)}
        };
    }
}
