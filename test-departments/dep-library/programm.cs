using System;
using System.Collections.Generic;
using System.Text;

namespace dep_library
{
    public class programm
    {
        public static Random rand = new Random();

        public static List<Department> GenerateDepartmentsInline(int N, int M)
        {
            List<Department> departments = new List<Department>();

            for (int k = 1; k <= N; k++)
            {
                int nextDep = -1;
                int i = RandNumber(M);
                int j = RandNumber(M, i);
                bool rool = RandRool();

                if (k != N)
                    nextDep = k + 1;

                Department newDep = new Department(k, nextDep, i, j);
                newDep.Rool = rool;

                if (rool)
                {
                    int t = RandNumber(M, i, j);
                    int r = RandNumber(M, t);

                    newDep.StampIdT = t;
                    newDep.StampIdR = r;
                }           

                departments.Add(newDep);
            }

            return departments;
        }

        private static int RandNumber(int M)
        {
            return rand.Next(1, M);
        }

        private static int RandNumber(int M, int stampI) //Генерируем J так, что I!=J или Т!=R
        { 
            int result = stampI;
            do
            {
                result = rand.Next(1, M);
            }
            while(stampI == result);

            return result;
        }

        private static int RandNumber(int M, int stampI, int stampJ) //T!=I && T=!J
        {
            Random rand = new Random();
            int result = stampI;
            do
            {
                result = rand.Next(1, M);
            }
            while (stampI == result || stampJ == result);

            return result;
        }

        private static bool RandRool()
        {
            return rand.Next(0, 2) > 0;
        }

        public static string GetDepartmentsData(List<Department> deps)
        {
            string result = "";
            foreach (Department department in deps)
            {
                result += "id " + department.DepartmentId +
                          "\nnextDep " + department.NextDepartmentId +
                          "\nstampI " + department.StampIdI +
                          "\nstampJ " + department.StampIdJ;

                if (department.Rool)
                {
                    result += "\nstampT " + department.StampIdT +
                                 "\nstampR " + department.StampIdR;
                }
                   

                result += "\n\n";
            }
            return result;
        }
    }
}
