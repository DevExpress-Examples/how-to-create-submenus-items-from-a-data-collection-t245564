using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Bars;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Specialized;
using DevExpress.Xpf.Core;

namespace Q158708 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            _Collection = new ObservableCollection<MyClass>();
            _Collection.Add(new MyClass("Name1"));
            _Collection.Add(new MyClass("Name2"));
            _Collection.Add(new MyClass("Name3"));
            GenerateItems(manager, manager.Bars["bar"], _Collection);
        }

        private void sb_GetItemData(object sender, EventArgs e) {
            BarSubItem sb = (BarSubItem)sender;
            sb1.ItemLinks.Add(new BarButtonItemLink() { BarItemName = "bt1" });
            sb1.ItemLinks.Add(new BarButtonItemLink() { BarItemName = "bt2" });
        }

        public void GenerateItems(BarManager manager, ILinksHolder holder, IEnumerable collection) {
            foreach(MyClass item in collection)
                holder.Links.Add(GetBarItem(manager, item));
        }
        public BarItem GetBarItem(BarManager manager, MyClass data) {
            string itemName = "button" + data.Name;
            BarItem item = manager.Items[itemName];
            if(item == null)
                item = new BarButtonItem() { Name = itemName, Content = data.Name };
            return item;
        }

        ObservableCollection<MyClass> _Collection;
    }
}
