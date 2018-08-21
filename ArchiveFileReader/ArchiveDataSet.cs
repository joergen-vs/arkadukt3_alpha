using System;
using System.Collections.Generic;
using System.Text;
using no.arkivverket.standarder.addml.v8_3;

namespace ArchiveFileReader
{
    class ArchiveDataSet
    {
        private addml _addml;

        private List<ArchiveFileReader> _archiveFileReader;

        public ArchiveDataSet(addml addml)
        {
            _addml = addml;

            foreach(flatFile flatfile in _addml.dataset[0].flatFiles.flatFile)
            {
                string reference = flatfile.definitionReference;
                reference = _addml.dataset[0].flatFiles.flatFileDefinitions[reference].typeReference;
                flatFileType flatFileType = _addml.dataset[0].flatFiles.structureTypes.flatFileTypes[reference];
                var format = flatFileType.Item;

                string recordSeparator = "", quotingChar = "", fieldSeparatingChar = "";
                if (format.GetType() == typeof(delimFileFormat))
                {
                    recordSeparator = ((delimFileFormat)format).recordSeparator;
                    fieldSeparatingChar = ((delimFileFormat)format).fieldSeparatingChar;
                    quotingChar = ((delimFileFormat)format).quotingChar;
                    _archiveFileReader.Add(new DelimitedFileReader(
                        flatfile.properties["fileName"].value,
                        flatFileType.charset,
                        ((delimFileFormat)format).recordSeparator,
                        ((delimFileFormat)format).fieldSeparatingChar,
                         ((delimFileFormat)format).quotingChar
                        ));
                }
                else if(format.GetType() == typeof(fixedFileFormat))
                {
                    recordSeparator = ((fixedFileFormat)format).recordSeparator;
                    _archiveFileReader.Add(new FixedFileReader(
                        flatfile.properties["fileName"].value,
                        flatFileType.charset,
                        ((fixedFileFormat)format).recordSeparator
                        ));
                }

            }
        }
    }
}

