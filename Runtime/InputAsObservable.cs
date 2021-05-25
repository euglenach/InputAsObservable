using System;
using InputAsRx.Util;
using UniRx;
using UnityEngine;

namespace InputAsRx{
    public static class InputAsObservable{
        public static IObservable<Unit> GetKey(KeyCode keyCode) =>
            KeyInputUtil.CreateSubject(KeyInputUtil.InputType.GetKey, keyCode);

        public static IObservable<Unit> GetKeyDown(KeyCode keyCode) =>
            KeyInputUtil.CreateSubject(KeyInputUtil.InputType.GetKeyDown, keyCode);

        public static IObservable<Unit> GetKeyUp(KeyCode keyCode) =>
            KeyInputUtil.CreateSubject(KeyInputUtil.InputType.GetKeyUp, keyCode);

        public static IObservable<Unit> AnyKey => KeyInputUtil.CreateSubject(KeyInputUtil.InputType.anyKey);
        public static IObservable<Unit> AnyKeyDown => KeyInputUtil.CreateSubject(KeyInputUtil.InputType.anyKeyDown);

        public static IObservable<float> Axis(string axisName) =>
            AxisInputUtil.CreateSubject(AxisInputUtil.InputType.Axis, axisName);

        public static IObservable<float> AxisRaw(string axisName) =>
            AxisInputUtil.CreateSubject(AxisInputUtil.InputType.AxisRaw, axisName);

        public static IObservable<Unit> GetMouseButton(int button) =>
            MouseButtonInputUtil.CreateSubject(MouseButtonInputUtil.InputType.GetMouseButton, button);

        public static IObservable<Unit> GetMouseButtonDown(int button) =>
            MouseButtonInputUtil.CreateSubject(MouseButtonInputUtil.InputType.GetMouseButtonDown, button);

        public static IObservable<Unit> GetMouseButtonUp(int button) =>
            MouseButtonInputUtil.CreateSubject(MouseButtonInputUtil.InputType.GetMouseButtonUp, button);

        public static IObservable<Unit> GetButton(string buttonName) =>
            ButtonInputUtil.CreateSubject(ButtonInputUtil.InputType.GetButton, buttonName);
        
        public static IObservable<Unit> GetButtonDown(string buttonName) =>
            ButtonInputUtil.CreateSubject(ButtonInputUtil.InputType.GetButtonDown, buttonName);
        
        public static IObservable<Unit> GetButtonUp(string buttonName) =>
            ButtonInputUtil.CreateSubject(ButtonInputUtil.InputType.GetButtonUp, buttonName);
    }
}
