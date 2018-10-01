using System;

using AppKit;
using Foundation;

namespace testsplitpane {
    public partial class ViewController : NSViewController {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject {
            get {
                return base.RepresentedObject;
            }
            set {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void OpenWindowClicked (NSObject sender)
        {
            var padVC = new PadViewController("PadViewController-broken");

            var window = NSWindow.GetWindowWithContentViewController(padVC);
            window.MakeKeyAndOrderFront(this);
        }

        partial void OpenWorkingWindow(NSObject sender)
        {
            var padVC = new PadViewController("PadViewController-working");

            var window = NSWindow.GetWindowWithContentViewController(padVC);
            window.MakeKeyAndOrderFront(this);
        }
    }
}
