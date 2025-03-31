namespace Team_Project_8
{

    /* 레퍼런스
    기획안으로 그래프(스킬,맵,등)를 주어졌을때
    그 그래프를 프로그래밍화 시키는 연습을 하자

    A : 출제자, B들 : 풀이자
    1. A : 사이트에서 크래프를 보고 코드로 옮겨적기
    2. B들 : A의 코드를 보고 반대로 그래프로 그리기
    3. A의 그래프 원본과 B의 그린 그래프가 일치 하는지 확인

    - A가 출제하면
    나머지 학생 B들은 풀어서 공유
    */



    internal class Program
    {
        static void Main(string[] args)
        {
            BigGraph grap = new BigGraph();
            grap.ShowNode(0);
            grap.ShowNode(1);
            grap.ShowNode(2);
            grap.ShowNode(3);
            grap.ShowNode(4);
            grap.ShowNode(5);
            grap.ShowNode(6);
            grap.ShowNode(7);

        }
    }

    class BigGraph
    {
        private bool[,] bGraph;
        private int bSize;

        public BigGraph()
        {
            bSize = 8;
            bGraph = new bool[8, 8]
            {
                { false, false,  false, false,  false, false, false, false },
                {  true, false,   true, false,  false,  true,  true, false },
                {  true,  true,  false, false,  false, false, false, false },
                { false, false,  false, false,  false, false, false, false },
                { false, false,  false, false,  false, false,  true, false },
                { false, false,  false, false,  false, false,  true, false },
                { false, false,  false, false,   true, false, false,  true },
                { false, false,  false, false,   true, false, false, false },
            };
            

        }
        public BigGraph(int size)
        {
            bSize = size;
            bGraph = new bool[size, size];
        }

        public void Add(int from, int to)
        {
            bGraph[from, to] = true;
        }

        public void ShowNode(int from)
        {
            Console.WriteLine($"{from} 번 노드의 인접한 노드 : ");
            for (int i = 0; i < bSize; ++i)
            {
                if (bGraph[from, i] == true)
                {
                    Console.WriteLine($"{i} 번 노드");
                }
                
            }
        }
    }
}






// bool[,] matrixGraph = new bool[8, 8]
//             {
//             { false, false,  false, false,  false, false, false, false, },
//             { false, false,  true, false,  false, true, false, false, },
//             { false, true,  false, false,  true, true, false, false, },
//             { false, false,  false, false,  false, false, false, true, },
//             { false, false,  true, false,  false, false, true, true, },
//             { false, true,  true, false,  false, false, true, true, },
//             { false, false,  false, false,  true, true, false, true, },
//             { false, false,  false, true,  true, true, true, false, },
// 
//             };