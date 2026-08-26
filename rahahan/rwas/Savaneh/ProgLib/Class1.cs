using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace ProgLib
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	public class Class1
	{
		public Class1()
		{
			//
			// TODO: Add constructor logic here
			//
		}


		[STAThread]
		static void Main() 
		{
			//Application.Run(new Form1());
			ImageListStreamer ocImageListStreamer;
//			Image ocImagePrev;
//			Image ocImageNext;
//			Image ocImageEnd;
//			Image ocImageFirst;

			ImageList ocImageList=new ImageList();
			
			ocImageList.ImageSize=new Size(35, 25);
			
			ocImageList.Images.Add(Image.FromFile("C:\\Documents and Settings\\Nasim\\Desktop\\icon\\icon\\Hazf.ICO"));
			ocImageList.Images.Add(Image.FromFile("C:\\Documents and Settings\\Nasim\\Desktop\\icon\\icon\\taeyd1.PNG"));
			ocImageList.Images.Add(Image.FromFile("C:\\Documents and Settings\\Nasim\\Desktop\\icon\\icon\\taeyd1.PNG"));
			ocImageList.Images.Add(Image.FromFile("C:\\Documents and Settings\\Nasim\\Desktop\\icon\\icon\\EXET.PNG"));
			//ocImageList.Images.Add(Image.FromFile("C:\\Documents and Settings\\Nasim\\Desktop\\Image\\Next.PNG"));
//			ocImageList.Images.Add(Image.FromFile("C:\\Documents and Settings\\Nasim\\Desktop\\Image\\End.PNG"));
//			ocImageList.Images.Add(Image.FromFile("C:\\Documents and Settings\\Nasim\\Desktop\\Image\\First.PNG"));

//			ocImagePrev=Image.FromFile("C:\\Documents and Settings\\Nasim\\Desktop\\Image\\Prev.PNG");
//
//			ocImageEnd=Image.FromFile("C:\\Documents and Settings\\Nasim\\Desktop\\Image\\End.PNG");
//
//			ocImageFirst=Image.FromFile("C:\\Documents and Settings\\Nasim\\Desktop\\Image\\First.PNG");
//
//			ocImageNext=Image.FromFile("C:\\Documents and Settings\\Nasim\\Desktop\\Image\\Next.PNG");

			ocImageListStreamer=ocImageList.ImageStream;

			ResourceWriter RW=new ResourceWriter("Components.MessageForm.resources");

			RW.AddResource("ocImageList.ImageStream",ocImageListStreamer);
//			RW.AddResource("PrevYearButton.Image",ocImagePrev);
//			RW.AddResource("btnRight.Image",ocImageEnd);
//			RW.AddResource("btnLeft.Image",ocImageFirst);
//			RW.AddResource("NextYearButton.Image",ocImageNext);

			RW.Close();

		}
	}
}
