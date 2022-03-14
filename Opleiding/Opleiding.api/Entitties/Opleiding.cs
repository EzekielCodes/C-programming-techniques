﻿using opleiding.api.Entitties;
using System.ComponentModel.DataAnnotations;

namespace Opleiding.api.Entitties
{

    public class Opleiding
    {
        public Guid OpleidingId { get; set; }
        [Required]
        public virtual Docent OpleidingshoofdID { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(45, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public virtual ICollection<OpoOpleiding> OpoOpleiding { get; set; }
    }
}



