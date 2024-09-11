using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollison : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
using UnityEngine;
public class ApplyForce : MonoBehaviour
{
	private Rigidbody rb;
	private void Start ()
	{
		rb = GetComponent<Rigidbody>();
		rb.AddForce(Vector3.right * 500);
	}
}