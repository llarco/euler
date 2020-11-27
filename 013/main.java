import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class main {

	public static void main(String[] args) throws IOException {
		
		Scanner sc = new Scanner(new File("data.txt"));
		int[][] data = new int[100][50];
		int line = 0;
		while(sc.hasNextLine()) {
			String in = sc.nextLine();
			for(int i=0; i < in.length(); i++) 
				data[line][i] = Integer.parseInt(in.substring(i,i+1));
			line++;
		}
		
		int[] result = new int[50];
		int carry = 0;
		for(int i=0; i<50; i++) {
			int sum = 0;
			for(int j=0; j<100; j++) {
				sum += data[j][49-i];
			}
			result[49-i]=(sum+carry)%10;
			carry = (sum+carry)/10;
		}
		
		System.out.print(carry);
		for(int i = 0; i < 8; i++)
			System.out.print(result[i]);
		
	}

}
