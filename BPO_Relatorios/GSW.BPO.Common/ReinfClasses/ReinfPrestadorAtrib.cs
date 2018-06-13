using System.Xml.Serialization;

namespace GSW.BPO.Common.ReinfClasses
{
    

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtPrestadorServicos/v1_03_02")]
    public partial class ReinfEvtServPrest
    {

        private ReinfEvtServPrestIdeEvento ideEventoField;

        private ReinfEvtServPrestIdeContri ideContriField;

        private ReinfEvtServPrestInfoServPrest infoServPrestField;

        private string idField;

        /// <remarks/>
        public ReinfEvtServPrestIdeEvento ideEvento
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
        public ReinfEvtServPrestIdeContri ideContri
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
        public ReinfEvtServPrestInfoServPrest infoServPrest
        {
            get
            {
                return this.infoServPrestField;
            }
            set
            {
                this.infoServPrestField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtPrestadorServicos/v1_03_02")]
    public partial class ReinfEvtServPrestIdeEvento
    {

        private byte indRetifField;

        private string nrReciboField;

        private string perApurField;

        private uint tpAmbField;

        private uint procEmiField;

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
        public uint procEmi
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtPrestadorServicos/v1_03_02")]
    public partial class ReinfEvtServPrestIdeContri
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtPrestadorServicos/v1_03_02")]
    public partial class ReinfEvtServPrestInfoServPrest
    {

        private ReinfEvtServPrestInfoServPrestIdeEstabPrest ideEstabPrestField;

        /// <remarks/>
        public ReinfEvtServPrestInfoServPrestIdeEstabPrest ideEstabPrest
        {
            get
            {
                return this.ideEstabPrestField;
            }
            set
            {
                this.ideEstabPrestField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtPrestadorServicos/v1_03_02")]
    public partial class ReinfEvtServPrestInfoServPrestIdeEstabPrest
    {

        private uint tpInscEstabPrestField;

        private string nrInscEstabPrestField;

        private ReinfEvtServPrestInfoServPrestIdeEstabPrestIdeTomador ideTomadorField;

        /// <remarks/>
        public uint tpInscEstabPrest
        {
            get
            {
                return this.tpInscEstabPrestField;
            }
            set
            {
                this.tpInscEstabPrestField = value;
            }
        }

        /// <remarks/>
        public string nrInscEstabPrest
        {
            get
            {
                return this.nrInscEstabPrestField;
            }
            set
            {
                this.nrInscEstabPrestField = value;
            }
        }

        /// <remarks/>
        public ReinfEvtServPrestInfoServPrestIdeEstabPrestIdeTomador ideTomador
        {
            get
            {
                return this.ideTomadorField;
            }
            set
            {
                this.ideTomadorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtPrestadorServicos/v1_03_02")]
    public partial class ReinfEvtServPrestInfoServPrestIdeEstabPrestIdeTomador
    {

        private byte tpInscTomadorField;

        private string nrInscTomadorField;

        private byte indObraField;

        private string vlrTotalBrutoField;

        private string vlrTotalBaseRetField;

        private string vlrTotalRetPrincField;

        private string vlrTotalRetAdicField;

        private string vlrTotalNRetPrincField;

        private string vlrTotalNRetAdicField;

        private ReinfEvtServPrestInfoServPrestIdeEstabPrestIdeTomadorNfs[] nfsField;

        private ReinfEvtServPrestInfoServPrestIdeEstabPrestIdeTomadorInfoProcRetPr[] infoProcRetPrField;

        private ReinfEvtServPrestInfoServPrestIdeEstabPrestIdeTomadorInfoProcRetAd[] infoProcRetAdField;

        /// <remarks/>
        public byte tpInscTomador
        {
            get
            {
                return this.tpInscTomadorField;
            }
            set
            {
                this.tpInscTomadorField = value;
            }
        }

        /// <remarks/>
        public string nrInscTomador
        {
            get
            {
                return this.nrInscTomadorField;
            }
            set
            {
                this.nrInscTomadorField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("nfs")]
        public ReinfEvtServPrestInfoServPrestIdeEstabPrestIdeTomadorNfs[] nfs
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
        public ReinfEvtServPrestInfoServPrestIdeEstabPrestIdeTomadorInfoProcRetPr[] infoProcRetPr
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
        public ReinfEvtServPrestInfoServPrestIdeEstabPrestIdeTomadorInfoProcRetAd[] infoProcRetAd
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtPrestadorServicos/v1_03_02")]
    public partial class ReinfEvtServPrestInfoServPrestIdeEstabPrestIdeTomadorNfs
    {

        private string serieField;

        private string numDoctoField;

        private System.DateTime dtEmissaoNFField;

        private string vlrBrutoField;

        private string obsField;

        private ReinfEvtServPrestInfoServPrestIdeEstabPrestIdeTomadorNfsInfoTpServ[] infoTpServField;

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
        public ReinfEvtServPrestInfoServPrestIdeEstabPrestIdeTomadorNfsInfoTpServ[] infoTpServ
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtPrestadorServicos/v1_03_02")]
    public partial class ReinfEvtServPrestInfoServPrestIdeEstabPrestIdeTomadorNfsInfoTpServ
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtPrestadorServicos/v1_03_02")]
    public partial class ReinfEvtServPrestInfoServPrestIdeEstabPrestIdeTomadorInfoProcRetPr
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
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtPrestadorServicos/v1_03_02")]
    public partial class ReinfEvtServPrestInfoServPrestIdeEstabPrestIdeTomadorInfoProcRetAd
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
