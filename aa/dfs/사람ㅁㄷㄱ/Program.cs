using System;

namespace 사람ㅁㄷㄱ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        class person
        {
            //bit = 한자리 이진수 (0과1 ,정보처리의 최소단위)
            //byte = 8 bit Cpu 데이터 처리 최소단위
            //4byte = 32bit
            //4byte로 표현할수 있는 숫자의 범위 -> 2의32승
            int age; //정수형 4byte
            float height; // 실수형 4byte
            bool isFemale; //참거짓 1byte
            char genderChar;//문자 하나 2byte
            string name;//문자열 문자 갯수*2byte

            // 입력 -> 함수기능 -> 출력

            void SayAllnfo()
            {
                SayAge();
                SayHeight();
                SaylsFemale();
                SaylsgenderChar();
                SayName();
            }

            void SayAge()
            {
                Console.WriteLine(age);
            }
            void SaylsFemale()
            {
                Console.WriteLine(isFemale);
            }
            void SaylsgenderChar()
            {
                Console.WriteLine(genderChar);
            }
            void SayHeight()
            {
                Console.WriteLine(height);
            }
            void SayName()
            {
                Console.WriteLine(name);
            }
        }
    }
}
