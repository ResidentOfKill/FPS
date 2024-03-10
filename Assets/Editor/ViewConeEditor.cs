using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;
using UnityEngine.XR;

[CustomEditor(typeof(ViewCone))]
public class ViewConeEditor : Editor
{
    private void OnSceneGUI()
    {
        ViewCone viewCone = (ViewCone)target;
        Handles.color = Color.white;
        Handles.DrawWireArc(viewCone.transform.position,Vector3.up, Vector3.forward,360,viewCone.viewRadius);
        Vector3 viewAngleA = viewCone.DirectionFromAngle(-viewCone.viewAngle / 2, false);
        Vector3 viewAngleB = viewCone.DirectionFromAngle(viewCone.viewAngle / 2, false);
        Handles.DrawLine(viewCone.transform.position,viewCone.transform.position+viewAngleA*viewCone.viewRadius);
        Handles.DrawLine(viewCone.transform.position,viewCone.transform.position+viewAngleB*viewCone.viewRadius);


        foreach (Transform visiblePlayer in viewCone.visiblePlayers)
        {
          Handles.DrawLine(viewCone.transform.position,visiblePlayer.position);  
        }
    }
}
