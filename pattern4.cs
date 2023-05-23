using System;
class Program {

	public static void Main() {

		for(int j=1;j<=6;j++) {
			for(int i=1,k=j;i<=5;i++,k*=j+1) {
		
		Console.Write(k.ToString().PadRight(5) + "  ");		
			}
			Console.WriteLine();
		}		
	}

}