using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Web;

namespace IcoShare.WebApp.Models
{
    public class IcoShare
    {
        public string IcoShareId { get; set; }
        public string TokenScriptHash{ get; set; }
        public BigInteger StartTime { get; set; }
        public BigInteger EndTime { get; set; }
        public BigInteger ContributionBundle { get; set; }
        public BigInteger MinContribution { get; set; }
        public BigInteger MaxContribution { get; set; }
        public BigInteger CurrentContribution { get; set; }

        public static IcoShare NewIcoShare(
            string TokenScriptHash, 
            BigInteger StartTime, BigInteger EndTime, 
            BigInteger ContributionBundle, BigInteger MinContribution, BigInteger MaxContribution, BigInteger CurrentContribution)
        {
            return new IcoShare
            {
                ContributionBundle = ContributionBundle,
                CurrentContribution = CurrentContribution,
                EndTime = EndTime,
                IcoShareId = Guid.NewGuid().ToString(),
                MaxContribution = MaxContribution,
                MinContribution = MinContribution,
                StartTime = StartTime,
                TokenScriptHash = TokenScriptHash
            };
        }
    }
}