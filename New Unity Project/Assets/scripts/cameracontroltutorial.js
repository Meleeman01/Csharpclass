#pragma strict

var Car: Transform;
var distance: float=6.4;
var height : float=1.4;
var rotationDamping : float=3.0;
var heightDamping : float=2.0;
var zoomRatio : float=0.5;
private var rotationVector :Vector3;



function Start () {

}

function LateUpdate () 
{
	var wantedAngle = Car.eulerAngles.y;
	var wantedHeight= Car.position.y+height;
	var myAngle= transform.eulerAngles.y;
	var myHeight= transform.position.y;
	myAngle= Mathf.LerpAngle(myAngle,wantedAngle,rotationDamping*Time.deltaTime);
	myHeight=Mathf.Lerp(myHeight,wantedHeight,heightDamping*Time.deltaTime);
	var currentRotation=Quaternion.Euler(0,myAngle,0);
	transform.position=Car.position;
	transform.position-=currentRotation*Vector3.forward*distance;
	transform.position.y=myHeight;
	transform.LookAt(Car);
}