using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATEA_Test.Infrastructure
{
    public static class StringExtensions
    {
        public static string AppendString(this string left, string right)
        {
            if (left == null || right == null)
            { 
                throw new ArgumentNullException("Parameters cannot be null");
            }
            
            return left + right;
        }
    }
}
