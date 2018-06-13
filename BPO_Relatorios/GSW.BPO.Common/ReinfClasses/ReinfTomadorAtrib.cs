using System.Xml.Serialization;

namespace GSW.BPO.Common.ReinfClasses
{
    

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtTomadorServicos/v1_03_02")]
    public partial class ReinfEvtServTom
    {

        private ReinfEvtServTomIdeEvento ideEventoField;

        private ReinfEvtServTomIdeContri ideContriField;

        private ReinfEvtServTomInfoServTom infoServTomField;

        private string idField;

        /// <remarks/>
        public ReinfEvtServTomIdeEvento ideEvento
        {
            get
            {
                return this.ideEventoField;
            }
            set
            {
                this.ideEventoField = value;
            }
        }

        /// <remarks/>
        public ReinfEvtServTomIdeContri ideContri
        {
            get
            {
                return this.ideContriField;
            }
            set
            {
                this.ideContriField = value;
            }
        }

        /// <remarks/>
        public ReinfEvtServTomInfoServTom infoServTom
        {
            get
            {
                return this.infoServTomField;
            }
            set
            {
                this.infoServTomField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtTomadorServicos/v1_03_02")]
    public partial class ReinfEvtServTomIdeEvento
    {

        private byte indRetifField;

        private string nrReciboField;

        private string perApurField;

        private uint tpAmbField;

        private byte procEmiField;

        private string verProcField;

        /// <remarks/>
        public byte indRetif
        {
            get
            {
                return this.indRetifField;
            }
            set
            {
                this.indRetifField = value;
            }
        }

        /// <remarks/>
        public string nrRecibo
        {
            get
            {
                return this.nrReciboField;
            }
            set
            {
                this.nrReciboField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "gYearMonth")]
        public string perApur
        {
            get
            {
                return this.perApurField;
            }
            set
            {
                this.perApurField = value;
            }
        }

        /// <remarks/>
        public uint tpAmb
        {
            get
            {
                return this.tpAmbField;
            }
            set
            {
                this.tpAmbField = value;
            }
        }

        /// <remarks/>
        public byte procEmi
        {
            get
            {
                return this.procEmiField;
            }
            set
            {
                this.procEmiField = value;
            }
        }

        /// <remarks/>
        public string verProc
        {
            get
            {
                return this.verProcField;
            }
            set
            {
                this.verProcField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtTomadorServicos/v1_03_02")]
    public partial class ReinfEvtServTomIdeContri
    {

        private byte tpInscField;

        private string nrInscField;

        /// <remarks/>
        public byte tpInsc
        {
            get
            {
                return this.tpInscField;
            }
            set
            {
                this.tpInscField = value;
            }
        }

        /// <remarks/>
        public string nrInsc
        {
            get
            {
                return this.nrInscField;
            }
            set
            {
                this.nrInscField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtTomadorServicos/v1_03_02")]
    public partial class ReinfEvtServTomInfoServTom
    {

        private ReinfEvtServTomInfoServTomIdeEstabObra ideEstabObraField;

        /// <remarks/>
        public ReinfEvtServTomInfoServTomIdeEstabObra ideEstabObra
        {
            get
            {
                return this.ideEstabObraField;
            }
            set
            {
                this.ideEstabObraField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtTomadorServicos/v1_03_02")]
    public partial class ReinfEvtServTomInfoServTomIdeEstabObra
    {

        private byte tpInscEstabField;

        private string nrInscEstabField;

        private byte indObraField;

        private ReinfEvtServTomInfoServTomIdeEstabObraIdePrestServ idePrestServField;

        /// <remarks/>
        public byte tpInscEstab
        {
            get
            {
                return this.tpInscEstabField;
            }
            set
            {
                this.tpInscEstabField = value;
            }
        }

        /// <remarks/>
        public string nrInscEstab
        {
            get
            {
                return this.nrInscEstabField;
            }
            set
            {
                this.nrInscEstabField = value;
            }
        }

        /// <remarks/>
        public byte indObra
        {
            get
            {
                return this.indObraField;
            }
            set
            {
                this.indObraField = value;
            }
        }

        /// <remarks/>
        public ReinfEvtServTomInfoServTomIdeEstabObraIdePrestServ idePrestServ
        {
            get
            {
                return this.idePrestServField;
            }
            set
            {
                this.idePrestServField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtTomadorServicos/v1_03_02")]
    public partial class ReinfEvtServTomInfoServTomIdeEstabObraIdePrestServ
    {

        private string cnpjPrestadorField;

        private string vlrTotalBrutoField;

        private string vlrTotalBaseRetField;

        private string vlrTotalRetPrincField;

        private string vlrTotalRetAdicField;

        private string vlrTotalNRetPrincField;

        private string vlrTotalNRetAdicField;

        private byte indCPRBField;

        private ReinfEvtServTomInfoServTomIdeEstabObraIdePrestServNfs[] nfsField;

        private ReinfEvtServTomInfoServTomIdeEstabObraIdePrestServInfoProcRetPr[] infoProcRetPrField;

        private ReinfEvtServTomInfoServTomIdeEstabObraIdePrestServInfoProcRetAd[] infoProcRetAdField;

        /// <remarks/>
        public string cnpjPrestador
        {
            get
            {
                return this.cnpjPrestadorField;
            }
            set
            {
                this.cnpjPrestadorField = value;
            }
        }

        /// <remarks/>
        public string vlrTotalBruto
        {
            get
            {
                return this.vlrTotalBrutoField;
            }
            set
            {
                this.vlrTotalBrutoField = value;
            }
        }

        /// <remarks/>
        public string vlrTotalBaseRet
        {
            get
            {
                return this.vlrTotalBaseRetField;
            }
            set
            {
                this.vlrTotalBaseRetField = value;
            }
        }

        /// <remarks/>
        public string vlrTotalRetPrinc
        {
            get
            {
                return this.vlrTotalRetPrincField;
            }
            set
            {
                this.vlrTotalRetPrincField = value;
            }
        }

        /// <remarks/>
        public string vlrTotalRetAdic
        {
            get
            {
                return this.vlrTotalRetAdicField;
            }
            set
            {
                this.vlrTotalRetAdicField = value;
            }
        }

        /// <remarks/>
        public string vlrTotalNRetPrinc
        {
            get
            {
                return this.vlrTotalNRetPrincField;
            }
            set
            {
                this.vlrTotalNRetPrincField = value;
            }
        }

        /// <remarks/>
        public string vlrTotalNRetAdic
        {
            get
            {
                return this.vlrTotalNRetAdicField;
            }
            set
            {
                this.vlrTotalNRetAdicField = value;
            }
        }

        /// <remarks/>
        public byte indCPRB
        {
            get
            {
                return this.indCPRBField;
            }
            set
            {
                this.indCPRBField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("nfs")]
        public ReinfEvtServTomInfoServTomIdeEstabObraIdePrestServNfs[] nfs
        {
            get
            {
                return this.nfsField;
            }
            set
            {
                this.nfsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infoProcRetPr")]
        public ReinfEvtServTomInfoServTomIdeEstabObraIdePrestServInfoProcRetPr[] infoProcRetPr
        {
            get
            {
                return this.infoProcRetPrField;
            }
            set
            {
                this.infoProcRetPrField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infoProcRetAd")]
        public ReinfEvtServTomInfoServTomIdeEstabObraIdePrestServInfoProcRetAd[] infoProcRetAd
        {
            get
            {
                return this.infoProcRetAdField;
            }
            set
            {
                this.infoProcRetAdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtTomadorServicos/v1_03_02")]
    public partial class ReinfEvtServTomInfoServTomIdeEstabObraIdePrestServNfs
    {

        private string serieField;

        private string numDoctoField;

        private System.DateTime dtEmissaoNFField;

        private string vlrBrutoField;

        private string obsField;

        private ReinfEvtServTomInfoServTomIdeEstabObraIdePrestServNfsInfoTpServ[] infoTpServField;

        /// <remarks/>
        public string serie
        {
            get
            {
                return this.serieField;
            }
            set
            {
                this.serieField = value;
            }
        }

        /// <remarks/>
        public string numDocto
        {
            get
            {
                return this.numDoctoField;
            }
            set
            {
                this.numDoctoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime dtEmissaoNF
        {
            get
            {
                return this.dtEmissaoNFField;
            }
            set
            {
                this.dtEmissaoNFField = value;
            }
        }

        /// <remarks/>
        public string vlrBruto
        {
            get
            {
                return this.vlrBrutoField;
            }
            set
            {
                this.vlrBrutoField = value;
            }
        }

        /// <remarks/>
        public string obs
        {
            get
            {
                return this.obsField;
            }
            set
            {
                this.obsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("infoTpServ")]
        public ReinfEvtServTomInfoServTomIdeEstabObraIdePrestServNfsInfoTpServ[] infoTpServ
        {
            get
            {
                return this.infoTpServField;
            }
            set
            {
                this.infoTpServField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtTomadorServicos/v1_03_02")]
    public partial class ReinfEvtServTomInfoServTomIdeEstabObraIdePrestServNfsInfoTpServ
    {

        private string tpServicoField;

        private string vlrBaseRetField;

        private string vlrRetencaoField;

        private string vlrRetSubField;

        private string vlrNRetPrincField;

        private string vlrServicos15Field;

        private string vlrServicos20Field;

        private string vlrServicos25Field;

        private string vlrAdicionalField;

        private string vlrNRetAdicField;

        /// <remarks/>
        public string tpServico
        {
            get
            {
                return this.tpServicoField;
            }
            set
            {
                this.tpServicoField = value;
            }
        }

        /// <remarks/>
        public string vlrBaseRet
        {
            get
            {
                return this.vlrBaseRetField;
            }
            set
            {
                this.vlrBaseRetField = value;
            }
        }

        /// <remarks/>
        public string vlrRetencao
        {
            get
            {
                return this.vlrRetencaoField;
            }
            set
            {
                this.vlrRetencaoField = value;
            }
        }

        /// <remarks/>
        public string vlrRetSub
        {
            get
            {
                return this.vlrRetSubField;
            }
            set
            {
                this.vlrRetSubField = value;
            }
        }

        /// <remarks/>
        public string vlrNRetPrinc
        {
            get
            {
                return this.vlrNRetPrincField;
            }
            set
            {
                this.vlrNRetPrincField = value;
            }
        }

        /// <remarks/>
        public string vlrServicos15
        {
            get
            {
                return this.vlrServicos15Field;
            }
            set
            {
                this.vlrServicos15Field = value;
            }
        }

        /// <remarks/>
        public string vlrServicos20
        {
            get
            {
                return this.vlrServicos20Field;
            }
            set
            {
                this.vlrServicos20Field = value;
            }
        }

        /// <remarks/>
        public string vlrServicos25
        {
            get
            {
                return this.vlrServicos25Field;
            }
            set
            {
                this.vlrServicos25Field = value;
            }
        }

        /// <remarks/>
        public string vlrAdicional
        {
            get
            {
                return this.vlrAdicionalField;
            }
            set
            {
                this.vlrAdicionalField = value;
            }
        }

        /// <remarks/>
        public string vlrNRetAdic
        {
            get
            {
                return this.vlrNRetAdicField;
            }
            set
            {
                this.vlrNRetAdicField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtTomadorServicos/v1_03_02")]
    public partial class ReinfEvtServTomInfoServTomIdeEstabObraIdePrestServInfoProcRetPr
    {

        private byte tpProcRetPrincField;

        private string nrProcRetPrincField;

        private string codSuspPrincField;

        private string valorPrincField;

        /// <remarks/>
        public byte tpProcRetPrinc
        {
            get
            {
                return this.tpProcRetPrincField;
            }
            set
            {
                this.tpProcRetPrincField = value;
            }
        }

        /// <remarks/>
        public string nrProcRetPrinc
        {
            get
            {
                return this.nrProcRetPrincField;
            }
            set
            {
                this.nrProcRetPrincField = value;
            }
        }

        /// <remarks/>
        public string codSuspPrinc
        {
            get
            {
                return this.codSuspPrincField;
            }
            set
            {
                this.codSuspPrincField = value;
            }
        }

        /// <remarks/>
        public string valorPrinc
        {
            get
            {
                return this.valorPrincField;
            }
            set
            {
                this.valorPrincField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtTomadorServicos/v1_03_02")]
    public partial class ReinfEvtServTomInfoServTomIdeEstabObraIdePrestServInfoProcRetAd
    {

        private byte tpProcRetAdicField;

        private string nrProcRetAdicField;

        private string codSuspAdicField;

        private string valorAdicField;

        /// <remarks/>
        public byte tpProcRetAdic
        {
            get
            {
                return this.tpProcRetAdicField;
            }
            set
            {
                this.tpProcRetAdicField = value;
            }
        }

        /// <remarks/>
        public string nrProcRetAdic
        {
            get
            {
                return this.nrProcRetAdicField;
            }
            set
            {
                this.nrProcRetAdicField = value;
            }
        }

        /// <remarks/>
        public string codSuspAdic
        {
            get
            {
                return this.codSuspAdicField;
            }
            set
            {
                this.codSuspAdicField = value;
            }
        }

        /// <remarks/>
        public string valorAdic
        {
            get
            {
                return this.valorAdicField;
            }
            set
            {
                this.valorAdicField = value;
            }
        }
    }

}
