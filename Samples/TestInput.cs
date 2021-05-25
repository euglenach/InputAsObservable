using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class TestInput : MonoBehaviour{
    
    void Start(){
        InputAsObservable.GetKey(KeyCode.A).Subscribe(_ => Debug.Log("key:A"));
        InputAsObservable.GetKeyDown(KeyCode.B).Subscribe(_ => Debug.Log("keydown:B"));
        InputAsObservable.GetKeyUp(KeyCode.C).Subscribe(_ => Debug.Log("keyup:C"));
        InputAsObservable.AnyKey.Subscribe(_ => Debug.Log("anyKey"));
        InputAsObservable.AnyKeyDown.Subscribe(_ => Debug.Log("anyKeyDown"));
        InputAsObservable.Axis("Vertical").Subscribe(y => Debug.Log("Axis y:" + y));
        InputAsObservable.AxisRaw("Horizontal").Subscribe(x => Debug.Log("AxisRaw x:" + x));
        InputAsObservable.GetMouseButton(0).Subscribe(_ => Debug.Log("mouse0"));
        InputAsObservable.GetMouseButtonDown(1).Subscribe(_ => Debug.Log("mouseDown1"));
        InputAsObservable.GetMouseButtonUp(2).Subscribe(_ => Debug.Log("mouseUp2"));
        InputAsObservable.GetButton("Fire1").Subscribe(_ => Debug.Log("button:Fire1"));
        InputAsObservable.GetButtonDown("Jump").Subscribe(_ => Debug.Log("buttonDown:Jump"));
        InputAsObservable.GetButtonDown("Submit").Subscribe(_ => Debug.Log("buttonUp:Submit"));

        this.OnKeyAsObservable(KeyCode.D).Subscribe(_ => Debug.Log("key:D"));
        this.OnKeyDownAsObservable(KeyCode.E).Subscribe(_ => Debug.Log("key:E"));
        this.OnKeyUpAsObservable(KeyCode.F).Subscribe(_ => Debug.Log("key:F"));
        this.OnAnyKeyAsObservable().Subscribe(_ => Debug.Log("anyKey"));
        this.OnAnyKeyDownAsObservable().Subscribe(_ => Debug.Log("anyKeyDown"));
        this.OnAxisAsObservable("Vertical").Subscribe(x => Debug.Log("Axis:" + x));
        this.OnAxisRawAsObservable("Horizontal").Subscribe(x => Debug.Log("AxisRaw x:" + x));
        this.OnButtonAsObservable("Fire1").Subscribe(_ => Debug.Log("button:Fire1"));
        this.OnButtonDownAsObservable("Jump").Subscribe(_ => Debug.Log("buttonDown:Jump"));
        this.OnButtonUpAsObservable("Submit").Subscribe(_ => Debug.Log("buttonUp:Submit"));
    }
}