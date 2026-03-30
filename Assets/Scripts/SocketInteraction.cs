using System;
using UnityEngine;

public class SocketInteraction : MonoBehaviour
{
    public bool leftDoorAttached = false;
    public bool rightDoorAttached = false;

    public GameObject leftDoor;
    public GameObject rightDoor;
    public GameObject doorWall;

    void Update()
    {
        // check bool status, if all true execute code
        if (leftDoorAttached == true && rightDoorAttached == true)
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
        //Debug.Log("both doors attached");
        doorWall.SetActive(false);
        leftDoor.SetActive(false);
        rightDoor.SetActive(false);
    }
}
