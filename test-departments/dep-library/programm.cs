using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Text;

namespace dep_library
{
    public  class Programm
    {
        public  Random rand = new Random();
        public  List<Department> deps;
        public Dictionary<int, bool> stamps = new Dictionary<int, bool>();

        public bool isInfiniteImportant = true;

        public Programm()
        { 
        }

        public void GenerateDepartments(int N, int M, bool inline = true)
        {
            List<Department> departments = new List<Department>();

            for (int k = 1; k <= N; k++)
            {
                int nextDepK = -1;
                int nextDepP = -1;
                int i = RandNumber(M);
                int j = RandNumber(M, i);
                bool rool = RandRool();

                if (k != N)
                {
                    if (inline)
                    {
                        nextDepK = k + 1;
                        if (k + 2 <= N)
                            nextDepP = k + 2;
                        else
                            nextDepP = 1;
                    }
                    else
                    {
                        nextDepK = RandNumber(N);
                        nextDepP = RandNumber(N);
                    }
                }
                
                if (k == N && !inline)
                    nextDepK = RandNumber(N);
                    nextDepP = RandNumber(N);


                Department newDep = new Department(k, nextDepK, i, j);
                newDep.Rool = rool;

                if (rool)
                {
                    int s = RandNumber(M, i, j);
                    int t = RandNumber(M, s);
                    int r = RandNumber(M, t);

                    newDep.NextDepP = nextDepP;
                    newDep.StampIdS = s;
                    newDep.StampIdT = t;
                    newDep.StampIdR = r;
                }           

                departments.Add(newDep);
            }

            deps = departments;
        }

        private int RandNumber(int L)
        {
            return rand.Next(1, L+1);
        }


        private  int RandNumber(int L, int stampI) //Генерируем J так, что I!=J или Т!=R
        { 
            int result = stampI;
            do
            {
                result = rand.Next(1, L);
            }
            while(stampI == result);

            return result;
        }

        private  int RandNumber(int L, int stampI, int stampJ) //T!=I && T=!J
        {
            Random rand = new Random();
            int result = stampI;
            do
            {
                result = rand.Next(1, L);
            }
            while (stampI == result || stampJ == result);

            return result;
        }

        private  bool RandRool()
        {
            return rand.Next(0, 2) > 0;
        }

        public  List<string> GetDepartmentsData()
        {
            List<string> result = new List<string>();
            int index = 0;
            foreach (Department department in deps)
            {
                result[index] += "id " + department.DepartmentId +
                                 "\nnextDepK " + department.NextDepK +
                                 "\nstampI " + department.StampIdI +
                                 "\nstampJ " + department.StampIdJ;

                if (department.Rool)
                {
                    result[index] += "\nnextDepP " + department.NextDepK +
                                     "\nstampS " + department.StampIdS +
                                     "\nstampT " + department.StampIdT +
                                     "\nstampR " + department.StampIdR;
                }
            }
            return result;
        }

        public string VasyaIsGoing(int A, int Z)
        {
            stamps.Clear();

            int nexDep = A;
            int currentDep = A;
            int previousindex = -1;
            bool isInfinite = false;
            bool stampSMarked = false;

            while (nexDep == -1 || currentDep != Z)
            {
                //если дошли до последнего отдела при Inline
                if (nexDep == -1)
                    break;

                currentDep = deps[nexDep - 1].DepartmentId;


                //если правило отдела - условное 
                if (deps[nexDep - 1].Rool && stamps.ContainsKey(deps[nexDep - 1].StampIdS))
                {
                    // и есть незачеркнутая печать S
                    if (stamps[deps[nexDep - 1].StampIdS])
                        stampSMarked = true;
                    else
                        stampSMarked = false;

                }

                // если правило отдела безусловное 
                if (!deps[nexDep - 1].Rool || !stampSMarked)
                {
                    // если в листе нету печати I или печать I зачеркнута
                    if (!stamps.ContainsKey(deps[nexDep - 1].StampIdI) || stamps[deps[nexDep - 1].StampIdI] == false)
                        // тогда ставим новую печать I
                        stamps[deps[nexDep - 1].StampIdI] = true;

                    // если есть печать J
                    if (stamps.ContainsKey(deps[nexDep - 1].StampIdJ))
                        // то зачеркиваем ее
                        stamps[deps[nexDep - 1].StampIdJ] = false;

                    // отправляем Васю в след отдел
                    nexDep = deps[nexDep - 1].NextDepK;
                }
                else
                //если правило отдела условное и печать S зачеркнута или ее нет
                {
                    // если в листе нету печати T или печать T зачеркнута
                    if (!stamps.ContainsKey(deps[nexDep - 1].StampIdT) || stamps[deps[nexDep - 1].StampIdT] == false)
                        // тогда ставим новую печать T
                        stamps[deps[nexDep - 1].StampIdT] = true;

                    // если есть печать R
                    if (stamps.ContainsKey(deps[nexDep - 1].StampIdR))
                        // то зачеркиваем ее
                        stamps[deps[nexDep - 1].StampIdR] = false;

                    // отправляем Васю в след отдел
                    nexDep = deps[nexDep - 1].NextDepP;
                }


                if (nexDep == previousindex || currentDep == previousindex)
                {
                    Console.WriteLine("loop");
                    isInfinite = true;
                    break;
                }

                previousindex = currentDep;

            };

            if (!isInfinite)
                return GetStampsData();
            else
                return "Вася застрял навечно в бюрократической машине";
        }

        public string GetStampsData()
        {
            string result = "";
            string status;

            foreach (var stamp in stamps)
            {
                if (stamp.Value)
                    status = "не зачеркнута";
                else
                    status = "зачеркнута";

                result += "stamp № "  + stamp.Key +" status - " + status + "\n";

            }


            return result;
        }

    }
}
