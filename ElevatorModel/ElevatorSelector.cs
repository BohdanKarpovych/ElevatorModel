using System;
using System.Collections.Generic;

namespace ElevatorModel
{
    public class ElevatorSelector
    {
        private List<Elevator> Elevators;

        public ElevatorSelector(params Elevator[] items)
        {
            Elevators = new List<Elevator>();
            foreach (var item in items)
            {
                Elevators.Add(item);
            }
        }

        public ElevatorSelector(List<Elevator> items)
        {
            Elevators = new List<Elevator>();
            foreach (var item in items)
            {
                Elevators.Add(item);
            }
        }

        public Elevator Find(Person person)
        {
            if (Elevators.Count != 0)
            {
                bool isAnyPast = false;
                int minOptimalTimeForPast = Int16.MaxValue;
                int minOptimalTime = Int16.MaxValue;
                Elevator optimal = null;
                foreach(var elevator in Elevators)
                {
                    if (person.Direction == elevator.Direction &&
                        (
                          (person.Floor >= elevator.CurrentFloor && person.Floor <= elevator.ResultFloor) ||
                          (person.Floor >= elevator.ResultFloor && person.Floor <= elevator.CurrentFloor)
                        )
                       )
                    {
                        if (Math.Abs(person.Floor - elevator.CurrentFloor) < minOptimalTimeForPast)
                        {
                            minOptimalTimeForPast = Math.Abs(person.Floor - elevator.CurrentFloor);
                            optimal = elevator;
                        }
                        isAnyPast = true;
                    }
                    else if (!isAnyPast)
                    {
                        int temp = Math.Abs(elevator.CurrentFloor - elevator.ResultFloor) + Math.Abs(person.Floor - elevator.ResultFloor);
                        if (temp < minOptimalTime)
                        {
                            minOptimalTime = temp;
                            optimal = elevator;
                        }
                    }
                }
                return optimal;
            }
            return null;
        }
    }
}
