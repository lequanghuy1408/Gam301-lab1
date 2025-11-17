using System.Collections;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(TaoRaCube());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator TaoRaCube() 
    {
        for (int i = 0; i < 10; i++) 
        {
         GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(Random.Range(-10f, 10f),Random.Range(-10f, 10f),Random.Range(-10f, 10f));
            yield return new WaitForSeconds(2);
        }

    }


}
