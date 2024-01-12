using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    Vector3 dir;
    void Start()
    {
        dir = InputTest.Instance.rightcontroller.GetComponent<LineRenderer>().GetPosition(1) - InputTest.Instance.rightcontroller.GetComponent<LineRenderer>().GetPosition(0);
        Destroy(gameObject, 3f);
    }
    void Update()
    {
        transform.position += speed *Time.deltaTime * dir;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Candle"))
        {
            Destroy(other.gameObject.transform.parent.gameObject);
            Destroy(gameObject);
        }
    }
}
