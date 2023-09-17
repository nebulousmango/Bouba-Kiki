using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralObjectSpawner : MonoBehaviour
{
    List<Transform> lst_spawnPoints = new List<Transform>();
    int i_gravity = 0;
    bool levelOver;
    [SerializeField] GameObject go_fallingObject;

    private void Start()
    {
        foreach(Transform trans in GetComponentsInChildren<Transform>())
        {
            if(trans != transform) lst_spawnPoints.Add(trans);
        }
        levelOver = FindObjectOfType<TouchInput>().levelOver;
        InstantiateRandom();
    }

    void InstantiateRandom()
    {
        if (levelOver == false)
        {
            int spawnPointNumber = Random.Range(0, lst_spawnPoints.Count);
            GameObject currentFallingObject = Instantiate(go_fallingObject, lst_spawnPoints[spawnPointNumber]);
            currentFallingObject.transform.SetParent(lst_spawnPoints[spawnPointNumber]);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (levelOver == false)
        {
            if (other.gameObject.GetComponent<FallingObject>())
            {
                FindObjectOfType<EventManager>().ObjectFallEvent();
                RespawnFallingObject(other.gameObject);
            }
        }
    }

    void RespawnFallingObject(GameObject go)
    {
        if (levelOver == false)
        {
            int spawnPointNumber = Random.Range(0, lst_spawnPoints.Count);
            go.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            go.GetComponent<FallingObject>().ChangeGravity(i_gravity);
            go.transform.position = lst_spawnPoints[spawnPointNumber].position;
        }
    }
}
