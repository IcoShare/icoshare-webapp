using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Web;

namespace IcoShare.WebApp.Models
{
    public enum IcoShareStatus
    {
        ACTIVE,
        FUNDED,
        NOTFUNDED
    }

    public class IcoShareViewModel
    {
        [DisplayName("ICO Share Id")]
        public string IcoShareId { get; set; }

        [DisplayName("Status")]
        public IcoShareStatus Status { get; set; }

        [Required]
        [DisplayName("ScriptHash")]
        public string TokenScriptHash{ get; set; }

        [Required]
        [DisplayName("Token Name")]
        public string TokenScriptName{ get; set; }

        [Required]
        [DisplayName("Website")]
        public string TokenScriptWebsite{ get; set; }
        
        [Required]
        [DisplayName("Start")]
        [DataType(DataType.Date)]
        public DateTime StartTime { get; set; }

        [Required]
        [DisplayName("End")]
        [DataType(DataType.Date)]
        public DateTime EndTime { get; set; }

        [Required]
        [DisplayName("Bundle")]
        public int ContributionBundle { get; set; }

        [Required]
        [DisplayName("Minumum")]
        public int MinContribution { get; set; }

        [Required]
        [DisplayName("Maximum")]
        public int MaxContribution { get; set; }

        [DisplayName("Current")]
        public int CurrentContribution { get; set; }
    }
}