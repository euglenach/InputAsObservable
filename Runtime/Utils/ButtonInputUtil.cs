using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace InputAsRx{
    internal static class ButtonInputUtil{
        internal enum InputType{
            GetButton, GetButtonDown, GetButtonUp
        }

        private static readonly Dictionary<InputType, Func<string, bool>> inputTable =
            new Dictionary<InputType, Func<string, bool>>{
                {InputType.GetButton, Input.GetButton},
                {InputType.GetButtonDown, Input.GetButtonDown},
                {InputType.GetButtonUp, Input.GetButtonUp}
            };

        internal static IObservable<Unit> CreateSubject(InputType inputType, string buttonName) =>
            Observable.EveryUpdate()
                      .Where(_ => inputTable[inputType](buttonName))
                      .AsUnitObservable();
    }
}