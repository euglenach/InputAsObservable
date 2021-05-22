using System;
using System.Collections.Generic;
using UnityEngine;

namespace UniRx{
    internal static class MouseButtonInputUtil{
        internal enum InputType{
            GetMouseButton, GetMouseButtonDown, GetMouseButtonUp
        }

        private static readonly Dictionary<InputType, Func<int, bool>> inputTable = new Dictionary<InputType, Func<int, bool>>{
                {InputType.GetMouseButton, Input.GetMouseButton},
                {InputType.GetMouseButtonDown, Input.GetMouseButtonDown},
                {InputType.GetMouseButtonUp, Input.GetMouseButtonUp}
        };

        internal static IObservable<Unit> CreateSubject(InputType inputType, int button) =>
            Observable.EveryUpdate()
                      .Where(_ => inputTable[inputType](button))
                      .AsUnitObservable();
    }
}
