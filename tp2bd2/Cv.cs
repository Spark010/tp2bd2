//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tp2bd2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cv
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cv()
        {
            this.Candidatures = new HashSet<Candidature>();
        }
    
        public int cv_id { get; set; }
        public int da { get; set; }
        public byte[] CV1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Candidature> Candidatures { get; set; }
        public virtual Etudiant Etudiant { get; set; }
    }
}
