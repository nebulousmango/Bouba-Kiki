using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchEvent : MonoBehaviour
{
    public delegate void CorrectShape();
    public static event CorrectShape OnCorrectShape;


    // Event function triggered when player touches correct shape.
    public void CorrectShapeEvent()
    {
        if(OnCorrectShape != null) 
            OnCorrectShape();
    }
}
