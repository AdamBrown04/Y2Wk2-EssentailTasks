using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y2Wk2_EssentailTasks
{
    internal class Car
    {
        string make;
        string model;
        string regPlate;
        int YoM;

        public void GetMake(string Make)
        {
            make = Make;
        }

        public void GetModel(string Model)
        {
            model = Model;
        }

        public void GetRegPlate(string RegPlate)
        {
            regPlate = RegPlate;
        }

        public void GetYoM(int yom)
        {
            YoM = yom;
        }

        public void ViewMake()
        {
            Console.WriteLine(make);
        }

        public void ViewModel()
        {
            Console.WriteLine(model);
        }

        public void ViewRegPlate()
        {
            Console.WriteLine(regPlate);
        }

        public void ViewYoM()
        {
            Console.WriteLine(YoM);
        }
    }
}
