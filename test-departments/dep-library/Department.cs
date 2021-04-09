using System;

namespace dep_library
{
    public class Department // Класс отдела
    {
		public int DepartmentId, StampIdI, StampIdJ, StampIdT, StampIdR, NextDepartmentId; //идентификатор, печать, след отдел
		public bool Rool; // true - условное, false - безусловное

		public Department(int departmentId, int nextDepartmentId, int stampIdI, int stampIdJ)
		{
			DepartmentId = departmentId;
			NextDepartmentId = nextDepartmentId;
			StampIdI = stampIdI;
			StampIdJ = stampIdJ;
			Rool = false;
		}
	}

}

