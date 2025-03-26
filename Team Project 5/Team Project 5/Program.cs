namespace Team_Project_5
{
    /*
    레퍼런스 게임 : 로스트 아크
    게임에서 플레이어가 다양한 물체 앞에서
    상호작용 키를 누르면 앞 대상에 따라서
    다양한 반응을 일으킬 수 있다

    1.NPC 앞에선 대화가 시작
    2.상자 앞에선 아이템 습득
    3.문 앞에선 이동 진행
    +) NPC중 상인 NPC는 상점을 열기
    */

    internal class Program
    {
        public interface IEnterable
        {
            public void Enter();
        }

        public interface IOpenable
        {
            public void Open();
        }

        public interface IMoveable
        {
            public void Move();
        }

        public interface IOutMoveable
        {
            public void OutMove();
        }

        public interface IGetable
        {
            public void Get();
        }

        public interface ITalkable
        {
            public void Talk();
        }

        public class Door : IMoveable, IOpenable, IEnterable, IOutMoveable
        {
            // 문앞에선 이동 진행

            public void Move()
            {
                Console.ReadKey();
                Console.WriteLine("문앞으로 이동합니다.");
            }

            public void Open()
            {
                Console.ReadKey();
                Console.WriteLine("문을 엽니다.");
            }

            public void Enter()
            {
                Console.ReadKey();
                Console.WriteLine("문안으로 들어갑니다.");
            }

            public void OutMove()
            {
                Console.WriteLine(" 다른 지역으로 이동 합니다.");
            }
        }

        public class Box : IMoveable, IOpenable, IGetable
        {
            // 상자 앞에선 아이템 습득
            public void Move()
            {
                Console.ReadKey();
                Console.WriteLine("상자 앞으로 이동합니다.");
            }

            public void Open()
            {
                Console.ReadKey();
                Console.WriteLine("상자를 엽니다.");
            }

            public void Get()
            {
                Console.ReadKey();
                Console.WriteLine("포션을 얻었습니다.");
            }
        }

        public class Npc : IMoveable, ITalkable
        {
            // NPC 앞에선 대화 시작 // 상인 NPC는 상점 열기
            public void Move()
            {
                Console.ReadKey();
                Console.WriteLine("NPC 앞으로 이동합니다.");
            }

            public void Talk()
            {
                Console.ReadKey();
                Console.WriteLine("NPC에게 말을 겁니다.");
            }
        }

        public class Npc2 : IMoveable, ITalkable, IOpenable
        {
            public void Move()
            {
                Console.ReadKey();
                Console.WriteLine("상인 NPC 앞으로 이동합니다.");
            }

            public void Talk()
            {
                Console.ReadKey();
                Console.WriteLine("상인 NPC에게 말을 겁니다.");
            }

            public void Open()
            {
                Console.ReadKey();
                Console.WriteLine("상점을 엽니다.");
            }
        }

        public class Player
        {
            public void Enter(IEnterable enterable)
            {
                enterable.Enter();
            }

            public void Open(IOpenable openable)
            {
                openable.Open();
            }

            public void Move(IMoveable moveable)
            {
                moveable.Move();
            }

            public void OutMove(IOutMoveable outmoveable)
            {
                outmoveable.OutMove();
            }

            public void Talk(ITalkable talkable)
            {
                talkable.Talk();
            }

            public void Get(IGetable getable)
            {
                getable.Get();
            }

        }

        static void Main(string[] args)
        {
            
            // 선택지(선택지 키를 따로 만든다)를 주고 그 앞으로 이동시킨다
            // 특정 키를 눌러 상호작용한다 

            Player player = new Player();
            Door door = new Door();
            Box box = new Box();
            Npc npc = new Npc();
            Npc2 npc2 = new Npc2();

            player.Move(door);
            player.Open(door);
            player.Enter(door);
            player.OutMove(door);

            player.Move(box);
            player.Open(box);
            player.Get(box);

            player.Move(npc);
            player.Talk(npc);

            player.Move(npc2);
            player.Talk(npc2);
            player.Open(npc2);











        }
    }
}
