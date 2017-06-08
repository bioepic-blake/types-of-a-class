using System;
using System.Collections.Generic;
using CoreGraphics;
using UIKit;

namespace typesOfaClass2
{
    public partial class ViewController : UIViewController
    {
        public UITextField lblIngredents0;
        public UITextField lblIngredents1;
        public UITextField lblIngredents2;
        public UILabel lblNumberOfIngerdents;
        public ResipyManager _Rmanager;
        public Resipys _resipys;
        public string str0;
		public string str1;
		public string str2;

		public string Iname1;

        public Ingredients _ingrediants;
       

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
           View.BackgroundColor = UIColor.White;

            LblIngredentsMethod0();
			//LblIngredentsMethod1();
			//LblIngredentsMethod2();

            LblNumberOfIngerdentsc();

            GetIngredentsNumber();
          
           
        }

        public void LblIngredentsMethod0()
        {
            var rect = new CGRect(25, 100, 200, 300);
            lblIngredents0 = new UITextField(rect);
           // lblIngredents.Text = "";
            View.Add(lblIngredents0);
        }

		//public void LblIngredentsMethod1()
		//{
		//	var rect = new CGRect(25, 255, 250, 50);
		//	lblIngredents1 = new UITextField(rect);
		//	// lblIngredents.Text = "";
		//	View.Add(lblIngredents1);
		//}

		//public void LblIngredentsMethod2()
		//{
		//	var rect = new CGRect(25, 310, 250, 50);
		//	lblIngredents2 = new UITextField(rect);
		//	// lblIngredents.Text = "";
		//	View.Add(lblIngredents2);
		//}


        public void LblNumberOfIngerdentsc()
        {
            var rect = new CGRect(100, 255, 250, 50);
            lblNumberOfIngerdents = new UILabel(rect);
            lblNumberOfIngerdents.Text = "placeholder";
            View.Add(lblNumberOfIngerdents);

        }
        private void GetIngredentsNumber()
        {
            _Rmanager = new ResipyManager();
            _Rmanager.createResipy();
            lblNumberOfIngerdents.Text = _Rmanager.numOFingrdents.ToString();

            //_Rmanager.createResipy();
            //str0 = _Rmanager.str0;
            //str1 = _Rmanager.str1;
            //str2 = _Rmanager.str2;



            string string1 = _resipys.list1;
       
            //lblIngredents0.Text = _resipys.Iname0;
            //lblIngredents1.Text = str1;
            //lblIngredents2.Text = str2;
           
		}




    }
}
