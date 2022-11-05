using System;

namespace UnitTestKata
{
    public class StringParseKata
    {
        private string delimiter;
        private string[] operands;
        private int sum;

        public StringParseKata()
        {
            sum = 0;
            delimiter = String.Empty;
            operands = new string[] { "1"};
        }

        public int Add(string input)
        {


            if (!input.Equals(String.Empty))
            {

                delimiter = parseDelimiter(input);
                operands = parseOperands(input);

                foreach (string op in operands)
                {

                    sum += System.Int32.Parse(op);
                }

            }

            return sum;
        }

        private string[] parseOperands(string input)
        {
            return input.Substring(input.IndexOf('\n') + 1).Split(delimiter);
        }


        private bool validFormat(string input)
        {
            bool isValid = false;

            if (input.StartsWith("//"))
            {
                if (input.Contains('\n'))
                {
                    int firstNewline = input.IndexOf('\n');
                    if (firstNewline > 2)
                    {
                        if (input.Length > firstNewline)
                        {
                            int lastNewLine = input.LastIndexOf('\n');
                            if (firstNewline == lastNewLine)
                            {
                                isValid = true;
                            }
                        }
                    }
                }
            }


            return isValid;
        }

        public string parseDelimiter(string input)
        {
            if (validFormat(input))
            {
                return input.Substring(2, input.IndexOf('\n') - 2);
            }
            else
            {
                throw new System.ArgumentException(string.Format("Invalid format. Valid format is //[delimeter]\\n[numbers]; actual value {0}", input), "input");
            }
        }
    }
}
