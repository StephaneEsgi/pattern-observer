using System;

namespace Observer
{
    public class ClassA : Observer
    {
        public void Update(){
            System.Console.WriteLine("ClassA");
        }
    }
}