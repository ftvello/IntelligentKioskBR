﻿#pragma checksum "C:\Users\fabsanc\OneDrive - Microsoft\Microsoft\Projetos\Cognitive-Samples-IntelligentKiosk\Kiosk\Controls\RealTimeFaceIdentificationBorder.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2C0C1C6332CE3626A8D60888EBD2DC36"
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
    partial class RealTimeFaceIdentificationBorder : 
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
                    this.userControl = (global::Windows.UI.Xaml.Controls.UserControl)(target);
                }
                break;
            case 2:
                {
                    this.faceRectangle = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 3:
                {
                    this.captionBorder = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 4:
                {
                    this.emotionEmojiControl = (global::IntelligentKioskSample.Controls.EmotionEmojiControl)(target);
                }
                break;
            case 5:
                {
                    this.captionTextHeader = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.captionTextSubHeader = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

