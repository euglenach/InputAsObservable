using System;
using UnityEngine;

namespace UniRx.Triggers{
    public static class InputAsObservableTriggerExtensions{
        public static IObservable<Unit> OnKeyAsObservable(this Component component, KeyCode keyCode) =>
            KeyInputUtil.CreateSubject(KeyInputUtil.InputType.GetKey, keyCode)
                        .TakeUntilDestroy(component);

        public static IObservable<Unit> OnKeyDownAsObservable(this Component component, KeyCode keyCode) =>
            KeyInputUtil.CreateSubject(KeyInputUtil.InputType.GetKeyDown, keyCode)
                        .TakeUntilDestroy(component);

        public static IObservable<Unit> OnKeyUpAsObservable(this Component component, KeyCode keyCode) =>
            KeyInputUtil.CreateSubject(KeyInputUtil.InputType.GetKeyUp, keyCode)
                        .TakeUntilDestroy(component);

        public static IObservable<Unit> OnAnyKeyAsObservable(this Component component) =>
            KeyInputUtil.CreateSubject(KeyInputUtil.InputType.anyKey)
                        .TakeUntilDestroy(component);

        public static IObservable<Unit> OnAnyKeyDownAsObservable(this Component component) =>
            KeyInputUtil.CreateSubject(KeyInputUtil.InputType.anyKeyDown)
                        .TakeUntilDestroy(component);

        public static IObservable<float> OnAxisAsObservable(this Component component, string axisName) =>
            AxisInputUtil.CreateSubject(AxisInputUtil.InputType.Axis, axisName)
                         .TakeUntilDestroy(component);

        public static IObservable<float> OnAxisRawAsObservable(this Component component, string axisName) =>
            AxisInputUtil.CreateSubject(AxisInputUtil.InputType.AxisRaw, axisName)
                         .TakeUntilDestroy(component);

        public static IObservable<Unit> OnButtonAsObservable(this Component component, string buttonName) =>
            ButtonInputUtil.CreateSubject(ButtonInputUtil.InputType.GetButton, buttonName)
                           .TakeUntilDestroy(component);
        
        public static IObservable<Unit> OnButtonDownAsObservable(this Component component, string buttonName) =>
            ButtonInputUtil.CreateSubject(ButtonInputUtil.InputType.GetButtonDown, buttonName)
                           .TakeUntilDestroy(component);
        
        public static IObservable<Unit> OnButtonUpAsObservable(this Component component, string buttonName) =>
            ButtonInputUtil.CreateSubject(ButtonInputUtil.InputType.GetButtonUp, buttonName)
                           .TakeUntilDestroy(component);
    }
}
