#pragma checksum "C:\Users\fabsanc\OneDrive - Microsoft\Microsoft\Projetos\Cognitive-Samples-IntelligentKiosk\Kiosk\Controls\ImageSearchUserControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0D17E788CAD4A2C38679C5581DD2A18F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Controls
{
    partial class ImageSearchUserControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.SearchControl = (global::Windows.UI.Xaml.Controls.UserControl)(target);
                }
                break;
            case 2:
                {
                    this.imageResultsGrid = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 48 "..\..\..\Controls\ImageSearchUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)this.imageResultsGrid).SelectionChanged += this.OnImageResultSelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.progressRing = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 4:
                {
                    this.addSelectedPhotosButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 59 "..\..\..\Controls\ImageSearchUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.addSelectedPhotosButton).Click += this.OnAcceptButtonClicked;
                    #line default
                }
                break;
            case 5:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element5 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 63 "..\..\..\Controls\ImageSearchUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element5).Click += this.OnCancelButtonClicked;
                    #line default
                }
                break;
            case 6:
                {
                    this.autoSuggestBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    #line 28 "..\..\..\Controls\ImageSearchUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.autoSuggestBox).QuerySubmitted += this.onQuerySubmitted;
                    #line 28 "..\..\..\Controls\ImageSearchUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.autoSuggestBox).TextChanged += this.onTextChanged;
                    #line default
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\Controls\ImageSearchUserControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.LoadImagesFromFileClicked;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

