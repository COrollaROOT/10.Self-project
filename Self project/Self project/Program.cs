using System;

namespace Self_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕하십니까!! 미래의 최첨단 AI 계산기를 실행 합니다.\n");
            // 첫번째 숫자 입력
            Console.WriteLine("계산 하고 싶으신 숫자를 입력 해주세요.");
            string input = Console.ReadLine();




            int num1;
            int num2;

            bool success = int.TryParse(input, out num1);



            if (success)
            {
                num1 = (int.Parse(input));
                Console.WriteLine("\n입력하신 첫 번째 수는 : {0} 이시군요 와우~~~~!!!", num1);
                // 두번째 숫자 입력
                Console.WriteLine("\n두번째 숫자를 입력 해주세요");

            }

            else
            {
                Console.WriteLine("잘못된 값을 입력하셨습니다.\n다른 최첨단 AI 와 함께 돌아오겠습니다.");
                Environment.Exit(0);
            }

            string input2 = Console.ReadLine();
            


            // 두 번째 숫자가 0이면 프로그램 종료
            if (input2 == "0")
            {
                Console.WriteLine("두 번째 숫자가 0입니다. 0으론 나눌 수 없습니다.\n다른 최첨단 AI 와 함께 돌아오겠습니다.");
                Environment.Exit(0);
            }
            bool success2 = int.TryParse(input2, out num2);
            if (success2)
            {
                num2 = (int.Parse(input2));
                Console.WriteLine("\n입력하신 두번째 수는 : {0} 입니다.\n\n탁월한 선택 이십니다.", num2);
                Console.WriteLine("\n이제 계산 하기위해 다음중 원하는 부호를 입력 하십시오\n");
                Console.WriteLine("\n1. + ");
                Console.WriteLine("\n2. - ");
                Console.WriteLine("\n3. * ");
                Console.WriteLine("\n4. / ");
                Console.WriteLine("\n5. % ");

            }

            else
            {
                Console.WriteLine("잘못된 값을 입력하셨습니다.\n다른 최첨단 AI 와 함께 돌아오겠습니다.");
                
            }
           

            string choice = Console.ReadLine();

          //  int result;
          //
          //  switch (choice)
          //  {
          //      case +:
          //          result = num1 + num2;
          //          Console.WriteLine("서로 친근하게 더해진 값은 {0} 입니다.", result);
          //          break;
          //      case -:
          //          result = num1 - num2;
          //          Console.WriteLine("서로 미워하게 되서 빠진 값은 {0} 입니다.", result);
          //          break;
          //      case :
          //          result = num1 num2;
          //          Console.WriteLine("서로 사랑하여 곱해진 값은 {0} 입니다.", result);
          //          break;
          //      case /:
          //          result = num1 / num2;
          //          Console.WriteLine("서로 증오하게 나누어진 값은 {0} 입니다.", result);
          //          break;
          //      case %:
          //          result = num1 % num2;
          //          Console.WriteLine("서로의 사랑의 나머지 흔적 값은 {0} 입니다.", result);
          //          break;
          //  }
                    int result = num1 + num2;
                    int result2 = num1 - num2;
                    int result3 = num1 * num2;
                    int result4 = num1 / num2;
                    int result5 = num1 % num2;
            
                    // 연산자에 맞는 출력값
                    if (choice == "+")
                    {
                        Console.WriteLine("서로 친근하게 더해진 값은 {0} 입니다.", result);
                    }
            
                    if (choice == "-")
                    {
                        Console.WriteLine("서로 미워하게 되서 빠진 값은 {0} 입니다.", result2);
                    }
            
                    if (choice == "*")
                    {
                        Console.WriteLine("서로 사랑하여 곱해진 값은 {0} 입니다.", result3);
                    }
            
                    if (choice == "/")
                    {
                        Console.WriteLine("서로 증오하게며 나누어진 값은 {0} 입니다.", result4);
                        
                    }
            
                    if (choice == "%")
                    {
                        Console.WriteLine("서로의 사랑의 나머지 흔적 값은 {0} 입니다.", result5);
                        
                    }




        }
    }
}



// using System;
// 
// namespace Self_project
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("안녕하십니까!! 미래의 최첨단 AI 계산기를 실행합니다.\n");
// 
//             // 첫 번째 숫자 입력
//             Console.Write("첫 번째 숫자를 입력하세요: ");
//             if (!int.TryParse(Console.ReadLine(), out int num1))
//             {
//                 Console.WriteLine("잘못된 값을 입력하셨습니다.\n다른 최첨단 AI와 함께 돌아오겠습니다.");
//                 return;
//             }
// 
//             // 두 번째 숫자 입력
//             Console.Write("두 번째 숫자를 입력하세요: ");
//             if (!int.TryParse(Console.ReadLine(), out int num2))
//             {
//                 Console.WriteLine("잘못된 값을 입력하셨습니다.\n다른 최첨단 AI와 함께 돌아오겠습니다.");
//                 return;
//             }
// 
//             // 연산자 입력
//             Console.WriteLine("\n이제 계산하기 위해 다음 중 원하는 부호를 입력하십시오:");
//             Console.WriteLine("+ : 더하기");
//             Console.WriteLine("- : 빼기");
//             Console.WriteLine("* : 곱하기");
//             Console.WriteLine("/ : 나누기");
//             Console.WriteLine("% : 나머지 연산");
//             Console.Write("연산자를 입력하세요: ");
//             string choice = Console.ReadLine();
// 
//             int result = 0;
//             bool validOperation = true;
// 
//             switch (choice)
//             {
//                 case "+":
//                     result = num1 + num2;
//                     Console.WriteLine("서로 친근하게 더해진 값은 {0} 입니다.", result);
//                     break;
// 
//                 case "-":
//                     result = num1 - num2;
//                     Console.WriteLine("서로 미워하게 되서 빠진 값은 {0} 입니다.", result);
//                     break;
// 
//                 case "*":
//                     result = num1 * num2;
//                     Console.WriteLine("서로 사랑하여 곱해진 값은 {0} 입니다.", result);
//                     break;
// 
//                 case "/":
//                     if (num2 == 0)
//                     {
//                         Console.WriteLine("두 번째 숫자가 0입니다. 0으로 나눌 수 없습니다.");
//                         validOperation = false;
//                     }
//                     else
//                     {
//                         double divisionResult = (double)num1 / num2;
//                         Console.WriteLine("서로 증오하게 나누어진 값은 {0} 입니다.", divisionResult);
//                     }
//                     break;
// 
//                 case "%":
//                     if (num2 == 0)
//                     {
//                         Console.WriteLine("두 번째 숫자가 0입니다. 0으로 나머지 연산을 할 수 없습니다.");
//                         validOperation = false;
//                     }
//                     else
//                     {
//                         result = num1 % num2;
//                         Console.WriteLine("서로의 사랑의 나머지 흔적 값은 {0} 입니다.", result);
//                     }
//                     break;
// 
//                 default:
//                     Console.WriteLine("잘못된 연산자를 입력하셨습니다.\n다른 최첨단 AI와 함께 돌아오겠습니다.");
//                     validOperation = false;
//                     break;
//             }
// 
//             // 프로그램 종료 메시지
//             if (validOperation)
//             {
//                 Console.WriteLine("\n계산이 완료되었습니다. 최첨단 AI 계산기와 함께 해주셔서 감사합니다.");
//             }
//         }
//     }
// }