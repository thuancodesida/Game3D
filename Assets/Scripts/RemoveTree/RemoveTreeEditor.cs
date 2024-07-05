using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.TerrainTools;
using UnityEngine;
[CustomEditor(typeof(RemoveTree))]

public class RemoveTreeEditor : Editor
{
  public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        RemoveTree removeTree = (RemoveTree)target;
        if(GUILayout.Button("Remove Underwater Trees"))
        {
            removeTree.RemoveTreeUnderWater();
        }
    }
}
