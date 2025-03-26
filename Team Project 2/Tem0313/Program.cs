using System.Diagnostics.CodeAnalysis;

namespace Tem0313
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //다수의 입력을 받아 연산하는 기능 구현
            //사용자로 부터 정수를 연속해서 입력 받아 수를 더 하는 기능 구현
            //


            Console.WriteLine("두 수 사이의 합을 구합니다. 시작할 작은 수를 입력해주세요");
            // 두 정수가 필요
            int num1; //정수 먼저 정의
            int num2;
            int pul = 0;
           // 반복문 활용
            while (true) // 값이 참 일때 진행 / 거짓 일때 다시 반복
            {
                string input1 = Console.ReadLine(); // 시작할 수 입력 받기(Console.ReadLine();) = string input1
                if (int.TryParse(input1, out num1)) // 입력받은 문자열(string input1)을 정수로 전환
                {
                    break; // 가장 가까운 반목문 종료

                }
                Console.WriteLine("숫자가 아닌 값입니다.다시 입력해주세요."); // 거짓된 값을 쓰면 출력

            }
            Console.WriteLine("끝 수를 입력해 주세요."); // 값이 참일때 반복하지 않고 진행

            while (true) 
            {
                string input2 = Console.ReadLine(); // 끝수 입력 받기(Console.ReadLine();) = string input2
                if (int.TryParse(input2, out num2)) // 입력받은 문자열(string input2)을 정수로 전환
                {
                    break;
                }
                Console.WriteLine("숫자가 아닌 값입니다.다시 입력해주세요.");
            }

            // 두 정수의 정보를 토대로 반복문을 통하여 시작부터 끝 수 까지 합을 임의 변수에 저장
            for (int i = num1; i <= num2; i++)
            {
                pul += i; // 두수의 사이의 합친 값
            }

            // 반복문이 끝난 후 "n1과 n2 사이 숫자의 합은 n3입니다" 출력
            Console.WriteLine($"{num1}과 {num2} 사이 숫자의 합은 {pul}입니다.");





        }
    }
}
