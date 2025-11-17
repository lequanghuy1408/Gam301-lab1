using UnityEngine;
using System.Collections;

public class MoveObjects : MonoBehaviour
{
    public Transform[] objects;  
    public Vector3[] newPositions; 

    private void Start()
    {
        StartCoroutine(MoveObjectsCoroutine());
    }

    IEnumerator MoveObjectsCoroutine()
    {
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].position = newPositions[i]; 
            yield return new WaitForSeconds(1f);   
        }
    }
}

