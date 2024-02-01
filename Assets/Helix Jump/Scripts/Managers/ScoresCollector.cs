using UnityEngine;

public class ScoresCollector : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;
    [SerializeField] private ClearPassSwitcher clearPassSwitcher;
    [SerializeField] private int scores;
    [SerializeField] private int maxScores;
  
    public int Scores => scores;  
    public int MaxScores => maxScores;

    protected override void Awake()
    {
        base.Awake();
        LoadMaxScores();
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {     
        if (type == SegmentType.Empty)
        {
            scores += levelProgress.CurrentLevel;

            if (clearPassSwitcher != null)
            {
                AddBonusScores();
            }                    
        }

        if (type == SegmentType.Finish)
        {
            if (scores > maxScores)
            {
                maxScores = scores;
                SaveMaxScores();               
            }
        }
    }

    private void AddBonusScores()
    {
        if (clearPassSwitcher.ClearPass == true)
        {
            scores += levelProgress.CurrentLevel;
        }
    }

    private void SaveMaxScores()
    {
        PlayerPrefs.SetInt("ScoresCollector:MaxScores", maxScores);           
    }

    private void LoadMaxScores()
    {
        maxScores = PlayerPrefs.GetInt("ScoresCollector:MaxScores", 0);
    }
}
