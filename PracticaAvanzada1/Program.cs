using System;

namespace PracticaAvanzada1
{
    public class PracticaAvanzada1
    {
        static void Main(string[] args)
        {
            //int[] arr = { 10,1,8,99,1002,5,22 };
            int[] arr = { 2, 3, 5, 6, 7 };
            List<int> list = new List<int>();
            foreach (var item in arr)
            {
                list.Add(item);
            }
            //instance 
            Operations op = new Operations();

            dynamic result = op.Multiplo(11);

            Console.WriteLine(result);

            //Delegate
            MessageEx exampleMessage = new MessageEx(Message.MessageString);
            exampleMessage("Hola de awa");

        }

        //delegate
        delegate void MessageEx(string msg);
    }

    class Message
    {
        public static void MessageString(string msg) {
            Console.WriteLine(msg);
        }
    }
}