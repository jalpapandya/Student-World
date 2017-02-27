class grandparent
{
 	String name;
 	grandparent(String s)
 	{
 		name=s;
 	}
  	void show()
 	{
 	 	System .out.println("grandparent name is"+name);
 	}
}
 class father extends grandparent
{
 	String name;
 	father(String s,String s1)
 	{
 		super(s);
   		name=s1;
 	}
  	void show()
 	{
 		super.show();
 		System .out.println("father name is"+name);
 	}
}
class child extends father
{
 	String name;
 	child(String s,String s1,String s2)
  	{
 		super(s,s1);
  		name=s2;
 	}
 	void show()
 	{
 		super.show();
 		System .out.println("child name is"+name);
 	}
}

class overiding
{
 	public static void main(String []args)
 	{
 		child c=new child("abc","pqr","xyz");
 		c.show();
 	}
}
