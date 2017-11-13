using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMovement : MonoBehaviour {

    public float magnitudeXMultiplier = 1.0f;
    public float frequencyXMultiplier = 0.1f;
    public float magnitudeYMultiplier = 1.0f;
    public float frequencyYMultiplier = 0.1f;

	// Update is called once per frame
	void Update () {
        transform.position += Vector3.left * Mathf.Sin(Time.time * frequencyXMultiplier) * magnitudeXMultiplier
            + Vector3.up * Mathf.Sin(Time.time * frequencyYMultiplier) * magnitudeYMultiplier;
	}
}
