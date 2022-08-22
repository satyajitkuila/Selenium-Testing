using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Implementing Abstraction Here
namespace SeleniumCsharpTraining.CSharpPrograms.Day6
{
    abstract class Browser
    {
        public virtual int zoomSettings(int zoom)
        {
            return zoom;
            
        }

        public virtual string browserName(string name)
        {
            return name;
        }

    }
}
