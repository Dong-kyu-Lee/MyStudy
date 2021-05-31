using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1f, 0f, 0f) * Time.deltaTime;

    }
}
