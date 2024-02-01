using UnityEngine;

public class Splash : MonoBehaviour
{
    [SerializeField] private ParticleSystem splashParticles;

    [Header("Vector")]
    [SerializeField] private float x;
    [SerializeField] private float y;
    [SerializeField] private float z;

    public void Init(Vector3 position)
    {
        transform.position = position + new Vector3(x, y, z);
    }
}
