//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WatermentsWebSCADA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class equipment
    {
        public equipment()
        {
            this.alarms = new HashSet<alarms>();
            this.measurement = new HashSet<measurement>();
        }
    
        public string Tag { get; set; }
        public string SIUnits { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> LastCalibrated { get; set; }
        public string Facilities_Name { get; set; }
    
        public virtual ICollection<alarms> alarms { get; set; }
        public virtual ICollection<measurement> measurement { get; set; }
        public virtual facilities facilities { get; set; }
    }
}
