using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestEY
{
    public static class ModifiedText
    {
        public static string GetModifiedText(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length == 0)
            {
                return "";
            }

            text = string.Concat(text.Where(c => !char.IsWhiteSpace(c)));

            var textlength = text.Length;

            var squareRoot = Math.Sqrt(textlength);

            var row = textlength / squareRoot;
            row = ((row - Math.Truncate(row)) > 0.5) ? (int)row + 1 : (int)row;

            var column = squareRoot;
            column = ((column - Math.Truncate(column)) > 0.5) ? (int)column + 1 : (int)column;

            if ((row * column) >= squareRoot)
            {
                string[,] matrix = new string[(int)row, (int)column];

                int position = 0;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        if (textlength > position)
                        {
                            matrix[i, j] = text[position].ToString();
                        }
                        position++;
                    }
                }

                string result = "";
                for (int j = 0; j < column; j++)
                {
                    for (int i = 0; i < row; i++)
                    {
                        if (matrix[i, j] != null)
                        {
                            result += matrix[i, j];
                        }
                    }
                    result += " ";
                }

                return result;

            }

            return "";

        }
    }
}
