using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkadukt3
{
    class Control
    {
        Project currentProject;
        List<Project> projects;

        public Control()
        {
            projects = new List<Project>();
        }

        public bool initialize()
        {

            return true;
        }

        public void NewDataDescription(string path)
        {
            Debug.WriteLine("TODO: Control.NewDataDescription(string path)");
            Project P = new Project();

            currentProject = P;
        }

        public void OpenDataDescription(string path)
        {
            Debug.WriteLine("TODO: Control.OpenDataDescription(string path)");
            Project P = new Project();

            currentProject = P;
        }

        public bool Save()
        {
            Debug.WriteLine("TODO: Control.Save()");
            currentProject.IsSaved = true;
            return true;
        }

        public bool SaveAs()
        {
            Debug.WriteLine("TODO: Control.SaveAs()");
            return true;
        }

        public void closeAddml()
        {
            Debug.WriteLine("TODO: Control.closeAddml()");
        }

        public void closeApp()
        {
            Debug.WriteLine("TODO: Control.closeApp()");
            for (int i = 0; i < projects.Count; i++)
            {
                close(projects[i]);
            }
        }

        private bool close(Project P)
        {
            if (P.IsSaved)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}