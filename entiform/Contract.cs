using System;
using System.Collections.Generic;

namespace entiform
{
    public partial class Contract
    {
        public int Id { get; set; }
        public int? Person { get; set; }
        public int? Car { get; set; }
        public DateTime ConDate { get; set; }

        public virtual Car CarNavigation { get; set; }
        public virtual Person PersonNavigation { get; set; }
    }
}
