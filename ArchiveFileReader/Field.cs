using System;
using System.Collections.Generic;
using System.Text;

namespace ArchiveFileReader
{
    class Field
    {
        public string Name { get { return DefinitionReference; } }
        public string DefinitionReference { get; }
        public string TypeReference { get; }
        public string Value { get; }

        public Field(string definitionReference, string typeReference, string value)
        {
            DefinitionReference = definitionReference;
            TypeReference = typeReference;
            Value = value;
        }
    }
}
