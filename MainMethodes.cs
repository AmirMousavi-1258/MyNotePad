using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyNotes
{
    internal class MainMethodes
    {
        public MainMethodes() { }
        public int findFirst(string key,string sentence,int BeginInd = 0)
        {
            char [] sentenceArray = sentence.ToCharArray();
            char[] keyArray = key.ToCharArray();
            int sizeKey = keyArray.Length;
            int sizeMain = sentenceArray.Length;
            int i = BeginInd;
            for (; i < sizeMain; i++)
            {
                int set = 0;
                if(sizeMain - i < sizeKey) { return -1; }
                for (int j = 0; j < sizeKey; j++)
                {
                    if (sentenceArray[i+j] != keyArray[j])
                    {
                        break;
                    }
                    set++;
                }
                if(set == sizeKey)
                {
                    return i;
                }
            }
            return -1;
        }
        public int findEnd(string key, string sentence,int beginInd = 0)
        {
            char[] sentenceArray = sentence.ToCharArray();
            char[] keyArray = key.ToCharArray();
            int sizeKey = keyArray.Length;
            int sizeMain = sentenceArray.Length;
            int i = beginInd;
            for (; i >= 0; i--)
            {
                int set = 0;
                if((i+1) < sizeKey) { return -1; }
                for (int j = 0; j < sizeKey; j++)
                {
                    if (sentenceArray[i - j] != keyArray[sizeKey - (j+1)])
                    {
                        break;
                    }
                    set++;
                }
                if (set == sizeKey)
                {
                    return ((i + 1) - sizeKey);
                }
            }
            return -1;
        }
        public Font getFont(string fileName)
        { 
            string FFamily, FSize, FStyle;
            StreamReader fontFile = File.OpenText(fileName);
            FFamily = fontFile.ReadLine();
            FSize = fontFile.ReadLine();
            FStyle = fontFile.ReadLine();
            float size = float.Parse(FSize);
            FontFamily ffamily = new FontFamily(FFamily);
            FontStyle fStyle = new FontStyle();
            switch (FStyle)
            {
                case "Regular":
                    fStyle = FontStyle.Regular;
                    break;
                case "Bold":
                    fStyle = FontStyle.Bold;
                    break;
                case "Italic":
                    fStyle = FontStyle.Italic;
                    break;
                case "Underline":
                    fStyle = FontStyle.Underline;
                    break;
                case "Strikeout":
                    fStyle = FontStyle.Strikeout;
                    break;
                default:
                    fStyle = FontStyle.Regular;
                    break;
            }
            Font font = new Font(ffamily,size,fStyle);
            fontFile.Close();
            return font;
        }

        public int getCol(string text,int ind)
        {
            char[] arr = text.ToCharArray();
            int colum = 1;
            for (int i = ind - 1; i >= 0; i--)
            {
                if (arr[i] == '\n')
                {
                    return colum;
                }
                colum++;
            }
            return colum;
        }
        public int[] findAll(string key,string text)
        {
            int[] arr = new int[0];
            int count = 0;
            int currentInd = findFirst("a",text);
            while (currentInd != -1)
            {
                count++;
                arr.Append(currentInd);
                currentInd = findFirst("a",text);
            }
            if (count>0)
            {
                return arr;
            }
            else
            {
                return Array.Empty<int>();
            }
            
        }
        public void replaceAll(string key, string replace, TextBox txtbx)
        {
            char[] sentenceArray = txtbx.Text.ToCharArray();
            char[] keyArray = key.ToCharArray();
            int sizeKey = keyArray.Length;
            int sizeMain = sentenceArray.Length;
            int i = 0;
            int count = 0;
            for (; i < sizeMain; i++)
            {
                int set = 0;
                if (sizeMain - i < sizeKey) { return; }
                for (int j = 0; j < sizeKey; j++)
                {
                    if (sentenceArray[i + j] != keyArray[j])
                    {
                        break;
                    }
                    set++;
                }
                if (set == sizeKey)
                {
                    txtbx.Select(i,sizeKey);
                    txtbx.SelectedText = replace;
                    set = 0;
                    i += replace.Length;
                    count++;
                }
            }
        }
    }
}
