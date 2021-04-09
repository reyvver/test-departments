using System;
using System.Collections.Generic;
using System.Text;

namespace dep_library
{
	public class Stamp //Класс печати
	{
		public int StampId;
		public bool IsMarked; //зачеркнута или нет

		public Stamp(int stampId)
		{
			StampId = stampId;
			IsMarked = false;
		}

		public void ChangeState()
		{
			IsMarked = !IsMarked;
		}
	}
}
