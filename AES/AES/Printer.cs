using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AES
{
    public static class Printer
    {

        public static String PrintByteArray(Byte[,] arr, int numCols)
        {
            //return numCols.ToString();
            String outStr = "";
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    outStr += "   " + String.Format("{0:X2}", arr[col,row]);
                }
                outStr += "\n\n";
            }

            return outStr;
        }

        public static String PrintByteArray(Byte[] arr, int numCols)
        {
            //return numCols.ToString();
            String outStr = "";
            for (int col = 0; col < numCols; col++)
            {
                outStr += "   " + String.Format("{0:X2}", arr[col]);
            }

            return outStr;
        }

        public static String PrintByteArray(Byte[][] arr, int numCols)
        {
            //return numCols.ToString();
            String outStr = "";
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < numCols; col++)
                {
                    outStr += "  " + String.Format("{0:X2}", arr[col][row]);
                }
                outStr += "\n\n";
            }

            return outStr;
        }

        public static String PrintExpandedKeyArray(Byte[][] arr, int numRows)
        {
            //return numCols.ToString();
            String outStr = "";
            for (int row = 0; row < numRows; row++)
            {
                if ((row % 4) == 0)
                    outStr += "\n";

                for (int col = 0; col < 4; col++)
                {
                    outStr += String.Format("{0:x2}", arr[row][col]);
                }
                outStr += "\n";                
            }

            return outStr;
        }

    }
}
