using UnityEngine;
using System.Collections;

public class Rotator_Planet : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, -23) * Time.deltaTime);
    }
}