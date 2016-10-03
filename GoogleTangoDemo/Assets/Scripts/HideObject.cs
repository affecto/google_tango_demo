using UnityEngine;
using System.Collections;

public class HideObject : MonoBehaviour {

    public MeshRenderer rend;
    
	// Use this for initialization
	void Start () {
        rend = GetComponent<MeshRenderer>();
        rend.enabled = false;

        // Hide the children of this object
        MeshRenderer[] rs = gameObject.GetComponentsInChildren<MeshRenderer>();
        foreach (MeshRenderer r in rs) {
            r.enabled = false;
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
