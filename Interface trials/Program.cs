using System;

namespace Interface_trials
{
    class Program
    {
        static void Main(string[] args)
        {
           // IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();
            //customerManager.Update();

            //IPersonManager employeManager = new EmployerManager();
            //employeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
           
        }
    }

    interface IPersonManager
    {
        //ımplement operation 
        void Add();
        void Update();
    }
    //inherits - class ---------------------- implements-interfaces
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }

    class EmployerManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
          
            personManager.Add();
        }
        
           
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }
}
