using System;
using System.Collections.Generic;
using System.Text;

namespace ArchiveFileReader
{
    class FixedFileReader : ArchiveFileReader
    {
        public string FilePath { get => _filePath; set => _filePath = value; }
        public string Charset { get => _charset; set => _charset = value; }
        public string RecordSeparator { get => _recordSeparator; set => _recordSeparator = value; }
        public string FileFormat { get => "fixed"; }

        /// <summary>
        /// FixedFile-reader
        /// </summary>
        /// <param name="value"></param>
        /// <param name="charset"></param>
        /// <param name="recordSeparator"></param>
        public FixedFileReader(string value, string charset, string recordSeparator)
        {
            FilePath = value;
            Charset = charset;
            RecordSeparator = recordSeparator;
        }
    }
}
