﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook
{

    interface IAnimal
    {
        void Sound();

        virtual void Nature()
        {

        }
    }


    public class Cat : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Cat Sound");
        }
    }

    public class InterfaceExample
    {
        public InterfaceExample() { }

        public void MainMethod()
        {
            Cat objCat = new Cat();
            objCat.Sound();
        }
    }
}
