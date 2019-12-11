using System;
namespace StudentForYou.DB
{
    public partial class PersonalChat
    {
        public int chp_id { get; set; }
        public int chp_send_user_id { get; set; }
        public int chp_receive_user_id { get; set; }
        public string chp_text { get; set; }
        public DateTime chp_creation_date { get; set; }
    }
}
