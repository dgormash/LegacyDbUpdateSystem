namespace FileSystemManager.Interfaces
{
    public interface IFileManager
    {
        string AssembleFileName();
        bool CreateFile(string path);
        bool WriteDataToFile(string path, object data);
    }
}