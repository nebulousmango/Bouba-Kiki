using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void ObjectFallAction();
    public static event ObjectFallAction OnObjectFall;

    public void ObjectFallEvent()
    {
        if(OnObjectFall!=null)
        {
            OnObjectFall();
        }
    }
}
