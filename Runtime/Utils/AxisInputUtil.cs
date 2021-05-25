using System;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace InputAsRx.Util{
    internal static class AxisInputUtil{
        internal enum InputType{
            Axis, AxisRaw
        }

        private static readonly Dictionary<InputType, Func<string, float>> inputTable = new Dictionary<InputType, Func<string, float>>{
                {InputType.Axis, Input.GetAxis},{InputType.AxisRaw, Input.GetAxisRaw}
        };

        internal static IObservable<float> CreateSubject(InputType inputType, string axisName) =>
            Observable.EveryUpdate()
                      .Select(_ => inputTable[inputType](axisName));
    }
}
