using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AccountIdGenrate.Model
{
    class Reflector
    {
        public void DoReflector(Type type)
        {
            Type t = Type.GetType(type.ToString());

            PropertyInfo[] properties = t.GetProperties();
            ConstructorInfo[] constructors = t.GetConstructors();
            MethodInfo[] methods = t.GetMethods();
            MemberInfo[] members = t.GetMembers();

            Console.WriteLine("");
            Console.WriteLine("==>Class Name: {0}", t.Name);
            Console.WriteLine("total properties :{0}",properties.Length);
            for(int i=0;i<properties.Length;i++)
            {
                Console.WriteLine(properties[i]);
            }
            Console.WriteLine("");

            Console.WriteLine("total constructors :{0}",constructors.Length);
            for(int i = 0; i < constructors.Length; i++)
            {
                Console.WriteLine(constructors[i]);
            }
            Console.WriteLine("");

            Console.WriteLine("total methods :{0}",methods.Length);
            for(int i = 0; i < methods.Length; i++)
            {
                Console.WriteLine(methods[i]);
            }
            Console.WriteLine("");

            Console.WriteLine("total members :{0}",members.Length);
            for(int i = 0; i < members.Length; i++)
            {
                Console.WriteLine(members[i]);
            }
            Console.WriteLine("");
        }
    }
}
