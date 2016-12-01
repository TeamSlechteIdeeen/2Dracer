using UnityEngine;
using System.Collections;

public class ColliderTest : MonoBehaviour {

    // Use this for initialization
    void start()
    {
        Debug.Log("init");
    }
    void OnTriggerEnter(Collision col)
    {
        if (col.gameObject.name == "finish")
        {
            Debug.Log("booped da finish");
        }
        if(col.gameObject.name == "checkpoint1")
        {
            Debug.Log("booped da shagpoint");
        }
    }
}
