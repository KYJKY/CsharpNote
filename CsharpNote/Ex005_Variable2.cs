using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNote
{
    internal class Ex005_Variable2
    {
        static void Main(string[] args)
        {
            // char 키워드: 문자 데이터 형식 변수를 선언 (문자 하나)
            char grade = 'A';

            // 이스케이프 시퀀스는 하나의 문자로 인식한다
            char es = '\n';
            es = '\r';
            es = '\b';


            // string @ 붙이면 그대로!
            string multiLines = @"
            안녕하세요 
반
가
워
요
^^~
            ";
            Console.WriteLine(multiLines);

            // 여러가지 출력법!
            string name = "C#";
            string version = "8.0";
            
            // 1. cw는 자체적으로 기능을 지원한다.
            Console.WriteLine("{0} {1}", name, version);

            // 2. String.Format()
            string result = string.Format("{0} {1}", name, version);

            // 3. 문자열 보간법
            Console.WriteLine($"{name} {version}");




            // bool 속지말 것
            // bool은 false와 true 두 가지가 있지만, 출력될 때는 False와 True로 대문자로 출력됨.
            // 그러므로 자바스크립트 단에서 받을 때 문자열 True False로 받게 되는 것에 유의하자


        }
    }
}
