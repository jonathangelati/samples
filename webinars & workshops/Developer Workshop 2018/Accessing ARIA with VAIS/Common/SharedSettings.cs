﻿using System;
using System.Xml.Serialization;
using System.Text;

namespace Common
{
    [XmlRoot(ElementName = "LicenseServer", Namespace = "http://www.varian.com/vmsos/schema/vms.osp/SharedSettings")]
    public class LicenseServer
    {
        [XmlElement(ElementName = "HostName", Namespace = "http://www.varian.com/vmsos/schema/vms.osp/SharedSettings")]
        public string HostName { get; set; }
        [XmlElement(ElementName = "PortNumber", Namespace = "http://www.varian.com/vmsos/schema/vms.osp/SharedSettings")]
        public string PortNumber { get; set; }

        public override string ToString()
        {
            return HostName + (string.IsNullOrEmpty(PortNumber) ? "": (":" + PortNumber));
        }
    }

    [XmlRoot(ElementName = "SharedSettings", Namespace = "http://www.varian.com/vmsos/schema/vms.osp/SharedSettings")]
    public class SharedSettings
    {
        [XmlElement(ElementName = "DoseUnits", Namespace = "http://www.varian.com/vmsos/schema/vms.osp/SharedSettings")]
        public string DoseUnits { get; set; }
        [XmlElement(ElementName = "DosePrecision", Namespace = "http://www.varian.com/vmsos/schema/vms.osp/SharedSettings")]
        public string DosePrecision { get; set; }
        [XmlElement(ElementName = "Culture", Namespace = "http://www.varian.com/vmsos/schema/vms.osp/SharedSettings")]
        public string Culture { get; set; }
        [XmlElement(ElementName = "DateFormat", Namespace = "http://www.varian.com/vmsos/schema/vms.osp/SharedSettings")]
        public string DateFormat { get; set; }
        [XmlElement(ElementName = "TimeFormat", Namespace = "http://www.varian.com/vmsos/schema/vms.osp/SharedSettings")]
        public string TimeFormat { get; set; }
        [XmlElement(ElementName = "Language", Namespace = "http://www.varian.com/vmsos/schema/vms.osp/SharedSettings")]
        public string Language { get; set; }
        [XmlElement(ElementName = "HIPAA", Namespace = "http://www.varian.com/vmsos/schema/vms.osp/SharedSettings")]
        public string HIPAA { get; set; }
        [XmlElement(ElementName = "HIPAATimeout", Namespace = "http://www.varian.com/vmsos/schema/vms.osp/SharedSettings")]
        public string HIPAATimeout { get; set; }
        [XmlElement(ElementName = "LicenseServer", Namespace = "http://www.varian.com/vmsos/schema/vms.osp/SharedSettings")]
        public LicenseServer LicenseServer { get; set; }
        [XmlElement(ElementName = "RememberLoggedInUser", Namespace = "http://www.varian.com/vmsos/schema/vms.osp/SharedSettings")]
        public string RememberLoggedInUser { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendFormat("{0}: {1}{2}", "Dose Units", DoseUnits, Environment.NewLine);
            builder.AppendFormat("{0}: {1}{2}", "Dose Precision", DosePrecision, Environment.NewLine);
            builder.AppendFormat("{0}: {1}{2}", "Culture", Culture, Environment.NewLine);
            builder.AppendFormat("{0}: {1}{2}", "Date Format", DateFormat, Environment.NewLine);
            builder.AppendFormat("{0}: {1}{2}", "Time Format", TimeFormat, Environment.NewLine);
            builder.AppendFormat("{0}: {1}{2}", "Language", Language, Environment.NewLine);
            builder.AppendFormat("{0}: {1}{2}", "HIPAA", HIPAA, Environment.NewLine);
            builder.AppendFormat("{0}: {1}{2}", "HIPAA Timeout", HIPAATimeout, Environment.NewLine);
            builder.AppendFormat("{0}: {1}{2}", "LicenseServer", LicenseServer, Environment.NewLine);
            builder.AppendFormat("{0}: {1}{2}", "Remember Logged In User", RememberLoggedInUser, Environment.NewLine);
            return builder.ToString();
        }
    }

}
