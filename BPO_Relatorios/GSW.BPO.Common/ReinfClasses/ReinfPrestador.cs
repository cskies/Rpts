using System.Xml.Serialization;

namespace GSW.BPO.Common.ReinfClasses.Prestador
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.reinf.esocial.gov.br/schemas/evtPrestadorServicos/v1_03_02")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.reinf.esocial.gov.br/schemas/evtPrestadorServicos/v1_03_02", IsNullable = false)]
    public partial class Reinf
    {

        private ReinfEvtServPrest evtServPrestField;

        private SignatureType signatureField;

        /// <remarks/>
        public ReinfEvtServPrest evtServPrest
        {
            get
            {
                return this.evtServPrestField;
            }
            set
            {
                this.evtServPrestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
    }

    
}
