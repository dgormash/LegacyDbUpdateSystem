using System;
using FileSystemManager.Common;
using FileSystemManager.Interfaces;

namespace FileSystemManager.Implementations
{
    public class FileNameAssembler:IFileNameAssembler
    {
        public string AssembleFileName(NameAssemblerInfo nameAssemblerInfo)
        {
            if (nameAssemblerInfo.DBaseLetter == null || nameAssemblerInfo.SeqNumber == null)
            {
                throw new ArgumentException("FileNameAssembler: не задан идентификатор базы данных или порядковый номер файла.");
            }

            return $"75{nameAssemblerInfo.DBaseLetter}{nameAssemblerInfo.SeqNumber}.add";
        }
    }
}