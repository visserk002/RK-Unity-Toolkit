using UnityEngine;
using System.Collections;
using System;
using System.Linq.Expressions;

public class RKBehaviour : MonoBehaviour {

	protected void SetPosition(Vector3 newPosition){
		transform.position = newPosition;
	}

	protected void SetPositionX(float x){
		transform.position = new Vector3 (x, transform.position.y, transform.position.z);
	}

	protected void SetPositionY(float y){
		transform.position = new Vector3 (transform.position.x, y, transform.position.z);
	}

	protected void SetPositionZ(float z){
		transform.position = new Vector3 (transform.position.x, transform.position.y, z);
	}

	protected void SetRotation(Quaternion newRotation){
		transform.rotation = newRotation;
	}

	protected void SetLocalEulerAngles(Vector3 newLocalEulerAngles){
		transform.localEulerAngles = newLocalEulerAngles;
	}

	protected void SetLocalEulerX(float x){
		transform.localEulerAngles = new Vector3 (x, transform.localEulerAngles.y, transform.localEulerAngles.z);
	}

	protected void SetLocalEulerY(float y){
		transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, y, transform.localEulerAngles.z);
	}

	protected void SetLocalEulerZ(float z){
		transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, transform.localEulerAngles.y, z);
	}

	protected void WhyIsntThisWorking(string prefix = "debug", bool includeTimestamp = false, params object[] valuesToDebug){

		string text = "";

		foreach(object obj in valuesToDebug){

			string time = "";

			if (includeTimestamp) {
				time = String.Format("{0:hh:mm:ss}", System.DateTime.Now);
			}

			text += (time + "-" + prefix + " " + obj.GetType() + ": " + obj.ToString()) + "\n";
		}

		Debug.Log (text);

	}

	protected void WhyIsntThisWorking(bool includeTimestamp = false, params object[] valuesToDebug){

		string text = "";

		foreach(object obj in valuesToDebug){

			string time = "";

			if (includeTimestamp) {
				time = String.Format("{0:hh:mm:ss}", System.DateTime.Now);
			}

			text += (time + "-" + obj.GetType() + ": " + obj.ToString()) + "\n";
		}

		Debug.Log (text);

	}

}
