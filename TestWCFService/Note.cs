//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWCFService
{
    using System;
    using System.Collections.Generic;
    
    public partial class Note
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public System.DateTime Creation { get; set; }
        public System.DateTime Modification { get; set; }
        public string Texte { get; set; }
        public int UserId { get; set; }
    }
}