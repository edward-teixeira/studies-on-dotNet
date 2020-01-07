using System;
using System.IO;

namespace Listings
{
    class Item_07 //Informações do drive
    {
        static void XMain(string[] args)
        {
            //TAREFA:
            //=======
            //Nome do drive
            //Verificar se o drive está pronto
            //Tipo do drive
            //Formato do drive
            //Espaço livre, em bytes, KB, MB, GB e TB

            var driveInfos = DriveInfo.GetDrives();

            foreach (var drive in driveInfos)
            {
                Console.WriteLine($"{drive.Name}\n{drive.TotalFreeSpace}\n{drive.AvailableFreeSpace}\n");
                Console.WriteLine();

                if (!drive.IsReady)
                {
                    Console.WriteLine("O Drive não está pronto");
                    continue;
                }
                long bytes = drive.TotalFreeSpace;
                Console.WriteLine($"Formato do Drive: {drive.DriveFormat}\n");
                Console.WriteLine($"Bytes: {bytes}");
                double Kbytes = bytes / 1024;
                Console.WriteLine($"Kbytes: {Kbytes}");
                double mBytes = Kbytes / 1024;
                Console.WriteLine($"Mbytes: {mBytes}");
                double gBytes = mBytes / 1024;
                Console.WriteLine($"Gbytes: {gBytes}");
                double tBytes = gBytes / 1024;
                Console.WriteLine($"Tbytes: {tBytes}");
                Console.WriteLine($"Tbytes: {0:N2}", tBytes);
            }

        }
    }
}
