﻿#pragma checksum "C:\Users\fabsanc\OneDrive - Microsoft\Microsoft\Projetos\Cognitive-Samples-IntelligentKiosk\Kiosk\Views\PersonGroupsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B6AE7FB14F09E41664AAA1BFAC47B0D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntelligentKioskSample.Views
{
    partial class PersonGroupsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
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
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 10 "..\..\..\Views\PersonGroupsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.OnPageLoaded;
                    #line default
                }
                break;
            case 2:
                {
                    this.commandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.ListView element3 = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 45 "..\..\..\Views\PersonGroupsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)element3).ItemClick += this.ListView_ItemClick;
                    #line default
                }
                break;
            case 4:
                {
                    this.progressControl = (global::Windows.UI.Xaml.Controls.ProgressRing)(target);
                }
                break;
            case 5:
                {
                    this.addPersonGroupFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 6:
                {
                    this.personGroupNameTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 25 "..\..\..\Views\PersonGroupsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.OnAddPersonGroupButtonClicked;
                    #line default
                }
                break;
            case 8:
                {
                    this.button_Copy = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\Views\PersonGroupsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button_Copy).Click += this.OnCancelAddPersonGroupButtonClicked;
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

