//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionStock1
{
    using System;
    using System.Collections.Generic;
    
    public partial class details_commande
    {
        public int Id_commande { get; set; }
        public int Id_Produit { get; set; }
        public int Quantite { get; set; }
    
        public virtual commande commande { get; set; }
        public virtual produit produit { get; set; }
    }
}
