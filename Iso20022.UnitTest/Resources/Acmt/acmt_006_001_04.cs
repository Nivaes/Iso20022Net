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
namespace Iso20022.Contracts.AcmtM006V00104 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04", IsNullable=false)]
    public partial class Document {
        
        private AccountManagementStatusReportV04 acctMgmtStsRptField;
        
        /// <remarks/>
        public AccountManagementStatusReportV04 AcctMgmtStsRpt {
            get {
                return this.acctMgmtStsRptField;
            }
            set {
                this.acctMgmtStsRptField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
    public partial class AccountManagementStatusReportV04 {
        
        private MessageIdentification1 msgIdField;
        
        private AdditionalReference3[] rltdRefField;
        
        private AccountManagementStatusAndReason3 stsRptField;
        
        private MarketPracticeVersion1 mktPrctcVrsnField;
        
        private Extension1[] xtnsnField;
        
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
        public AccountManagementStatusAndReason3 StsRpt {
            get {
                return this.stsRptField;
            }
            set {
                this.stsRptField = value;
            }
        }
        
        /// <remarks/>
        public MarketPracticeVersion1 MktPrctcVrsn {
            get {
                return this.mktPrctcVrsnField;
            }
            set {
                this.mktPrctcVrsnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Xtnsn")]
        public Extension1[] Xtnsn {
            get {
                return this.xtnsnField;
            }
            set {
                this.xtnsnField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
    public partial class Extension1 {
        
        private string plcAndNmField;
        
        private string txtField;
        
        /// <remarks/>
        public string PlcAndNm {
            get {
                return this.plcAndNmField;
            }
            set {
                this.plcAndNmField = value;
            }
        }
        
        /// <remarks/>
        public string Txt {
            get {
                return this.txtField;
            }
            set {
                this.txtField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
    public partial class MarketPracticeVersion1 {
        
        private string nmField;
        
        private string dtField;
        
        private string nbField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="gYearMonth")]
        public string Dt {
            get {
                return this.dtField;
            }
            set {
                this.dtField = value;
            }
        }
        
        /// <remarks/>
        public string Nb {
            get {
                return this.nbField;
            }
            set {
                this.nbField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
    public partial class GenericIdentification29 {
        
        private string idField;
        
        private string issrField;
        
        private string schmeNmField;
        
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
        public string Issr {
            get {
                return this.issrField;
            }
            set {
                this.issrField = value;
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
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
    public partial class RejectedReason4Choice {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(RejectedStatusReason6Code))]
        [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification29))]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
    public partial class RejectionReason16 {
        
        private RejectedReason4Choice rsnField;
        
        private string addtlRsnInfField;
        
        /// <remarks/>
        public RejectedReason4Choice Rsn {
            get {
                return this.rsnField;
            }
            set {
                this.rsnField = value;
            }
        }
        
        /// <remarks/>
        public string AddtlRsnInf {
            get {
                return this.addtlRsnInfField;
            }
            set {
                this.addtlRsnInfField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
    public partial class Status14Choice {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rjctd", typeof(RejectionReason16))]
        [System.Xml.Serialization.XmlElementAttribute("Sts", typeof(AccountManagementStatus1Code))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
    public partial class AccountManagementStatusAndReason3 {
        
        private Status14Choice stsField;
        
        private string acctApplIdField;
        
        /// <remarks/>
        public Status14Choice Sts {
            get {
                return this.stsField;
            }
            set {
                this.stsField = value;
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
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.006.001.04")]
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