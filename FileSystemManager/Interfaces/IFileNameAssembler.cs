namespace FileSystemManager.Interfaces
{
    public interface IFileNameAssembler
    {
        string AssembleFileName(string dBaseLetter, string seqNum);
    }
}