using FileSystemManager.Common;

namespace FileSystemManager.Interfaces
{
    public interface IFileNameAssembler
    {
        string AssembleFileName(NameAssemblerInfo nameAssemblerInfo);
    }
}