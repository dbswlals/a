using System;

// enum (enumerated type ) 열거형
// enum 의 기본요소는 모두 int 형
enum e_PlayerState
{
    IDLE, // ...00000000
    ATTACK, // ...00000001
    JUMP, // ...00000010
    WALK, // ...00000011
    RUN, // ...00000100
    DASH, // ...00000101
    HOME // ...00000110
}
// 비트단위의 열거형을 쓰는 이유 : 
// enum 은 요소간의 겹치지 않은것이 전제
// 열거형은 필요한데 요소간의 중복이 필요한 경우 비트 단위의 열거형을 씀
[Flags] // Flags attiribute (속성) enum 정의 요소자체에 영향을 끼치지 않음
        // 단지 ToString() 속성을 참조할때 중복되는 요소들에 대해 모든 요소표현 가능
enum e_PlayerStateFlags
{
    IDLE = 0, // ...00000000
    ATTACK = 1 << 0, // ...00000001
    JUMP = 1 << 1, // ...00000010
    WALK = 1 << 2, // ...00000100
    RUN = 1 << 3, // ...00001000
    DASH = 1 << 4, // ...000100000
    HOME = 1<< 5,  // ...00100000
    JUMP_ATTACK = JUMP | ATTACK, // ...00000011
}

namespace _Enum
{
    class Program
    {
        
        static bool doAttack;
        static bool doJump;
        static bool doWalk;
        static bool doRun;
        static bool doDash;
        static bool doHome;

        static e_PlayerState createMotion = e_PlayerState.DASH;
        static void main(string[] args)
        {
            // Switch-case 분기문
            // if 처럼 참/거짓에 따라 분기하지 않고
            // 변수의 값에 따라 분기하는 분기문
            /*switch (조건변수)
            {
                case 조건1:
                    break;
                case 조건2:
                    break;
                case 조건3:
                    break;
                default:
                    // 어느경우도 해당되지 않을 경우
                    break;
            }*/

            // string case 예시
            Console.WriteLine("검색할 캐릭터의 이름을 입력하세요");
            string name = Console.ReadLine();
            switch (name)
            {
                case "가렌":
                    Console.WriteLine($"{name} (은)는 챔피언입니다");
                    break;
                case "헤카림":
                    Console.WriteLine($"{name} (은)는 챔피언입니다");
                    break;
                case "티모":
                    Console.WriteLine($"{name} (은)는 챔피언입니다");
                    break;
                default:
                    Console.WriteLine($"{name} (은) 플레이어입니다");
                    break;
            }

            // 전사 생성과 동시에 특정 모션을 취하는 기능
            Warrior warrior1 = new Warrior();
            Console.WriteLine("생성할 전사의 이름을 입력하세요"); // ReadLine 콘솔창의 입력값을 받음
            warrior1.name = Console.ReadLine();
            // if 문에 따라 모션 분기
            if (doAttack)
            {
                warrior1.Attack();
            }
            else if (doJump)
            {
                warrior1.JUMP();
            }
            else if (doWalk)
            {
                warrior1.WALK ();
            }
            else if (doRun)
            {
                warrior1.RUN();
            }
            else
            {
                // DO NOTHING
            }

            switch (createMotion)
            {
                case e_PlayerState.IDLE:
                    break;
                case e_PlayerState.ATTACK:
                    warrior1.Attack();
                    break;
                case e_PlayerState.JUMP:
                    warrior1.JUMP();
                    break;
                case e_PlayerState.WALK:
                    warrior1.WALK();
                    break;
                case e_PlayerState.RUN:
                    warrior1.RUN();
                    break;
                case e_PlayerState.DASH:
                    warrior1.DASH();
                    break;
                case e_PlayerState.HOME:
                    warrior1.HOME();
                    break;
                default:
                    break;
            }

            // 동작 명령
            Console.WriteLine("전사에게 명령을 내려주세요");
            string motionlnput =  Console.ReadLine();
            e_PlayerState motion = (e_PlayerState)Enum.Parse(typeof(e_PlayerState), motionlnput);
            object motionObject;
            bool isParsed = Enum.TryParse(typeof(e_PlayerState), motionlnput, out motionObject);
            motion = (e_PlayerState)motionObject;
            if (isParsed)
            {
                switch (motion)
                {
                    case e_PlayerState.IDLE:
                        break;
                    case e_PlayerState.ATTACK:
                        warrior1.Attack();
                        break;
                    case e_PlayerState.JUMP:
                        warrior1.JUMP();
                        break;
                    case e_PlayerState.WALK:
                        warrior1.WALK();
                        break;
                    case e_PlayerState.RUN:
                        warrior1.RUN();
                        break;
                    case e_PlayerState.DASH:
                        warrior1.DASH();
                        break;
                    case e_PlayerState.HOME:
                        warrior1.HOME();
                        break;
                    default:
                        break;
                }
            }
        }
    }

    class Warrior
    {
        public string name;
        public void Attack()
        {
            Console.WriteLine($"{name}(이)가 공격함");
        }
        public void JUMP()
        {
            Console.WriteLine($"{name}(이)가 점프함");
        }
        public void WALK()
        {
            Console.WriteLine($"{name}(이)가 걸어감");
        }
        public void RUN()
        {
            Console.WriteLine($"{name}(이)가 뛰어감");
        }
        public void DASH()
        {
            Console.WriteLine($"{name}(이)가 급발진함");
        }
        public void HOME()
        {
            Console.WriteLine($"{name}(이)가 집으로 감");
        }
    }
}
