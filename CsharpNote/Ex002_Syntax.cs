using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNote
{
    public class Ex002_Syntax
    {
        static void Main(string[] args)
        {
            // [ctrl + e + e] 드래그 된 코드나 한 행을 C# Interactive에서 실행시킨다. 


            /* 
                문법(Syntax): 문법은 반드시 지켜야하는 규칙이고 스타일은 프로그램 작성에 대한 가이드라인
                

            */

            // 01 EmptyStatement
            // 하나의 문장은 ';' 세미콜론으로 끝나야 한다.

            // 02
            // 클래스 명은 대문자로 시작한다. > 파스칼표기법.
            // 꺽쇠는 AllMan을 권장한다. (이와 대비되는 K&R는 Java와 Javascript에서 주로 채택된다.)
            // 그리고 메인 메서드는 대문자로 시작한다. (Java와 혼동X) 메인 메서드는 엔트리포인트, 즉 프로그램의 시작지점을 뜻한다.
            // ... C#에서 Method는 '메소드'가 아닌 '메서드'이다.
            


            // 03
            // "네임스페이스.클래스.메서드" 형태이다.
            // using 을 사용하므로서 해당 영역을 생략할 수 있다.
            // 이는 네임스페이스만 using 할 수 있는 것 뿐만 아니라 System.Console 까지도 using에 쓸 수 있다.
            System.Console.WriteLine("출력 내용");


            // 04
            // 공백은 프로그래밍에서 무시된다. 하지만 하나의 이름 내부에서는 공백을 통해 인식을 못하게 된다. 
            System.   Console.        
                WriteLine
                ("출력 내용");

            // 05
            // 문자열 보간 > JavaScript 템플릿 문자열 
            string name = "김연중";
            string chat = "큰 일을 하기 위해 작은 일 부터";
            Console.WriteLine($"[{DateTime.Now.Date}], {name}: {chat}");


            // 06 PlaceHolder 자리표시자 
            string a = "김연중";
            string b = "안녕하세요?";
            Console.WriteLine("나는 {0}입니다.", a);
            Console.WriteLine("나는 {0}입니다. {0}인데요.", a);
            Console.WriteLine("나는 {0}입니다. {1}", a, b);


        }
    }
}
