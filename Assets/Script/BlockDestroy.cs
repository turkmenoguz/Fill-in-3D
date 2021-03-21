using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroy : MonoBehaviour
{

     void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            Destroy(collision.gameObject);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
