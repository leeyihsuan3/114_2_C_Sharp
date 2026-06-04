using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Facts
{
    public class FoodItem
    {
        public string Name;
        private double calories;
        private double fat;
        private double carb;

        // 新增建構子以便從 MainForm 建立 FoodItem 實例
        public FoodItem(string name, double calories, double fat, double carb)
        {
            this.Name = name;
            this.calories = calories;
            this.fat = fat;
            this.carb = carb;
        }

        public string Name1
        {
            get { return Name; }
            set { Name = value; }
        }
        public double Calories
        {
            get { return calories; }
            set { calories = value; }
        }
        public double Fat
        {
            get { return fat; }
            set { fat = value; }
        }
        public double Carb
        {
            get { return carb; }
            set { carb = value; }
        }
    }
}