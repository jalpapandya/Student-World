import java.io.*;
class file1
{
public static void main(String atr[])
{
try
	{
File infile=new File("input.txt");
File outfile=new File("output.txt");
FileReader in;
FileWriter out;
in=new FileReader(infile);
out=new FileWriter(outfile);
int ch;
while((ch=in.read())!=-1)
out.write(ch);
in.close();
out.close();
}
catch(IOException e)
{	
System.out.println(e);
	}
	}
	}
