using System;

namespace ssa
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    // camel case
    // class, function, namespace 등은 대문자로 시작한다.
    // 변수는 소문자로 시작한다.
    // 단어가 바뀔때 첫 문자는 대문자로 시작한다.
    // 줄임말은 되도록 사용하지 않는다
    // 이름을 보았을때 어떤 기능이나 목적인지 알 수 있도록 선정한다.
    // 애매하거나 복잡한 내용이 있으면 주석을 달아준다.
   
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

        // 이 사람에 대한 모든 정보를 말한다.

        // 객체선정 : 사람
        // 추상화 : 사람은 나이와, 키와 여자인지 남자인지와 성별문자, 이름이 있다.
        // 클래스화(설계도 제작) : 추상화에서 각 특징과 요소들의 형태를 정의
        // 변수 "나이"는 정수형이다
        // 변수 "키"는 실수형이다
        // 변수 "여자인가?"는 논리형이다
        // 변수 "성별문자"는 문자형이다
        // 변수 "이름"은 문자열형이다
        // 객체화(설계도로 객체를 만든다. 찍어낸다)
    }

}