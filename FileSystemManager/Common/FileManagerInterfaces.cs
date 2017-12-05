using FileSystemManager.Interfaces;

namespace FileSystemManager.Common
{
    public class FileManagerInterfaces
    {
        public IFileNameAssembler FileNameAssembler { get; set; }
        public IFileDataWriter FileDataWriter { get; set; }
        public IArchiver Archiver { get; set; }
        public IMd5Calculator Md5Calculator { get; set; }
        public IFtpUploader FtpUploader { get; set; }
        public IFtpArchiveStatusChecker FtpArchiveStatusChecker { get; set; }
    }
}