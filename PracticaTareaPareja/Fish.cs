using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaTareaPareja
{
    class Fish.Animal
    {

        public int sizeInft { get; set; }
        //metodos
        public Boolean canEar { get; set; }
         public string getInfo()
         {
        var Ear = "";
        if (canEar == true)
        {
            Ear = "El animal puede oir";
        }
        else
        {
            Ear = "El animal no puede oir";
        }
        return " El animal mide " + sizeInft + ",    tiene " + animalAge + " años, y  " + Ear;
         }
        public string swin()
        {
        return "El animal esta nadando";
         }
    }
}
