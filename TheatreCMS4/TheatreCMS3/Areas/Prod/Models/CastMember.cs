using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheatreCMS3.Areas.Prod.Models
{
    public class CastMember
    {
        [Key]
        public int CastMemberId { get; set; }
        public string Name { get; set; }
        public int? YearJoined { get; set; }
        public string ProductionTitle { get; set; }
        public PositioinEnum MainRole { get; set; }
        public string Bio { get; set; }
        public Byte[] Photo { get; set; }
        public bool CurrentMember { get; set; }
        public string Character { get; set; }
        public int? CastYearLeft { get; set; }
        public int? DebutYear { get; set; }

    }

    public enum PositioinEnum
    {
        Actor, Director, Technician, StageManager, Other
    }
}