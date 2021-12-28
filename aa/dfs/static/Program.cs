/*using System;

namespace 스태틱틱 
    class Program
{
    static void Main(string[] args)
    {
        Orc orc1 = new Orc();
        orc1.name = "오크";
        orc1.height = 240.0f;

        Orc.typeName = "오크 타입 설계도";
        Orc.SayTypename();

        // static 멤버(변수와 지수)는 객체 단위로 접근할 수가 없다
        // 
    }
    class Orc

    // 접근제한자
    // 위치 : 자료형 말
    // 아무것도 안써있으면 기본적으로 private
    // public, private, protected
    // public : 다른 클래스에서 접근 가능하다.
    // private : 다른 클래스에서 접근이 불가능하다.
    // protected : 상속자만 접근 가능
    {
        public int age;
        public float height;
        public bool isResting;
        public char genderChar;
        public string name;
        public float Welght;

        static public string typeName;

        static public string SayTypename;

        // static
        public void Smach()
        {
            Console.WriteLine($"{name} (이)가 휘둘렀다");
        }
        public void Jump()
        {
            Console.WriteLine($"{name} (이)가 점프했다");
        }
    }

    static class Person
    {
        // static class를 쓰는 이유 : 
        // 객체를 찍어내는 것이 아니라 정보, 기능, 개념 등이 유일하게 필요한 경우 사용
        //
    }
}
}*/
