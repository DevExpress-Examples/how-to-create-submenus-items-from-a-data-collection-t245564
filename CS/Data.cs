using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Q158708 {
    public class MyClass {
        public MyClass(string name) {
            _Name = name;
        }
        public MyClass() {

        }
        private string _Name;
        public string Name {
            get { return _Name; }
            set {
                _Name = value;
            }
        }
    }
}
