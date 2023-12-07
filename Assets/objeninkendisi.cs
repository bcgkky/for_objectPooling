using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeninkendisi : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pasiflestir"))
        {
            gameObject.SetActive(false);
        }
    }

}
