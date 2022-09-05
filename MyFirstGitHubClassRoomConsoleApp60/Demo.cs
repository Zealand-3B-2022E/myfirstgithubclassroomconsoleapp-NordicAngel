using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    internal class Demo
    {
        public int Demo1 { get; set; }
        public int Demo2 { get; set; }

        public Demo(int demo1, int demo2)
        {
            Demo1 = demo1;
            Demo2 = demo2;
        }

        public override string ToString()
        {
            return $"Demo1 = {Demo1}; Demo2 = {Demo2}";
        }
    }
}
