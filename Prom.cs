using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chanworld
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("chanworld.exe 세찬 철보아ㅗ랒더갸ㅓㅐㅑ얼제ㅐ더랴ㅐㅈ둘재다루재ㅜ릳ㅇ,ㅓㅈㄷㄱㅈㄷㄱㅈㄷㄱㅈㄷㄱ.");
                return;
            
            }
            Console.WriteLine("여러분 안녕하세요, {0}, {1}, {2}", args[0], args[1], args[2]);
        
            
            
        }
    }
}
