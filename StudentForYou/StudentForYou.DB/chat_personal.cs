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
    
    public partial class chat_personal
    {
        public int chp_id { get; set; }
        public int chp_send_user_id { get; set; }
        public int chp_receive_user_id { get; set; }
        public string chp_text { get; set; }
        public System.DateTime chp_creation_date { get; set; }
    }
}
