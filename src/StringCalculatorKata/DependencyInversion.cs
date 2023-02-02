using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    // High-level modules should not depend on low-level modules. Both should depend on abstractions.

    public interface IAutomobile
    {
        void Ignition();
        void Stop();
    }

    public class Jeep : IAutomobile
    {
        #region IAutomobile Members
        public void Ignition()
        {
            Console.WriteLine("Jeep start");
        }

        public void Stop()
        {
            Console.WriteLine("Jeep stopped.");
        }
        #endregion
    }

    public class SUV : IAutomobile
    {
        #region IAutomobile Members
        public void Ignition()
        {
            Console.WriteLine("SUV start");
        }

        public void Stop()
        {
            Console.WriteLine("SUV stopped.");
        }
        #endregion
    }


    public class AutomobileController
    {
        IAutomobile m_Automobile;

        public AutomobileController(IAutomobile automobile)
        {
            this.m_Automobile = automobile;
        }

        public void Ignition()
        {
            m_Automobile.Ignition();
        }

        public void Stop()
        {
            m_Automobile.Stop();
        }
    }

    class Program2
    {
        static void Main2(string[] args)
        {
            IAutomobile automobile = new Jeep();
            //IAutomobile automobile = new SUV();
            AutomobileController automobileController = new AutomobileController(automobile);
            automobileController.Ignition();
            automobileController.Stop();

            Console.Read();
        }
    }

}
