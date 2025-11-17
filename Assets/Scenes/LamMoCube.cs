using System.Collections;
using System.Resources;
using UnityEngine;

public class LamMoCube : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(fadeObject());
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator fadeObject()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Renderer renderer = GetComponent<Renderer>();
            Color color = renderer.material.color;
            for(float alpha = 1f; alpha >= 0f; alpha -= 0.1f)
            {
                color.a = alpha;
                renderer.material.color = color;
                yield return new WaitForSeconds(0.5f);
            }
        }
    }
}
