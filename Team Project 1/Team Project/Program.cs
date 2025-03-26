//namespace Team_Project
///* 팀원 프로파일링
//1. 5인 1조로 서로 자기소개와 얘기를 주고받도록 한다
//2. 서로 궁금한점을 물어보며 프로파일링
//3. 주고받은 내용을 기준으로 개인정보(인적사항)을 프로그램에서
//표현할수 잇는 자료형으로 작성
//4. 프로파일링 한 내용을 토대로 콘솔로 출력


//이형원 28 165.4 intj 저번에 마이크 안됬음 언니 여동생 
//우수연 29 169.5 entp 남동생  
//홍성대 21 169   INTP 대학 안다니고 누나 둘 쌍둥이 여동생
//김영근 32  ?   intj  남동생 소방관 5년 만난 12살 연상 예비 배우자
//정혜성 27 180  intp  게임개발을 위해 3개월 전부터 시작 
//신희관 34 190  intp  모바일 관심이 있어 코딩 시작 게임에도 관심 VR쪽에도 관심  형제x
//*/

//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] name = new string[6];
            
//            string[] mbti = new string[6];
//            int[] age = new int[6];
//            string[] height = new string[6];
//            string[] TMI = new string[6];


//            name[0] = "김영근";
//            name[1] = "이형원";
//            name[2] = "우수연";
//            name[3] = "홍성대";
//            name[4] = "정혜성";
//            name[5] = "신희관";

//            mbti[0] = "intj"; // intj
//            mbti[1] = "intj"; // intj
//            mbti[2] = "entp"; // entp
//            mbti[3] = "INTP"; // INTP
//            mbti[4] = "intp"; // intp
//            mbti[5] = "intp"; // intp

//            age[0] = 32;// 32
//            age[1] = 28; // 28
//            age[2] = 29; // 29
//            age[3] = 21; // 21
//            age[4] = 27; // 27
//            age[5] = 34; // 34

//            height[0] = "?"; // ?
//            height[1] = "165.4cm"; // 165.4cm
//            height[2] = "169.5cm"; // 169.5cm
//            height[3] = "169cm"; // 169cm
//            height[4] = "180cm"; // 180cm
//            height[5] = "190cm"; // 190cm

//            TMI[0] = "남동생 소방관 5년 만난 12살 연상 예비 배우자와 곧 결혼을 약속 하였습니다"; // 남동생 소방관 5년 만난 12살 연상 예비 배우자
//            TMI[1] = "저번에 마이크 안됬음 언니 여동생"; // 저번에 마이크 안됬음 언니 여동생
//            TMI[2] = "남동생 있음"; // 남동생 있음
//            TMI[3] = "대학 안다니고 누나 둘 쌍둥이 여동생"; // 대학 안다니고 누나 둘 쌍둥이 여동생
//            TMI[4] = "게임개발을 위해 따로 공부 3개월 전부터 시작"; // 게임개발을 위해 따로 공부 3개월 전부터 시작
//            TMI[5] = "모바일 관심이 있어 코딩 시작 게임에도 관심 VR쪽에도 관심 형제x"; // 모바일 관심이 있어 코딩 시작 게임에도 관심 VR쪽에도 관심 형제x

//            for (int i = 0; i < name.Length; i++)
//            {
//                Console.WriteLine(name[i] + "님의 나이는 " + age[i] + "세입니다. \n키는" + height[i] + "이고 \nMBTI는 " + mbti[i] + " 입니다.\n" + TMI[i]);
//            }
           



//        }
//    }
//}
