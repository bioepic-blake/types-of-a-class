using System;
using System.Collections.Generic;
namespace typesOfaClass2
{
    public class ResipyManager
    {
       
        public int numOFingrdents;
        public string str0;
		//public string str1;
		//public string str2;
        //constructor
        public ResipyManager()
        {
        }

        public void createResipy()
        {
            var ingredents = new List<Ingredients>();

            Ingredients ing = new Ingredients("carrots");
            Ingredients ing2 = new Ingredients("milk");
            Ingredients ing3 = new Ingredients("flour");

            ingredents.Add(ing);
            ingredents.Add(ing2);
            ingredents.Add(ing3);

            Resipys r = new Resipys(ingredents);

            numOFingrdents = r.NumberOfIngredents;

            str0 = r.Iname0;
            //str1 = r.Iname1;
            //str2 = r.Iname2;
        }

	
    }
}
