using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    [SerializeField] Text MyText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Reloj");
    }

    IEnumerator Reloj()
    {
        for (int n = 0; ; n++)
        {
            MyText.text = "Tiempo " + n.ToString("00:00");
            yield return new WaitForSeconds(1);
        }
    }
}