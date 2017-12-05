using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSystemManager.Common;
using FileSystemManager.Interfaces;

namespace FileSystemManager
{
    public class FileManager
    {
        private FileManagerInterfaces _interfaces; //Интерфейсы класса FileManager

        //FileManager устанавливает поле <имя файла> в формате 75<v|f>NNNNN.add
        private string _fileName;
        //FileManager создаёт файл с указанным именем и записывает в него информацию
        
        //FileManager упаковывает файл внешним архиватором
        
        //FileManager вычисляет контрольную сумму архива (MD5)
        
        //FileManager выгружает архив на указаннный ftp-ресурс
       
        //FileManager проверяет корректность выгрузки

        public FileManager(FileManagerInterfaces interfaces)
        {
            _interfaces = interfaces;
        }


        public 
    }
}
