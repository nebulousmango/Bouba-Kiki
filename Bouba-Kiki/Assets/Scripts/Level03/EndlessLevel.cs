using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessLevel : MonoBehaviour
{
    // Array for shapes in randomised pool. 
    [SerializeField] GameObject[] changingShapeList;
    // Array for all eighteen shapes on board.
    [SerializeField] GameObject[] fixedShapeList;
    // Int used by shape randomiser.
    private int currentIndex = 0;

    // ChangeShape function listens for OnCorrectShape event.
    private void OnEnable()
    {
        TouchEvent.OnCorrectShape += ChangeShape;
    }
    private void OnDisable()
    {
        TouchEvent.OnCorrectShape -= ChangeShape;
    }

    private void Start()
    {
        // Initialises scene.
        DisableScripts();

        // Starts shape changing loop.
        ChangeShape();    
    }


    // Function for shape randomiser.
    void ChangeShape()
    {
        // Disables TouchShape script for all fixed shapes on board.
        DisableScripts();

        // Generates random number, activates new centre shape and deactivates old centre shape.
        int newIndex = Random.Range(0, changingShapeList.Length);
        changingShapeList[currentIndex].SetActive(false);
        currentIndex = newIndex;
        changingShapeList[currentIndex].SetActive(true);

        // Enables TouchShape script for matching shape by looking for matching tag.
        string currentTag = changingShapeList[currentIndex].tag;
        GameObject activeShape = GameObject.FindGameObjectWithTag(currentTag);
        activeShape.GetComponent<TouchShapeMain>().enabled = true;
    }

    // Function that disables TouchShape script for each object in the FixedShape array.
    public void DisableScripts()
    {
        int numFixedShapes = fixedShapeList.Length;
        for (int i = 0; i < numFixedShapes; i++)
        {
            fixedShapeList[i].GetComponent<TouchShapeMain>().enabled = false;
        }
    }
}
