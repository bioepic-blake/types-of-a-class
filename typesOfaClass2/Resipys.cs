using System;
using System.Collections.Generic;

namespace typesOfaClass2
{
    public class Resipys
    {
		public int move = 0;
        public int NumberOfIngredents = 0; //int for counting items in list 

        private List<Ingredients> _ingredents; // declering a list of type class Ingredents 
        public List<string> list1;
        public string Iname0;
		//public string Iname1;
		//public string Iname2;
        ViewController vc = new ViewController();

        //===============constructor
        public Resipys(List<Ingredients>ingredents)
        {
            _ingredents = ingredents;
           NumberOfIngredents = _ingredents.Count;

            foreach(Ingredients i in _ingredents)
            {
                list1.Add(i.Name);
                 
            }
        }


        private void ListM()
        {
             list1 = new List<string>();
            foreach(string i in list1)
            {
                vc.lblIngredents0.Text = i;
            }
        }

       

    }
}
