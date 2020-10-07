using System;
using System.Windows.Forms;

namespace Hydra
{
	// Token: 0x02000003 RID: 3
	internal class Program
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002898 File Offset: 0x00000A98
		public static byte TextInsanity()
		{
			if (Program.textInsanity >= 5)
			{
				Program.textInsanity = 0;
				if (Program._textInsanity < 3)
				{
					Program._textInsanity += 1;
				}
			}
			else
			{
				Program.textInsanity += 1;
			}
			return Program._textInsanity;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000028D1 File Offset: 0x00000AD1
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MsgBoxForm
			{
				IsStartupForm = true
			});
		}

		// Token: 0x04000007 RID: 7
		public static Random rand = new Random();

		// Token: 0x04000008 RID: 8
		public static short textLength = 5;

		// Token: 0x04000009 RID: 9
		private static byte _textInsanity = 0;

		// Token: 0x0400000A RID: 10
		private static byte textInsanity = 0;
	}
}
