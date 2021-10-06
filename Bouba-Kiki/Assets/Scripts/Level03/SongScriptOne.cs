using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongScriptOne : MonoBehaviour, ISongScripts
{
    [SerializeField] GameObject[] changingShapeList;
    int sequenceNum;

    private void Start()
    {
        // Initialise scene.
        DisableShapes();
        sequenceNum = changingShapeList.Length;
    }

    // Function to hide all objects in ChangingShapes list.
    public void DisableShapes()
    {
        int numFixedShapes = changingShapeList.Length;
        for (int i = 0; i < numFixedShapes; i++)
        {
            changingShapeList[i].SetActive(false);
        }
    }

    // Function that runs fixed-length shape sequence.
    public void PlaySong()
    {
        // Write shape sequence here.

    }
}
