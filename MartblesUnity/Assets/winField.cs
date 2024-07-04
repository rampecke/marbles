using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winField : MonoBehaviour
{
    public GameObject uiObject;

    void Start()
    {
        uiObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other) // Note the capital 'O'
    {
        if (other.gameObject.CompareTag("Marble")) // Use CompareTag for better performance
        {
            uiObject.SetActive(true);
        }
    }
}

