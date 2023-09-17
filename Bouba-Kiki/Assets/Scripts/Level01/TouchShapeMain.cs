using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class TouchShapeMain : MonoBehaviour
{
    private new Collider2D collider2D;
    [SerializeField] bool isInfiniteLevel;
    [SerializeField] string failScene;

    void Start()
    {
        collider2D = GetComponent<Collider2D>();
    }

    private void Update()
    {
        CheckForTouch();
    }

    // Function to check for incorrect or correct player tap.
    void CheckForTouch()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            var wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            var touchPosition = new Vector2(wp.x, wp.y);

            // If player touches collider.
            if (collider2D == Physics2D.OverlapPoint(touchPosition))
            {
                // Triggers event function, which EndlessLevel script uses to run ChangeShape.
                FindObjectOfType<TouchEvent>().CorrectShapeEvent();
            }

            // If player taps anywhere outside the collider.
            else
            {
                if(isInfiniteLevel) SceneManager.LoadScene(failScene);
                else FindObjectOfType<TimeManager>().LevelOver();
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            var wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var touchPosition = new Vector2(wp.x, wp.y);

            if (collider2D == Physics2D.OverlapPoint(touchPosition))
            {
                FindObjectOfType<TouchEvent>().CorrectShapeEvent();
            }

            else
            {
                if (isInfiniteLevel) SceneManager.LoadScene(failScene);
                else FindObjectOfType<TimeManager>().LevelOver();
            }
        }
    }
}