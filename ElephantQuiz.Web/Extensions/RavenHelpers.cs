using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElephantQuiz.Web.Extensions
{
    public static class RavenHelpers
    {
        public static int ToIntId(this string id)
        {
            return int.Parse(id.Substring(id.LastIndexOf('/') + 1));
        }
    }
}