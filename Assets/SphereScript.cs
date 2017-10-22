using UnityEngine;
using System.Collections;

public class SphereScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<MeshRenderer>().sharedMaterial.color = new Color(0.5f, 1.0f, 1.0f, 0.5f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
