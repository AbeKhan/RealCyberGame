using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockMouse : MonoBehaviour
{
    public bool t = true;
    private void Update()
    {
        OnApplicationFocus(t);
    }
    void OnApplicationFocus(bool hasFocus)
    {
        if (hasFocus)
        {
            Cursor.lockState = CursorLockMode.Locked;
            // Debug.Log("Application is focussed");
        }
        //else
        //{
        //    Debug.Log("Application lost focus");
        //}
    }
}