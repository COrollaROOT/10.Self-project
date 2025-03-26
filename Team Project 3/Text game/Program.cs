namespace Text_game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                
                Console.WriteLine("시작하려면 Enter 키를 누르세요. 종료하려면 Q를 입력하세요.");

                string input = Console.ReadLine();
                if (input?.ToUpper() == "Q")
                    break;

                Console.Clear(); // 화면을 지우고 재실행 느낌을 줌


                Console.WriteLine("영근쓰 선택지 게임에 오신걸 환영 합니다.\n");
                Console.Write("당신의 이름을 입력해주세요 : \n");
                string playerName = Console.ReadLine();


                Console.WriteLine($"\n안녕하세요, {playerName} 님!\n");
                Console.WriteLine("\n첫 질문 시작하겠습니다. \n좋아하는 게임 장르는? \n");
                Console.WriteLine("1. 스포츠 게임");
                Console.WriteLine("2. 생존 크레프팅");
                Console.WriteLine("3. FPS");
                Console.WriteLine("4. 액션 & 소울라이크");
                Console.Write("선택 : ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("제가 공이랑은 안 친해요 ㅠ ㅠ 스포츠 게임은 1점 입니다");
                }

                else if (choice == "2")
                {
                    Console.WriteLine("오옷! 저랑 떄려 치우고 같이 집 지으러 가시죠. 제 최애 생존 크레프팅 게임 점수는 1억점 입니다 ");
                }

                else if (choice == "3")
                {
                    Console.WriteLine("밀베에 2분대 떨어짐 무기 파밍후 바로 합류 뭘 쫌 아시네요. 저의 2번째 최애 FPS는 1만점 입니다");
                }

                else if (choice == "4")
                {
                    Console.WriteLine("엘데의 왕이 되었는냐? 왕의 소울을 가졌구나 게임좀 해보신 분이시군요. 액션 & 소울라이크 게임은 100점입니다");
                }

                else
                {
                    Console.WriteLine("다른걸 누르다니 저랑 친해 지기신 글렀네요. 메롱~");
                }




            }
        }
    }
}
