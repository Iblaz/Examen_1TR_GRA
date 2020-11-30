using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject sphere;
    private Vector3 posicionRelativa;
    // Start is called before the first frame update
    void Start()
    {
        posicionRelativa = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = sphere.transform.position + posicionRelativa;
    }
}
