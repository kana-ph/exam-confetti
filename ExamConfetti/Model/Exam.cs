using System.Collections.Generic;

namespace ExamConfetti.Model
{
	class Exam
	{
		private string title;
		private string instruction;
		private ImageFile headerLogo;
		private string footer;
		private List<ImageFile> images;
		private List<ExamItem> items;

		public Exam()
		{
			images = new List<ImageFile>();
			items = new List<ExamItem>();
		}

		public string Title { set; get; }
		public string Instruction { set; get; }
		public ImageFile HeaderLogo { set; get; }
		public string Footer { set; get; }
		public List<ImageFile> Images { private set; get; }
		public List<ExamItem> Items { private set; get; }

        public static Exam Load(string fileName)
        {

        }

        public void Save()
        {

        }

        public List<ExamItem> ShuffleItems()
        {

        }
	}
}
