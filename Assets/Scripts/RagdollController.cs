using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Effect
{
    public Rigidbody ragdollPart;
    public Vector3 force;
    public KeyCode input;

}

public class RagdollController : MonoBehaviour {

    public Effect[] effects;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        foreach (Effect e in effects)
        {
            if (Input.GetKey(e.input))
            {
                e.ragdollPart.AddRelativeForce(e.force);
            }
        }
	}
}
