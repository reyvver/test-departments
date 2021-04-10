using System;

namespace dep_library
{
    public class Department // Класс отдела
    {
		public int DepartmentId, StampIdI, StampIdJ, StampIdS, StampIdT, StampIdR, NextDepK, NextDepP; //идентификатор, печать, след отдел
		public bool Rool; // true - условное, false - безусловное

		public Department(int departmentId, int nextDepartmentId, int stampIdI, int stampIdJ)
		{
			DepartmentId = departmentId;
			NextDepK = nextDepartmentId;
			StampIdI = stampIdI;
			StampIdJ = stampIdJ;

			NextDepP = -1;
			StampIdS = -1;
			StampIdT = -1;
			StampIdR = -1;

			Rool = false;
		}
	}

}

