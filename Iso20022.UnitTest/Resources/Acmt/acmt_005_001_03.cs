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
namespace Iso20022.Contracts.AcmtM005V00103 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03", IsNullable=false)]
    public partial class Document {
        
        private RequestForAccountManagementStatusReportV03 reqForAcctMgmtStsRptField;
        
        /// <remarks/>
        public RequestForAccountManagementStatusReportV03 ReqForAcctMgmtStsRpt {
            get {
                return this.reqForAcctMgmtStsRptField;
            }
            set {
                this.reqForAcctMgmtStsRptField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
    public partial class RequestForAccountManagementStatusReportV03 {
        
        private MessageIdentification1 msgIdField;
        
        private AccountManagementMessageReference2 reqDtlsField;
        
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
        public AccountManagementMessageReference2 ReqDtls {
            get {
                return this.reqDtlsField;
            }
            set {
                this.reqDtlsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
    public partial class PartyIdentification5Choice {
        
        private object itemField;
        
        private ItemChoiceType1 itemElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BICOrBEI", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress5))]
        [System.Xml.Serialization.XmlElementAttribute("NtlRegnNb", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification1))]
        [System.Xml.Serialization.XmlElementAttribute("TaxIdNb", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType1 {
        
        /// <remarks/>
        BICOrBEI,
        
        /// <remarks/>
        NmAndAdr,
        
        /// <remarks/>
        NtlRegnNb,
        
        /// <remarks/>
        PrtryId,
        
        /// <remarks/>
        TaxIdNb,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
    public partial class IndividualPerson4 {
        
        private string gvnNmField;
        
        private string mddlNmField;
        
        private string nmField;
        
        private GenderCode gndrField;
        
        private bool gndrFieldSpecified;
        
        private System.DateTime birthDtField;
        
        private bool birthDtFieldSpecified;
        
        /// <remarks/>
        public string GvnNm {
            get {
                return this.gvnNmField;
            }
            set {
                this.gvnNmField = value;
            }
        }
        
        /// <remarks/>
        public string MddlNm {
            get {
                return this.mddlNmField;
            }
            set {
                this.mddlNmField = value;
            }
        }
        
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
        public GenderCode Gndr {
            get {
                return this.gndrField;
            }
            set {
                this.gndrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GndrSpecified {
            get {
                return this.gndrFieldSpecified;
            }
            set {
                this.gndrFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime BirthDt {
            get {
                return this.birthDtField;
            }
            set {
                this.birthDtField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BirthDtSpecified {
            get {
                return this.birthDtFieldSpecified;
            }
            set {
                this.birthDtFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
    public enum GenderCode {
        
        /// <remarks/>
        MALE,
        
        /// <remarks/>
        FEMA,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
    public partial class GenericIdentification10 {
        
        private string idField;
        
        private object itemField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("IdTp", typeof(PersonIdentificationType1Code))]
        [System.Xml.Serialization.XmlElementAttribute("XtndedIdTp", typeof(string))]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
    public enum PersonIdentificationType1Code {
        
        /// <remarks/>
        PASS,
        
        /// <remarks/>
        CPFA,
        
        /// <remarks/>
        SRSA,
        
        /// <remarks/>
        NRIN,
        
        /// <remarks/>
        OTHR,
        
        /// <remarks/>
        DRLC,
        
        /// <remarks/>
        SOCS,
        
        /// <remarks/>
        AREG,
        
        /// <remarks/>
        IDCD,
        
        /// <remarks/>
        EMID,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
    public partial class IndividualPersonIdentificationChoice {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdNb", typeof(GenericIdentification10))]
        [System.Xml.Serialization.XmlElementAttribute("PrsnNm", typeof(IndividualPerson4))]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
    public partial class OwnerIdentification1Choice {
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IndvOwnrId", typeof(IndividualPersonIdentificationChoice))]
        [System.Xml.Serialization.XmlElementAttribute("OrgOwnrId", typeof(PartyIdentification5Choice))]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
    public partial class SimpleIdentificationInformation {
        
        private string idField;
        
        /// <remarks/>
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
    public partial class AccountIdentification1 {
        
        private SimpleIdentificationInformation prtryField;
        
        /// <remarks/>
        public SimpleIdentificationInformation Prtry {
            get {
                return this.prtryField;
            }
            set {
                this.prtryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
    public partial class InvestmentAccount45 {
        
        private AccountIdentification1 acctIdField;
        
        private string acctNmField;
        
        private string acctDsgntField;
        
        private OwnerIdentification1Choice ownrIdField;
        
        private PartyIdentification2Choice acctSvcrField;
        
        /// <remarks/>
        public AccountIdentification1 AcctId {
            get {
                return this.acctIdField;
            }
            set {
                this.acctIdField = value;
            }
        }
        
        /// <remarks/>
        public string AcctNm {
            get {
                return this.acctNmField;
            }
            set {
                this.acctNmField = value;
            }
        }
        
        /// <remarks/>
        public string AcctDsgnt {
            get {
                return this.acctDsgntField;
            }
            set {
                this.acctDsgntField = value;
            }
        }
        
        /// <remarks/>
        public OwnerIdentification1Choice OwnrId {
            get {
                return this.ownrIdField;
            }
            set {
                this.ownrIdField = value;
            }
        }
        
        /// <remarks/>
        public PartyIdentification2Choice AcctSvcr {
            get {
                return this.acctSvcrField;
            }
            set {
                this.acctSvcrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
    public partial class LinkedMessage2Choice {
        
        private AdditionalReference3 itemField;
        
        private ItemChoiceType itemElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OthrRef", typeof(AdditionalReference3))]
        [System.Xml.Serialization.XmlElementAttribute("PrvsRef", typeof(AdditionalReference3))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public AdditionalReference3 Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03", IncludeInSchema=false)]
    public enum ItemChoiceType {
        
        /// <remarks/>
        OthrRef,
        
        /// <remarks/>
        PrvsRef,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
    public partial class AccountManagementMessageReference2 {
        
        private LinkedMessage2Choice lkdRefField;
        
        private AccountManagementType1Code stsReqTpField;
        
        private string acctApplIdField;
        
        private InvestmentAccount45 invstmtAcctField;
        
        /// <remarks/>
        public LinkedMessage2Choice LkdRef {
            get {
                return this.lkdRefField;
            }
            set {
                this.lkdRefField = value;
            }
        }
        
        /// <remarks/>
        public AccountManagementType1Code StsReqTp {
            get {
                return this.stsReqTpField;
            }
            set {
                this.stsReqTpField = value;
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
        
        /// <remarks/>
        public InvestmentAccount45 InvstmtAcct {
            get {
                return this.invstmtAcctField;
            }
            set {
                this.invstmtAcctField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:acmt.005.001.03")]
    public enum AccountManagementType1Code {
        
        /// <remarks/>
        ACCO,
        
        /// <remarks/>
        ACCM,
    }
}
