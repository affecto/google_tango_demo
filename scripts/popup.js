#pragma strict
public var rend: Renderer;
function Start() {
    rend = GetComponent.<Renderer>();
    rend.enabled = false;
}

function NearEnough() {
    // Find out distance between objects
    var location: Vector3 = transform.position;
    var anotherObject: GameObject;
    var anotherlocation: Vector3 = GameObject.Find("Cube").transform.position;
    var difference: Vector3 = location - anotherlocation;
    var distance: float = difference.magnitude;
    // If distance is smaller than threshold, return True
    if (distance < 10.0) {
        rend.enabled = true;
    }
    else {
        rend.enabled = false;
    }
}

// Toggle the Object's visibility each second.
function Update() {
    // Find out whether current second is odd or even
    var oddeven: boolean = Mathf.FloorToInt(Time.time) % 2 == 0;

    // Find out if another object is near enough
    // Find out distance between objects
    var location: Vector3 = transform.position;
    var anotherObject: GameObject;
    var anotherlocation: Vector3 = GameObject.Find("Cube").transform.position;
    var difference: Vector3 = location - anotherlocation;
    var distance: float = difference.magnitude;
    // If distance is smaller than threshold, return True
    if (distance < 4.0) {
        rend.enabled = true;
    }
    else {
        rend.enabled = false;
    }
    // Enable renderer accordingly
    //rend.enabled = oddeven;
}
