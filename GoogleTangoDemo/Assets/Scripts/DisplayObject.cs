using UnityEngine;
using System.Collections;



public class DisplayObject : MonoBehaviour {

    public Renderer rend;

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        // Find out whether current second is odd or even
        bool oddeven = Mathf.FloorToInt(Time.time) % 2 == 0;

        // Find out if another object is near enough
        // Find out distance between objects
        Vector3 location = transform.position;
        Vector3 cameraPosition = GameObject.Find("Tango Delta Camera").transform.position;
        Vector3 difference = location - cameraPosition;
        float distance = difference.magnitude;
        // If distance is smaller than threshold, return True
        if (distance < 2.0)
        {
            rend.enabled = true;
        }
        else
        {
            rend.enabled = false;
        }
        // Enable renderer accordingly
        //rend.enabled = oddeven;
    }
}
