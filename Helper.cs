using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40kListApp
{
    public class Helper
    {
        public List<string> parseDelimLine(string line, char delim)
        {
            List<string> result = new List<string>();

            string[] tokens = line.Split(delim);
            foreach (string token in tokens)
            {
                token.Trim();
                result.Add(token);
            }

            return result;
        }
    }
}
