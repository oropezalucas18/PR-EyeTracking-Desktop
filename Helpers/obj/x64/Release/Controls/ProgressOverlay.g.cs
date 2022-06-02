﻿#pragma checksum "C:\Users\Lucas Oropeza\Documents\PR-EYE TRACKING\PR-EYE TRACKING HEATMAPS\Helpers\Controls\ProgressOverlay.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3A339FFA5F379388F38A473CBF5167FFAABC4ED4CCAB06A2C31FBBE811633724"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Helpers.Controls
{
    partial class ProgressOverlay : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(global::Windows.UI.Xaml.Controls.ProgressRing obj, global::System.Boolean value)
            {
                obj.IsActive = value;
            }
            public static void Set_Windows_UI_Xaml_Media_Brush_Opacity(global::Windows.UI.Xaml.Media.Brush obj, global::System.Double value)
            {
                obj.Opacity = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ProgressOverlay_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IProgressOverlay_Bindings
        {
            private global::Helpers.Controls.ProgressOverlay dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Grid obj2;
            private global::Windows.UI.Xaml.Media.SolidColorBrush obj3;
            private global::Windows.UI.Xaml.Controls.ProgressRing obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;
            private global::Windows.UI.Xaml.Controls.Button obj6;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.RoutedEventHandler obj6Click;

            private ProgressOverlay_obj1_BindingsTracking bindingsTracking;

            public ProgressOverlay_obj1_Bindings()
            {
                this.bindingsTracking = new ProgressOverlay_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Controls\ProgressOverlay.xaml line 25
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Grid)target;
                        break;
                    case 3: // Controls\ProgressOverlay.xaml line 30
                        this.obj3 = (global::Windows.UI.Xaml.Media.SolidColorBrush)target;
                        break;
                    case 4: // Controls\ProgressOverlay.xaml line 43
                        this.obj4 = (global::Windows.UI.Xaml.Controls.ProgressRing)target;
                        break;
                    case 5: // Controls\ProgressOverlay.xaml line 46
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 6: // Controls\ProgressOverlay.xaml line 52
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Button)target;
                        this.obj6Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ProgressObject.Cancel();
                        };
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += obj6Click;
                        break;
                    default:
                        break;
                }
            }

            // IProgressOverlay_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Helpers.Controls.ProgressOverlay)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }
            public void SetConverterLookupRoot(global::Windows.UI.Xaml.FrameworkElement rootElement)
            {
                this.converterLookupRoot = new global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement>(rootElement);
            }

            public global::Windows.UI.Xaml.Data.IValueConverter LookupConverter(string key)
            {
                if (this.localResources == null)
                {
                    global::Windows.UI.Xaml.FrameworkElement rootElement;
                    this.converterLookupRoot.TryGetTarget(out rootElement);
                    this.localResources = rootElement.Resources;
                    this.converterLookupRoot = null;
                }
                return (global::Windows.UI.Xaml.Data.IValueConverter) (this.localResources.ContainsKey(key) ? this.localResources[key] : global::Windows.UI.Xaml.Application.Current.Resources[key]);
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Helpers.Controls.ProgressOverlay obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ProgressObject(obj.ProgressObject, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_BackgroundOpacity(obj.BackgroundOpacity, phase);
                    }
                }
            }
            private void Update_ProgressObject(global::Helpers.Controls.ProgressObject obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ProgressObject(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ProgressObject_IsActive(obj.IsActive, phase);
                        this.Update_ProgressObject_Text(obj.Text, phase);
                        this.Update_ProgressObject_IsCancellable(obj.IsCancellable, phase);
                    }
                }
            }
            private void Update_ProgressObject_IsActive(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ProgressOverlay.xaml line 25
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj2, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("BooleanToVisibilityConverter").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), null, null));
                    // Controls\ProgressOverlay.xaml line 43
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ProgressRing_IsActive(this.obj4, obj);
                }
            }
            private void Update_BackgroundOpacity(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\ProgressOverlay.xaml line 30
                    XamlBindingSetters.Set_Windows_UI_Xaml_Media_Brush_Opacity(this.obj3, obj);
                }
            }
            private void Update_ProgressObject_Text(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ProgressOverlay.xaml line 46
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                }
            }
            private void Update_ProgressObject_IsCancellable(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\ProgressOverlay.xaml line 52
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj6, (global::Windows.UI.Xaml.Visibility)this.LookupConverter("BooleanToVisibilityConverter").Convert(obj, typeof(global::Windows.UI.Xaml.Visibility), null, null));
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class ProgressOverlay_obj1_BindingsTracking
            {
                private global::System.WeakReference<ProgressOverlay_obj1_Bindings> weakRefToBindingObj; 

                public ProgressOverlay_obj1_BindingsTracking(ProgressOverlay_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<ProgressOverlay_obj1_Bindings>(obj);
                }

                public ProgressOverlay_obj1_Bindings TryGetBindingObject()
                {
                    ProgressOverlay_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                    UpdateChildListeners_ProgressObject(null);
                }

                public void DependencyPropertyChanged_ProgressObject(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    ProgressOverlay_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Helpers.Controls.ProgressOverlay obj = sender as global::Helpers.Controls.ProgressOverlay;
                        if (obj != null)
                        {
                            bindings.Update_ProgressObject(obj.ProgressObject, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_ProgressObject = 0;
                public void UpdateChildListeners_(global::Helpers.Controls.ProgressOverlay obj)
                {
                    ProgressOverlay_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Helpers.Controls.ProgressOverlay.ProgressObjectProperty, tokenDPC_ProgressObject);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_ProgressObject = obj.RegisterPropertyChangedCallback(global::Helpers.Controls.ProgressOverlay.ProgressObjectProperty, DependencyPropertyChanged_ProgressObject);
                        }
                    }
                }
                public void PropertyChanged_ProgressObject(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    ProgressOverlay_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Helpers.Controls.ProgressObject obj = sender as global::Helpers.Controls.ProgressObject;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ProgressObject_IsActive(obj.IsActive, DATA_CHANGED);
                                bindings.Update_ProgressObject_Text(obj.Text, DATA_CHANGED);
                                bindings.Update_ProgressObject_IsCancellable(obj.IsCancellable, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "IsActive":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ProgressObject_IsActive(obj.IsActive, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Text":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ProgressObject_Text(obj.Text, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "IsCancellable":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ProgressObject_IsCancellable(obj.IsCancellable, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Helpers.Controls.ProgressObject cache_ProgressObject = null;
                public void UpdateChildListeners_ProgressObject(global::Helpers.Controls.ProgressObject obj)
                {
                    if (obj != cache_ProgressObject)
                    {
                        if (cache_ProgressObject != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ProgressObject).PropertyChanged -= PropertyChanged_ProgressObject;
                            cache_ProgressObject = null;
                        }
                        if (obj != null)
                        {
                            cache_ProgressObject = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ProgressObject;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 6: // Controls\ProgressOverlay.xaml line 52
                {
                    this.CancelButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Controls\ProgressOverlay.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    ProgressOverlay_obj1_Bindings bindings = new ProgressOverlay_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

