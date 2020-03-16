using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private Vector3 rotationSpeed = new Vector3(110f, 110f, 110f);

    // Update is called once per frame
    void Update()
    {
        float xDelta = rotationSpeed.x * Time.deltaTime;
        float yDelta = rotationSpeed.y * Time.deltaTime;
        float zDelta = rotationSpeed.z * Time.deltaTime;
        transform.Rotate(new Vector3(xDelta, yDelta, zDelta), Space.World);
    }
}
