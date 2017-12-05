using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using FileSystemManager.Interfaces;

namespace FileSystemManager.Implementations
{
    public class FileDataWriter:IFileDataWriter
    {
        /// <summary>
        /// Класс FileDataWriter реализует интерфейс IFileDataWriter. Осуществляет запись текстовых данных data в 
        /// текстовый файл fileName в кодировке 866.
        /// </summary>
        /// <param name="data">Список строк, представляет собой текстовые данные, которые необходимо записать в файл</param>
        /// <param name="fileName">Полный путь к файлу (включая имя и расширение), в который производится запись данных data</param>
        
        public void WriteDataToFile(List<string> data, string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentException("FileDataWriter: Не задано имя файла.");
            }

            if (data == null)
            {
                throw new ArgumentException($"FileDataWriter: Отсутствуют данные для записи в файл {fileName}");
            }

            using (var stream = new FileStream(fileName,FileMode.OpenOrCreate))
            
            using (var streamWriter = new StreamWriter(stream, Encoding.GetEncoding(866)))
            {
                foreach (var line in data)
                {
                    streamWriter.WriteLine(line);
                }
            }
        }
    }
}