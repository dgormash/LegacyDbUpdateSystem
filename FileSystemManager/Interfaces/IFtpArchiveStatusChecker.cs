namespace FileSystemManager.Interfaces
{
    internal interface IFtpArchiveStatusChecker
    {
        CheckStatus CheckFileOnFtp(string fileName);
    }
}