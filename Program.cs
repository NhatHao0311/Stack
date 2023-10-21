namespace Stack
{
    internal class Program
    {
        static void Test()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Stack stack = new Stack(n);

            Console.WriteLine("Nhap phan tu cho Stack ( Nhap so am de ket thuc ): ");
            int input;
            while (true)
            {
                input = int.Parse(Console.ReadLine());
                if (input < 0)
                {
                    break;
                }
                else
                {
                    stack.Push(input);
                }
            }

            Console.WriteLine("Cac gia tri trong Stack la: ");
            stack.ShowStack();

            Console.WriteLine();
            Console.WriteLine($"So gia tri trong stack la: {stack.Count()}");
            Console.WriteLine();

            if (!stack.IsEmpty())
            {
                int value;
                if(stack.Peek(out value))
                {
                    Console.WriteLine("Top of Stack: " + value);
                }
            }
            Console.WriteLine();


            while (!stack.IsEmpty())
            {
                int Index;
                stack.Pop(out Index);
                Console.WriteLine($"Popped Stack: {Index} ");
            }
            Console.WriteLine("Stack is empty! ");
          

        }
        static void Main(string[] args)
        {
            Test();
        }
    }
}