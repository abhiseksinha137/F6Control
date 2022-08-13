using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace testEvent
{
    public delegate void Notify();  // delegate
    public class testEvent
    {
        public Button _btn;
        public event Notify ProcessCompleted; // event
        public testEvent(Button btn)
        {
            _btn = btn;
            _btn.MouseDown += new MouseEventHandler(btnClick);  // External Eventhandler for mouse

        }

        private void btnClick(object sender, MouseEventArgs e) // Event Handler for class
        {
            ProcessCompleted?.Invoke();
        }
    }
}
