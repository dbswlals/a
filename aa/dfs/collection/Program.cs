
            using System;

            using System.Collections.Generic;



// Collection 은 동적배열이라고도 함.  

            // Array 와 다르게 크기를 정해놓지않고  

            // Collection 단어 뜻대로 수집하듯이  

            // 아이템들을 추가하거나 뺄 수 있으며, 그에따라 데이터 크기가 유동적으로 변한다. 

    namespace UnityLesson_CSharp_Collection

    {

        class Program

        {

            static void Main(string[] args)

            {
                //-------------------------------- 
                // List  
                //-------------------------------- 

                List<int> _list = new List<int>();
                _list.Add(3);
                _list.Add(2);
                _list.Add(1);
                _list.Add(0);
                _list.Add(3);


                // 0번째 인덱스부터 탐색하고 , 첫번째로 인자와 같은 요소를 발견하면 삭제. 
                // 삭제 성공시 true 반환, 인자와 같은 요소를 못찾으면 false 반환. 

                _list.Remove(3);

                int length = _list.Count;

                for (int i = 0; i < length; i++)
                {
                    int tmpNumber = _list[i];
                    Console.WriteLine(tmpNumber);
                }

                // foreach 는 collection 이 가지고있는 타입의 아이템만큼 반복문을 실행하면서 각 아이템을 반환해준다. 

                foreach (int num in _list)
                {
                    Console.WriteLine(num);
                }

                //-------------------------------- 
                // Dictionary 
                //-------------------------------- 

                Dictionary<string, string> _dic = new Dictionary<string, string>();
                _dic.Add("검사", "양손대검을 사용하여 물리공격을 하는 클래스");
                _dic.Add("마법사", "지팡이를 사용하여 마법공격을 하는 클래스");
                _dic.Add("수호자", "창과 방패를 사용하여 물리공격 및 방어 위주의 클래스");
                _dic.Remove("검사");

                bool isSwordMasterExist = _dic.ContainsKey("검사");
                if (isSwordMasterExist)
                {
                    string tmpValue = _dic["검사"];
                    Console.WriteLine($"검사: {tmpValue}");
                }

                else
                {
                    Console.WriteLine("검사를 찾을 수 없습니다");
                }


                // dictionary 도 foreach 구문이 가능하다. 
                // dictionary 도 collection 이고 
                // dictionary 의 key , value 도 각각 collection 이다.  
                // 즉 , dictionary 자체도 foreach 문이 가능하고, key, value 도 각각 foreach 구문이 가능하다.
                // 아래 세가지 예시 : 


                // dictionary 의 key 값 을 foreach 문을 통해 반복문 실행 

                foreach (string sub in _dic.Keys)
                {
                    string tmpValue = _dic[sub];
                    Console.WriteLine($"{sub} : {tmpValue}");
                }

                // dictionary 의 value 값 을 foreach 문을 통해 반복문 실행 

                foreach (string sub in _dic.Values)
                {
                    Console.WriteLine(sub);
                }

                // dictionary를 foreach 문을 통해 반복문 실행 

                foreach (KeyValuePair<string, string> sub in _dic)

                {
                    string tmpKey = sub.Key;
                    string tmpValue = sub.Value;
                    Console.WriteLine($"{tmpKey} : {tmpValue}");
                }

                // 위 세가지 경우가 있지만,  
                // dictionary 는 단어 뜻대로 사전 처럼 사용하기 위한 collection 이다. 
                // 우리가 사전을 찾을때 ,  
                // 단어를 먼저 찾고 거기에 따라 단어의 뜻을 찾는다.  
                // dictionary 에서 key 는 단어, value 는 단어의 뜻과 같은 역할이다. 
                // 따라서 foreach 문을 사용해서 접근할때도, 
                // dictionary 의 key 로 반복문을 통해 접근하는 경우가 대부분이지,  
                // value 나 dictionary 자체로 접근하는 경우는 잘 없다.  
                // 마치 '사과' 라는 단어를 검색하면 '사과나무에서 열리는 열매' 라는 뜻을 찾는것이지 
                // '사과나무에서 열리는 열매' 를 검색해서 '사과'를 찾거나 
                // '사과 : 사과나무에서 열리는 열매' 자체를 검색하지 않는것과 같다고 생각하면 된다.  



                //-------------------------------- 
                // Queue   ( List와 비슷하나, FIFO, First lnput, First Ouput 체계이다 )
                //-------------------------------- 
                Queue<int> _queue = new Queue<int>();

                _queue.Enqueue(10);
                _queue.Enqueue(20);
                _queue.Enqueue(30);


            Console.WriteLine(_queue.Peek()); // 가장 첫번째에 있는 값을 반환
            Console.WriteLine(_queue.Dequeue()); // Queue의 가장 첫번째에 있는 값을 반환
            Console.WriteLine(_queue.Dequeue());
            Console.WriteLine(_queue.Dequeue());

            //-------------------------------- 
            // Stack ( List와 비슷하나, LIFO, Last lnput, First Qutput 체계이다)
            //-------------------------------- 
            Stack<int> _stack = new Stack<int>();

            _stack.Push(10);
            _stack.Push(20);
            _stack.Push(30);

            Console.WriteLine(_stack.Peek()); // 가장 마지막에 있는 값을 반환
            Console.WriteLine(_stack.Pop());
            Console.WriteLine(_stack.Pop());
            Console.WriteLine(_stack.Pop());



        }

    }

    }