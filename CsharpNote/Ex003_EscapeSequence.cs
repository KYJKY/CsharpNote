using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNote
{
    public class Ex003_EscapeSequence
    {
        static void Main(string[] args)
        {
            // [\n]: 줄바꿈
            Console.WriteLine("안녕\n하세요.");

            // [\t]: 탭만큼 들여쓰기
            Console.WriteLine("반갑\t습니다.");

            // [/r]: 캐리지리턴 > 줄 맨 앞으로. 무언가를 더 타이핑하면 작성 영역이 겹치므로 사라진다? 
            Console.WriteLine("또 만나요. \r");
            Console.ReadLine();     // 커서 위치 확인용

            // [\']: 작은 따옴표(홑 따옴표) 표현 
            Console.WriteLine("작은 따옴표 > \'");

            // [\"]: 큰 따옴표 표현 
            Console.WriteLine("큰 따옴표 > \"");

            // [\\]: 백슬래시 표현. 특히 경로를 표현할 때 많이 쓰인다.
            Console.WriteLine("백슬래시(역슬래시) > \\");

            // 문자열 앞에 @를 붙이는 경우, 공백/탭이 그대로 표현된다. 
            Console.WriteLine(@"안
                                    녕
                                        하  
                                                       세
            요 ㅋㅋ ..");

            // []: 
            Console.WriteLine();



        }
    }
}
