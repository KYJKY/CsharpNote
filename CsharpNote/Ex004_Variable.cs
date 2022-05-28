using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNote
{
    public class Ex004_Variable
    {
        static void Main(string[] args)
        {
            /*
            
            01 변수
            변수(Variable): 프로그램에서 사용할 데이터를 임시로 저장해 놓는 그릇
            
            1. 변수 선언
            2. 변수 할당(값 넣는거)
            3. 변수 사용(참조)

            1, 2단계를 한 번에 진행하는 것을 우리는 '초기화' 한다고 한다.

            */
            
            int age;
            age = 26;
            Console.WriteLine(age);

            // 02 리터럴
            // 변수에 들어가는 값은 ? > 리터럴
            // 위에서 26은 리터럴이고 정수형 리터럴이다.


            // 03 자릿수 구분하기 > 언더스코어 '_' 문자를 사용한다.
            int number = 1_824_000;
            Console.WriteLine(number);


            // 04 상수 
            const double pi = 3.141592;


            // 05 int .net Type
            // int 키워드와 Int32는 동일한 키워드다.
            // 래퍼타입이라고 하기도 함
            int min = System.Int32.MinValue;
            int max = System.Int32.MaxValue;
            Console.WriteLine($"int 변수의 최소값: {min}");
            Console.WriteLine($"int 변수의 최대값: {max}");


        }
    }
}
