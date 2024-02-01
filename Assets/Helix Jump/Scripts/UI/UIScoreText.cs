using UnityEngine;
using UnityEngine.UI;

public class UIScoreText : BallEvents
{
    [SerializeField] private ScoresCollector scoresCollector;
    [SerializeField] private Text scoreText;

    [SerializeField] private Text maxScoreText;
    [SerializeField] private string markMaxScoreText;

    private void Start()
    {
        maxScoreText.text = markMaxScoreText + " " + scoresCollector.MaxScores;
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type != SegmentType.Trap)
        {
            scoreText.text = scoresCollector.Scores.ToString(); 
        }

        if (type == SegmentType.Finish)
        {
            maxScoreText.text = markMaxScoreText + " " + scoresCollector.MaxScores;
        }
    }
}
