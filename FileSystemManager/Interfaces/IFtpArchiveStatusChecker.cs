namespace FileSystemManager.Interfaces
{
    public interface IFtpArchiveStatusChecker
    {
        CheckStatus CheckFileOnFtp(string fileName);
    }
}