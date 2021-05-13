using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstaculos : MonoBehaviour
{

    public GameObject obst;
    public float limites;
    public float tempoMaximo = 3f;

    private float tempo = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newObst = Instantiate(obst);
        newObst.transform.position = transform.position + new Vector3(Random.Range(-limites, limites), 0, 0 );
    }

    // Update is called once per frame
    void Update()
    {
        if (tempo> tempoMaximo)
        {
            GameObject newObst = Instantiate(obst);
            newObst.transform.position = transform.position + new Vector3(Random.Range(-limites, limites), 0, 0);
            Destroy(newObst, 30f);
            tempo = 0;
        }

        tempo += Time.deltaTime;
    }
}
