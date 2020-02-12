using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rocket_Admin.Models
{
    public class EnumList
    {

        public enum EnableType
        {
            開 = 1,
            關 = 0
        }
        public enum BoolType
        {
            是 = 1,
            否 = 0
        }
        public enum GenderType
        {
            女,
            男
        }

        public enum presenceType
        {
            陪訓中 = 1,
            結訓 = 0,
            退訓=2
        }



    }
}