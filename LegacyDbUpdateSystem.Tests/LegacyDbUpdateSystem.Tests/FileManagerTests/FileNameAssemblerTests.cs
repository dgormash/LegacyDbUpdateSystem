using System;
using FileSystemManager.Common;
using NUnit.Framework;
using FileSystemManager.Implementations;

namespace LegacyDbUpdateSystem.Tests.FileManagerTests
{
    [TestFixture]
    public class FileNameAssemblerTests
    {
        private static FileNameAssembler GetFileNameAssembler()
        {
            return new FileNameAssembler();
        }

        [Test]
        public void FileNameAssembler_GetsRightFileAssemblerInfoWith_v_Identificator_ReturnesValidName()
        {
            var nameAssembler = GetFileNameAssembler();   
            var nameAssemblerInfo = new NameAssemblerInfo
            {
                DBaseLetter = "v",
                SeqNumber = "00001"
            };

            var result = nameAssembler.AssembleFileName(nameAssemblerInfo);

            StringAssert.AreEqualIgnoringCase("75v00001.add", result);
        }

        [Test]
        public void FileNameAssembler_GetsRightFileAssemblerInfoWith_f_Identificator_ReturnesValidName()
        {
            var nameAssembler = GetFileNameAssembler();
            var nameAssemblerInfo = new NameAssemblerInfo
            {
                DBaseLetter = "f",
                SeqNumber = "00001"
            };

            var result = nameAssembler.AssembleFileName(nameAssemblerInfo);

            StringAssert.AreEqualIgnoringCase("75f00001.add", result);
        }

        [Test]
        public void FileNameAssembler_GetsRightFileAssemblerInfoWith_F_Identificator_ReturnesValidName()
        {
            var nameAssembler = GetFileNameAssembler();
            var nameAssemblerInfo = new NameAssemblerInfo
            {
                DBaseLetter = "F",
                SeqNumber = "00001"
            };

            var result = nameAssembler.AssembleFileName(nameAssemblerInfo);

            StringAssert.AreEqualIgnoringCase("75f00001.add", result);
        }

        [Test]
        public void FileNameAssembler_GetsNull_DBaseLetter_Throws_An_ArgumentException()
        {
            var nameAssembler = GetFileNameAssembler();
            var nameAssemblerInfo = new NameAssemblerInfo
            {
                DBaseLetter = null,
                SeqNumber = "00001"
            };

            var exception = Assert.Catch<ArgumentException>(() => nameAssembler.AssembleFileName(nameAssemblerInfo));
            StringAssert.Contains("не задан идентификатор базы данных или порядковый номер файла.", exception.Message);
        }

        [Test]
        public void FileNameAssembler_Space_As_DBaseLetter_Throws_An_ArgumentException()
        {
            var nameAssembler = GetFileNameAssembler();
            var nameAssemblerInfo = new NameAssemblerInfo
            {
                DBaseLetter = " ",
                SeqNumber = "00001"
            };

            var exception = Assert.Catch<ArgumentException>(() => nameAssembler.AssembleFileName(nameAssemblerInfo));
            StringAssert.Contains("не задан идентификатор базы данных или порядковый номер файла.", exception.Message);
        }

        [Test]
        public void FileNameAssembler_EmptyString_As_DBaseLetter_Throws_An_ArgumentException()
        {
            var nameAssembler = GetFileNameAssembler();
            var nameAssemblerInfo = new NameAssemblerInfo
            {
                DBaseLetter = "",
                SeqNumber = "00001"
            };

            var exception = Assert.Catch<ArgumentException>(() => nameAssembler.AssembleFileName(nameAssemblerInfo));
            StringAssert.Contains("не задан идентификатор базы данных или порядковый номер файла.", exception.Message);
        }

        [Test]
        public void FileNameAssembler_GetsNull_As_SeqNumber_Throws_An_ArgumentException()
        {
            var nameAssembler = GetFileNameAssembler();
            var nameAssemblerInfo = new NameAssemblerInfo
            {
                DBaseLetter = "f",
                SeqNumber = null
            };

            var exception = Assert.Catch<ArgumentException>(() => nameAssembler.AssembleFileName(nameAssemblerInfo));
            StringAssert.Contains("не задан идентификатор базы данных или порядковый номер файла.", exception.Message);
        }

        [Test]
        public void FileNameAssembler_Space_As_SeqNumber_Throws_An_ArgumentException()
        {
            var nameAssembler = GetFileNameAssembler();
            var nameAssemblerInfo = new NameAssemblerInfo
            {
                DBaseLetter = "v",
                SeqNumber = " "
            };

            var exception = Assert.Catch<ArgumentException>(() => nameAssembler.AssembleFileName(nameAssemblerInfo));
            StringAssert.Contains("не задан идентификатор базы данных или порядковый номер файла.", exception.Message);
        }

        [Test]
        public void FileNameAssembler_EmptyString_As_SeqNumber_Throws_An_ArgumentException()
        {
            var nameAssembler = GetFileNameAssembler();
            var nameAssemblerInfo = new NameAssemblerInfo
            {
                DBaseLetter = "v",
                SeqNumber = ""
            };

            var exception = Assert.Catch<ArgumentException>(() => nameAssembler.AssembleFileName(nameAssemblerInfo));
            StringAssert.Contains("не задан идентификатор базы данных или порядковый номер файла.", exception.Message);
        }

        [Test]
        public void FileNameAssembler_Gets_Null_As_NameAssemblerInfo_Throws_An_Argument_Exception()
        {
            var nameAssembler = GetFileNameAssembler();
            var exception = Assert.Catch<ArgumentException>(() => nameAssembler.AssembleFileName(null));
            StringAssert.Contains("Параметр NameAssemblerInfo = null.",exception.Message);
        }

    }
}