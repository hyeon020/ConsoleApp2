using System;
class P105_1 
{
    static void Main(string[] args)
    {
        int a, b, c; //삼각형 세 변의 길이를 입력받는 정수형 a,b,c 변수 선언
        double s, l; //삼각형의 넓이s와 세 변의 길이의 합 나누기 2인 l
        Console.Write("삼각형의 세 변의 길이를 입력하시오.  : ");
        a = Console.Read();
        b = Console.Read();  //a,b,c 문자코드값 리턴
        c = Console.Read(); //입력받은 세 변의 문자코드값을 리턴
        l = (a + b + c) / 2; //세 변의 합을 2로 나눈 값
        s = Math.Sqrt(l* (l - a) * (l - b) * (l - c)); //헤론의 공식을 사용하여 삼각형의 넓이를 구함
        Console.WriteLine("삼각형의 넓이는 : " + s);
    }
}
