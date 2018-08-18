using Arkadukt3.Addml;
using System;
using System.Collections.Generic;

namespace Arkadukt3
{
    class AddmlUtils
    {
        public static key CreateAlternateKey(string keyName, params fieldDefinitionReference[] references)
        {
            key _alternateKey = new key();
            _alternateKey.name = keyName;
            _alternateKey.Item = new alternateKey();
            _alternateKey.fieldDefinitionReferences = references;
            return _alternateKey;
        }

        public static key CreatePrimaryKey(string keyName, params fieldDefinitionReference[] references)
        {
            key _primaryKey = new key();
            _primaryKey.name = keyName;
            _primaryKey.Item = new primaryKey();
            _primaryKey.fieldDefinitionReferences = references;

            return _primaryKey;
        }

        public static key CreateForeignKey(string keyName,
            fieldDefinitionReference[] references,
            flatFileDefinitionReference foreignFlatFileDefinitionReference
            )
        {
            key _foreignKey = new key();
            _foreignKey.name = keyName;

            foreignKey _foreign = new foreignKey();
            _foreign.flatFileDefinitionReference = foreignFlatFileDefinitionReference;

            _foreignKey.Item = _foreignKey;
            _foreignKey.fieldDefinitionReferences = references;

            return _foreignKey;
        }

        public static flatFileDefinitionReference CreateFlatFileDefinitionReference(
            string _flatFileDefinitionReference,
            recordDefinitionReference[] recordDefinitionReference
            )
        {
            flatFileDefinitionReference foreignFlatFileDefinitionReference = new flatFileDefinitionReference();
            foreignFlatFileDefinitionReference.name = _flatFileDefinitionReference;
            foreignFlatFileDefinitionReference.recordDefinitionReferences = recordDefinitionReference;

            return foreignFlatFileDefinitionReference;
        }

        public static recordDefinitionReference[] CreateRecordDefinitionReference(
            string[] _recordDefinitionReference,
            List<fieldDefinitionReference[]> _fieldDefinitionReference
            )
        {
            recordDefinitionReference[] recordDefinitionReference = new recordDefinitionReference[_recordDefinitionReference.Length];
            for (int i = 0; i < _recordDefinitionReference.Length; i++)
            {
                recordDefinitionReference[i] = new recordDefinitionReference();
                recordDefinitionReference[i].name = _recordDefinitionReference[i];
                recordDefinitionReference[i].fieldDefinitionReferences = _fieldDefinitionReference[i];
            }

            return recordDefinitionReference;
        }

        public static fieldDefinitionReference[] CreateFieldDefinitionReferences(string[] references)
        {
            fieldDefinitionReference[] fieldDefinitionReference = new fieldDefinitionReference[references.Length];
            for (int i = 0; i < references.Length; i++)
            {
                fieldDefinitionReference[i] = new fieldDefinitionReference();
                fieldDefinitionReference[i].name = references[i];
            }
            return fieldDefinitionReference;
        }

        public static string getUUID()
        {
            return Guid.NewGuid().ToString();
        }
    }
}