using System.Runtime.InteropServices;

namespace _250311_김영근
    /*다양한 데이터 타입과 변수를 사용해 자신에 대한 데이터를 콘솔에 출력하시오


[실수] 키(cm 기준)
[문자열, 개행 적용]
간단한 자기소개*/
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] name = new string[1]; 
            int[] age = new int[1];
            float[] height = new float[1];
            string[] self = new string[1];

            name[0] = "김영근";
            age[0] = 32;
            height[0] = 165;
            self[0] = "이것은 나의 개발자로써의 첫 선언문 입니다.\r\n\r\n그저 하고싶은거 잘하는거를 모른체 살아 왔습니다\r\n하지만 좋아하는건 있었습니다 바로'게임'\r\n\r\n하고 싶은거도 모르고 잘하는것도 모를땐 좋아하는걸 해보자 생각했습니다\r\n제가 좋아하던 게임을 다른사람들도 좋아하게 되는 게임을 만드는\r\n게임 개발자로써 열심히 나아가 보려 합니다\r\n\r\n훗날 이글을 다시 볼 미래의 내 자신에게 절대 부끄럽지 안도록 열심히 공부 하겠습니다.";

            for (int i = 0; i < name.Length; i ++) 
            {
                Console.WriteLine(name[i] + "입니다 \n나이는 " + age[i] + "세입니다. \n키는" + height[i] + "이고 \n " + self[i]);
            }
        }
    }
}
