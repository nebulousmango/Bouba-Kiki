using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchInput : MonoBehaviour
{
    Touch touch;
    Vector2 v2_startPos;

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

        //if(Input.GetMouseButtonDown(0))
        //{
        //    Vector3 v3_newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    v3_newPos.z = 0;
        //    transform.position = v3_newPos;
        //}
    }

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        SceneManager.LoadScene("FailMenu02");
    }
}
