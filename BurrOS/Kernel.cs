using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;
using System.IO;
using Cosmos.System.FileSystem;
using System.Text.RegularExpressions;

namespace BurrOS
{
    public class Kernel : Sys.Kernel
    {
        CosmosVFS fs = new Sys.FileSystem.CosmosVFS();
        protected override void BeforeRun()
        {
            fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Console.WriteLine("Cosmos booted successfully.");
            Console.WriteLine("Pasando a BurrOS...");
        }

        protected override void Run()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Modo Basico");
            Console.WriteLine("Escribe ayuda si no sabes que hacer");
            Console.Write("Burrote#");
            var Comando = Console.ReadLine();
            switch (Comando)
            {
                case "ayuda":
                    Console.Clear();
                    Console.WriteLine("Si quieres algo mas facil escribe mgraf(Esto inciara el modo grafico)");
                    Console.WriteLine("Lo que se muestra aqui es lo basico para algo un poquito mas aca vease el ins-");
                    Console.WriteLine("tructivo");
                    Console.WriteLine("Recuerda que Enter es para siguiente");
                    Console.WriteLine("hola - Saludas al burrote");
                    Console.WriteLine("apagar - Apaga la computadora");
                    Console.WriteLine("reiniciar - Reinicia la computadora");
                    Console.WriteLine("GArch - inicia GArchives (es el explorador de archivos)");
                    Console.WriteLine("mtext - se inicia en modo de texto");
                    Console.WriteLine("clr - Limpia la pantalla");
                    Console.ReadLine();
                    break;

                case "hola":
                    Console.Write("El burro dice: ");
                    Console.WriteLine("Quiubo");
                    Console.ReadLine();
                    break;

                case "apagar":
                    Cosmos.System.Power.Shutdown();
                    break;

                case "reiniciar":
                    Cosmos.System.Power.Reboot();
                    break;

                case "GArch":
                    GArchivesmtext.GArchives(fs);
                    break;

                case "mtext":

                    break;

                case "mgraf":

                    break;

                case "clr":
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Comando no reconocido");
                    Thread.Sleep(1300);
                    break;
            }
        }
    }
}