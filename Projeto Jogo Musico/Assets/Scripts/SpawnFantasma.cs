using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFantasma : MonoBehaviour
{
    
    public GameObject fantasma;
    public float limites;
    public float tempoMaximo = 3f;

    private float tempo = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newFantasma = Instantiate(fantasma);
        newFantasma.transform.position = transform.position + new Vector3(0, Random.Range(-limites, limites), 0 );
    }

    // Update is called once per frame
    void Update()
    {
        if (tempo> tempoMaximo)
        {
            GameObject newFantasma = Instantiate(fantasma);
            newFantasma.transform.position = transform.position + new Vector3(0,Random.Range(-limites, limites), 0 );
            Destroy(newFantasma, 20f);
            tempo = 0;
        }

        tempo += Time.deltaTime;
    }
}