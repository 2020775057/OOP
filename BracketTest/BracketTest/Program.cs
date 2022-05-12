using System;

public interface Stack
{
	bool isEmpty();
	void push(char item);
	char pop();
	void delete();
	char peek();
}


public class StackNode
{
	char data;
	StackNode link;

    public char Data { get => Data1; set => Data1 = value; }
    public StackNode Link { get => Link1; set => Link1 = value; }
    public char Data1 { get => data; set => data = value; }
    public StackNode Link1 { get => link; set => link = value; }
}



public class LinkedStack : Stack
{
	private StackNode top;

    public StackNode Top { get => top; set => top = value; }

    public bool isEmpty()
	{
		return (Top == null);
	}

	public void push(char item)
	{
		StackNode newNode = new StackNode();
		newNode.Data = item;
		newNode.Link = Top;
		Top = newNode;
	// System.out.println("Inserted Item : " + item);
}

public char pop()
{
	if (isEmpty())
	{
		Console.WriteLine("Deleting fail! Linked Stack is empty!!");
		return (char)0;
	}
	else
	{
		char item = Top.Data1;
		Top = Top.Link1;
		return item;
	}
}

public void delete()
{
	if (isEmpty())
	{
			Console.WriteLine("Deleting fail! Linked Stack is empty!!");

	}
	else
	{
		Top = Top.Link1;
	}
}

public char peek()
{
	if (isEmpty())
	{
			Console.WriteLine("Peeking fail! Linked Stack is empty!!");
		return (char)0;
	}
	else
		return Top.Data1;
}

public void printStack()
{
	if (isEmpty())
			Console.WriteLine("Linked Stack is empty!! %n %n");
		else
	{
		StackNode temp = Top;
			Console.WriteLine("Linked Stack>> ");
		while (temp != null)
		{
				Console.WriteLine("\t %c \n", temp.Data);
			temp = temp.Link;
		}
			Console.WriteLine();
	}
}
}



public class OptExp
{
	private String exp;
	private int expSize;
	private char testCh, openPair;

    public string Exp { get => Exp1; set => Exp1 = value; }
    public int ExpSize { get => ExpSize1; set => ExpSize1 = value; }
    public char TestCh { get => TestCh1; set => TestCh1 = value; }
    public char OpenPair { get => OpenPair1; set => OpenPair1 = value; }
    public string Exp1 { get => exp; set => exp = value; }
    public int ExpSize1 { get => expSize; set => expSize = value; }
    public char TestCh1 { get => testCh; set => testCh = value; }
    public char OpenPair1 { get => openPair; set => openPair = value; }

    public bool testPair(String exp)
	{
		this.Exp = exp;
		LinkedStack S = new LinkedStack();
		ExpSize = this.Exp.Length;
		for (int i = 0; i < ExpSize; i++)
		{
			TestCh = this.Exp[i];
			switch (TestCh)
			{
				case '(':
				case '{':
				case '[':
					S.push(TestCh);
					break;
				case ')':
				case '}':
				case ']':
					if (S.isEmpty())
						return false;
					else
					{
						OpenPair = S.pop();
						if ((OpenPair == '(' && TestCh != ')') || (OpenPair == '{' && TestCh != '}')
								|| (OpenPair == '[' && TestCh != ']'))
							return false;
						else
							break;
					}
			}
		}
		if (S.isEmpty())
			return true;
		else
			return false;
	}
}



public class BracketTest
{

	public static void Main()
	{
		OptExp opt = new OptExp();
		String exp = "(3*5)-6/2)";

		Console.WriteLine(exp);

		if (opt.testPair(exp))
			Console.WriteLine("괄호 맞음!!");
		else
			Console.WriteLine("괄호 틀림!!");
	}
}
