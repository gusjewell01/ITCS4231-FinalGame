using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    public GameObject rotater;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) {
        player.transform.position = new Vector3(0,1.67999995f,0);
        RotaterPosition.position = 1;
        rotater.transform.localEulerAngles = new Vector3(0, 0, 0);
        player.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
    }
}
