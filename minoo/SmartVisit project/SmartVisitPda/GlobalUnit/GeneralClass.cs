using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace GlobalUnit
{
    public class GeneralClass
    {
        public enum PrgMod { MainForm, Normal, NewRecord, EditRecord, FormLoading, BindingData };

        public static PrgMod m_PrgMod;        

        public static bool IsNumeric(string InputString)
        {
            bool bRes = true;

            if (InputString.Length > 0)
            {
                for (int i = 0; bRes && i < InputString.Length; i++)
                {
                    if (InputString[i] != '+' && InputString[i] != '-' && InputString[i] != '.' && !char.IsNumber(InputString, i))
                        bRes = false;
                }
            }
            else
                bRes = false;

            return (bRes);
        }
    }
}
