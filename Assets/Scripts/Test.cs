using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public string myStr = "First";
    // Start is called before the first frame update
    void Start()
    {
        print("Second");
    }

    // Update is called once per frame
    void Update()
    {
        print("Thrid");
    }
}
