using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	void Update () {
        transform.Rotate(Vector3.right * 15 * Time.deltaTime);

        transform.Rotate(Vector3.up * 20 * Time.deltaTime, Space.World);
    }
}
