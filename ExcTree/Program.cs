using System;
using System.Collections;
using System.Collections.Generic;

namespace ExcTree
{
    class Program
    {

        public class ExpressionTree
        {
            public class Node
            {
                private String val;
                private Node left;
                private Node right;
                public Node()
                {
                    this.left = null;
                    this.right = null;
                }
                public Node(String value)
                {
                    this.val = value;
                    this.left = null;
                    this.right = null;
                }
                public String Val
                {
                    get
                    {
                        return val;
                    }
                    set
                    {
                        this.val = value;
                    }
                }
                public Node Left
                {
                    get
                    {
                        return left;
                    }
                    set
                    {
                        this.left = value;
                    }
                }
                public Node Right
                {
                    get
                    {
                        return right;
                    }
                    set
                    {
                        this.right = value;
                    }
                }
                public bool isLeaf()
                {
                    return left == null && right == null;
                }
                public bool isDigit()
                {
                    return val[0] >= '0' && val[0] <= '9';
                }
            }

            private Node root = null;
            private String expression;
            private ArrayList separatedExpression;
            private Dictionary<char, string> parameters;

            public ExpressionTree(String expression)
            {

                this.expression = expression;
                this.separatedExpression = Splitter(expression);
                this.parameters = GetNamedParameters();
                Tuple<Node,bool> builder = BuildTree(Splitter(expression));
                root = builder.Item1;
                if (builder.Item2)
                {
                    Console.WriteLine("NEEDED MORE ARGUMENTS");
                    Console.WriteLine("EXPRESSION WILL BE PROCESSED BY DEFAULT");
                    PrintPreorder(root);
                    Console.WriteLine();
                }
                else if (root.isLeaf())
                {
                    Console.WriteLine("SO MANY ARGUMENTS");
                    Console.WriteLine("PROCESSED TREE LIKE ONE NODE TREE");
                    PrintPreorder(root);
                    Console.WriteLine();
                }
                else if(separatedExpression.Count != GetCurrentPrefixExpression(root).Length)
                {
                    Console.WriteLine("SOME MISTAKES IN EXPRESSION");
                    PrintPreorder(root);
                    Console.WriteLine();
                }
            }

            public Node GetRoot()
            {
                return root;
            }

            public void Join(Node joinRoot)
            {
                root = JoinGroup(root, joinRoot);
            }

            private Node JoinGroup(Node main, Node second)
            {
                if (main.Left == null && second != null)
                    return second;
                Node temp = new Node(main.Val);
                temp.Left = JoinGroup(main.Left, second);
                temp.Right = main.Right;
                return temp;
            }

            public String GetCurrentPrefixExpression(Node root)
            {
                if (root == null)
                    return "";
                String result = root.Val;
                result += GetCurrentPrefixExpression(root.Left);
                result += GetCurrentPrefixExpression(root.Right);
                return result;
            }

            private Tuple<Node,bool> BuildTree(ArrayList values)
            {
                String element = (string)values[0];
                values.RemoveAt(0);
                if (element.Equals("sІn") || element.Equals("cos") || element.Equals("SIN") || element.Equals("COS"))
                {
                    Node t = new Node(element);
                    t.Right = BuildTree(values).Item1;
                    return Tuple.Create(t,false);
                }
                else if ((element[0] >= 'a' && element[0] <= 'z') || (element[0] >= 'A' && element[0] <= 'Z') ||
                    (element[0] >= '0' && element[0] <= '9'))
                {
                    return Tuple.Create(new Node(element),false);
                }
                
                Node temp = new Node(element);
                bool exceptionFlag = false;

                if (values.Count != 0)
                    temp.Left = BuildTree(values).Item1;
                else
                {
                    temp.Left = new Node("1");
                    exceptionFlag = true;
                }
               
                if (values.Count != 0)
                    temp.Right = BuildTree(values).Item1;
                else
                {
                    temp.Right = new Node("1");
                    exceptionFlag = true;
                }
                
                return Tuple.Create(temp,exceptionFlag);
            }
            
            private ArrayList Splitter(String prefixExpression)
            {
                ArrayList values = new ArrayList();
                for (int i = 0; i < prefixExpression.Length; i++)
                {
                    if ((prefixExpression[i] >= 'a' && prefixExpression[i] <= 'z') || (prefixExpression[i] >= 'A' && prefixExpression[i] <= 'Z') ||
                    (prefixExpression[i] >= '0' && prefixExpression[i] <= '9'))
                    {
                        if ((prefixExpression[i] == 'S' || prefixExpression[i] == 's') && (i + 2) < prefixExpression.Length && (prefixExpression.Substring(i, 3) == "sin" || prefixExpression.Substring(i, 3) == "SIN"))
                        {
                            values.Add(prefixExpression.Substring(i, 3));
                            i += 2;
                        }
                        else if ((prefixExpression[i] == 'C' || prefixExpression[i] == 'c') && (i + 2) < prefixExpression.Length && (prefixExpression.Substring(i, 3) == "cos" || prefixExpression.Substring(i, 3) == "COS"))
                        {
                            
                            values.Add(prefixExpression.Substring(i, 3));
                            i += 2;
                        }
                        else
                        {
                            values.Add(prefixExpression[i] + "");
                        }
                    }
                    else if (prefixExpression[i] != ' ')
                    {
                        values.Add(prefixExpression[i] + "");
                    }
                }
                return values;
            }

            public Dictionary<char, String> GetNamedParameters()
            {
                ArrayList separatedExpression = Splitter(GetCurrentPrefixExpression(root));
                Dictionary<char, string> parameters = new Dictionary<char, string>();
                for (int i = 0; i < separatedExpression.Count; i++)
                    if (separatedExpression[i].ToString().Length == 1 && 
                        (separatedExpression[i].ToString()[0] >= 'a' && separatedExpression[i].ToString()[0] <= 'z' ||
                         separatedExpression[i].ToString()[0] >= 'A' && separatedExpression[i].ToString()[0] <= 'Z'))
                        if (!parameters.ContainsKey(separatedExpression[i].ToString()[0]))
                            parameters.Add(separatedExpression[i].ToString()[0], "");
                return parameters;
            }
            
            public void Print(String TYPE)
            {
                if (root != null)
                {
                    Console.WriteLine("-----" + TYPE + "ORDER-------");
                    switch (TYPE)
                    {
                        case "PRE":
                            {
                                PrintPreorder(root);
                                break;
                            }
                        case "IN":
                            {
                                PrintInorder(root);
                                break;
                            }
                        case "POST":
                            {
                                PrintPostorder(root);
                                break;
                            }
                    }
                    Console.WriteLine();
                }
            }
            private void PrintPostorder(Node root)
            {
                if (root == null)
                    return;
                PrintPostorder(root.Left);
                PrintPostorder(root.Right);
                Console.Write(root.Val);
            }
            private void PrintPreorder(Node root)
            {
                if (root == null)
                    return;
                Console.Write(root.Val);
                PrintPreorder(root.Left);
                PrintPreorder(root.Right);
            }
            private void PrintInorder(Node root)
            {
                if (root == null)
                    return;
                if (root.Val == "+" || root.Val == "-")
                    Console.Write("(");
                PrintInorder(root.Left);
                Console.Write(root.Val);
                PrintInorder(root.Right);
                if (root.Val == "+" || root.Val == "-")
                    Console.Write(")");
            }
            
            public double Evaluate(string vars)
            {

                if (GetNamedParameters().Count > 0)
                {
                    string[] p = vars.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if (p.Length == GetNamedParameters().Count)
                    {
                        Dictionary<char, string> namedParams = GetNamedParameters();
                        List<char> keys = new List<char>(namedParams.Keys);
                        int i = 0;
                        foreach (char key in keys)
                        {
                            namedParams[key] = p[i];
                            i++;
                        }
                        return Eval(root, namedParams);
                    }
                    else
                    {
                        Console.WriteLine("BAD COUNT OF PARAMETERS");
                        return -1;
                    }
                }
                return Eval(root,GetNamedParameters());
            }
            
            private double Eval(Node root, Dictionary<char,string> parameters)
            {
                
                if (root == null)
                    return 0;
                if (root.isLeaf() && root.isDigit())
                    return Convert.ToDouble(root.Val);
                if(root.isLeaf() && !root.isDigit())
                    return Convert.ToDouble(parameters[root.Val[0]]);
                
                double left = Eval(root.Left,parameters);
                double right = Eval(root.Right,parameters);
                
                switch (root.Val)
                {
                    case "+": return left + right;
                    case "-": return left - right;
                    case "*": return left * right; 
                    case "/": return left / right;
                    case "sin": return Math.Sin(right);
                    case "cos": return Math.Cos(right);
                    case "SIN": return Math.Sin(right);
                    case "COS": return Math.Cos(right);
                }
                return 0;
            }
        }

        public class Menu
        {
            private ExpressionTree expression1 = null;
            private ExpressionTree expression2 = null;

            public void enter(String expr)
            {
                expression1 = new ExpressionTree(expr);
            }

            public void print()
            {
                if (expression1 != null)
                {
                    expression1.Print("PRE");
                    expression1.Print("IN");
                    expression1.Print("POST");
                }
                else
                {
                    Console.WriteLine("THE TREE MUST BE INITIALIZED");
                }
            }
            public void vars()
            {
                if (expression1 != null)
                {
                    Dictionary<char, string> parameters = expression1.GetNamedParameters();
                    foreach(KeyValuePair<char, string> p in parameters)
                    {
                        Console.Write(p.Key + " ");
                    }
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("THE TREE MUST BE INITIALIZED");
            }
            public void comp(string vars)
            {
                if (expression1 != null)
                {
                    double result = expression1.Evaluate(vars);
                    if (result != -1)
                        Console.WriteLine("CALCULATION RESULT : " + result);
                }
                else
                {
                    Console.WriteLine("THE TREE MUST BE INITIALIZED");
                }

            }

            public void join(string expr)
            {
                if (expression1 != null)
                {
                    expression2 = new ExpressionTree(expr);
                    expression1.Join(expression2.GetRoot());
                }
                else
                {
                    Console.WriteLine("THE TREE MUST BE INITIALIZED");
                }
            }
        }
        static void Main(string[] args)
        {
            String command;

            Menu menu = new Menu();
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("-------------");
                Console.WriteLine("ENTER COMMAND");
                Console.WriteLine("-------------");
                command = Console.ReadLine();

                int start = command.IndexOf(" ")+1;
                int end = command.Length - command.IndexOf(" ")-1;
                string vars = "";
                String com = "";
                if (start != 0)
                {
                    vars = command.Substring(start, end);
                    com = command.Substring(0, start-1);
                }
                else
                    com = command;
                switch (com)
                {
                    case "enter":
                        {
                            menu.enter(vars);
                            break;
                        }
                    case "vars":
                        {
                            menu.vars();
                            break;
                        }
                        
                    case "print":
                        {
                            menu.print();
                            break;
                        }
                    case "comp":
                        {
                            menu.comp(vars);
                            break;
                        }
                    case "join":
                        {
                            menu.join(vars);
                            break;
                        }
                    case "exit":
                        {
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("WRONG COMMAND");
                            break;
                        }
                }
            }
        }
    }
}
