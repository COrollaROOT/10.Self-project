namespace Team_Project_11
{
    /*
        레퍼런스 : 디자인 패턴 구현 실습

        - 팩토리 패턴 -
            객체를 생성하는 책임 - 객체 공장에서 생성후 필요한곳에 반환
            객체 생성시 한곳에서 선언 - 다른곳에선 재사용만 

        WeaponFactory 제작
        1. 무기는 이름, 공격력,공격범위
        2. 팩토리를 통해서 무기 생성을 진행하는 경우
        (1) 철검,나무창,돌도끼
        +) 무기 팩토리에 희귀도를 추가하여 제작할 수 있도록 구현
        (1) 일반등급 : +0%, 희귀등급 : +10%, 전설등급 : +20%

        - 빌더 패턴 -
            객체 생성 과정과 표현 방법을 분리
            다른 결과물 또는 복잡한 객체를 생성할때 사용

        AnimalBulilder 제작
        1. 동물의 이름, 생산품, 울음소리, 사료종류를 조합
        2. 여러 종류의 동물을 구현할 수 있도록 빌더를 제작
        (1) 양, 소, 닭
        +) 희귀종 동물 구현
        (1) 희귀종 동물은 특수 생산품으로 구현
    */

    internal class Program
    {
        //        static void Main(string[] args)
        //        {
        //            // 무기제작
        //            WeaponFactory weaponFactory = new WeaponFactory();
        //
        //            Console.WriteLine("제작할 무기를 입력 해주세요 : ");
        //            
        //            Console.ReadLine();
        //
        //            Console.WriteLine($"{0} 이/가 제작되었습니다.", weaponFactory);
        //            
        //        }
        //
        //
        //    }
        //
        //    // 팩토리를 사용하여 무기 생성 : 철검,나무창,쇠도끼
        //    public class WeaponFactory // 
        //    {
        //        public Weapon Crafting(string name) // 무기 제작
        //        {
        //            // 뭐로 만들지 지정
        //            switch (name) // 이름을 주면 이름에 맞는 무기 제작 // 10% 확률로 희귀등급 20%확률로 전설등급
        //            {
        //                case "철검": return new Weapon("철검", 100f, 100);
        //                case "돌도끼": return new Weapon("돌도끼", 80f, 50);
        //                case "나무창": return new Weapon("나무창", 50f, 200);
        //                case "희귀 철검": return new Weapon("희귀 철검", 100 * 1.5f, 100);
        //                case "희귀 돌도끼": return new Weapon("희귀 돌도끼", 100 * 1.5f, 50);
        //                case "희귀 나무창": return new Weapon("희귀 나무창", 100 * 1.5f, 200);
        //                case "전설 철검": return new Weapon("전설 철검", 100 * 2.5f, 100);
        //                case "전설 돌도끼": return new Weapon("전설 돌도끼", 100 * 2.5f, 50);
        //                case "전설 나무창": return new Weapon("전설 나무창", 100 * 2.5f, 200);
        //
        //            }
        //            // 위에 없는 이름 입력시 만들수 없다
        //            Console.WriteLine("!!제작 불가!!");
        //            return null; // 없는걸로 반환
        //
        //        }
        //    }
        //        public class Weapon // 무기 클래스 선언 : 이름, 공격력,공격범위
        //        {
        //            public string name; // 프로퍼티 생성
        //            public float pow;
        //            public int powrange;
        //
        //            public Weapon(string name, float pow, int powrange) // 생성자 초기화
        //            {
        //                this.name = name;
        //                this.pow = pow;
        //                this.powrange = powrange;
        //            }

        static void Main(string[] args)
        {
            AnimalBuilder sheepBuilder = new AnimalBuilder();
            sheepBuilder
                .SetName("양")
                .SetSound("메~~~에~~~엥~~~")
                .SetProducts("양털")
                .SetFeed("짚");

            Animal sheep = sheepBuilder.Build();
            Console.WriteLine("알고 싶은 동물의 이름을 입력해 주세요 : ");
            Console.ReadLine($"{}");
            Console.WriteLine("이름 : {0}\n울음 소리 : {1}\n소재 : {2}\n먹이 : {3}", sheep.name, sheep.sound, sheep.products, sheep.feed);
            Console.WriteLine("요청하신 해당 동물의 정보 입니다");
        }

        public class AnimalBuilder
        {
            public string name;
            public string sound;
            public string products;
            public string feed;

            public AnimalBuilder()
            {
                name = "동물이름";
                sound = "울음소리";
                products = "소재";
                feed = "먹이";
            }

            public Animal Build()
            {
                Animal animal = new Animal();
                animal.name = name;
                animal.sound = sound;
                animal.products = products;
                animal.feed = feed;

                return animal;

            }

            public AnimalBuilder SetName(string name)
            {
                this.name = name;
                return this;
            }

            public AnimalBuilder SetSound(string sound)
            {
                this.sound = sound;
                return this;
            }

            public AnimalBuilder SetProducts(string products)
            {
                this.products = products;
                return this;
            }

            public AnimalBuilder SetFeed(string feed)
            {
                this.feed = feed;
                return this;
            }
        }

        public class Animal
        {
            public string name;
            public string sound;
            public string products;
            public string feed;
        }
    }
}

