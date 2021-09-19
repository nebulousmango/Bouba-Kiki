using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TouchShape : MonoBehaviour
{
    private Collider2D collider2D;
    private TouchScriptSwitch touchSwitch;
    [HideInInspector] public static int shapeSequence;

    void Start()
    {
        collider2D = GetComponent<Collider2D>();
        touchSwitch = GetComponent<TouchScriptSwitch>();
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
                Debug.Log(shapeSequence);
            }
            else
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
