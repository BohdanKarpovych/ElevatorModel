using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElevatorModel;

namespace ElevatorModelTest
{
    [TestClass]
    public class ElevatorModelUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Elevator instance1 = new Elevator(1, 5);
            Elevator instance2 = new Elevator(7, 5);
            Elevator instance3 = new Elevator(4, 4);
            Elevator instance4 = new Elevator(2, 9);
            Elevator instance5 = new Elevator(7, 3);
            var inputInfo = new { directoin = State.Up, floor = 5 };
            var expected = instance4;

            ElevatorSelector Test = new ElevatorSelector(instance1, instance2, instance3, instance4, instance5);
            var actual = Test.Find(inputInfo.directoin, inputInfo.floor);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Elevator instance1 = new Elevator(5, 5);
            Elevator instance2 = new Elevator(10, 5);
            Elevator instance3 = new Elevator(9, 1);
            Elevator instance4 = new Elevator(7, 9);
            Elevator instance5 = new Elevator(1, 3);
            var inputInfo = new { directoin = State.Up, floor = 2 };
            var expected = instance5;

            ElevatorSelector Test = new ElevatorSelector(instance1, instance2, instance3, instance4, instance5);
            var actual = Test.Find(inputInfo.directoin, inputInfo.floor);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Elevator instance1 = new Elevator(5, 1);
            Elevator instance2 = new Elevator(1, 7);
            Elevator instance3 = new Elevator(2, 6);
            Elevator instance4 = new Elevator(7, 1);
            Elevator instance5 = new Elevator(2, 2);
            var inputInfo = new { directoin = State.Down, floor = 9 };
            var expected = instance3;

            ElevatorSelector Test = new ElevatorSelector(instance1, instance2, instance3, instance4, instance5);
            var actual = Test.Find(inputInfo.directoin, inputInfo.floor);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Elevator instance1 = new Elevator(1, 10);
            Elevator instance2 = new Elevator(10, 10);
            Elevator instance3 = new Elevator(1, 1);
            Elevator instance4 = new Elevator(5, 9);
            Elevator instance5 = new Elevator(4, 1);
            var inputInfo = new { directoin = State.Down, floor = 7 };
            var expected = instance2;

            ElevatorSelector Test = new ElevatorSelector(instance1, instance2, instance3, instance4, instance5);
            var actual = Test.Find(inputInfo.directoin, inputInfo.floor);

            Assert.AreEqual(expected, actual);
        }
    }
}
