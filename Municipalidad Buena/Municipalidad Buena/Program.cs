using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Municipalidad_Buena
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly archivoAssembly = Assembly.LoadFile("C:/Users/infig/source/repos/Reflection/Reflection/ClassLibrary1.dll");
            foreach (Type type in archivoAssembly.GetTypes())
            {
                if (type.IsClass) Console.WriteLine("class");
                else if (type.IsInterface) Console.WriteLine("interface");
                else Console.WriteLine("otro tipo");
                Console.WriteLine(type.Name);
                PropertyInfo[] propertyInfos = type.GetProperties();
                MethodInfo[] properties = type.GetMethods();
                Console.WriteLine("Atributos: ");
                foreach(PropertyInfo atr in propertyInfos)
                {
                    Console.WriteLine("\t" + atr.Name + "  " + atr.PropertyType);
                }

                Console.WriteLine("Metodos: ");
                foreach (MethodInfo prop in properties)
                {
                    ParameterInfo[] parameterInfos = prop.GetParameters();
                    Console.Write("Parametros: ");
                    foreach(ParameterInfo par in parameterInfos)
                    {
                        Console.Write(par.ParameterType + " " + par.Name);
                    }
                    Console.WriteLine("\t Nombre: " + prop.Name + "    Retorno: " + prop.ReturnParameter);
                }

                Console.WriteLine();


            }
            Console.ReadKey();
        }
    }
}
