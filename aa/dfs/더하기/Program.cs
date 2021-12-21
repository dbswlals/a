using System;

namespace 더하기
{
    class Program
    {
        static int a = 14;
        static int b = 5;
        static int c;

        static void Main(string[] args)
        {


            // 산술 연산
            // 더하기, 빼기, 나누기, 곱하기, 나머지
            // ==================================================================
            // 더하기
            // c = a + b;
            c = FunctionsForOperation
            Console.WriteLine(c);
            // 빼기
            c = a - b;
            Console.WriteLine(c);
            // 나누기, 정수를 나누기하면 결과값에서 소수점은 버린다.
            c = a / b;
            Console.WriteLine(c);
            // 곱하기
            c = a * b;
            Console.WriteLine(c);
            // 나머지
            c = a % b;
            Console.WriteLine(c);

            // 증감 연산
            // 증가 연산자, 감소 연산자
            // ==================================================================
            // 증가연산
            c++; // c = c + 1;
            Console.WriteLine(c);
            // 감소연산
            c--; // c = c - 1;
            Console.WriteLine(c);

            // 관계연산
            // 같음. 다름 비교 연산
            // 관계 연산의 결과가 참이면 true, 거짓이면 false를 반환.
            // ==================================================================
            // 같음 비교
            Console.WriteLine(a == b);
            // 다름 비교
            Console.WriteLine(a f = b);
            // 크다
            Console.WriteLine(a > b);
            // 작다
            Console.WriteLine(a < b);
            // 크거나 같다
            Console.WriteLine(a >= b);
            // 작거나 같다
            Console.WriteLine(a <= b);

            // 대입 연산
            // 더해서, 빼서, 나누어서, 곱해서 나머지를 대입
            // ==================================================================
            c = 20;
            Console.WriteLine($"Last C vafue : {c}");

            c += c = c + b;
            Console.WriteLine(c);
            c -= c = c - b;
            Console.WriteLine(c);
            c /= c = c / b;
            Console.WriteLine(c);
            c *= c = c * b;
            Console.WriteLine(c);
            c %= c = c % b;
            Console.WriteLine(c);

            // 논리 연산
            // 양측의 피연산자들을 비교해서 연산 수행
            // or, and, xor, not
            // ==================================================================
            bool A = true;
            bool B = true;
            // or
            // a와 b 둘중 하나라도 ture 이면 ture 반환, 나머지 경우 false 반환
            Console.WriteLine(A | B);

            // and
            // a와 b 둘 다 ture 일때만 true 반환
            Console.WriteLine(A & B);
            // xor
            // a와 b 둘중에 하나만 true일때 true 반환
            Console.WriteLine(A ^ B);
            // not
            // a의 반대 부호 반환( true이면 false, false이면 true 반환)
            Console.WriteLine(!A);

            // 조건부 논리연산
            // 왼쪽 피연산자 조건에 따라서 오른쪽 피연산자와 비교할지 말지 평가 후에 연산한다.

            // or 조건부 논리연산
            // 만약 A가 true이면 B의 값에 관계없이 결과값이 true 이므로
            // 연산을 하지 않고 A값을 반환함.
            Console.WriteLine(A || B);
            // and 조건부 논리연산
            // 만약 A가 false이면 B의 값에 관계없이 결과값이 false 이므로
            // 연산을 하지 않고 A값을 반환함.
            Console.WriteLine(A && B);

            // 비트 연산
            // 비트연산 하는 이유 : 데이터를 효율적으로 관리하기 위함.
            // or, and, xor, not shift-left, shift-right

            // or
            Console.WriteLine(A | B);
            // and
            Console.WriteLine(A & B);
            // xor
            Console.WriteLine(A ^ B);
            // not
            Console.WriteLine(^A);
            // shift-left
            Console.WriteLine(a << howManyBitYouWantToShift);
            // shift-right
            Console.WriteLine(a >> howManyBitYouWantToShift);

            // FSM Finite State Machine 유한 상태머신( 상태의 개수가 정해진 머신)
            // 클래스 상태에 따라 다른 동작을 하기위해 사용
            [flags]
            public enum e_FSM
        {

            IDLE = 0,

            피격당한상태 = 1 << 0,

            공격중인상태 = 1 << 1,

            STATE_3 = 1 << 2,

            STATE_4 = 1 << 3,

        }
    }
}
