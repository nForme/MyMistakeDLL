using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMistake;

namespace Room
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyMistake.Room room = new MyMistake.Room();
            room.length = 10;
            room.height = 2;
            room.nameRoom = "Living";
            room.width = 4;
            room.windows = true;

            double S = room.SRoom(room.length, room.width);

            
        }

        public void Messsage()
        {
            Console.WriteLine($"Площадь комнаты равна: {S}");
        }
    }
}
