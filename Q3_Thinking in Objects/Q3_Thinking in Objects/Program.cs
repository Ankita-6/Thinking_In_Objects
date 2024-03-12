using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_Thinking_in_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Project
    {
        ProjectManager manager = new ProjectManager();
    }
    public class ProjectManager
    {
        List<Project> projects = new List<Project>();
    }
    public class ProjectLead 
    {
        Project project = new Project();
        ProjectManager manager = new ProjectManager();
    }
}





   