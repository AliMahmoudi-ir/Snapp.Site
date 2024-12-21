using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kavenegar;

namespace Snapp.Core.Senders
{
    public static class SmsSender
    {
        public static void  VerifySend(string to, string template, string token)
        {
            var api = new KavenegarApi("6437526D7767467546696F455044366E77524A58704B6A6654385148694A53574D4D492F6855332F352B553D");

            var strTo = to;
            var strTemplate = template;
            var strToken = token;

            api.VerifyLookup(strTo, strTemplate, strToken);
        }
    }
}
