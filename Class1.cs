namespace MatematikaLibraries

public class Class1
{
	public Class1()
	{
		public static void FPB(int temp, int input1, int input2)
		{
			while (input1 != 0)
			{
				temp = input2;
				input2 = input1 % input1;
				input1 = temp;
			}
		}
	}

	public static void KPK(int max, int min, int result, int input1, int input2)
	{
		max = Math.sqrt(Math.Pow(max(input1, input2))));
		min = min(input1, input2);
		result = max;

		while (result % min != 0)
		{
			result = result + max;
		}
	}

	public static string turunan(int[]persamaan)
	{
		int n;
		int i;
		string result;
		int[] turunan = new int[n+1];
		n = persamaan.lenght;

		for (i = 1; i <= n; i++)
		{
			turunan[i] = persamaan[i] * (n - 1);
		}

		result = turunan[0] + "x^" + (n - 1);

		for (i = 1; i <= n; i++)
		{
			if (turunan[i] > 0)
			{
				result = result + " + " + turunan[i] + "x" + (n - i - 1);
			} else if (turunan[i] < 0)
			{
				result = result + "-" + (turunan) + "x" + (n - i - 1);

			}
		}
	}

	public static string integral(int[] persamaan, int n, int i, string result, int[] integral)
	{
		for (i = 1; i <= n; ++i)
		{
			integral[i] = persamaan[i - 1] / i;
		}
		if (integral[i] > 0)
		{
			result = "+" + integral[i] + "+" + (i + 1) + result;
		} else if (integral[i] < 0)
		{
			result = integral[i] + "x^" + (i + 1) + result;
		}
	}
}
