using System;
using UnityEngine;

public class SocketInteraction : MonoBehaviour
{
    public bool leftDoorAttached = false;
    public bool rightDoorAttached = false;

    public GameObject leftDoor;
    public GameObject rightDoor;

    void Update()
    {
        // check bool status, if all true execute code
        if (!(leftDoorAttached == false & rightDoorAttached == false))
        {
            ChangeDoors();
        }
    }

    public void LeftDoorAttached()
    {
        leftDoorAttached = true;
    }

    public void RightDoorAttached()
    {
        rightDoorAttached = true;
    }

    public void ChangeDoors()
    {
        Debug.Log("both doors attached");
    }
}
