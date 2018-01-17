using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    [SerializeField]
    GameObject objectToFollow;

    [SerializeField]
    Vector3 offset;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = objectToFollow.transform.position + offset;
        transform.LookAt(objectToFollow.transform);
            
    }
}
