using System;
using System.Collections.Generic;
using UnityEngine;

namespace UniRx{
    internal static class KeyInputUtil{
        internal enum InputType{
            GetKey, GetKeyDown, GetKeyUp, anyKey, anyKeyDown
        }

        private static readonly Dictionary<InputType, Func<KeyCode, bool>> inputTable = new Dictionary<InputType, Func<KeyCode, bool>>{
                {InputType.GetKey, Input.GetKey},
                {InputType.GetKeyDown, Input.GetKeyDown},
                {InputType.GetKeyUp, Input.GetKeyUp},
                {InputType.anyKey, _ => Input.anyKey},
                {InputType.anyKeyDown, _ => Input.anyKeyDown}
        };

        internal static IObservable<Unit> CreateSubject(InputType inputType, KeyCode keyCode = KeyCode.None) =>
            Observable.EveryUpdate()
                      .Where(_ => inputTable[inputType](keyCode))
                      .AsUnitObservable();


        static void Hoge(){}
    }
}
