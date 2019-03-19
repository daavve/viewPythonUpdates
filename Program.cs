using System;
using System.IO;
using System.Collections.Generic;

namespace PythonUpdates
{
    public class PyProject
    {
        string Name;
        string Ver_cur;
        string Ver_next;

        bool report_if_out_of_date;

        public PyProject(string name, string ver_cur, string ver_next)
        {
            Name = name;
            Ver_cur = ver_cur;
            Ver_next = ver_next;
            report_if_out_of_date = true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String pylines0 = null;
            String pylines1 = null;
            String nooutofdate = null;
            try
            {
                using (StreamReader sr = new StreamReader("p0.txt"))
                {
                    pylines0 = sr.ReadToEnd();
                }
                using (StreamReader sr = new StreamReader("p1.txt"))
                {
                    pylines1 = sr.ReadToEnd();
                }
                using (StreamReader sr = new StreamReader("No_Mark_out_of_date"))
                {
                    nooutofdate = sr.ReadToEnd();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("File could not be read");
                Console.WriteLine(e.Message);
            }
            var dictionary = new Dictionary<string, PyProject>();
            var dictionary_no_out_of_date = new Dictionary<string, bool>();
            foreach(string no_mark in nooutofdate.Split('\n'))
            {
                if(no_mark.Length > 1)
                {
                    dictionary_no_out_of_date.Add(no_mark, true);
                }
            }
            string[] spylines0 = pylines0.Split('\n');
            for (int i = 2; i < spylines0.Length; ++i){
                string[] splitline = spylines0[i].Split(' ');
                string[] eachproject = new string[4];
                int j = 0;
                foreach(string split in splitline)
                {
                    if(split.Length > 1)
                    {
                        eachproject[j] = split;
                        ++j;
                    }
                    
                }
                //Console.WriteLine("----------------");
                //foreach(string split in eachproject)
                //{
                //    Console.WriteLine(split);
                //}
                
            }

           
            
        }
    }
}
