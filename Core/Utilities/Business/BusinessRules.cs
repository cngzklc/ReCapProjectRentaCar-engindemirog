using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] rules)
        {
            int x=0;
            for ( int i = 0; i < rules.Length; i++)
            {
                x = i;
                if (rules[i].Success)
                {
                    return rules[i];
                    i++;
                }
            }

            return rules[x];
        }
    }
}
