//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Team4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer_Table()
        {
            this.Booking_Table = new HashSet<Booking_Table>();
        }
    
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Pincode { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Contactno { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string CustomerType { get; set; }
        public int Customer_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking_Table> Booking_Table { get; set; }
    }
}
