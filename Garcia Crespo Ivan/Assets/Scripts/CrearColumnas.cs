using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearColumnas : MonoBehaviour
{
    [SerializeField] Text MyText;
    //Variable de tipo Object que contendrá el Prefab a instanciar
    [SerializeField] GameObject MyColumn;
    //Variable de tipo Transform que contendrá el objeto de referencia
    [SerializeField] Transform RefPos;
    public int tiempo = 2;
    public int columnas = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ColumnCorrutine");
        StartCoroutine("Contador");
    }


    void CrearColumna()
    {
        float posRandom = Random.Range(-9.5f, 9.5f);
        float posRandom2 = Random.Range(-9.5f, 9.5f);
        Vector3 DestPos = new Vector3(posRandom, 0.5f, posRandom2);
        Vector3 NewPos = RefPos.position + DestPos;
        Instantiate(MyColumn, NewPos, Quaternion.identity);
    }
    IEnumerator ColumnCorrutine()
    {

        for (int n = 0; ; n++)
        {
            CrearColumna();
            yield return new WaitForSeconds(tiempo);
            columnas++;
         }
    }

    IEnumerator Contador()
    {
        for (int n = 0; ; n++)
        {
            MyText.text = columnas.ToString("00");
            yield return new WaitForSeconds(tiempo);
        }
    }
}