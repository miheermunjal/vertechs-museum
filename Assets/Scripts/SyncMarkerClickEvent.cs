using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncMarkerClickEvent : MonoBehaviour, IInputClickHandler
{
    public void OnInputClicked(InputClickedEventData eventData)
    {
        var camera = GameObject.FindWithTag("MainCamera");
        var marker = GameObject.FindWithTag("SyncMarker");
        var room = GameObject.FindWithTag("Room");

        var deltaRotationY = marker.transform.rotation.eulerAngles.y - transform.rotation.eulerAngles.y;
        room.transform.RotateAround(marker.transform.position, Vector3.up, deltaRotationY);

        var deltaPosition = marker.transform.position - transform.position;
        room.transform.position -= deltaPosition;



    }
}
