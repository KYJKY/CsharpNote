using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpNoteCore
{
    class Ex001_HelloWorld
    {
        static void Main(string[] args)
        {
            // 다른 프로젝트를 실행하기 위해서는 시작 프로젝트를 설정해줘야 한다.
            // 매번 시작 프로젝트를 설정해주는 것보다 현재 선택된 프로젝트를 실행시키는 방법이 있다. (선택영역 = 탐색기에서 볼드처리)
            // 솔루션 - 속성 - 시작프로젝트 (현재 선택영역으로 설정)

            Console.WriteLine("Hello World");

            // 현재 프로젝트 파일을 클릭하면 XML 형태의 내부가 노출되는데 이를 안보고 싶다면 
            // 솔루션 탐색기에 상단에 '선택한 항목 미리 보기' 옵션을 off해주면 됨


            /*
            
            .net Core에서 디버깅을 진행하면 bin > Debug에 .exe 실행파일이 존재하지 않는다. (근데 존재한다? > 윈도우라서)
            .net Core는 크로스 플랫폼이기 때문에 실제 실행파일은 .dll이다.
            때문에 리눅스에서 해당 .dll파일을 실행시키면 Hello World가 출력된다.

             */
        }
    }
}
