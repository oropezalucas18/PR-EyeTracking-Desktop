﻿#pragma checksum "C:\Users\Lucas Oropeza\Desktop\EYE TRACKING DESKTOP\PR-EyeTracking-Desktop\Flashback\Views\Project\SaveView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E75EB9C5E9F40072D88E0847E68F0CD443DAADE7C001D4253429889BF1D41C80"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Flashback.Views
{
    partial class SaveView : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(global::Windows.UI.Xaml.Controls.Primitives.Selector obj, global::System.Int32 value)
            {
                obj.SelectedIndex = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SaveView_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISaveView_Bindings
        {
            private global::Flashback.Views.SaveView dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ComboBox obj2;
            private global::Windows.UI.Xaml.Controls.Button obj3;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.RoutedEventHandler obj3Click;

            private SaveView_obj1_BindingsTracking bindingsTracking;

            public SaveView_obj1_Bindings()
            {
                this.bindingsTracking = new SaveView_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\Project\SaveView.xaml line 24
                        this.obj2 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_2(this.obj2);
                        break;
                    case 3: // Views\Project\SaveView.xaml line 29
                        this.obj3 = (global::Windows.UI.Xaml.Controls.Button)target;
                        this.obj3Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.ProjectViewModel.RenderMovie();
                        };
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += obj3Click;
                        break;
                    default:
                        break;
                }
            }

            // ISaveView_Bindings

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
                    this.dataRoot = (global::Flashback.Views.SaveView)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Flashback.Views.SaveView obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_VideoQualities(obj.VideoQualities, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ProjectViewModel(obj.ProjectViewModel, phase);
                    }
                }
            }
            private void Update_VideoQualities(global::System.String[] obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Project\SaveView.xaml line 24
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj2, obj, null);
                }
            }
            private void Update_ProjectViewModel(global::Flashback.ViewModels.ProjectViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ProjectViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ProjectViewModel_Project(obj.Project, phase);
                    }
                }
            }
            private void Update_ProjectViewModel_Project(global::Flashback.Models.Project obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ProjectViewModel_Project(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ProjectViewModel_Project_VideoQuality(obj.VideoQuality, phase);
                    }
                }
            }
            private void Update_ProjectViewModel_Project_VideoQuality(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Project\SaveView.xaml line 24
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_Selector_SelectedIndex(this.obj2, obj);
                }
            }
            private void UpdateTwoWay_2_SelectedIndex()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.ProjectViewModel != null)
                        {
                            if (this.dataRoot.ProjectViewModel.Project != null)
                            {
                                this.dataRoot.ProjectViewModel.Project.VideoQuality = this.obj2.SelectedIndex;
                            }
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class SaveView_obj1_BindingsTracking
            {
                private global::System.WeakReference<SaveView_obj1_Bindings> weakRefToBindingObj; 

                public SaveView_obj1_BindingsTracking(SaveView_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<SaveView_obj1_Bindings>(obj);
                }

                public SaveView_obj1_Bindings TryGetBindingObject()
                {
                    SaveView_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_ProjectViewModel(null);
                    UpdateChildListeners_ProjectViewModel_Project(null);
                }

                public void PropertyChanged_ProjectViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SaveView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Flashback.ViewModels.ProjectViewModel obj = sender as global::Flashback.ViewModels.ProjectViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ProjectViewModel_Project(obj.Project, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Project":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ProjectViewModel_Project(obj.Project, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Flashback.ViewModels.ProjectViewModel cache_ProjectViewModel = null;
                public void UpdateChildListeners_ProjectViewModel(global::Flashback.ViewModels.ProjectViewModel obj)
                {
                    if (obj != cache_ProjectViewModel)
                    {
                        if (cache_ProjectViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ProjectViewModel).PropertyChanged -= PropertyChanged_ProjectViewModel;
                            cache_ProjectViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ProjectViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ProjectViewModel;
                        }
                    }
                }
                public void PropertyChanged_ProjectViewModel_Project(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    SaveView_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::Flashback.Models.Project obj = sender as global::Flashback.Models.Project;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ProjectViewModel_Project_VideoQuality(obj.VideoQuality, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "VideoQuality":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ProjectViewModel_Project_VideoQuality(obj.VideoQuality, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::Flashback.Models.Project cache_ProjectViewModel_Project = null;
                public void UpdateChildListeners_ProjectViewModel_Project(global::Flashback.Models.Project obj)
                {
                    if (obj != cache_ProjectViewModel_Project)
                    {
                        if (cache_ProjectViewModel_Project != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ProjectViewModel_Project).PropertyChanged -= PropertyChanged_ProjectViewModel_Project;
                            cache_ProjectViewModel_Project = null;
                        }
                        if (obj != null)
                        {
                            cache_ProjectViewModel_Project = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ProjectViewModel_Project;
                        }
                    }
                }
                public void RegisterTwoWayListener_2(global::Windows.UI.Xaml.Controls.ComboBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.Selector.SelectedIndexProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_2_SelectedIndex();
                        }
                    });
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
            case 1: // Views\Project\SaveView.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    SaveView_obj1_Bindings bindings = new SaveView_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

