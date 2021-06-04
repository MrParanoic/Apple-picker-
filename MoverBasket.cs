using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBasket : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void Update()
    {

        
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * _speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * _speed * Time.deltaTime;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Apple")
        {
            collision.gameObject.transform.SetParent(gameObject.transform);
        }
    }
}
