using UnityEngine;

public class BallTrail : BallEvents
{
    [SerializeField] private Transform parentTransform;
    [SerializeField] private MeshRenderer visualMeshRenderer;
    [SerializeField] private Blot blotPrefab;
    [SerializeField] private Splash splashPrefab;
    [SerializeField] private ParticleSystem splashParticles;
    [SerializeField] private AudioSource blotSound;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type != SegmentType.Empty)
        {
            Blot blot = Instantiate(blotPrefab, parentTransform);
            blot.Init(new Vector3(visualMeshRenderer.transform.position.x, transform.position.y, visualMeshRenderer.transform.position.z), visualMeshRenderer.material.color);

            Splash splash = Instantiate(splashPrefab, parentTransform);
            splash.Init(new Vector3(splashParticles.transform.position.x, transform.position.y, splashParticles.transform.position.z));

            if (blotSound != null )
            {
                blotSound.Play();
            }
        }
    }
}
