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
    
    public partial class Candidature
    {
        public int candidature_id { get; set; }
        public int stage_id { get; set; }
        public int da { get; set; }
        public int cv_id { get; set; }
        public bool est_accepter { get; set; }
    
        public virtual Cv Cv { get; set; }
        public virtual Etudiant Etudiant { get; set; }
        public virtual Stage Stage { get; set; }
    }
}
