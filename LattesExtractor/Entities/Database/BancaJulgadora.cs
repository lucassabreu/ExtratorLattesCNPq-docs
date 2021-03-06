//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LattesExtractor.Entities.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class BancaJulgadora
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BancaJulgadora()
        {
            this.BaseDeConsulta = new HashSet<BaseDeConsulta>();
            this.AreaConhecimento = new HashSet<AreaConhecimento>();
            this.PalavraChave = new HashSet<PalavraChave>();
            this.Professor = new HashSet<Professor>();
        }
    
        public int BancaJulgadoraId { get; set; }
        public string TipoBancaJulgadora { get; set; }
        public string NaturezaBancaJulgadora { get; set; }
        public string TituloBancaJulgadora { get; set; }
        public decimal AnoBancaJulgadora { get; set; }
        public string PaisBancaJulgadora { get; set; }
        public Nullable<int> IdiomaId { get; set; }
        public string HomePageBancaJulgadora { get; set; }
        public string DOIBancaJulgadora { get; set; }
        public string TituloEmInglesBancaJulgadora { get; set; }
        public Nullable<int> InstituicaoEmpresaId { get; set; }
        public string InformacoesAdicionaisBancaJulgadora { get; set; }
        public string InformacoesAdicionaisEmInglesBancaJulgadora { get; set; }
    
        public virtual Idioma Idioma { get; set; }
        public virtual InstituicaoEmpresa InstituicaoEmpresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaseDeConsulta> BaseDeConsulta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AreaConhecimento> AreaConhecimento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PalavraChave> PalavraChave { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Professor> Professor { get; set; }
    }
}
