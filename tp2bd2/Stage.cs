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
    
    public partial class Stage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stage()
        {
            this.Candidatures = new HashSet<Candidature>();
        }
    
        public int stage_id { get; set; }
        public int compagnie_id { get; set; }
        public string poste { get; set; }
        public string lieux { get; set; }
        public System.DateTime date_debut { get; set; }
        public System.DateTime date_fin { get; set; }
        public double salaire { get; set; }
        public int heure_semaine { get; set; }
        public string description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Candidature> Candidatures { get; set; }
        public virtual Compagny Compagny { get; set; }
    }
}
