using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class expresie
    {
        public string s;
        public string numere = ".0123456789";
        public string elem = "()+-*/";
        public int nrele;
        public int[] stiv1 = new int[100];
        public char[] stiv2 = new char[100];
        public int sti1 = 0, sti2 = 0;
        public expresie(string a)
        {
            s = a;
            nrele = s.Length;
        }
        public void formstiv()
        {
            int p;
            sti1 = 0;
            for (int i = 0; i < nrele; i++)
                if (elem.IndexOf(s[i]) >= 0)
                {
                    stiv2[sti2] = s[i];
                    sti2++;
                }
                else
                {
                    stiv1[sti1] = 0;
                    while (i < nrele && numere.IndexOf(s[i]) > 0)
                    {
                        int p1;
                        p1 = (Int32)Char.GetNumericValue(s[i]);
                        stiv1[sti1] = stiv1[sti1]*10 + p1;
                        i++;
                    }
                    i--;
                    sti1++;
                }
        }

        public void redimstiv (int p1,int p2,int l1,int l2)
        {
            int v = 1;
            while(p2+v<sti2)
            {
                stiv2[p1 + v - 1] = stiv2[p2 + v-1];
                v++;
            }
            stiv2[p1 + v] = '\0';
            v = 0;
            while(l1+v<=sti1)
            {
                stiv1[l1 + v] = stiv1[l2 + v-1];
                v++;
            }
            stiv1[l1 + v ] = '\0';
        }

        public void rezpar(int i1,int j2)
        {
            int j1,j22,j3;
            j1 = i1 + 1;
            j22 = j2;
            j3 = j2 ;
            while (elem.IndexOf(stiv2[j1]) != 1 && j1 < sti1)
            {
                j1++;
            }
            for (int k = i1 + 1; k <j1; k++)
            {
                if (stiv2[k] == '*' || stiv2[k]=='/' )
                {
                    if(stiv2[k]=='*')
                        stiv1[j22] = stiv1[j22] * stiv1[j22+1];
                    else stiv1[j22] = stiv1[j22] / stiv1[j22 + 1];
                    stiv1[j22+1] = stiv1[j22];
                    j3++;
                }
                j22++;
            }
            j22 = j2;
            for (int k = i1 + 1; k <j1; k++)
            {
                if (stiv2[k] == '+' || stiv2[k] == '-')
                {
                    int p;
                    p = k ;
                    while (stiv2[p+1] == '*' || stiv2[p+1] == '/')
                        p++;
                    p = j22 + (p - k)+1;
                    if(stiv2[k] == '+')
                     stiv1[j22] = stiv1[j22] + stiv1[p];
                    else
                        stiv1[j22] = stiv1[j22] - stiv1[p];
                    stiv1[p] = stiv1[j22];
                    j3++;
                }
                j22++;
            }
            j3++;
            redimstiv(i1,j1,j2,j3);
        }

        public string rezultat ()
        {
            formstiv();
            int p=sti2-1,j2=0;
            while(p>=0)
            {
                if(elem.IndexOf(stiv2[p])==0)
                {
                    for (int c = 0; c < p; c++)
                        if (elem.IndexOf(stiv2[c]) > 1)
                            j2++;
                    rezpar(p, j2);
                }
                p--;
            }
            s = "";
            stiv2[sti2] = ')';
            rezpar(-1, 0);
            s = s+stiv1[0];
            return s;
        }

    }

}
