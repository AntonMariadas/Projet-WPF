﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MaVideothequeEntities : DbContext
    {
        public MaVideothequeEntities()
            : base("name=MaVideothequeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Emprunt> Emprunt { get; set; }
        public virtual DbSet<Film> Film { get; set; }
        public virtual DbSet<FilmGenre> FilmGenre { get; set; }
        public virtual DbSet<FilmPays> FilmPays { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<PAYS> PAYS { get; set; }
        public virtual DbSet<Trace> Trace { get; set; }
        public virtual DbSet<Utilisateur> Utilisateur { get; set; }
    }
}
