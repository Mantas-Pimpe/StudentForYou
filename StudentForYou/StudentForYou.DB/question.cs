//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentForYou.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class question
    {
        public int qns_id { get; set; }
        public string qns_name { get; set; }
        public string qns_text { get; set; }
        public System.DateTime qns_creation_date { get; set; }
        public Nullable<int> qns_user_id { get; set; }
        public int qns_likes { get; set; }
        public int qns_views { get; set; }
        public int qns_comments { get; set; }
    }
}
