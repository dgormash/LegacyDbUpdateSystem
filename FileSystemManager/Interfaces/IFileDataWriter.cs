using System.Collections.Generic;
using Microsoft.SqlServer.Server;

namespace FileSystemManager.Interfaces
{
    public interface IFileDataWriter
    {
        void WriteDataToFile( List<string> data, string fileName);
    }

}