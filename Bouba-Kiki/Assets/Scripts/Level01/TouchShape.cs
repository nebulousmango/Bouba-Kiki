using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TouchShape : MonoBehaviour
{
    private new Collider2D collider2D;
    [HideInInspector] public static int shapeSequence;

    void Start()
    {
        collider2D = GetComponent<Collider2D>();
        shapeSequence = 0;
    }

    private void Update()
    {
        CheckForTouch();
    }

    public void CheckForTouch()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            var wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            var touchPosition = new Vector2(wp.x, wp.y);

            if (collider2D == Physics2D.OverlapPoint(touchPosition))
            {
                shapeSequence++;
            }
            else
            {
                SceneManager.LoadScene("FailMenu01");
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            var wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var touchPosition = new Vector2(wp.x, wp.y);

            if (collider2D == Physics2D.OverlapPoint(touchPosition))
            {
                shapeSequence++;
            }
            else
            {
                SceneManager.LoadScene("FailMenu01");
            }
        }
    }
}
