using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
             new Worker(),
             new Manager()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

        }
    }

    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void getSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            
        }

        public void getSalary()
        {
            
        }

        public void Work()
        {
           
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            
        }

        public void getSalary()
        {
            
        }

        public void Work()
        {
            
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
           
        }
    }
}
