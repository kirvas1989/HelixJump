using UnityEngine;

public class FloorSoundShedule : BallEvents
{
    [SerializeField] private AudioSource floorSound;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(floorSound != null)
        {
            if (type == SegmentType.Empty)
            {
                floorSound.Play();  
            }
        }
    }
}
