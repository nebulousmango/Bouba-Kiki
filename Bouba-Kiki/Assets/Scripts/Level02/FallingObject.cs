using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    public void ChangeGravity(int i)
    {
        float gravity = (float)i / 10;
        gravity = Mathf.Clamp(gravity, 0.5f, 2);
        GetComponent<Rigidbody2D>().gravityScale = gravity;
    }
}
