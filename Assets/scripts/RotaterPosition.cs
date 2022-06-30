using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotaterPosition : MonoBehaviour
{
    public static int position;
    public float p;
    // Start is called before the first frame update
    void Start()
    {
        position = 1;
    }

    // Update is called once per frame
    void Update()
    {
        p = position;
    }
}
