using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    Touch touch;
    Vector2 v2_startPos;
    Vector2 v2_direction;

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                v2_startPos = touch.position;
                Vector3 v3_newPos = Camera.main.ScreenToWorldPoint(v2_startPos);
                v3_newPos.z = 0;
                transform.position = v3_newPos;
            }
        }
    }

}
