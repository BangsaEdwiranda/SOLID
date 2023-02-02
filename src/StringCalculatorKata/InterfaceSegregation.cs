using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    // When all the tasks are done by a single class or in other words,
    // one class is used in almost all the application classes then it has become a fat class with overburden
    // Dont force a task to implement method it does not use

    public interface IOrder
    {
        void AddToCart();
    }

    public interface IOnlineOrder
    {
        void CCProcess();
    }

    public class OnlineOrder : IOrder, IOnlineOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }

        public void CCProcess()
        {
            //process through credit card
        }
    }

    public class OfflineOrder : IOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
        }
    }


}
