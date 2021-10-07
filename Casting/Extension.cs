using System;
using System.Collections.Generic;
using System.Text;

namespace Casting
{
	static class Extension
	{
		public static bool CustomContain(this string str, string word)
		{
			string[] strArr = str.Split(' ');
			foreach (var item in strArr)
			{
				for (int i = 0; i < item.Length - word.Length + 1; i++)
				{
					if (char.ToLower(item[i]) == char.ToLower(word[0]))
					{
						for (int j = 1; j < word.Length; j++)
						{
							if (char.ToLower(word[j]) != char.ToLower(item[i + j]))
							{
								break;
							}
							if (j == word.Length - 1)
							{
								return true;
							}
						}
					}
				}
			}
			return false;
		}
	}
}
