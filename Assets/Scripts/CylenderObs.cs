using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylenderObs : MonoBehaviour
{
    MeshRenderer mesh;
    public Color failColor;
    public GameManager manager;
    public float rotationSpeed=30f;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            mesh.material.color = failColor;
            manager.fail();
        }
    }
}
