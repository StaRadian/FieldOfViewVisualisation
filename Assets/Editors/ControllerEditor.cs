using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof (Controller))]
public class ControllerEditor : Editor
{
    void OnSceneGUI()
    {
        Controller fow = (Controller)target;

        //Mouse Position
        Handles.color = Color.white;
        Handles.DrawWireArc(fow.AimPos, Vector3.up, Vector3.forward, 360.0f, 0.1f);
    }
}