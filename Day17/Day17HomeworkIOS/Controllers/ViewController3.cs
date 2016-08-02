using System;
using Foundation;
using UIKit;

namespace Day17HomeworkIOS.Controllers
{
    public partial class ViewController3 : UIViewController
    {
        string password = "123";
        public ViewController3(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override bool ShouldPerformSegue(string segueIdentifier, NSObject sender)
        {
            if(segueIdentifier== "passwordSegue")
            {
                if(Password.Text==password)
                {
                    Password.ResignFirstResponder();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return base.ShouldPerformSegue(segueIdentifier, sender);
        }
    }
}