using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proppeler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(new Vector3(0, 0, 1));
        transform.Rotate(Vector3.forward*Time.deltaTime*500);
    }
}
