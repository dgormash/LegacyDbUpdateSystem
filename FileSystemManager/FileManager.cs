using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSystemManager.Interfaces;

namespace FileSystemManager
{
    public class FileManager
    {
        private const string RegionCode = "75";
        //FileManager устанавливает поле <имя файла> в формате 75<v|f>NNNNNN.add
        private IFileNameAssembler _fileNameAssembler;
        private string _fileName;
        //FileManager создаёт файл с указанным именем и записывает в него информацию
        private IFileDataWriter _fileDataWriter;
        //FileManager упаковывает файл внешним архиватором
        private IArchiver _archiver;
        //FileManager вычисляет контрольную сумму архива (MD5)
        private IMd5Calculator _md5Calculator;
        //FileManager выгружает архив на указаннный ftp-ресурс
        private IFtpUploader _ftpUploader;
        //FileManager проверяет корректность выгрузки
        private IFtpArchiveStatusChecker _ftpArchiveStatusChecker;
    }
}
