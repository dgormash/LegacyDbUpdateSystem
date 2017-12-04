using FileSystemManager.Common;
using NUnit.Framework;
using FileSystemManager;

namespace LegacyDbUpdateSystem.Tests.FileManagerTests
{
    [TestFixture]
    public class FileNameAssemblerTests
    {
        [TestCase]
        public void FileNameAssembler_GetsRightFileAssemblerInfoWith_v_Identificator_ReturnesValidName()
        {
            FileManager fileManager = new FileManager();
            var nameAssemblerInfo = new NameAssemblerInfo
            {
                DBaseLetter = "v",
                SeqNumber = "00001"
            };

        } 
         
    }
}