using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitProject
{
    class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            //修复了一个共同版本都有的bug
            return "名字：" + Name + " 颜色：" + Color + " 年龄：" + Age;
        }
    }
}
