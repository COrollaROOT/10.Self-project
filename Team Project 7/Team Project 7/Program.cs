namespace Team_Project_7
{
    /*
    1.요세푸스 문제 : 입력 (int n, int k)

    n명이 동그랗게 모여 있을 때 /배열? /리스트? /Q?
    숫자 k를 외치면 1번부터 시작 /"k!!"
    모임에서 빠지는 경우를 반복했을 때 /out
    마지막에 남아 있는 사람을 구하는 문제   
    */
    
    internal class Program

    {
            public static int Yosepus(int n, int k)
        {
            Queue<int> queue = new Queue<int>(n);
            for (int i = 1; i <= n; i++)
            {
                queue.Enqueue(i);
            }

            int count = 0;
            while (queue.Count > 1)
            {
                count++;
                if (count % k == 0)
                {
                    queue.Dequeue();
                }
                else
                {
                    int value = queue.Dequeue();
                    queue.Enqueue(value);
                }
            }

            return queue.Dequeue();
        }


        /*
 2. 괄호 검사기 : 입력 (string "()[]{}")
    (), {}, [] 가 조합된 경우가 있을 때
    괄호의 결과가 제대로 구성되어 있는지 검사하는 기능
    정상 : ()(), ({})[], (({}[]){})
*/
        public static bool IsCorrectBracket(string str)
            {
                Stack<char> stack = new Stack<char>();

                for (int i = 0; i < str.Length; i++)
                {
                    char c = str[i];

                    switch (c)
                    {
                        case '(':
                        case '{':
                        case '[':
                            stack.Push(c);
                            break;

                        case ')':
                            if (stack.Count == 0)
                                return false;

                            if (stack.Peek() != '(')
                                return false;

                            stack.Pop();
                            break;

                        case '}':
                            if (stack.Count == 0)
                                return false;

                            if (stack.Peek() != '{')
                                return false;

                            stack.Pop();
                            break;

                        case ']':
                            if (stack.Count == 0)
                                return false;

                            if (stack.Peek() != '[')
                                return false;

                            stack.Pop();
                            break;
                    }
                }

                if (stack.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static void Main(string[] args)
            {
                int n = 8;
                int k = 5;
                int result = Yosepus(n, k);
                Console.WriteLine("요세푸스({0}, {1}) 의 결과는 : {2}", n, k, result);

                string str = "[]]";
                Console.WriteLine("괄호 검사기의 결과는 : {0}", IsCorrectBracket(str));
            }
        }
    }