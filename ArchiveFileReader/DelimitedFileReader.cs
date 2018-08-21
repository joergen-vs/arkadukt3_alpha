using System;
using System.Collections.Generic;
using System.Text;

namespace ArchiveFileReader
{
    class DelimitedFileReader : ArchiveFileReader
    {
        public string FilePath { get => _filePath; set => _filePath = value; }
        public string Charset { get => _charset; set => _charset = value; }
        public string RecordSeparator { get => _recordSeparator; set => _recordSeparator = value; }
        public string FieldSeparatingChar { get => _fieldSeparatingChar; set => _fieldSeparatingChar = value; }
        public string QuotingChar { get => _quotingChar; set => _quotingChar = value; }
        public string FileFormat { get => "delimited"; }

        /// <summary>
        /// DelimitedFile-reader
        /// </summary>
        /// <param name="value"></param>
        /// <param name="charset"></param>
        /// <param name="recordSeparator"></param>
        /// <param name="fieldSeparatingChar"></param>
        /// <param name="quotingChar"></param>
        public DelimitedFileReader(string value, string charset, string recordSeparator, string fieldSeparatingChar, string quotingChar)
        {
            FilePath = value;
            Charset = charset;
            RecordSeparator = recordSeparator;
            FieldSeparatingChar = fieldSeparatingChar;
            QuotingChar = quotingChar;
        }
    }
}
