using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AES
{
    public class InputParser
    {
        public InputParser()
        {
            
        }

        public Byte[,] ParseInput(String inStr)
        {
            Byte[,] state = new Byte[4, 4];

            for (int col = 0; col < 4; col++)
            {
                for (int row = 0; row < 4; row++)
                {
                    state[col,row] = InterpretChars(inStr[(col * 2) * 4 + (row * 2)],inStr[(col * 2) * 4 + (row * 2) + 1]);
                }
            }

            return state;
        }

        public Byte[] ParseKey(String inStr)
        {
            int nK = inStr.Length / 2 / 4;
            Byte[] key = new Byte[nK * 4];

            for (int col = 0; col < nK * 4; col++)
            {
                    key[col] = InterpretChars(inStr[(col * 2)], inStr[(col * 2) + 1]);
            }

            return key;
        }

        public Byte InterpretChars(char inChar, char inChar2){
            int val = (int)inChar;
            int val2 = (int)inChar2;

            Byte b1 = (Byte)(val - (val < 58 ? 48 : (val < 97 ? 55 : 87)));
            Byte b2 = (Byte)(val2 - (val2 < 58 ? 48 : (val2 < 97 ? 55 : 87)));

            b1 = (Byte)((Byte)(b1 << 4) | b2);

            return b1;

        }


    }
}
