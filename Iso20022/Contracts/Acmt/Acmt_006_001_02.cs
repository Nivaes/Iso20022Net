﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace Iso20022.Contracts.AcmtM006V00102 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02", IsNullable=false)]
    public partial class Document {
        
        private AccountManagementStatusReportV02 acctMgmtStsRptV02Field;
        
        /// <remarks/>
        public AccountManagementStatusReportV02 AcctMgmtStsRptV02 {
            get {
                return this.acctMgmtStsRptV02Field;
            }
            set {
                this.acctMgmtStsRptV02Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02")]
    public partial class AccountManagementStatusReportV02 {
        
        private MessageIdentification1 msgIdField;
        
        private AdditionalReference3[] rltdRefField;
        
        private AccountManagementStatusAndReason1 stsRptField;
        
        /// <remarks/>
        public MessageIdentification1 MsgId {
            get {
                return this.msgIdField;
            }
            set {
                this.msgIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RltdRef")]
        public AdditionalReference3[] RltdRef {
            get {
                return this.rltdRefField;
            }
            set {
                this.rltdRefField = value;
            }
        }
        
        /// <remarks/>
        public AccountManagementStatusAndReason1 StsRpt {
            get {
                return this.stsRptField;
            }
            set {
                this.stsRptField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02")]
    public partial class MessageIdentification1 {
        
        private string idField;
        
        private System.DateTime creDtTmField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CreDtTm {
            get {
                return this.creDtTmField;
            }
            set {
                this.creDtTmField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02")]
    public partial class RejectedStatus5 {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rsn", typeof(RejectedStatusReason6Code))]
        [System.Xml.Serialization.XmlElementAttribute("XtndedRsn", typeof(string))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02")]
    public enum RejectedStatusReason6Code {
        
        /// <remarks/>
        SAFE,
        
        /// <remarks/>
        NSLA,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02")]
    public partial class AccountManagementStatusAndReason1 {
        
        private object itemField;
        
        private string acctApplIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rjctd", typeof(RejectedStatus5))]
        [System.Xml.Serialization.XmlElementAttribute("Sts", typeof(AccountManagementStatus1Code))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        public string AcctApplId {
            get {
                return this.acctApplIdField;
            }
            set {
                this.acctApplIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02")]
    public enum AccountManagementStatus1Code {
        
        /// <remarks/>
        RECE,
        
        /// <remarks/>
        ACCP,
        
        /// <remarks/>
        EXEC,
        
        /// <remarks/>
        STNP,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02")]
    public partial class PostalAddress1 {
        
        private AddressType2Code adrTpField;
        
        private bool adrTpFieldSpecified;
        
        private string[] adrLineField;
        
        private string strtNmField;
        
        private string bldgNbField;
        
        private string pstCdField;
        
        private string twnNmField;
        
        private string ctrySubDvsnField;
        
        private string ctryField;
        
        /// <remarks/>
        public AddressType2Code AdrTp {
            get {
                return this.adrTpField;
            }
            set {
                this.adrTpField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AdrTpSpecified {
            get {
                return this.adrTpFieldSpecified;
            }
            set {
                this.adrTpFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdrLine")]
        public string[] AdrLine {
            get {
                return this.adrLineField;
            }
            set {
                this.adrLineField = value;
            }
        }
        
        /// <remarks/>
        public string StrtNm {
            get {
                return this.strtNmField;
            }
            set {
                this.strtNmField = value;
            }
        }
        
        /// <remarks/>
        public string BldgNb {
            get {
                return this.bldgNbField;
            }
            set {
                this.bldgNbField = value;
            }
        }
        
        /// <remarks/>
        public string PstCd {
            get {
                return this.pstCdField;
            }
            set {
                this.pstCdField = value;
            }
        }
        
        /// <remarks/>
        public string TwnNm {
            get {
                return this.twnNmField;
            }
            set {
                this.twnNmField = value;
            }
        }
        
        /// <remarks/>
        public string CtrySubDvsn {
            get {
                return this.ctrySubDvsnField;
            }
            set {
                this.ctrySubDvsnField = value;
            }
        }
        
        /// <remarks/>
        public string Ctry {
            get {
                return this.ctryField;
            }
            set {
                this.ctryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02")]
    public enum AddressType2Code {
        
        /// <remarks/>
        ADDR,
        
        /// <remarks/>
        PBOX,
        
        /// <remarks/>
        HOME,
        
        /// <remarks/>
        BIZZ,
        
        /// <remarks/>
        MLTO,
        
        /// <remarks/>
        DLVY,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02")]
    public partial class NameAndAddress5 {
        
        private string nmField;
        
        private PostalAddress1 adrField;
        
        /// <remarks/>
        public string Nm {
            get {
                return this.nmField;
            }
            set {
                this.nmField = value;
            }
        }
        
        /// <remarks/>
        public PostalAddress1 Adr {
            get {
                return this.adrField;
            }
            set {
                this.adrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02")]
    public partial class GenericIdentification1 {
        
        private string idField;
        
        private string schmeNmField;
        
        private string issrField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string SchmeNm {
            get {
                return this.schmeNmField;
            }
            set {
                this.schmeNmField = value;
            }
        }
        
        /// <remarks/>
        public string Issr {
            get {
                return this.issrField;
            }
            set {
                this.issrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02")]
    public partial class PartyIdentification2Choice {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BICOrBEI", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5))]
        [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification1))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.02")]
    public partial class AdditionalReference3 {
        
        private string refField;
        
        private PartyIdentification2Choice refIssrField;
        
        private string msgNmField;
        
        /// <remarks/>
        public string Ref {
            get {
                return this.refField;
            }
            set {
                this.refField = value;
            }
        }
        
        /// <remarks/>
        public PartyIdentification2Choice RefIssr {
            get {
                return this.refIssrField;
            }
            set {
                this.refIssrField = value;
            }
        }
        
        /// <remarks/>
        public string MsgNm {
            get {
                return this.msgNmField;
            }
            set {
                this.msgNmField = value;
            }
        }
    }
}
