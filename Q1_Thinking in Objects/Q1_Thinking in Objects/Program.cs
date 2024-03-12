
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Thinking_in_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDE ide = new IDE();


            LangJava java = new LangJava();
            LangCSharp csharp = new LangCSharp();
            LangC c = new LangC();

            ide.Languages.Add(java);
            ide.Languages.Add(csharp);
            ide.Languages.Add(c);

            ide.Work();
        }
    }

    class IDE
    {


        public List<ILanguage> Languages = new List<ILanguage>();

        public void Work()
        {
            foreach (var l in Languages)
            {
                Console.WriteLine(l.GetName());
                Console.WriteLine(l.GetUnit());
                Console.WriteLine(l.GetParadigm());
                Console.WriteLine("-----------");
            }


        }
    }

    interface ILanguage
    {
        string GetName();
        string GetUnit();
        string GetParadigm();

    }

    abstract class OOLangugae : ILanguage
    {

        abstract public string GetName();
        public string GetUnit()
        {
            return "Class";
        }
        public string GetParadigm()
        {
            return "Object Oriented Langugae";
        }

    }

    abstract class ProceduralLangugae : ILanguage
    {

        abstract public string GetName();
        public string GetUnit()
        {
            return "Function";
        }
        public string GetParadigm()
        {
            return "Procedural Oriented Langugae";
        }

    }

    class LangJava : OOLangugae 
    {
        public override string GetName() { return "Java Language"; }


    }
    class LangCSharp : OOLangugae
    {
        public override string GetName() { return "CSharp Language"; }

    }
    class LangC : ProceduralLangugae
    {
        public override string GetName() { return "C Language"; }


    }
    
    
}







 