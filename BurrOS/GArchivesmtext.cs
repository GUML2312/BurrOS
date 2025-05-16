using Cosmos.Debug.Kernel.Plugs.Asm;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cosmos.System.FileSystem;

namespace BurrOS
{
    internal class GArchivesmtext
    {
        //Quiu
        public static void GArchives(Cosmos.System.FileSystem.CosmosVFS fs) 
        {
            var disco = @"0:\";
            var caminorealacolima = @"0:\";
            var actual = @"0:\";
        inicio:
            Console.Clear();
            float libre = fs.GetAvailableFreeSpace(disco);
            float total = fs.GetTotalSize(disco);
            libre = libre / 1073741824;
            total = total / 1073741824;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Espacio libre: " + libre + "GiB de " + total + "GiB" + " Disco: " + disco);
            Console.WriteLine("  ________    _____                .__    .__");
            Console.WriteLine(" /  _____/   /  _  \\_______   ____ |  |__ |__|__  __ ____   ______");
            Console.WriteLine("/   \\  ___  /  /_\\  \\_  __ \\_/ ___\\|  |  \\|  \\  \\/ // __ \\ /  ___/");
            Console.WriteLine("\\    \\_\\  \\/    |    \\  | \\/\\  \\___|   Y  \\  |\\   /\\  ___/ \\___ \\ ");
            Console.WriteLine(" \\______  /\\____|__  /__|    \\___  >___|  /__| \\_/  \\___  >____  >");
            Console.WriteLine("        \\/         \\/            \\/     \\/              \\/     \\/ ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(disco);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(caminorealacolima);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(actual);
            Console.ForegroundColor = ConsoleColor.Green;
            var waza = Console.ReadLine();
            switch (waza)
            {
                case "ayuda":
                    Console.Clear();
                    Console.WriteLine("Lo que se muestra aqui es lo basico para algo un poquito mas aca vease el ins-");
                    Console.WriteLine("tructivo");
                    Console.WriteLine("Recuerda que Enter es para siguiente");
                    Console.WriteLine("");
                    Console.ReadLine();
                goto inicio;

                case "salir":
                    Console.Clear();
                    Console.WriteLine("Adios cuidate");
                    Thread.Sleep(1300);
                break;

                default:
                    Console.WriteLine("Comando no reconocido");
                    Thread.Sleep(1300);
                goto inicio;
            }
        }
    }
}
