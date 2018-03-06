using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //int floor = int.Parse(Console.ReadLine());
            //string direction = Console.ReadLine().ToLower();
            //State parseddirection = State.Static;
            //switch (direction)
            //{
            //    case "up":
            //        parseddirection = State.Up;
            //        break;
            //    case "down":
            //        parseddirection = State.Down;
            //        break;
            //}

            Elevator instance1 = new Elevator(1, 5);
            Elevator instance2 = new Elevator(7, 5);
            Elevator instance3 = new Elevator(4, 4);
            Elevator instance4 = new Elevator(2, 9);
            Elevator instance5 = new Elevator(7, 3);
            var inputInfo = new { direction = State.Up, floor = 5 };
            ElevatorSelector ins = new ElevatorSelector(instance1, instance2, instance3, instance4, instance5);
            var res = ins.Find(inputInfo.direction, inputInfo.floor);
            if (res != null)
            {
                Console.Write(res.ToString());
            }
        }
    }
}
