using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace vmware.lookupservice
{
    [XmlType(Namespace = "urn:lookup")]
    [DebuggerStepThrough]
    [DesignerCategory("code")]    
    [Serializable]
    public class LookupHaBackupNodeConfiguration : DynamicData
    {
        private string dbTypeField;
        private string dbJdbcUrlField;
        private string dbUserField;
        private string dbPassField;

        [XmlElement(Order = 0)]
        public string dbType
        {
            get
            {
                return this.dbTypeField;
            }
            set
            {
                this.dbTypeField = value;
            }
        }

        [XmlElement(Order = 1)]
        public string dbJdbcUrl
        {
            get
            {
                return this.dbJdbcUrlField;
            }
            set
            {
                this.dbJdbcUrlField = value;
            }
        }

        [XmlElement(Order = 2)]
        public string dbUser
        {
            get
            {
                return this.dbUserField;
            }
            set
            {
                this.dbUserField = value;
            }
        }

        [XmlElement(Order = 3)]
        public string dbPass
        {
            get
            {
                return this.dbPassField;
            }
            set
            {
                this.dbPassField = value;
            }
        }
    }
}
