using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using iMedicalMVC.Enum;
using System.Web.Mvc;

namespace iMedicalMVC.Infrastructure
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class AuthorizeEnumAttribute : AuthorizeAttribute
    {
        public AuthorizeEnumAttribute(params object[] roles)
        {
            //if (roles.Any(r => r.GetType().BaseType != typeof(UserType)))
            //    throw new ArgumentException("roles");

            this.Roles = string.Join(",", roles.Select(r => UserType.GetName(r.GetType(), r)));
        }
    }
}