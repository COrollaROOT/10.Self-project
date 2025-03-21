namespace _250313_김영근_과제_2
{
    internal class Program
    {
        static void Main(string[] args)
        //중첩반복문을 활용하여 아래 그림처럼 출력하는 네가지 프로그램을 각각 작성하여 보자.
        //Tip : Console.Write(" ");를 쓰면 빈 공백 하나를, Console.Write("*");을 쓰면 별 하나를 출력할 수 있다
        // 무엇이 반복 되는지 찾는게 중요
        // 1. 기본 문장을 찾아서 만들고 2. 몇번 반복되는지 확인후 횟수만큼 반복문 돌린다 3. 반복되는 과정에서 변하는 규칙 찾고 적용

            
            // 1번 삼각형
        {
            for (int i = 0; i <= 5; i++)     //for (초기화;(int i(변수) = 0;) 조건식;(i < 10;) 증감연산(i++))
                                               // i가 5와 같아 질때까까지 반복
            {

                for (int j = 0; j < i; j++)  // 행을 나타내는 i
                {
                    Console.Write("*"); // *을 나타내는 j             //j 가 i와 같아 질때까지 반복
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            // 2번 삼각형
            for (int i = 0; i < 5; i++)                               // i(행)가 1일때 z(*)도 1번
            {

                for (int j = 0; j < 4 - i; j++)                       //j(공백) 4번 쓰고 z(*) 1번
                {                                                     //j(공백) 3번 쓰고 z(*) 2번
                    Console.Write(" ");                               //j(공백) 2번 쓰고 z(*) 3번
                }                                                     //j(공백) 1번 쓰고 z(*) 4번
                for (int z = 0; z <= i; z++)                          //j(공백) 0번 쓰고 z(*) 5번
                {                                                     
                    Console.Write("*");                               
                }                                                     
                Console.WriteLine();                                  
            }                                                         
            Console.WriteLine();                                      
                                                                      
                       // 3번 삼각형
                       //기본문장! 별하나 출력
                       //별 하나 찍고 반복문
                       // 행이 바뀔때마다 별이 하나씩 줄어든다



            for (int i = 5; i >= 1; i--)               //i = 5 일때 i 가 1보다 크커나 같으면 다음 for문 으로
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");     
                }
                Console.WriteLine();        // 공백 한 줄
            }

            Console.WriteLine();

            // 4번 삼각형
            // 행이 반복 될때마다 공백이 늘고 별은 줄어들게
            for (int i = 0; i < 5; i++)  
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int z = 0; z < 5 - i; z++) // 하나씩 감소 하게 하기위해 - i
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

