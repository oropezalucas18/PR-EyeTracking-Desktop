﻿#pragma checksum "C:\Users\Lucas Oropeza\Documents\PR-EYE TRACKING\PR-EYE TRACKING HEATMAPS\Helpers\Controls\HamburgerMenu.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4C9BE828910A0E7FC045D70333507EB086E1EBB491F7669D7DB54CC6CED0EEFA"
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
    partial class HamburgerMenu : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Panel_Background(global::Windows.UI.Xaml.Controls.Panel obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Background = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_SplitView_IsPaneOpen(global::Windows.UI.Xaml.Controls.SplitView obj, global::System.Boolean value)
            {
                obj.IsPaneOpen = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_SplitView_PaneBackground(global::Windows.UI.Xaml.Controls.SplitView obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.PaneBackground = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Control_Foreground(global::Windows.UI.Xaml.Controls.Control obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Foreground = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Foreground(global::Windows.UI.Xaml.Controls.TextBlock obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Foreground = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton obj, global::System.Nullable<global::System.Boolean> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Boolean) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Boolean), targetNullValue);
                }
                obj.IsChecked = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_SymbolIcon_Symbol(global::Windows.UI.Xaml.Controls.SymbolIcon obj, global::Windows.UI.Xaml.Controls.Symbol value)
            {
                obj.Symbol = value;
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
        private class HamburgerMenu_obj4_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IHamburgerMenu_Bindings
        {
            private global::Helpers.Navigation.NavigationLink dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj4;
            private global::Windows.UI.Xaml.Controls.SymbolIcon obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;

            public HamburgerMenu_obj4_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // Controls\HamburgerMenu.xaml line 240
                        this.obj4 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 5: // Controls\HamburgerMenu.xaml line 245
                        this.obj5 = (global::Windows.UI.Xaml.Controls.SymbolIcon)target;
                        break;
                    case 6: // Controls\HamburgerMenu.xaml line 246
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj4.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Helpers.Navigation.NavigationLink) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IHamburgerMenu_Bindings

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
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Helpers.Navigation.NavigationLink)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Helpers.Navigation.NavigationLink obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Symbol(obj.Symbol, phase);
                        this.Update_Label(obj.Label, phase);
                    }
                }
            }
            private void Update_Symbol(global::Windows.UI.Xaml.Controls.Symbol obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\HamburgerMenu.xaml line 245
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_SymbolIcon_Symbol(this.obj5, obj);
                }
            }
            private void Update_Label(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\HamburgerMenu.xaml line 246
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj, null);
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class HamburgerMenu_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IHamburgerMenu_Bindings
        {
            private global::Helpers.Controls.HamburgerMenu dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private global::Windows.UI.Xaml.ResourceDictionary localResources;
            private global::System.WeakReference<global::Windows.UI.Xaml.FrameworkElement> converterLookupRoot;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Grid obj23;
            private global::Windows.UI.Xaml.Controls.Grid obj24;
            private global::Windows.UI.Xaml.Controls.SplitView obj25;
            private global::Windows.UI.Xaml.Controls.ListView obj26;
            private global::Windows.UI.Xaml.Controls.ContentControl obj27;
            private global::Windows.UI.Xaml.Controls.Primitives.ToggleButton obj28;
            private global::Windows.UI.Xaml.Controls.TextBlock obj29;
            private global::Windows.UI.Xaml.Controls.ContentControl obj30;

            private HamburgerMenu_obj1_BindingsTracking bindingsTracking;

            public HamburgerMenu_obj1_Bindings()
            {
                this.bindingsTracking = new HamburgerMenu_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 23: // Controls\HamburgerMenu.xaml line 257
                        this.obj23 = (global::Windows.UI.Xaml.Controls.Grid)target;
                        break;
                    case 24: // Controls\HamburgerMenu.xaml line 290
                        this.obj24 = (global::Windows.UI.Xaml.Controls.Grid)target;
                        break;
                    case 25: // Controls\HamburgerMenu.xaml line 319
                        this.obj25 = (global::Windows.UI.Xaml.Controls.SplitView)target;
                        this.bindingsTracking.RegisterTwoWayListener_25(this.obj25);
                        break;
                    case 26: // Controls\HamburgerMenu.xaml line 335
                        this.obj26 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 27: // Controls\HamburgerMenu.xaml line 342
                        this.obj27 = (global::Windows.UI.Xaml.Controls.ContentControl)target;
                        break;
                    case 28: // Controls\HamburgerMenu.xaml line 298
                        this.obj28 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)target;
                        this.bindingsTracking.RegisterTwoWayListener_28(this.obj28);
                        break;
                    case 29: // Controls\HamburgerMenu.xaml line 305
                        this.obj29 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 30: // Controls\HamburgerMenu.xaml line 311
                        this.obj30 = (global::Windows.UI.Xaml.Controls.ContentControl)target;
                        break;
                    default:
                        break;
                }
            }

            // IHamburgerMenu_Bindings

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
                    this.dataRoot = (global::Helpers.Controls.HamburgerMenu)newDataRoot;
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
            private void Update_(global::Helpers.Controls.HamburgerMenu obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Background(obj.Background, phase);
                        this.Update_HeaderBackground(obj.HeaderBackground, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_HamburgerMenuToggleButton(obj.HamburgerMenuToggleButton, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_PaneBackground(obj.PaneBackground, phase);
                        this.Update_NavigationLinks(obj.NavigationLinks, phase);
                        this.Update_PaneForeground(obj.PaneForeground, phase);
                        this.Update_HeaderForeground(obj.HeaderForeground, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_IsPaneOpen(obj.IsPaneOpen, phase);
                    }
                }
            }
            private void Update_Background(global::Windows.UI.Xaml.Media.Brush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\HamburgerMenu.xaml line 257
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Panel_Background(this.obj23, obj, null);
                }
            }
            private void Update_HeaderBackground(global::Windows.UI.Xaml.Media.SolidColorBrush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\HamburgerMenu.xaml line 290
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Panel_Background(this.obj24, obj, null);
                }
            }
            private void Update_HamburgerMenuToggleButton(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_HamburgerMenuToggleButton(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_HamburgerMenuToggleButton_IsChecked(obj.IsChecked, phase);
                    }
                }
            }
            private void Update_HamburgerMenuToggleButton_IsChecked(global::System.Nullable<global::System.Boolean> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\HamburgerMenu.xaml line 319
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_SplitView_IsPaneOpen(this.obj25, (global::System.Boolean)this.LookupConverter("NullableBooleanToBooleanConverter").Convert(obj, typeof(global::System.Boolean), null, null));
                }
            }
            private void Update_PaneBackground(global::Windows.UI.Xaml.Media.SolidColorBrush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\HamburgerMenu.xaml line 319
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_SplitView_PaneBackground(this.obj25, obj, null);
                }
            }
            private void Update_NavigationLinks(global::Helpers.Navigation.NavigationLink[] obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\HamburgerMenu.xaml line 335
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj26, obj, null);
                }
            }
            private void Update_PaneForeground(global::Windows.UI.Xaml.Media.SolidColorBrush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\HamburgerMenu.xaml line 335
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_Foreground(this.obj26, obj, null);
                    // Controls\HamburgerMenu.xaml line 342
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_Foreground(this.obj27, obj, null);
                }
            }
            private void Update_HeaderForeground(global::Windows.UI.Xaml.Media.SolidColorBrush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Controls\HamburgerMenu.xaml line 298
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_Foreground(this.obj28, obj, null);
                    // Controls\HamburgerMenu.xaml line 305
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Foreground(this.obj29, obj, null);
                    // Controls\HamburgerMenu.xaml line 311
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_Foreground(this.obj30, obj, null);
                }
            }
            private void Update_IsPaneOpen(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\HamburgerMenu.xaml line 298
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj28, (global::System.Nullable<global::System.Boolean>)this.LookupConverter("NullableBooleanToBooleanConverter").Convert(obj, typeof(global::System.Nullable<global::System.Boolean>), null, null), null);
                }
            }
            private void UpdateTwoWay_25_IsPaneOpen()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.HamburgerMenuToggleButton != null)
                        {
                            this.dataRoot.HamburgerMenuToggleButton.IsChecked = (global::System.Nullable<global::System.Boolean>)this.LookupConverter("NullableBooleanToBooleanConverter").ConvertBack(this.obj25.IsPaneOpen, typeof(global::System.Nullable<global::System.Boolean>), null, null);
                        }
                    }
                }
            }
            private void UpdateTwoWay_28_IsChecked()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.IsPaneOpen = (global::System.Boolean)this.LookupConverter("NullableBooleanToBooleanConverter").ConvertBack(this.obj28.IsChecked, typeof(global::System.Boolean), null, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class HamburgerMenu_obj1_BindingsTracking
            {
                private global::System.WeakReference<HamburgerMenu_obj1_Bindings> weakRefToBindingObj; 

                public HamburgerMenu_obj1_BindingsTracking(HamburgerMenu_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<HamburgerMenu_obj1_Bindings>(obj);
                }

                public HamburgerMenu_obj1_Bindings TryGetBindingObject()
                {
                    HamburgerMenu_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_HamburgerMenuToggleButton(null);
                }

                public void DependencyPropertyChanged_HamburgerMenuToggleButton_IsChecked(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    HamburgerMenu_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Windows.UI.Xaml.Controls.Primitives.ToggleButton obj = sender as global::Windows.UI.Xaml.Controls.Primitives.ToggleButton;
                        if (obj != null)
                        {
                            bindings.Update_HamburgerMenuToggleButton_IsChecked(obj.IsChecked, DATA_CHANGED);
                        }
                    }
                }
                private global::Windows.UI.Xaml.Controls.Primitives.ToggleButton cache_HamburgerMenuToggleButton = null;
                private long tokenDPC_HamburgerMenuToggleButton_IsChecked = 0;
                public void UpdateChildListeners_HamburgerMenuToggleButton(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton obj)
                {
                    if (obj != cache_HamburgerMenuToggleButton)
                    {
                        if (cache_HamburgerMenuToggleButton != null)
                        {
                            cache_HamburgerMenuToggleButton.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, tokenDPC_HamburgerMenuToggleButton_IsChecked);
                            cache_HamburgerMenuToggleButton = null;
                        }
                        if (obj != null)
                        {
                            cache_HamburgerMenuToggleButton = obj;
                            tokenDPC_HamburgerMenuToggleButton_IsChecked = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, DependencyPropertyChanged_HamburgerMenuToggleButton_IsChecked);
                        }
                    }
                }
                public void RegisterTwoWayListener_25(global::Windows.UI.Xaml.Controls.SplitView sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.SplitView.IsPaneOpenProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_25_IsPaneOpen();
                        }
                    });
                }
                public void RegisterTwoWayListener_28(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_28_IsChecked();
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
            switch(connectionId)
            {
            case 2: // Controls\HamburgerMenu.xaml line 249
                {
                    this.HamburgerMenuNavigationListViewStyle = (global::Windows.UI.Xaml.Style)(target);
                }
                break;
            case 25: // Controls\HamburgerMenu.xaml line 319
                {
                    this.HamburgerMenuSplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 26: // Controls\HamburgerMenu.xaml line 335
                {
                    this.HamburgerMenuNavigationListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.HamburgerMenuNavigationListView).SelectionChanged += this.HamburgerMenuNavigationListView_SelectionChanged;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.HamburgerMenuNavigationListView).Loaded += this.HamburgerMenuNavigationListView_Loaded;
                }
                break;
            case 28: // Controls\HamburgerMenu.xaml line 298
                {
                    this.HamburgerMenuToggleButton = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                }
                break;
            case 29: // Controls\HamburgerMenu.xaml line 305
                {
                    this.HamburgerMenuHeaderTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
            case 1: // Controls\HamburgerMenu.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    HamburgerMenu_obj1_Bindings bindings = new HamburgerMenu_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    bindings.SetConverterLookupRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 4: // Controls\HamburgerMenu.xaml line 240
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element4 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    HamburgerMenu_obj4_Bindings bindings = new HamburgerMenu_obj4_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element4.DataContext);
                    element4.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element4, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element4, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
