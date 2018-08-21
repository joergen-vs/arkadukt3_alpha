using System;
using System.Collections.Generic;
using System.Text;

namespace ArchiveFileReader
{
    class Post
    {
        List<Field> fields;

        public Post()
        {

        }

        public List<Field> GetFields()
        {
            return fields;
        }

        public List<Field> GetFields(params string[] fieldNames)
        {
            List<Field> list = new List<Field>(fieldNames.Length);
            foreach(string fieldName in fieldNames)
            {
                Field field = getField(fieldName);
                if (field != null)
                    list.Add(field);
            }
            return list;
        }

        public Field getField(int fieldIndex)
        {
            if (fieldIndex > -1 && fieldIndex < fields.Count)
                return fields[fieldIndex];
            return null;
        }

        public Field getField(string fieldName)
        {
            foreach (Field field in fields)
                if (field.Name.Equals(fieldName))
                    return field;
            return null;
        }
    }
}
