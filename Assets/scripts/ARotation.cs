using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARotation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rotater;
    public bool rotateChecker;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag =="1") {
            rotater.transform.localEulerAngles = new Vector3(90f, 0, 0);
        }
        if (other.gameObject.tag =="2") {
            rotater.transform.localEulerAngles = new Vector3(-90f, 0, 0);
        }
    }
}
