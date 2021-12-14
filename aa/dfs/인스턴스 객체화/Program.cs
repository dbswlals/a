using System;

namespace 인스턴스_객체화
{
    class Program
    {
        static void Main(string[] args)
        {
            person person1 = new person();
            // . 점연산자
            // 클래스의 멤버에 접근할때 사용, namespace 안의 클래스에 접근할때 사용.
            person1.age = 80; // 정수형은 그냥 숫자 입력
            person1.height = 123.4f; // 실수형ㅇㄴ 숫자 뒤에 f 추가 입력
            person1.isFemale = false; // 논리형은 true 또는 false
            person1.genderChar = '여'; // 문자형은 ' 작은 따옴표 안에 단일 문자
            person1.name = "김아무개"; // 문자열형은 " 큰 따음표 안에 다중문자
            person1.SayAllnfo();
        }
    }
    class person
    {
        // 접근제한자
        // 위치 : 자료형 말
        // 아무것도 안써있으면 기본적으로 private
        // public, private, protected
        // public : 다른 클래스에서 접근 가능하다.
        // private : 다른 클래스에서 접근이 불가능하다.
        // protected : 상속자만 접근 가능

        //bit = 한자리 이진수 (0과1 ,정보처리의 최소단위)
        //byte = 8 bit Cpu 데이터 처리 최소단위
        //4byte = 32bit
        //4byte로 표현할수 있는 숫자의 범위 -> 2의32승
        public int age; //정수형 4byte
        public float height; // 실수형 4byte
        public bool isFemale; //참거짓 1byte
        public char genderChar;//문자 하나 2byte
        public string name;//문자열 문자 갯수*2byte

        // 입력 -> 함수기능 -> 출력

        public void SayAllnfo()
        {
            SayAge();
            SayHeight();
            SaylsFemale();
            SaylsgenderChar();
            SayName();
        }

        public void SayAge()
        {
            Console.WriteLine(age);
        }
        public void SaylsFemale()
        {
            Console.WriteLine(isFemale);
        }
        public void SaylsgenderChar()
        {
            Console.WriteLine(genderChar);
        }
        public void SayHeight()
        {
            Console.WriteLine(height);
        }
        public void SayName()
        {
            Console.WriteLine(name);
        }
    }
}
