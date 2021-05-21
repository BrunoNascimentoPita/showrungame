using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float zRotation;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        rotationObst();
        
    }

    private void rotationObst()
    {
        zRotation = zRotation + Time.deltaTime * 50;
        transform.rotation = Quaternion.Euler(0, 0, zRotation);
    }
}
