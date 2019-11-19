using System;

namespace HW23._2
{
    class SubsystemTransmission
    {
        public void Gas()
        {
            Console.WriteLine("Разгон");
        }
    }
    class SubsystemControlMechanism
    {
        public void TurnLeft()
        {
            Console.WriteLine("Поворот налево");
        }
        public void TurnRight()
        {
            Console.WriteLine("Поворот направо");
        }
    }
    class SubsystemBreakingSystem
    {
        public void Break()
        {
            Console.WriteLine("Торможение");
        }
    }

    class Chassis
    {
        SubsystemTransmission subsystemTransmission;
        SubsystemControlMechanism subsystemControlMechanism;
        SubsystemBreakingSystem subsystemBreakingSystem;

        public Chassis(SubsystemTransmission st, SubsystemControlMechanism sc, SubsystemBreakingSystem sb)
        {
            subsystemTransmission = st;
            subsystemControlMechanism = sc;
            subsystemBreakingSystem = sb;
        }
        public void Accelerating()
        {
            subsystemTransmission.Gas();
        }
        public void TurningLeft()
        {
            subsystemControlMechanism.TurnLeft();
        }
        public void TurningRight()
        {
            subsystemControlMechanism.TurnRight();
        }
        public void Breaking()
        {
            subsystemBreakingSystem.Break();
        }
    }

    class Engine
    {
        public void StartEngine()
        {
            Console.WriteLine("Завести авто");
        }
    }
    class Body
    {
        public void BodyType()
        {
            Console.WriteLine("Седан");
        }
    }

    class Automobile
    {
        Chassis chassis;
        Engine engine;
        Body body;
        public Automobile(Chassis c, Engine e, Body b)
        {
            chassis = c;
            engine = e;
            body = b;
        }
        public void EngineStarting()
        {
            engine.StartEngine();
        }
        public void Accelerate()
        {
            chassis.Accelerating();
        }
        public void LeftTurn()
        {
            chassis.TurningLeft();
        }
        public void RightTurn()
        {
            chassis.TurningRight();
        }
        public void Break()
        {
            chassis.Breaking();
        }
        public void GetBodyType()
        {
            body.BodyType();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Chassis chassisforcar = new Chassis(new SubsystemTransmission(), new SubsystemControlMechanism(), new SubsystemBreakingSystem());
            Automobile car = new Automobile(chassisforcar, new Engine(), new Body());
            car.EngineStarting();
            car.Accelerate();
            car.LeftTurn();
            car.RightTurn();
            car.Break();
            car.GetBodyType();
        }
    }
}
