namespace Team_Project_9
{
    /*
    레퍼런스 : 게임에 필요한 알고리즘 구현 상황
    1. 5가지 정렬 알고리즘의 컨셉 & 동작 방법 분석
    2. 슈도코드 또는 플로우 차트 형태로 설계
    3. 설계를 한 내용을 토대로 코드 작성 진행
    4. 원하는대로 동작하지 않는다면, 다시 원인 분석

    알고리즘 설계 5단계를 반복 하면서 5가지 정렬 알고리즘 구현
    (소스코드 참고 X - 알고리즘 설계 및 구현 능력 키우기)
    */
    internal class Program
    {

        // 버블 정렬 (Bubble Sort)
        // 두 개의 인접한 원소를 비교하여 작은 값을 안쪽으로 큰 값을 뒤쪽으로 교환하는 정렬

        // 반복이 기본이기 때문에 반목문 사용
        // 반복문 for (begin, condition, step) { body }
        // begin : 반목문 진입할 때 단 한번 실행 int i = 0
        // condition : 반복마다 해당 조건 확인. false, 즉 거짓이면 반복문 중지 i < len
        // step : 각 반복의 body가 실행된 이후 실행 i++
        // body : condition이 true인 동안 계속해서 실행됩니다.

        static void BubbleSort(int[] array) // 버블 정렬 선언
        {
            int len = array.Length; // 배열의 길이 선언
            for (int i = 0; i < len; i++) // 배열의 길이 만큼 반복(i) - 앞에서 한칸씩 뒤로 이동
            {
                for (int j = 0; j < len - i - 1; ) // 배열 길이 - i - 1 만큼 반복(j) - 뒤에서 한칸씩 앞으로 이동
                {

                }
            }
        }



        static void Main(string[] args)
        {
            // 한 교실에 학생들을 키순으로 자리 배치 
        }
    }
}
