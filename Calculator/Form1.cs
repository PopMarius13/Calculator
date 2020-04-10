using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string nr = "0";
        public string elem = "()+-*/";
        public string numere = "0123456789";
        public int nre, k;
        public int pars = 0, pard = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void a0_Click(object sender, EventArgs e)
        {
            Afis.Text = Afis.Text + "0";
        }

        private void a1_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            nre = nr.Length;
            if (nre>=1 && nr[nre - 1] == ')')
                Afis.Text = Afis.Text + "*1";
            else
            if (nre > 2)
            {
                k = elem.IndexOf(nr[nre - 2]);
                if (nr[nre - 1] == '0' && k >= 0)
                    Afis.Text = Afis.Text + ".1";
                else
                    Afis.Text = Afis.Text + "1";
            }
            else if (nre == 1 && nr[nre - 1] == '0')
                Afis.Text = Afis.Text + ".1";
            else
                Afis.Text = Afis.Text + "1";
        }

        private void a2_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            nre = nr.Length;
            if (nre >= 1 && nr[nre - 1] == ')')
                Afis.Text = Afis.Text + "*2";
            else
            if (nre > 2)
            {
                k = elem.IndexOf(nr[nre - 2]);
                if (nr[nre - 1] == '0' && k >= 0)
                    Afis.Text = Afis.Text + ".2";
                else
                    Afis.Text = Afis.Text + "2";
            }
            else if (nre == 1 && nr[nre - 1] == '0')
                Afis.Text = Afis.Text + ".2";
            else
                Afis.Text = Afis.Text + "2";
        }

        private void a3_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            nre = nr.Length;
            if (nre >= 1 && nr[nre - 1] == ')')
                Afis.Text = Afis.Text + "*3";
            else
            if (nre > 2)
            {
                k = elem.IndexOf(nr[nre - 2]);
                if (nr[nre - 1] == '0' && k >= 0)
                    Afis.Text = Afis.Text + ".3";
                else
                    Afis.Text = Afis.Text + "3";
            }
            else if (nre == 1 && nr[nre - 1] == '0')
                Afis.Text = Afis.Text + ".3";
            else
                Afis.Text = Afis.Text + "3";
        }

        private void a4_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            nre = nr.Length;
            if (nre >= 1 && nr[nre - 1] == ')')
                Afis.Text = Afis.Text + "*4";
            else
            if (nre > 2)
            {
                k = elem.IndexOf(nr[nre - 2]);
                if (nr[nre - 1] == '0' && k >= 0)
                    Afis.Text = Afis.Text + ".4";
                else
                    Afis.Text = Afis.Text + "4";
            }
            else if (nre == 1 && nr[nre - 1] == '0')
                Afis.Text = Afis.Text + ".4";
            else
                Afis.Text = Afis.Text + "4";
        }

        private void a5_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            nre = nr.Length;
            if (nre >= 1 && nr[nre - 1] == ')')
                Afis.Text = Afis.Text + "*5";
            else
            if (nre > 2)
            {
                k = elem.IndexOf(nr[nre - 2]);
                if (nr[nre - 1] == '0' && k >= 0)
                    Afis.Text = Afis.Text + ".5";
                else
                    Afis.Text = Afis.Text + "5";
            }
            else if (nre == 1 && nr[nre - 1] == '0')
                Afis.Text = Afis.Text + ".5";
            else
                Afis.Text = Afis.Text + "5";
        }

        private void a6_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            nre = nr.Length;
            if (nre >= 1 && nr[nre - 1] == ')')
                Afis.Text = Afis.Text + "*6";
            else
            if (nre > 2)
            {
                k = elem.IndexOf(nr[nre - 2]);
                if (nr[nre - 1] == '0' && k >= 0)
                    Afis.Text = Afis.Text + ".6";
                else
                    Afis.Text = Afis.Text + "6";
            }
            else if (nre == 1 && nr[nre - 1] == '0')
                Afis.Text = Afis.Text + ".6";
            else
                Afis.Text = Afis.Text + "6";
        }

        private void a7_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            nre = nr.Length;
            if (nre >= 1 && nr[nre - 1] == ')')
                Afis.Text = Afis.Text + "*7";
            else
            if (nre > 2)
            {
                k = elem.IndexOf(nr[nre - 2]);
                if (nr[nre - 1] == '0' && k >= 0)
                    Afis.Text = Afis.Text + ".7";
                else
                    Afis.Text = Afis.Text + "7";
            }
            else if (nre == 1 && nr[nre - 1] == '0')
                Afis.Text = Afis.Text + ".7";
            else
                Afis.Text = Afis.Text + "7";
        }

        private void a8_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            nre = nr.Length;
            if (nre >= 1 && nr[nre - 1] == ')')
                Afis.Text = Afis.Text + "*8";
            else
            if (nre > 2)
            {
                k = elem.IndexOf(nr[nre - 2]);
                if (nr[nre - 1] == '0' && k >= 0)
                    Afis.Text = Afis.Text + ".8";
                else
                    Afis.Text = Afis.Text + "8";
            }
            else if (nre == 1 && nr[nre - 1] == '0')
                Afis.Text = Afis.Text + ".8";
            else
                Afis.Text = Afis.Text + "8";
        }

        private void a9_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            nre = nr.Length;
            if (nre >= 1 && nr[nre - 1] == ')')
                Afis.Text = Afis.Text + "*9";
            else
            if (nre > 2)
            {
                k = elem.IndexOf(nr[nre - 2]);
                if (nr[nre - 1] == '0' && k >= 0)
                    Afis.Text = Afis.Text + ".9";
                else
                    Afis.Text = Afis.Text + "9";
            }
            else if (nre == 1 && nr[nre - 1] == '0')
                Afis.Text = Afis.Text + ".9";
            else
                Afis.Text = Afis.Text + "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            nre = nr.Length;
            if (nre > 0)
            {
                int k;
                k = elem.IndexOf(nr[nre - 1]);
                if (k < 0)
                    Afis.Text = Afis.Text + "+";
                else if (k == 1)
                    Afis.Text = Afis.Text + "+";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            nre = nr.Length;
            if (nre > 0)
            {
                int k;
                k = elem.IndexOf(nr[nre - 1]);
                if (k <= 0)
                    Afis.Text = Afis.Text + "-";
                else if (k == 1)
                    Afis.Text = Afis.Text + "-";
            }
        }
        private void inmultire_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            nre = nr.Length;
            if (nre > 0)
            {
                int k;
                k = elem.IndexOf(nr[nre - 1]);
                if (k < 0)
                    Afis.Text = Afis.Text + "*";
                else if (k == 1)
                    Afis.Text = Afis.Text + "*";
            }
        }

        private void inpartire_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            nre = nr.Length;
            if (nre > 0)
            {
                int k;
                k = elem.IndexOf(nr[nre - 1]);
                if (k < 0)
                    Afis.Text = Afis.Text + "/";
                else if (k == 1)
                    Afis.Text = Afis.Text + "/";
            }
        }
        private void punct_Click(object sender, EventArgs e)
        {
            Afis.Text = Afis.Text + ".";
        }

        private void clean_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            int l;
            l = nr.Length;
            if(l>0)
             nr = nr.Substring(0, nr.Length - 1);
            Afis.Text = nr;
        }

        private void allclean_Click(object sender, EventArgs e)
        {
            nr = "";
            Afis.Text = "";
        }

        private void Afis_TextChanged(object sender, EventArgs e)
        {

        }

        private void past_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            k = nr.Length;
            int o1, o2;
            if (k == 0)
            {
                pars++;
                Afis.Text = Afis.Text + "(";
            }
            else
            {
                o1 = numere.IndexOf(nr[k - 1]);
                o2 = elem.IndexOf(nr[k - 1]);
                if (nr[k - 1] == '(')
                {
                    pars++;
                    Afis.Text = Afis.Text + "(";
                }
                else if (pars >= pard && nr[k - 1] == ')')
                {
                    pars++;
                    Afis.Text = Afis.Text + "*(";
                }
                else if (pars >= pard && o1 >= 0)
                {
                    pars++;
                    Afis.Text = Afis.Text + "*(";
                }
                else if (pars >= pard && o2 >= 0)
                {
                    pars++;
                    Afis.Text = Afis.Text + "(";
                }
            }
        }

        private void padr_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            k = nr.Length;
            int o,i=k-1,i1=1,ok=0,o1;
            o = elem.IndexOf(nr[k - 1]);
            while(i>=0)
            {
                if (nr[i] == '(')
                {
                    i1 = i + 1;
                    break;
                }
                i--;
            }
            while(i1<k-1)
            {
                o1 = elem.IndexOf(nr[i1]);
                if (o1 > 1)
                {
                    ok = 1;
                    break;
                }
                i1++;
            }
            if (pars > pard && nr[k - 1] != '(' && (o<0 || o==1) && ok==1)
            {
                Afis.Text = Afis.Text + ")";
                pard++;
            }
        }

        private void egal_Click(object sender, EventArgs e)
        {
            nr = Afis.Text;
            expresie n = new expresie(nr);
            nr = n.rezultat();
            Afis.Text = nr;
        }

        public void Verificari_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
