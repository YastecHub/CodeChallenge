using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            //I Handled edge case where zigzag pattern is not applicable based on user input
            if (numRows == 1 || numRows >= s.Length)
            {
                return s;
            }

            //I created a list of StringBuilder for each row
            List<StringBuilder> rows = new List<StringBuilder>();
            for (int i = 0; i < Math.Min(numRows, s.Length); i++)
            {
                rows.Add(new StringBuilder());
            }
            int currentRow = 0;
            bool goingDown = false;

            //I moved in through each Character in the String
            foreach (char c in s)
            {
                //Then Add each character to the current row
                rows[currentRow].Append(c);

                //Checked if the particular row is the top or bottom row, then reverse the direction of the row to move in a ZigZag manner
                if (currentRow == 0 || currentRow == numRows - 1)
                {
                    goingDown = !goingDown;
                }
                //move to the next row based on the current direction
                currentRow += goingDown ? 1 : -1;
            }

            //Then Combine all the rows to merge the stings
            StringBuilder result = new StringBuilder();
            foreach (var row in rows)
            {
                result.Append(row);
            }
             return result.ToString();
        }
    }
}