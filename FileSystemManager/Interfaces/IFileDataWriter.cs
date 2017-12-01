using System.Collections.Generic;
using Microsoft.SqlServer.Server;

namespace FileSystemManager.Interfaces
{
    internal interface IFileDataWriter
    {
        void WriteDataToFile(string fileName, List<string> data);
    }

}