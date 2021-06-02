using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyrsach
{
    class Sportsmen
    {
        public string Name;
        public int[] chas1;
        public int[] min1;
        public int[] sek1;
        public int[] chas2;
        public int[] min2;
        public int[] sek2;
        public int[] chas3;
        public int[] min3;
        public int[] sek3;
        public int[] chas4;
        public int[] min4;
        public int[] sek4;
        public int[] summabrc;
        public int[] summabrm;
        public int[] summabrs;
        public int[] summabrych;
        public int[,] pesultsatapov;
        public int[] resutssek;
        public int[,] vrych;
        public int[] minimum;
        public int[] mesta;
        public int Zummamest;
        public int Maxsimbr;
        public void Calc1()
        {
            for (int i = 0; i < sek1.Length; i++)
                summabrs[0] += sek1[i];
            int s = summabrs[0] % 60;
            summabrm[0] = summabrs[0] / 60;
            summabrs[0] = s;
            for (int i = 0; i < min1.Length; i++)
                summabrm[0] += min1[i];
            int m = summabrm[0] % 60;
            summabrc[0] = summabrm[0] / 60;
            summabrm[0] = m;
            for (int i = 0; i < chas1.Length; i++)
                summabrc[0] += chas1[i];
        }
        public void Calc2()
        {
            for (int i = 0; i < sek2.Length; i++)
                summabrs[1] += sek2[i];
            int s = summabrs[1] % 60;
            summabrm[1] = summabrs[1] / 60;
            summabrs[1] = s;
            for (int i = 0; i < min2.Length; i++)
                summabrm[1] += min2[i];
            int m = summabrm[1] % 60;
            summabrc[1] = summabrm[1] / 60;
            summabrm[1] = m;
            for (int i = 0; i < chas2.Length; i++)
                summabrc[1] += chas2[i];
        }
        public void Calc3()
        {
            for (int i = 0; i < sek3.Length; i++)
                summabrs[2] += sek3[i];
            int s = summabrs[2] % 60;
            summabrm[2] = summabrs[2] / 60;
            summabrs[2] = s;
            for (int i = 0; i < min3.Length; i++)
                summabrm[2] += min3[i];
            int m = summabrm[2] % 60;
            summabrc[2] = summabrm[2] / 60;
            summabrm[2] = m;
            for (int i = 0; i < chas3.Length; i++)
                summabrc[2] += chas3[i];
        }
        public void Calc4()
        {
            for (int i = 0; i < sek4.Length; i++)
                summabrs[3] += sek4[i];
            int s = summabrs[3] % 60;
            summabrm[3] = summabrs[3] / 60;
            summabrs[3] = s;
            for (int i = 0; i < min4.Length; i++)
                summabrm[3] += min4[i];
            int m = summabrm[3] % 60;
            summabrc[3] = summabrm[3] / 60;
            summabrm[3] = m;
            for (int i = 0; i < chas4.Length; i++)
                summabrc[3] += chas4[i];
        }
        public void Calc5()
        {
            for (int j = 0; j < Program.n; j++)
            {
                pesultsatapov[j, 2] = sek1[j] + sek2[j] + sek3[j] + sek4[j];
                int s = pesultsatapov[j, 2] % 60;
                pesultsatapov[j, 1] = pesultsatapov[j, 2] / 60;
                pesultsatapov[j, 2] = s;
                pesultsatapov[j, 1] = pesultsatapov[j, 1] + min1[j] + min2[j] + min3[j] + min4[j];
                int m = pesultsatapov[j, 1] % 60;
                pesultsatapov[j, 0] = pesultsatapov[j, 1] / 60;
                pesultsatapov[j, 1] = m;
                pesultsatapov[j, 0] = pesultsatapov[j, 0] + chas1[j] + chas2[j] + chas3[j] + chas4[j];
            }
        }
        public void Calc6()
        {
            for (int j = 0; j < Program.n; j++)
            {
                resutssek[j] = pesultsatapov[j, 2] + pesultsatapov[j, 1] * 60 + pesultsatapov[j, 0] * 3600;
            }
        }
        public void Calc7()
        {
            for (int i = 0; i < Program.n; i++)
            {
                vrych[0, i] = chas1[i] * 3600 + min1[i] * 60 + sek1[i];
                vrych[1, i] = chas2[i] * 3600 + min2[i] * 60 + sek2[i];
                vrych[2, i] = chas3[i] * 3600 + min3[i] * 60 + sek3[i];
                vrych[3, i] = chas4[i] * 3600 + min4[i] * 60 + sek4[i];
            }
            int min = int.MaxValue;
            for (int i = 0; i < Program.n; i++)
                for (int j = 0; j < 4; j++)
                    if (min > vrych[j, i])
                    {
                        min = vrych[j, i];
                        minimum[i] = min;
                    }
        }

        public void Calc8()
        { int Swp;
            for (int k = 0; k < Program.n*2-1; k=k+2)
                for (int i = 0; i < Program.s-1; i++)
                {
                    if (Program.znachen[i, k+1] > Program.znachen[i + 1, k+1])
                    {
                        Swp = Program.znachen[i + 1, k+1];
                        Program.znachen[i + 1, k+1] = Program.znachen[i, k+1];
                        Program.znachen[i, k+1] = Swp;
                        Swp = Program.znachen[i + 1, k];
                        Program.znachen[i + 1, k] = Program.znachen[i, k];
                        Program.znachen[i, k] = Swp;
                    }
                    else
                    {
                        if (Program.znachen[i, k + 1] == Program.znachen[i + 1, k + 1])
                            if (Program.stran[i].minimum[i] > Program.stran[i + 1].minimum[i])
                        {
                            Swp = Program.znachen[i + 1, k + 1];
                            Program.znachen[i + 1, k + 1] = Program.znachen[i, k + 1];
                            Program.znachen[i, k + 1] = Swp;
                            Swp = Program.znachen[i + 1, k];
                            Program.znachen[i + 1, k] = Program.znachen[i, k];
                            Program.znachen[i, k] = Swp;
                        }
                    }
                }
        }
        public void Calc9()
        {
            for (int i = 0; i < Program.n; i++)
                Zummamest = Zummamest +( mesta[i]+1); 
        }
        public void Calc10()
        {
            int Swp;
            for (int i=0;i< Program.s-1; i++)
            {
                if (Program.mestasort[i,1] > Program.mestasort[i + 1,1])
                {
                    Swp = Program.mestasort[i + 1, 1];
                    Program.mestasort[i + 1,1] = Program.mestasort[i, 1];
                    Program.mestasort[i, 1] = Swp;
                    Swp = Program.mestasort[i + 1, 0];
                    Program.mestasort[i + 1, 0] = Program.mestasort[i, 0];
                    Program.mestasort[i, 0] = Swp;
                }
                else
                {
                    if (Program.mestasort[i,1] == Program.mestasort[i + 1, 1])
                        if (Program.stran[i].Maxsimbr > Program.stran[i + 1].Maxsimbr)
                        {
                            Swp = Program.mestasort[i + 1, 1];
                            Program.mestasort[i + 1, 1] = Program.mestasort[i, 1];
                            Program.mestasort[i, 1] = Swp;
                            Swp = Program.mestasort[i + 1, 0];
                            Program.mestasort[i + 1, 0] = Program.mestasort[i, 0];
                            Program.mestasort[i, 0] = Swp;
                        }
                }


            }
         }   
        public void Calc11()
            {
                for (int i = 0; i < Program.n; i++)
                    summabrych[i] = summabrc[i] * 3600 + summabrm[i] * 60 + summabrs[i];
                int max = int.MinValue;
                for (int i = 0; i < Program.n; i++)
                    for (int j = 0; j < 4; j++)
                        if (max > summabrych[i])
                        {
                            max = summabrych[i];
                            Maxsimbr = max;
                        }
            }
    }
}
