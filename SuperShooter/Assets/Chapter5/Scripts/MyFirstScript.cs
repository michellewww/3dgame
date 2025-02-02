using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public float speed;

    [SerializeField]
    private float speed1;

    // Start is called before the first frame update
    void Start()
    {
        print("test Start");
    }

    // Update is called once per frame
    void Update()
    {
        print(speed);
    }
}
