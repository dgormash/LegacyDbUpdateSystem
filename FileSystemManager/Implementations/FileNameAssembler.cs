using System;
using FileSystemManager.Common;
using FileSystemManager.Interfaces;

namespace FileSystemManager.Implementations
{
    public class FileNameAssembler:IFileNameAssembler
    {
        public string AssembleFileName(NameAssemblerInfo nameAssemblerInfo)
        {
            if (nameAssemblerInfo == null)
            {
                throw new ArgumentException("FileNameAssebler: Параметр NameAssemblerInfo = null.");
            }

            if (string.IsNullOrWhiteSpace(nameAssemblerInfo.DBaseLetter) || string.IsNullOrWhiteSpace(nameAssemblerInfo.SeqNumber))
            {
                throw new ArgumentException("FileNameAssembler: не задан идентификатор базы данных или порядковый номер файла.");
            }

            return $"75{nameAssemblerInfo.DBaseLetter}{nameAssemblerInfo.SeqNumber}.add";
        }
    }
}