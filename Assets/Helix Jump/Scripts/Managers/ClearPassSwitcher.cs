public class ClearPassSwitcher : BallEvents
{
    private bool clearPass;
    public bool ClearPass => clearPass;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty)
        {
            clearPass = true;
        }
        else
        {
            clearPass = false;
        }
    }
}
