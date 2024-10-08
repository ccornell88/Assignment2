﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class FileLoggerTests
{
    [TestMethod]
    public void FileLogger_CreatesLogFile_Log_FileExists()
    {
        // Arrange
        FileLogger logger = new FileLogger("TestFilePath");

        //
        Assert.IsTrue(File.Exists("TestFilePath"));


    }

}
