//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Multifenetrage.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emprunt
    {
        public int Id { get; set; }
        public Nullable<int> IdUtilisateur { get; set; }
        public Nullable<int> IdFilm { get; set; }
        public Nullable<System.DateTime> DateEmprunt { get; set; }
        public Nullable<System.DateTime> DateRetour { get; set; }
        public string Statut { get; set; }
    
        public virtual Film Film { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
    }
}