using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsUnitTests
{
    public class NumberPhone
    {
        public bool GetNumber(string phone, out long? pResult)
        {
            bool result = false;
            pResult = null;

            if (!String.IsNullOrEmpty(phone))
            {
                var arrayCh = phone.Where(x => char.IsDigit(x)).ToArray();

                if(arrayCh.Length == 11)
                {
                    if (arrayCh[0] == '7' || arrayCh[0] == '8')
                    {
                        long.TryParse(arrayCh, out long numberPhone);
                        pResult = numberPhone;
                        result = true;
                    }
                }
            }

            return result;
        }
    }
}
