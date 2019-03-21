using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Syncfusion.TreeView.Engine;
using Xamarin.Forms.Xaml;
using Syncfusion.XForms.TreeView;

namespace GettingStartedBound
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GettingStatred : ContentPage
    {
        SfTreeView TreeView;
        public GettingStatred()
        {
            InitializeComponent();
            TreeView = treeView;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var imageIcon = sender as Image;
            var treeViewNode = imageIcon.BindingContext as TreeViewNode;
            if (treeViewNode.IsExpanded)
                TreeView.CollapseNode(treeViewNode);
            else
                TreeView.ExpandNode(treeViewNode);
        }
    }
}