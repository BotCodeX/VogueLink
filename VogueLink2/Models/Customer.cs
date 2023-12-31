//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VogueLink2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Carts = new HashSet<Cart>();
            this.Favourates = new HashSet<Favourate>();
            this.Orders = new HashSet<Order>();
            this.Reviews = new HashSet<Review>();
        }
    
        public int Customer_Id { get; set; }
        public string Customer_FName { get; set; }
        public string Customer_LName { get; set; }
        public string Customer_Email { get; set; }
        public string Customer_Pass { get; set; }
        public string Customer_Phone { get; set; }
        public string Customer_Gender { get; set; }
        public string Customer_District { get; set; }
        public string Customer_City { get; set; }
        public string Customer_Area { get; set; }
        public string Customer_Ship { get; set; }
        public string Customer_DP { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Favourate> Favourates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
