using System.Collections;
using UnityEngine;

public class FloorDestroyer : MonoBehaviour
{
    [Header("Vector")]
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;

    [Header("Fading time")]
    [SerializeField] private int seconds;

    public GameObject[] Segments;

    private Transform ballVisualModel;

    public void Start()
    {
        ballVisualModel = GameObject.FindGameObjectWithTag("Ball").transform;
    }

    private void Update()
    {
        if (transform.position.y > ballVisualModel.position.y)
        {
            StartCoroutine(WaitBeforeFade());
        }
    }

    private IEnumerator WaitBeforeFade()
    {
        for (int i = 0; i < Segments.Length; i++)
        {
            Segments[i].GetComponent<Rigidbody>().AddRelativeForce(x, -y, z);
            Segments[i].GetComponent<ConstantForce>().enabled = true;
        }

        yield return new WaitForSeconds(seconds);

        for (int i = 0; i < Segments.Length; i++)
        {
            Segments[i].GetComponent<MeshRenderer>().enabled = false;
            Segments[i].GetComponent<Rigidbody>().AddRelativeForce(x, y, z);
        }
    }
}
