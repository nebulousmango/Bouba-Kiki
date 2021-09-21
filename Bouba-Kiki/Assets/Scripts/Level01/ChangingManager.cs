using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangingManager : MonoBehaviour
{
    public GameObject[] changingShape;
    GameObject activeShape;
    GameObject prevShape;
    int sequenceNumber;

    private void Start()
    {
        changingShape[0].SetActive(false); //A_Red: Shape 1
        changingShape[1].SetActive(false); //E_Green: Shape 11
        changingShape[2].SetActive(false); //F_Purp: Shape 18
        changingShape[3].SetActive(false); //C_Red: Shape 3
        changingShape[4].SetActive(false); //B_Green: Shape 8
        changingShape[5].SetActive(false); //E_Red: Shape 5
        changingShape[6].SetActive(false); //D_Purp: Shape 16
        changingShape[7].SetActive(false); //B_Red: Shape 2
        changingShape[8].SetActive(false); //D_Red: Shape 4
        changingShape[9].SetActive(false); //A_Purp: Shape 13
    }

    void Update()
    {
        PlaySong();
        sequenceNumber = TouchShape.shapeSequence;
    }

    void PlaySong()
    {
        if (sequenceNumber == 0)
        {
            activeShape = GameObject.FindGameObjectWithTag("Shape1");
            activeShape.GetComponent<TouchScriptSwitch>().SwitchOnScript();
            changingShape[0].SetActive(true);
        }

        if(sequenceNumber == 1)
        {
            changingShape[0].SetActive(false);
            prevShape = GameObject.FindGameObjectWithTag("Shape1");
            prevShape.GetComponent<TouchScriptSwitch>().SwitchOffScript();

            activeShape = GameObject.FindGameObjectWithTag("Shape11");
            activeShape.GetComponent<TouchScriptSwitch>().SwitchOnScript();
            changingShape[1].SetActive(true);
        }

        if (sequenceNumber == 2)
        {
            changingShape[0].SetActive(false);
            prevShape = GameObject.FindGameObjectWithTag("Shape11");
            prevShape.GetComponent<TouchScriptSwitch>().SwitchOffScript();

            changingShape[1].SetActive(false);
            activeShape = GameObject.FindGameObjectWithTag("Shape18");
            activeShape.GetComponent<TouchScriptSwitch>().SwitchOnScript();
            changingShape[2].SetActive(true);
        }

        if (sequenceNumber == 3)
        {
            changingShape[0].SetActive(false);
            prevShape = GameObject.FindGameObjectWithTag("Shape18");
            prevShape.GetComponent<TouchScriptSwitch>().SwitchOffScript();

            changingShape[2].SetActive(false);
            activeShape = GameObject.FindGameObjectWithTag("Shape3");
            activeShape.GetComponent<TouchScriptSwitch>().SwitchOnScript();
            changingShape[3].SetActive(true);
        }

        if (sequenceNumber == 4)
        {
            changingShape[0].SetActive(false);
            prevShape = GameObject.FindGameObjectWithTag("Shape3");
            prevShape.GetComponent<TouchScriptSwitch>().SwitchOffScript();

            changingShape[3].SetActive(false);
            activeShape = GameObject.FindGameObjectWithTag("Shape8");
            activeShape.GetComponent<TouchScriptSwitch>().SwitchOnScript();
            changingShape[4].SetActive(true);
        }

        if (sequenceNumber == 5)
        {
            changingShape[0].SetActive(false);
            prevShape = GameObject.FindGameObjectWithTag("Shape8");
            prevShape.GetComponent<TouchScriptSwitch>().SwitchOffScript();

            changingShape[4].SetActive(false);
            activeShape = GameObject.FindGameObjectWithTag("Shape5");
            activeShape.GetComponent<TouchScriptSwitch>().SwitchOnScript();
            changingShape[5].SetActive(true);
        }

        if (sequenceNumber == 6)
        {
            changingShape[0].SetActive(false);
            prevShape = GameObject.FindGameObjectWithTag("Shape5");
            prevShape.GetComponent<TouchScriptSwitch>().SwitchOffScript();

            changingShape[5].SetActive(false);
            activeShape = GameObject.FindGameObjectWithTag("Shape16");
            activeShape.GetComponent<TouchScriptSwitch>().SwitchOnScript();
            changingShape[6].SetActive(true);
        }

        if (sequenceNumber == 7)
        {
            changingShape[0].SetActive(false);
            prevShape = GameObject.FindGameObjectWithTag("Shape16");
            prevShape.GetComponent<TouchScriptSwitch>().SwitchOffScript();

            changingShape[6].SetActive(false);
            activeShape = GameObject.FindGameObjectWithTag("Shape2");
            activeShape.GetComponent<TouchScriptSwitch>().SwitchOnScript();
            changingShape[7].SetActive(true);
        }

        if (sequenceNumber == 8)
        {
            changingShape[0].SetActive(false);
            prevShape = GameObject.FindGameObjectWithTag("Shape2");
            prevShape.GetComponent<TouchScriptSwitch>().SwitchOffScript();

            changingShape[7].SetActive(false);
            activeShape = GameObject.FindGameObjectWithTag("Shape4");
            activeShape.GetComponent<TouchScriptSwitch>().SwitchOnScript();
            changingShape[8].SetActive(true);
        }

        if (sequenceNumber == 9)
        {
            changingShape[0].SetActive(false);
            prevShape = GameObject.FindGameObjectWithTag("Shape4");
            prevShape.GetComponent<TouchScriptSwitch>().SwitchOffScript();

            changingShape[8].SetActive(false);
            activeShape = GameObject.FindGameObjectWithTag("Shape13");
            activeShape.GetComponent<TouchScriptSwitch>().SwitchOnScript();
            changingShape[9].SetActive(true);
        }

        if (sequenceNumber == 10)
        {
            SceneManager.LoadScene("WinMenu");
        }
    }
}
