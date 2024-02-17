using System;
using System.Threading.Channels;
namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args) 
        {

            MyList<string> isimler=new MyList<string>(); // Generic yapılara bir örnek.
            isimler.Add("Kerem");


        }
    }
}