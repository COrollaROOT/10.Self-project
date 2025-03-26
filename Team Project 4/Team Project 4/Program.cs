namespace Team_Project_4
{

    /*
    과제 1. 포켓몬 구현하기 2
    다음 조건에 맞도록 포켓몬에 대한 데이터를 구현하세요.
    포켓몬은 최소 6종류 이상 구현되어야 합니다
    */
    internal class Program
    {

        /*
        모든 포켓몬의 공통 부모 클래스로 동작한다.
        모든 포켓몬은 공통으로 Attack() 이라는 기능을 가지며, 포켓몬마다 다른 공격에 대한 내용을 콘솔에 출력할 수 있어야 한다.
        */
        abstract class Pokemon
        {
            public string Name;
            public string Skill;

            public Pokemon(string Name, string Skill)
            {
                Name = Name;
                Skill = Skill;
            }

            public void Attack()
            {
                Console.WriteLine($"{Name} 이/가 {Skill} 로 공격 합니다.");
            }
        }

            class Phantom : Pokemon
        {
            public Phantom() : base("팬텀", "섀도펀치") { }

            // 이름 팬텀 // 스킬 섀도펀치          

        }

        class Hudin : Pokemon
        {
           
            public Hudin() : base("후딘", "염력") { }
            // 이름 후딘 // 스킬 염력


        }




    

    class Slippers : Pokemon
        {
        public Slippers() : base("슬리퍼", "최면술") { }
        // 슬리퍼
        
            // 스킬 최면술
            
        }

        class Metamong : Pokemon
        {
        public Metamong() : base("메타몽", "변신하기") { }
        // 메타몽
        
            // 스킬 변신하기
            
        }

        class Lijamong : Pokemon
        {
            public Lijamong() : base("리자몽", "불대문자") { }
            // 이름 리자몽
            
            // 스킬 불대문자
            
        }

        class Gyarados : Pokemon
        {
            public Gyarados() : base("갸라도스", "파도타기") { }
            // 이름 갸라도스

            // 스킬 파도타기

        }

        /*
        필드로 포켓몬을 보관할 수 있는 배열을 6의 크기로 가진다
        현재 꺼내져 있는 포켓몬 인스턴스에 대한 참조를 필드로 가진다
        Pick(int index) : 배열 기준으로 입력받은 인덱스(매개변수)에 있는 포켓몬을 '현재 꺼내져 있는 포켓몬을 참조하는 필드'에 대입한다
        Print() : 자신이 가진 모든 모든 포켓몬의 이름을 출력한다
        */
        class Trainer
        {
            private Pokemon[] pokemon = new Pokemon[6];
            
            public Trainer()
            {

                pokemon[0] = new Phantom();
                pokemon[1] = new Hudin();
                pokemon[2] = new Slippers();
                pokemon[3] = new Metamong();
                pokemon[4] = new Lijamong();
                pokemon[5] = new Gyarados();
            }

        }

     


        static void Main(string[] args)
        {
            
            

        }
    }
}
