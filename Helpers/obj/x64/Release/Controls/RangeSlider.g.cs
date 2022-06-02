﻿#pragma checksum "C:\Users\Lucas Oropeza\Documents\PR-EYE TRACKING\PR-EYE TRACKING HEATMAPS\Helpers\Controls\RangeSlider.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "73AEC1458348335DBDD64C4A16A7205FCC61A88D95736ED3A2DD0B673199453B"
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
    partial class RangeSlider : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Slider_TickFrequency(global::Windows.UI.Xaml.Controls.Slider obj, global::System.Double value)
            {
                obj.TickFrequency = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Minimum(global::Windows.UI.Xaml.Controls.Primitives.RangeBase obj, global::System.Double value)
            {
                obj.Minimum = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Maximum(global::Windows.UI.Xaml.Controls.Primitives.RangeBase obj, global::System.Double value)
            {
                obj.Maximum = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Slider_StepFrequency(global::Windows.UI.Xaml.Controls.Slider obj, global::System.Double value)
            {
                obj.StepFrequency = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(global::Windows.UI.Xaml.Controls.Primitives.RangeBase obj, global::System.Double value)
            {
                obj.Value = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Control_IsEnabled(global::Windows.UI.Xaml.Controls.Control obj, global::System.Boolean value)
            {
                obj.IsEnabled = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Slider_ThumbToolTipValueConverter(global::Windows.UI.Xaml.Controls.Slider obj, global::Windows.UI.Xaml.Data.IValueConverter value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Data.IValueConverter) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Data.IValueConverter), targetNullValue);
                }
                obj.ThumbToolTipValueConverter = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class RangeSlider_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IRangeSlider_Bindings
        {
            private global::Helpers.Controls.RangeSlider dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Slider obj77;
            private global::Windows.UI.Xaml.Controls.Slider obj78;
            private global::Windows.UI.Xaml.Controls.Slider obj79;

            private RangeSlider_obj1_BindingsTracking bindingsTracking;

            public RangeSlider_obj1_Bindings()
            {
                this.bindingsTracking = new RangeSlider_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 77: // Controls\RangeSlider.xaml line 472
                        this.obj77 = (global::Windows.UI.Xaml.Controls.Slider)target;
                        break;
                    case 78: // Controls\RangeSlider.xaml line 481
                        this.obj78 = (global::Windows.UI.Xaml.Controls.Slider)target;
                        this.bindingsTracking.RegisterTwoWayListener_78(this.obj78);
                        break;
                    case 79: // Controls\RangeSlider.xaml line 492
                        this.obj79 = (global::Windows.UI.Xaml.Controls.Slider)target;
                        this.bindingsTracking.RegisterTwoWayListener_79(this.obj79);
                        break;
                    default:
                        break;
                }
            }

            // IRangeSlider_Bindings

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
                    this.dataRoot = (global::Helpers.Controls.RangeSlider)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Helpers.Controls.RangeSlider obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_TickFrequency(obj.TickFrequency, phase);
                        this.Update_Minimum(obj.Minimum, phase);
                        this.Update_Maximum(obj.Maximum, phase);
                        this.Update_StepFrequency(obj.StepFrequency, phase);
                        this.Update_End(obj.End, phase);
                        this.Update_IsEndSliderEnabled(obj.IsEndSliderEnabled, phase);
                        this.Update_ThumbTooltipValueConverter(obj.ThumbTooltipValueConverter, phase);
                        this.Update_Start(obj.Start, phase);
                        this.Update_IsStartSliderEnabled(obj.IsStartSliderEnabled, phase);
                    }
                }
            }
            private void Update_TickFrequency(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\RangeSlider.xaml line 472
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Slider_TickFrequency(this.obj77, obj);
                }
            }
            private void Update_Minimum(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\RangeSlider.xaml line 472
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Minimum(this.obj77, obj);
                    // Controls\RangeSlider.xaml line 481
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Minimum(this.obj78, obj);
                    // Controls\RangeSlider.xaml line 492
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Minimum(this.obj79, obj);
                }
            }
            private void Update_Maximum(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\RangeSlider.xaml line 472
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Maximum(this.obj77, obj);
                    // Controls\RangeSlider.xaml line 481
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Maximum(this.obj78, obj);
                    // Controls\RangeSlider.xaml line 492
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Maximum(this.obj79, obj);
                }
            }
            private void Update_StepFrequency(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\RangeSlider.xaml line 472
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Slider_StepFrequency(this.obj77, obj);
                    // Controls\RangeSlider.xaml line 481
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Slider_StepFrequency(this.obj78, obj);
                    // Controls\RangeSlider.xaml line 492
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Slider_StepFrequency(this.obj79, obj);
                }
            }
            private void Update_End(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\RangeSlider.xaml line 481
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(this.obj78, obj);
                }
            }
            private void Update_IsEndSliderEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\RangeSlider.xaml line 481
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj78, obj);
                }
            }
            private void Update_ThumbTooltipValueConverter(global::Windows.UI.Xaml.Data.IValueConverter obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\RangeSlider.xaml line 481
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Slider_ThumbToolTipValueConverter(this.obj78, obj, null);
                    // Controls\RangeSlider.xaml line 492
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Slider_ThumbToolTipValueConverter(this.obj79, obj, null);
                }
            }
            private void Update_Start(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\RangeSlider.xaml line 492
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(this.obj79, obj);
                }
            }
            private void Update_IsStartSliderEnabled(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Controls\RangeSlider.xaml line 492
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Control_IsEnabled(this.obj79, obj);
                }
            }
            private void UpdateTwoWay_78_Value()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.End = this.obj78.Value;
                    }
                }
            }
            private void UpdateTwoWay_79_Value()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.Start = this.obj79.Value;
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class RangeSlider_obj1_BindingsTracking
            {
                private global::System.WeakReference<RangeSlider_obj1_Bindings> weakRefToBindingObj; 

                public RangeSlider_obj1_BindingsTracking(RangeSlider_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<RangeSlider_obj1_Bindings>(obj);
                }

                public RangeSlider_obj1_Bindings TryGetBindingObject()
                {
                    RangeSlider_obj1_Bindings bindingObject = null;
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
                }

                public void DependencyPropertyChanged_TickFrequency(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    RangeSlider_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Helpers.Controls.RangeSlider obj = sender as global::Helpers.Controls.RangeSlider;
                        if (obj != null)
                        {
                            bindings.Update_TickFrequency(obj.TickFrequency, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_Minimum(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    RangeSlider_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Helpers.Controls.RangeSlider obj = sender as global::Helpers.Controls.RangeSlider;
                        if (obj != null)
                        {
                            bindings.Update_Minimum(obj.Minimum, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_Maximum(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    RangeSlider_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Helpers.Controls.RangeSlider obj = sender as global::Helpers.Controls.RangeSlider;
                        if (obj != null)
                        {
                            bindings.Update_Maximum(obj.Maximum, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_StepFrequency(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    RangeSlider_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Helpers.Controls.RangeSlider obj = sender as global::Helpers.Controls.RangeSlider;
                        if (obj != null)
                        {
                            bindings.Update_StepFrequency(obj.StepFrequency, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_End(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    RangeSlider_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Helpers.Controls.RangeSlider obj = sender as global::Helpers.Controls.RangeSlider;
                        if (obj != null)
                        {
                            bindings.Update_End(obj.End, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_IsEndSliderEnabled(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    RangeSlider_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Helpers.Controls.RangeSlider obj = sender as global::Helpers.Controls.RangeSlider;
                        if (obj != null)
                        {
                            bindings.Update_IsEndSliderEnabled(obj.IsEndSliderEnabled, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_ThumbTooltipValueConverter(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    RangeSlider_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Helpers.Controls.RangeSlider obj = sender as global::Helpers.Controls.RangeSlider;
                        if (obj != null)
                        {
                            bindings.Update_ThumbTooltipValueConverter(obj.ThumbTooltipValueConverter, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_Start(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    RangeSlider_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Helpers.Controls.RangeSlider obj = sender as global::Helpers.Controls.RangeSlider;
                        if (obj != null)
                        {
                            bindings.Update_Start(obj.Start, DATA_CHANGED);
                        }
                    }
                }
                public void DependencyPropertyChanged_IsStartSliderEnabled(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    RangeSlider_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::Helpers.Controls.RangeSlider obj = sender as global::Helpers.Controls.RangeSlider;
                        if (obj != null)
                        {
                            bindings.Update_IsStartSliderEnabled(obj.IsStartSliderEnabled, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_TickFrequency = 0;
                private long tokenDPC_Minimum = 0;
                private long tokenDPC_Maximum = 0;
                private long tokenDPC_StepFrequency = 0;
                private long tokenDPC_End = 0;
                private long tokenDPC_IsEndSliderEnabled = 0;
                private long tokenDPC_ThumbTooltipValueConverter = 0;
                private long tokenDPC_Start = 0;
                private long tokenDPC_IsStartSliderEnabled = 0;
                public void UpdateChildListeners_(global::Helpers.Controls.RangeSlider obj)
                {
                    RangeSlider_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.TickFrequencyProperty, tokenDPC_TickFrequency);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.MinimumProperty, tokenDPC_Minimum);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.MaximumProperty, tokenDPC_Maximum);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.StepFrequencyProperty, tokenDPC_StepFrequency);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.EndProperty, tokenDPC_End);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.IsEndSliderEnabledProperty, tokenDPC_IsEndSliderEnabled);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.ThumbTooltipValueConverterProperty, tokenDPC_ThumbTooltipValueConverter);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.StartProperty, tokenDPC_Start);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.IsStartSliderEnabledProperty, tokenDPC_IsStartSliderEnabled);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_TickFrequency = obj.RegisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.TickFrequencyProperty, DependencyPropertyChanged_TickFrequency);
                            tokenDPC_Minimum = obj.RegisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.MinimumProperty, DependencyPropertyChanged_Minimum);
                            tokenDPC_Maximum = obj.RegisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.MaximumProperty, DependencyPropertyChanged_Maximum);
                            tokenDPC_StepFrequency = obj.RegisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.StepFrequencyProperty, DependencyPropertyChanged_StepFrequency);
                            tokenDPC_End = obj.RegisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.EndProperty, DependencyPropertyChanged_End);
                            tokenDPC_IsEndSliderEnabled = obj.RegisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.IsEndSliderEnabledProperty, DependencyPropertyChanged_IsEndSliderEnabled);
                            tokenDPC_ThumbTooltipValueConverter = obj.RegisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.ThumbTooltipValueConverterProperty, DependencyPropertyChanged_ThumbTooltipValueConverter);
                            tokenDPC_Start = obj.RegisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.StartProperty, DependencyPropertyChanged_Start);
                            tokenDPC_IsStartSliderEnabled = obj.RegisterPropertyChangedCallback(global::Helpers.Controls.RangeSlider.IsStartSliderEnabledProperty, DependencyPropertyChanged_IsStartSliderEnabled);
                        }
                    }
                }
                public void RegisterTwoWayListener_78(global::Windows.UI.Xaml.Controls.Slider sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_78_Value();
                        }
                    });
                }
                public void RegisterTwoWayListener_79(global::Windows.UI.Xaml.Controls.Slider sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_79_Value();
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
            case 78: // Controls\RangeSlider.xaml line 481
                {
                    this.EndSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.EndSlider).ValueChanged += this.EndSlider_ValueChanged;
                }
                break;
            case 79: // Controls\RangeSlider.xaml line 492
                {
                    this.StartSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                    ((global::Windows.UI.Xaml.Controls.Slider)this.StartSlider).ValueChanged += this.StartSlider_ValueChanged;
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
            case 1: // Controls\RangeSlider.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    RangeSlider_obj1_Bindings bindings = new RangeSlider_obj1_Bindings();
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

