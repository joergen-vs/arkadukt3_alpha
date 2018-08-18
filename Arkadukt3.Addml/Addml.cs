﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkadukt3.Addml
{
    using System.Xml.Serialization;

    public class Addml
    {
        public static addml getAddmlFromFile(string filePath)
        {
            addml _addml = null;
            return _addml;
        }
        public static addml getAddmlFromString(string addmlXml)
        {
            addml _addml = null;
            return _addml;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class addml
    {

        private dataset[] datasetField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dataset")]
        public dataset[] dataset
        {
            get
            {
                return this.datasetField;
            }
            set
            {
                this.datasetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class dataset
    {

        private string descriptionField;

        private reference referenceField;

        private flatFiles flatFilesField;

        private dataObjects dataObjectsField;

        private string nameField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public reference reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        public flatFiles flatFiles
        {
            get
            {
                return this.flatFilesField;
            }
            set
            {
                this.flatFilesField = value;
            }
        }

        /// <remarks/>
        public dataObjects dataObjects
        {
            get
            {
                return this.dataObjectsField;
            }
            set
            {
                this.dataObjectsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class reference
    {

        private context contextField;

        private content contentField;

        private string nameField;

        /// <remarks/>
        public context context
        {
            get
            {
                return this.contextField;
            }
            set
            {
                this.contextField = value;
            }
        }

        /// <remarks/>
        public content content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class context
    {

        private string descriptionField;

        private additionalElements additionalElementsField;

        private process[] processesField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public additionalElements additionalElements
        {
            get
            {
                return this.additionalElementsField;
            }
            set
            {
                this.additionalElementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("process", IsNullable = false)]
        public process[] processes
        {
            get
            {
                return this.processesField;
            }
            set
            {
                this.processesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class additionalElements
    {

        private string descriptionField;

        private additionalElement[] additionalElementField;

        private process[] processesField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("additionalElement")]
        public additionalElement[] additionalElement
        {
            get
            {
                return this.additionalElementField;
            }
            set
            {
                this.additionalElementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("process", IsNullable = false)]
        public process[] processes
        {
            get
            {
                return this.processesField;
            }
            set
            {
                this.processesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class additionalElement
    {

        private string valueField;

        private property[] propertiesField;

        private additionalElements additionalElementsField;

        private process[] processesField;

        private string nameField;

        private string dataTypeField;

        private string formatField;

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public property[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        public additionalElements additionalElements
        {
            get
            {
                return this.additionalElementsField;
            }
            set
            {
                this.additionalElementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("process", IsNullable = false)]
        public process[] processes
        {
            get
            {
                return this.processesField;
            }
            set
            {
                this.processesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class property
    {

        private string valueField;

        private property[] propertiesField;

        private string nameField;

        private string dataTypeField;

        private string formatField;

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public property[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format
        {
            get
            {
                return this.formatField;
            }
            set
            {
                this.formatField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class process
    {

        private parameter[] parametersField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("parameter", IsNullable = false)]
        public parameter[] parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class parameter
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class content
    {

        private string descriptionField;

        private additionalElements additionalElementsField;

        private process[] processesField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public additionalElements additionalElements
        {
            get
            {
                return this.additionalElementsField;
            }
            set
            {
                this.additionalElementsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("process", IsNullable = false)]
        public process[] processes
        {
            get
            {
                return this.processesField;
            }
            set
            {
                this.processesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class flatFiles
    {

        private flatFile[] flatFileField;

        private flatFileDefinition[] flatFileDefinitionsField;

        private structureTypes structureTypesField;

        private query[] queriesField;

        private process[] processesField;

        private flatFileProcesses[] flatFileProcessesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("flatFile")]
        public flatFile[] flatFile
        {
            get
            {
                return this.flatFileField;
            }
            set
            {
                this.flatFileField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("flatFileDefinition", IsNullable = false)]
        public flatFileDefinition[] flatFileDefinitions
        {
            get
            {
                return this.flatFileDefinitionsField;
            }
            set
            {
                this.flatFileDefinitionsField = value;
            }
        }

        /// <remarks/>
        public structureTypes structureTypes
        {
            get
            {
                return this.structureTypesField;
            }
            set
            {
                this.structureTypesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("query", IsNullable = false)]
        public query[] queries
        {
            get
            {
                return this.queriesField;
            }
            set
            {
                this.queriesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("process", IsNullable = false)]
        public process[] processes
        {
            get
            {
                return this.processesField;
            }
            set
            {
                this.processesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("flatFileProcesses")]
        public flatFileProcesses[] flatFileProcesses
        {
            get
            {
                return this.flatFileProcessesField;
            }
            set
            {
                this.flatFileProcessesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class flatFile
    {

        private property[] propertiesField;

        private string nameField;

        private string definitionReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public property[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string definitionReference
        {
            get
            {
                return this.definitionReferenceField;
            }
            set
            {
                this.definitionReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class flatFileDefinition
    {

        private string descriptionField;

        private property[] propertiesField;

        private external externalField;

        private string recordDefinitionFieldIdentifierField;

        private recordDefinition[] recordDefinitionsField;

        private string nameField;

        private string typeReferenceField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public property[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        public external external
        {
            get
            {
                return this.externalField;
            }
            set
            {
                this.externalField = value;
            }
        }

        /// <remarks/>
        public string recordDefinitionFieldIdentifier
        {
            get
            {
                return this.recordDefinitionFieldIdentifierField;
            }
            set
            {
                this.recordDefinitionFieldIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordDefinition", IsNullable = false)]
        public recordDefinition[] recordDefinitions
        {
            get
            {
                return this.recordDefinitionsField;
            }
            set
            {
                this.recordDefinitionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string typeReference
        {
            get
            {
                return this.typeReferenceField;
            }
            set
            {
                this.typeReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class external
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class recordDefinition
    {

        private string descriptionField;

        private property[] propertiesField;

        private string recordDefinitionFieldValueField;

        private incomplete incompleteField;

        private string fixedLengthField;

        private repeatingGroup[] repeatingGroupsField;

        private key[] keysField;

        private fieldDefinition[] fieldDefinitionsField;

        private string nameField;

        private string typeReferenceField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public property[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        public string recordDefinitionFieldValue
        {
            get
            {
                return this.recordDefinitionFieldValueField;
            }
            set
            {
                this.recordDefinitionFieldValueField = value;
            }
        }

        /// <remarks/>
        public incomplete incomplete
        {
            get
            {
                return this.incompleteField;
            }
            set
            {
                this.incompleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string fixedLength
        {
            get
            {
                return this.fixedLengthField;
            }
            set
            {
                this.fixedLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("repeatingGroup", IsNullable = false)]
        public repeatingGroup[] repeatingGroups
        {
            get
            {
                return this.repeatingGroupsField;
            }
            set
            {
                this.repeatingGroupsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("key", IsNullable = false)]
        public key[] keys
        {
            get
            {
                return this.keysField;
            }
            set
            {
                this.keysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fieldDefinition", IsNullable = false)]
        public fieldDefinition[] fieldDefinitions
        {
            get
            {
                return this.fieldDefinitionsField;
            }
            set
            {
                this.fieldDefinitionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string typeReference
        {
            get
            {
                return this.typeReferenceField;
            }
            set
            {
                this.typeReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class incomplete
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class repeatingGroup
    {

        private object itemField;

        private fieldDefinitionReference[] fieldDefinitionReferencesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fixedOccurrences", typeof(string), DataType = "nonNegativeInteger")]
        [System.Xml.Serialization.XmlElementAttribute("repeatingGroupOccurrenceField", typeof(repeatingGroupOccurrenceField))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fieldDefinitionReference", IsNullable = false)]
        public fieldDefinitionReference[] fieldDefinitionReferences
        {
            get
            {
                return this.fieldDefinitionReferencesField;
            }
            set
            {
                this.fieldDefinitionReferencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class repeatingGroupOccurrenceField
    {

        private string definitionReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string definitionReference
        {
            get
            {
                return this.definitionReferenceField;
            }
            set
            {
                this.definitionReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class fieldDefinitionReference
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class key
    {

        private object itemField;

        private fieldDefinitionReference[] fieldDefinitionReferencesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("alternateKey", typeof(alternateKey))]
        [System.Xml.Serialization.XmlElementAttribute("foreignKey", typeof(foreignKey))]
        [System.Xml.Serialization.XmlElementAttribute("primaryKey", typeof(primaryKey))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fieldDefinitionReference", IsNullable = false)]
        public fieldDefinitionReference[] fieldDefinitionReferences
        {
            get
            {
                return this.fieldDefinitionReferencesField;
            }
            set
            {
                this.fieldDefinitionReferencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class alternateKey
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class foreignKey
    {

        private flatFileDefinitionReference flatFileDefinitionReferenceField;

        private string relationTypeField;

        /// <remarks/>
        public flatFileDefinitionReference flatFileDefinitionReference
        {
            get
            {
                return this.flatFileDefinitionReferenceField;
            }
            set
            {
                this.flatFileDefinitionReferenceField = value;
            }
        }

        /// <remarks/>
        public string relationType
        {
            get
            {
                return this.relationTypeField;
            }
            set
            {
                this.relationTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class flatFileDefinitionReference
    {

        private recordDefinitionReference[] recordDefinitionReferencesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordDefinitionReference", IsNullable = false)]
        public recordDefinitionReference[] recordDefinitionReferences
        {
            get
            {
                return this.recordDefinitionReferencesField;
            }
            set
            {
                this.recordDefinitionReferencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class recordDefinitionReference
    {

        private fieldDefinitionReference[] fieldDefinitionReferencesField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fieldDefinitionReference", IsNullable = false)]
        public fieldDefinitionReference[] fieldDefinitionReferences
        {
            get
            {
                return this.fieldDefinitionReferencesField;
            }
            set
            {
                this.fieldDefinitionReferencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class primaryKey
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class fieldDefinition
    {

        private string descriptionField;

        private property[] propertiesField;

        private string startPosField;

        private string endPosField;

        private string fixedLengthField;

        private string minLengthField;

        private string maxLengthField;

        private unique uniqueField;

        private notNull notNullField;

        private fieldParts fieldPartsField;

        private code[] codesField;

        private string nameField;

        private string typeReferenceField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public property[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string startPos
        {
            get
            {
                return this.startPosField;
            }
            set
            {
                this.startPosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string endPos
        {
            get
            {
                return this.endPosField;
            }
            set
            {
                this.endPosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string fixedLength
        {
            get
            {
                return this.fixedLengthField;
            }
            set
            {
                this.fixedLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string minLength
        {
            get
            {
                return this.minLengthField;
            }
            set
            {
                this.minLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string maxLength
        {
            get
            {
                return this.maxLengthField;
            }
            set
            {
                this.maxLengthField = value;
            }
        }

        /// <remarks/>
        public unique unique
        {
            get
            {
                return this.uniqueField;
            }
            set
            {
                this.uniqueField = value;
            }
        }

        /// <remarks/>
        public notNull notNull
        {
            get
            {
                return this.notNullField;
            }
            set
            {
                this.notNullField = value;
            }
        }

        /// <remarks/>
        public fieldParts fieldParts
        {
            get
            {
                return this.fieldPartsField;
            }
            set
            {
                this.fieldPartsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("code", IsNullable = false)]
        public code[] codes
        {
            get
            {
                return this.codesField;
            }
            set
            {
                this.codesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string typeReference
        {
            get
            {
                return this.typeReferenceField;
            }
            set
            {
                this.typeReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class unique
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class notNull
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class fieldParts
    {

        private fieldDefinition[] fieldDefinitionField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fieldDefinition")]
        public fieldDefinition[] fieldDefinition
        {
            get
            {
                return this.fieldDefinitionField;
            }
            set
            {
                this.fieldDefinitionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class code
    {

        private string codeValueField;

        private string explanField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeValue
        {
            get
            {
                return this.codeValueField;
            }
            set
            {
                this.codeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string explan
        {
            get
            {
                return this.explanField;
            }
            set
            {
                this.explanField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class structureTypes
    {

        private flatFileType[] flatFileTypesField;

        private recordType[] recordTypesField;

        private fieldType[] fieldTypesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("flatFileType", IsNullable = false)]
        public flatFileType[] flatFileTypes
        {
            get
            {
                return this.flatFileTypesField;
            }
            set
            {
                this.flatFileTypesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("recordType", IsNullable = false)]
        public recordType[] recordTypes
        {
            get
            {
                return this.recordTypesField;
            }
            set
            {
                this.recordTypesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("fieldType", IsNullable = false)]
        public fieldType[] fieldTypes
        {
            get
            {
                return this.fieldTypesField;
            }
            set
            {
                this.fieldTypesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class flatFileType
    {

        private string descriptionField;

        private string charsetField;

        private charDefinition[] charDefinitionsField;

        private object itemField;

        private string nameField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string charset
        {
            get
            {
                return this.charsetField;
            }
            set
            {
                this.charsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("charDefinition", IsNullable = false)]
        public charDefinition[] charDefinitions
        {
            get
            {
                return this.charDefinitionsField;
            }
            set
            {
                this.charDefinitionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("delimFileFormat", typeof(delimFileFormat))]
        [System.Xml.Serialization.XmlElementAttribute("fixedFileFormat", typeof(fixedFileFormat))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class charDefinition
    {

        private string fromCharField;

        private string toCharField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fromChar
        {
            get
            {
                return this.fromCharField;
            }
            set
            {
                this.fromCharField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string toChar
        {
            get
            {
                return this.toCharField;
            }
            set
            {
                this.toCharField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class delimFileFormat
    {

        private string recordSeparatorField;

        private string fieldSeparatingCharField;

        private string quotingCharField;

        /// <remarks/>
        public string recordSeparator
        {
            get
            {
                return this.recordSeparatorField;
            }
            set
            {
                this.recordSeparatorField = value;
            }
        }

        /// <remarks/>
        public string fieldSeparatingChar
        {
            get
            {
                return this.fieldSeparatingCharField;
            }
            set
            {
                this.fieldSeparatingCharField = value;
            }
        }

        /// <remarks/>
        public string quotingChar
        {
            get
            {
                return this.quotingCharField;
            }
            set
            {
                this.quotingCharField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class fixedFileFormat
    {

        private string recordSeparatorField;

        /// <remarks/>
        public string recordSeparator
        {
            get
            {
                return this.recordSeparatorField;
            }
            set
            {
                this.recordSeparatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class recordType
    {

        private string descriptionField;

        private trimmed trimmedField;

        private string nameField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public trimmed trimmed
        {
            get
            {
                return this.trimmedField;
            }
            set
            {
                this.trimmedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class trimmed
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class fieldType
    {

        private string descriptionField;

        private string dataTypeField;

        private string fieldFormatField;

        private string alignmentField;

        private string padCharField;

        private string packTypeField;

        private string[] nullValuesField;

        private string nameField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string dataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        public string fieldFormat
        {
            get
            {
                return this.fieldFormatField;
            }
            set
            {
                this.fieldFormatField = value;
            }
        }

        /// <remarks/>
        public string alignment
        {
            get
            {
                return this.alignmentField;
            }
            set
            {
                this.alignmentField = value;
            }
        }

        /// <remarks/>
        public string padChar
        {
            get
            {
                return this.padCharField;
            }
            set
            {
                this.padCharField = value;
            }
        }

        /// <remarks/>
        public string packType
        {
            get
            {
                return this.packTypeField;
            }
            set
            {
                this.packTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("nullValue", IsNullable = false)]
        public string[] nullValues
        {
            get
            {
                return this.nullValuesField;
            }
            set
            {
                this.nullValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class query
    {

        private string descriptionField;

        private string statementField;

        private string nameField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string statement
        {
            get
            {
                return this.statementField;
            }
            set
            {
                this.statementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class flatFileProcesses
    {

        private process[] processesField;

        private recordProcesses[] recordProcessesField;

        private string flatFileReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("process", IsNullable = false)]
        public process[] processes
        {
            get
            {
                return this.processesField;
            }
            set
            {
                this.processesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recordProcesses")]
        public recordProcesses[] recordProcesses
        {
            get
            {
                return this.recordProcessesField;
            }
            set
            {
                this.recordProcessesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string flatFileReference
        {
            get
            {
                return this.flatFileReferenceField;
            }
            set
            {
                this.flatFileReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class recordProcesses
    {

        private process[] processesField;

        private fieldProcesses[] fieldProcessesField;

        private string definitionReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("process", IsNullable = false)]
        public process[] processes
        {
            get
            {
                return this.processesField;
            }
            set
            {
                this.processesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fieldProcesses")]
        public fieldProcesses[] fieldProcesses
        {
            get
            {
                return this.fieldProcessesField;
            }
            set
            {
                this.fieldProcessesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string definitionReference
        {
            get
            {
                return this.definitionReferenceField;
            }
            set
            {
                this.definitionReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class fieldProcesses
    {

        private process[] processesField;

        private string definitionReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("process", IsNullable = false)]
        public process[] processes
        {
            get
            {
                return this.processesField;
            }
            set
            {
                this.processesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string definitionReference
        {
            get
            {
                return this.definitionReferenceField;
            }
            set
            {
                this.definitionReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class dataObjects
    {

        private string descriptionField;

        private dataObject[] dataObjectField;

        private process[] processesField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("dataObject")]
        public dataObject[] dataObject
        {
            get
            {
                return this.dataObjectField;
            }
            set
            {
                this.dataObjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("process", IsNullable = false)]
        public process[] processes
        {
            get
            {
                return this.processesField;
            }
            set
            {
                this.processesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class dataObject
    {

        private string descriptionField;

        private property[] propertiesField;

        private dataObjects dataObjectsField;

        private process[] processesField;

        private string nameField;

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public property[] properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        public dataObjects dataObjects
        {
            get
            {
                return this.dataObjectsField;
            }
            set
            {
                this.dataObjectsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("process", IsNullable = false)]
        public process[] processes
        {
            get
            {
                return this.processesField;
            }
            set
            {
                this.processesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class flatFileDefinitions
    {

        private flatFileDefinition[] flatFileDefinitionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("flatFileDefinition")]
        public flatFileDefinition[] flatFileDefinition
        {
            get
            {
                return this.flatFileDefinitionField;
            }
            set
            {
                this.flatFileDefinitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class recordDefinitions
    {

        private recordDefinition[] recordDefinitionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recordDefinition")]
        public recordDefinition[] recordDefinition
        {
            get
            {
                return this.recordDefinitionField;
            }
            set
            {
                this.recordDefinitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class repeatingGroups
    {

        private repeatingGroup[] repeatingGroupField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("repeatingGroup")]
        public repeatingGroup[] repeatingGroup
        {
            get
            {
                return this.repeatingGroupField;
            }
            set
            {
                this.repeatingGroupField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class keys
    {

        private key[] keyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("key")]
        public key[] key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class fieldDefinitions
    {

        private fieldDefinition[] fieldDefinitionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fieldDefinition")]
        public fieldDefinition[] fieldDefinition
        {
            get
            {
                return this.fieldDefinitionField;
            }
            set
            {
                this.fieldDefinitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class codes
    {

        private code[] codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("code")]
        public code[] code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class flatFileTypes
    {

        private flatFileType[] flatFileTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("flatFileType")]
        public flatFileType[] flatFileType
        {
            get
            {
                return this.flatFileTypeField;
            }
            set
            {
                this.flatFileTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class charDefinitions
    {

        private charDefinition[] charDefinitionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("charDefinition")]
        public charDefinition[] charDefinition
        {
            get
            {
                return this.charDefinitionField;
            }
            set
            {
                this.charDefinitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class recordTypes
    {

        private recordType[] recordTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recordType")]
        public recordType[] recordType
        {
            get
            {
                return this.recordTypeField;
            }
            set
            {
                this.recordTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class fieldTypes
    {

        private fieldType[] fieldTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fieldType")]
        public fieldType[] fieldType
        {
            get
            {
                return this.fieldTypeField;
            }
            set
            {
                this.fieldTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class nullValues
    {

        private string[] nullValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nullValue")]
        public string[] nullValue
        {
            get
            {
                return this.nullValueField;
            }
            set
            {
                this.nullValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class queries
    {

        private query[] queryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("query")]
        public query[] query
        {
            get
            {
                return this.queryField;
            }
            set
            {
                this.queryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class processes
    {

        private process[] processField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("process")]
        public process[] process
        {
            get
            {
                return this.processField;
            }
            set
            {
                this.processField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class parameters
    {

        private parameter[] parameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parameter")]
        public parameter[] parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class recordDefinitionReferences
    {

        private recordDefinitionReference[] recordDefinitionReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("recordDefinitionReference")]
        public recordDefinitionReference[] recordDefinitionReference
        {
            get
            {
                return this.recordDefinitionReferenceField;
            }
            set
            {
                this.recordDefinitionReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class fieldDefinitionReferences
    {

        private fieldDefinitionReference[] fieldDefinitionReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("fieldDefinitionReference")]
        public fieldDefinitionReference[] fieldDefinitionReference
        {
            get
            {
                return this.fieldDefinitionReferenceField;
            }
            set
            {
                this.fieldDefinitionReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.arkivverket.no/standarder/addml")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.arkivverket.no/standarder/addml", IsNullable = false)]
    public partial class properties
    {

        private property[] propertyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("property")]
        public property[] property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }
    }
}
