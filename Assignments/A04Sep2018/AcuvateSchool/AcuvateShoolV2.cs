using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acuvate_school1.ver2
{
    public class subject
    {
        public string sub;
        public student_detailsv2 Sub_top_stud = new student_detailsv2();
        public int sub_max_marks = 0;
    }

    class AcuvateShoolV2
    {

        static void Main2(string[] args)
        {
            student_detailsv2[] Std_Dtl_Obj = new student_detailsv2[220];
            //subjects subject = new subjects();
            subject[] Sub_Obj = new subject[6];
            student_detailsv2 temp;

            for (int i = 0; i < Sub_Obj.Length; i++)
            {
                Sub_Obj[i] = new subject();
                Console.WriteLine("enter name of subject" + (i + 1));
                Sub_Obj[i].sub = Console.ReadLine();
            }

            int Grade_valid = 1;
            int Response = 1;
            int[] grade = new int[12];




            for (int i = 0; i <= Std_Dtl_Obj.Length; i++)
            {


                Std_Dtl_Obj[i] = new student_detailsv2();
                Console.WriteLine("enter first name");
                Std_Dtl_Obj[i].Firstname = Console.ReadLine();
                Console.WriteLine("enter rollnum");
                Std_Dtl_Obj[i].rollnum = Console.ReadLine();
                do
                {
                    Console.WriteLine("enter grade in number (1-12)");
                    int gr = int.Parse(Console.ReadLine());
                    if (gr > 0 && gr < 13)
                    {
                        if (grade[gr - 1] < 23)
                        {
                            Std_Dtl_Obj[i].Grade = gr;
                            grade[gr - 1] = +1;
                            Grade_valid = 0;
                        }
                        else Console.WriteLine("max students already in class");

                    }
                    else Console.WriteLine("please enter grade in numbers between 1-12");
                } while (Grade_valid == 1);

                for (int sub = 0; sub < Sub_Obj.Length; sub++)
                {
                    Console.WriteLine("enter marks of " + Sub_Obj[sub].sub);
                    Std_Dtl_Obj[i].marks[sub] = int.Parse(Console.ReadLine());
                    Std_Dtl_Obj[i].perct += (Std_Dtl_Obj[i].marks[sub] / Sub_Obj.Length);
                    if (Std_Dtl_Obj[i].marks[sub] > Sub_Obj[sub].sub_max_marks)
                    {
                        Sub_Obj[sub].sub_max_marks = Std_Dtl_Obj[i].marks[sub];
                        Sub_Obj[sub].Sub_top_stud.Firstname = Std_Dtl_Obj[i].Firstname;
                    }

                }
                Console.WriteLine("please enter 1. to fill student details/n 2. to get count/n 3. sub high grade and high avg");
                Response = int.Parse(Console.ReadLine());
                if (Response == 1)
                {
                    continue;
                }
                else if (Response == 2)
                {
                    Console.WriteLine("grade   num of students");
                    for (int it = 0; it < grade.Length; it++)
                    {
                        Console.WriteLine("{0}    {1}", it + 1, grade[it]);
                    }

                }
                else if (Response == 3)
                {
                    for (int mx_sb = 0; mx_sb < 6; mx_sb++)
                    {
                        for (int st_mx = 0; st_mx < i; st_mx++)
                        {
                            if (Sub_Obj[mx_sb].sub_max_marks == Std_Dtl_Obj[st_mx].marks[mx_sb])
                            {
                                Sub_Obj[mx_sb].Sub_top_stud = Std_Dtl_Obj[st_mx];
                            }
                        }

                    }
                    foreach (subject mar in Sub_Obj)
                        Console.WriteLine(mar.sub + "   " + mar.sub_max_marks + "   " + mar.Sub_top_stud.Firstname);

                    Console.WriteLine("\n");
                    for (float hi_gr = 0; hi_gr <= i; hi_gr++)
                    {

                        for (int j = 0; j <= (i - hi_gr - 1); j++)
                        {
                            if (Std_Dtl_Obj[j].perct < Std_Dtl_Obj[j + 1].perct)
                            {
                                temp = Std_Dtl_Obj[j];
                                Std_Dtl_Obj[j] = Std_Dtl_Obj[j + 1];
                                Std_Dtl_Obj[j + 1] = temp;
                            }
                        }
                    }
                    //foreach (student_detailsv2 hi_per in obj_std_det)
                    //    Console.WriteLine(hi_per.Firstname + "    " + hi_per.perct);
                    Console.WriteLine("RANK     std name        percent");

                    for (int hi_per = 0; hi_per <= i; hi_per++)
                    {
                        Console.WriteLine((hi_per + 1) + "   " + Std_Dtl_Obj[hi_per].Firstname + "    " + Std_Dtl_Obj[hi_per].perct);
                    }

                }

            }


        }


    }






}


public class student_detailsv2
{
    public string Firstname;
    public string rollnum;
    public int Grade = 1;
    public int[] marks = new int[6];
    public float perct = 0;

}


