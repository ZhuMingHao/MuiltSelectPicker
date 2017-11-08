using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MuiltSelectPicker
{
    public class CustomPicker : Picker
    {
        Action<object> action;

        public CustomPicker()
        {

        }
        public void RegisterAction(Action<object> callback)
        {
            action = callback;
        }

        public void Cleanup()
        {
            action = null;
        }

        public void InvokeAction(object data)
        {
            if (action == null || data == null)
            {
                return;
            }
            action.Invoke(data);
        }
    }

}
