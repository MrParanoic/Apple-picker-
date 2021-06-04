using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyApple : MonoBehaviour
{
    public static float destroyEdge = -20f;
    private void Update()
    {
        if (transform.position.y < destroyEdge)
        {
            Destroy(this.gameObject);
        }
    }
}
