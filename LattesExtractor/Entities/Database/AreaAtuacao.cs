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
    
    public partial class AreaAtuacao
    {
        public int ProfessorId { get; set; }
        public int SequenciaAreaAtuacao { get; set; }
        public string GrandeAreaAtuacao { get; set; }
        public string NomeAreaAtuacao { get; set; }
        public string SubAreaAtuacao { get; set; }
        public string Especialidade { get; set; }
        public string TermoCompleto { get; set; }
    
        public virtual Professor Professor { get; set; }
    }
}
