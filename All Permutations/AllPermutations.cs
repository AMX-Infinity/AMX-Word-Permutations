/*
 * All Permutations
 * Display all possible permutations for a set of characters.
 * 
 * Author: Afaan Bilal (https://afaan.ml)
 * Copyright (c) 2016 Afaan Bilal, AMX Infinity (https://www.amxinfinity.ml)
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace All_Permutations
{
    public partial class AllPermutations : Form
    {
        public AllPermutations()
        {
            InitializeComponent();
        }
         
        private string base_convert(string number, int fromBase, int toBase)
        {
            StringBuilder res = new StringBuilder();
            long n = Int32.Parse(number);
            if (fromBase > toBase)
            {
                while (n > 0)
                {
                    res.Append((char)(n % toBase + '0'));
                    n /= toBase;
                }
                string r = res.ToString();
                char[] cr = r.ToCharArray();
                Array.Reverse(cr);
                StringBuilder rcb = new StringBuilder();
                foreach (char c in cr)
                    rcb.Append(c);
                return rcb.ToString();
            }
            else
            {
                long ret = 0;
                for (int i = number.Length - 1, j = 0; i >= 0; i--, j++)
                    ret += (int)(number[i] - '0') * (int)Math.Pow((double)fromBase, (double)j);
                res.Append(ret);
            }
            return res.ToString();
        }
        
        private bool inArrayBin<T>(T[] arr, T s, long ubound)
        {
            long bottom = 0, top = ubound;
            long mid;
            StringComparer sc = StringComparer.Create(System.Globalization.CultureInfo.CurrentCulture, false);
            do
            {
                mid = (top + bottom) / 2;
                int res = sc.Compare(arr[mid], s);
                if (res < 0)
                    bottom = mid + 1;
                else if (res > 0)
                    top = mid - 1;
            } while (bottom <= top && !arr[mid].Equals(s));
            return (arr[mid] != null && arr[mid].Equals(s));
        }

        string[] words;
        long wcount;
        long real_wcount;
        long time;

        private void Permute(string chs)
        {
            time = 0;
            long stime = DateTime.Now.Ticks;

            char[] chars = chs.ToCharArray();
            Array.Sort(chars);
            int lcount = chars.Length;

            char[] u_chars = new char[chars.Length];
            int uc_len = 0;
            for (int i = 0; i < chars.Length; i++)
                if (!inArrayBin(u_chars, chars[i], uc_len))
                    u_chars[uc_len++] = chars[i];

            real_wcount = (long)Math.Pow((double)uc_len, (double)lcount);
            wcount = (long)Math.Pow((double)lcount, (double)lcount);

            StringBuilder keys_b = new StringBuilder();
            for (int i = 0; i < lcount; i++)
                keys_b.Append('0');
            string keys = keys_b.ToString();

            words = new string[real_wcount];
            long len = 0;
            
            for (int i = 0; i < wcount; i++)
            {
                StringBuilder cur_word = new StringBuilder();
                for (int j = 0; j < lcount; j++)
                {
                    int key = keys[j] - '0';
                    cur_word.Append(chars[key]);
                }

                keys = base_convert(keys, lcount, 10);
                long keys_l = Int32.Parse(keys);
                keys_l++;
                keys = base_convert(keys_l.ToString(), 10, lcount);

                if (keys.Length < lcount)
                {
                    StringBuilder sbz = new StringBuilder();
                    for (int k = 0; k < lcount - keys.Length; k++)
                        sbz.Append('0');
                    sbz.Append(keys);
                    keys = sbz.ToString();
                }

                if (!inArrayBin(words, cur_word.ToString(), len))
                    words[len++] = cur_word.ToString();
            }

            long ftime = DateTime.Now.Ticks;
            time += ftime - stime;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (tbChars.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter some characters first!", "All Permutations", MessageBoxButtons.OK);
                return;
            }

            cc.Text = "Characters: " + tbChars.Text.Trim().ToCharArray().Length;
            this.UseWaitCursor = true;
            RunInBackground(Permute, tbChars.Text.Trim());
        }
        
        private void RunInBackground(Action<string> work, string data)
        {
            BackgroundWorker bgW = new BackgroundWorker();
            bgW.DoWork += delegate
            {
               work(data);
            };
            bgW.RunWorkerAsync();
            bgW.RunWorkerCompleted += delegate
            {
                bgW.Dispose();

                twc.Text = "Total Permutations: " + wcount;
                wc.Text = "Unique Permutations: " + real_wcount;
                
                long stime = DateTime.Now.Ticks;
                
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < real_wcount; i++)
                {
                    sb.Append(words[i] + "     ");
                    if ((i+1) % 10 == 0)
                        sb.AppendLine();
                }
                rtbWords.Text = sb.ToString();

                long ftime = DateTime.Now.Ticks;
                long t2 = ftime - stime;
                long t1 = time;
                time += t2;
                lblT1.Text = "Time (Permute): " + t1 + " Ticks";
                lblT2.Text = "Time (Print): " + t2 + " Ticks";
                this.UseWaitCursor = false;
            };
        }
        
        private void linkCopyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amxinfinity.ml");
            System.Diagnostics.Process.Start("https://afaan.ml");
        }
    }
}
