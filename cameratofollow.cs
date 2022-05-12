using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameratofollow : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject thingstofollow;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = thingstofollow.transform.position + new Vector3(0, 0, -10);
    }
}
