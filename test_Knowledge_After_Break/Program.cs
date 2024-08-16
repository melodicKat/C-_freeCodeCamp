using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;

namespace conmeo 
{
    internal class Program
    {
        delegate void updateNameHandler(string name);
        static void Main(string[] args)
        {
            hocSinh a = new hocSinh();
            a.eventNameChange += ShowChange;
            a.Name = "conmeo";
            a.Name = "conmeo";
            a.Name = "conmdf";

            hocSinh b = new hocSinh();
            b.NameChange = ShowChange;
            b.Name = "conmeo";
            b.Name = "condsafasdo";
            b.Name = "conmdf";

            hocSinh c = new hocSinh();
            c.NameChange = ShowChange;
            c.Name = "conmeo";
            c.Name = "conmeo";
            c.Name = "conmdf";

            Console.ReadKey();


        }

        static void ShowChange(string name)
        {
            Console.WriteLine("Name changed to: " + name);
        }

        class hocSinh
        {


            public updateNameHandler namechange;

            public updateNameHandler NameChange { set => namechange = value; }

            public event updateNameHandler eventNameChange;
           
            private string name;
            public string Name
            {
                get => name;
                set 
                { 
                    name = value;
                 
                    eventNameChange?.Invoke(value);
                
                }
            }
        }
        
    }

}