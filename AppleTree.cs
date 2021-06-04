using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    //префаб €блока
    public GameObject prefabApple;
    //скорость движени€ €блони
    public float _speedTree= 1f;
    // рассто€ние на котором должно мен€тьс€ направление 
    public float leftAndRightEdge = 10f;
    // процент смены направлени€
    public float chanceChangeDirection= 0.1f;
    //врем€ сбрасывани€ €блок
    public float timeToDropApple = 1f;
    private void FixedUpdate()
    {
        Vector3 pos = transform.position;
        pos.x += _speedTree * Time.deltaTime;
        transform.position = pos;
        if (pos.x > leftAndRightEdge)
        {
            _speedTree *= -1f;
        }
        else if (pos.x < -leftAndRightEdge)
        {
            _speedTree *= -1f;
        }
        else if (Random.value < chanceChangeDirection)
        {
            _speedTree *= -1f;
        }
    }
    void Start()
    {
        Invoke("DropApple", 2f);
    }
    void DropApple()
    {
        GameObject drop = Instantiate<GameObject>(prefabApple);
        drop.transform.position = transform.position;
        Invoke("DropApple", timeToDropApple);
    }
}
