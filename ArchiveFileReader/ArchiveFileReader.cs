using System;

namespace ArchiveFileReader
{
    public class ArchiveFileReader : IArchiveFileReader
    {
        public string _filePath;
        public string _charset;
        public string _recordSeparator;
        public string _fieldSeparatingChar;
        public string _quotingChar;
        public string _fileFormat;
    }
}
