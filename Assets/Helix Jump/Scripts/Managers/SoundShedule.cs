using UnityEngine;

public class SoundShedule : BallEvents
{
    [SerializeField] private AudioSource floorSound;
    [SerializeField] private AudioSource trapSound;
    [SerializeField] private AudioSource finishSound;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty)
        {
            floorSound.Play();
        }

        if (type == SegmentType.Trap)
        {
            trapSound.Play();
        }

        if (type == SegmentType.Finish)
        {
            finishSound.Play();
        }
    }
}