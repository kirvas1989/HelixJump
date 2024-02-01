using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class LevelPallete
{
    public Color AxisColor;
    public Color BallColor;
    public Color TrailColor;
    public Color SplashColor;
    public Color DefaultSegmentColor;
    public Color TrapSegmentColor;
    public Color FinishSegmentColor;
    public Color CanvasBackgroudColor;
    public Color CameraBackgroundColor;
    public Color DefeatTextColor;
    public Color ResetTextColor;
    public Color ResetDefeatTextColor;

}

public class LevelColors : MonoBehaviour
{
    [SerializeField] private LevelPallete[] pallete;

    [SerializeField] private Material axisMaterial;
    [SerializeField] private Material ballMaterial;
    [SerializeField] private Material trailMaterial;
    [SerializeField] private Material defaultSegmentMaterial;
    [SerializeField] private Material trapSegmentMaterial;
    [SerializeField] private Material finishSegmentMaterial;
    [SerializeField] private ParticleSystem splashParticles;
    [SerializeField] private Image backgroudImage;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Text defeatText;
    [SerializeField] private Text resetText;
    [SerializeField] private Text resetDefeatText;


    private void Start()
    {
        int index = Random.Range(0, pallete.Length);

        axisMaterial.color = pallete[index].AxisColor;
        ballMaterial.color = pallete[index].BallColor; 
        trailMaterial.color = pallete[index].TrailColor;
        splashParticles.startColor = pallete[index].SplashColor;   
        defaultSegmentMaterial.color = pallete[index].DefaultSegmentColor;
        trapSegmentMaterial.color = pallete[index].TrapSegmentColor;
        finishSegmentMaterial.color= pallete[index].FinishSegmentColor;
        backgroudImage.color = pallete[index].CanvasBackgroudColor;
        mainCamera.backgroundColor = pallete[index].CameraBackgroundColor;
        defeatText.color = pallete[index].DefeatTextColor;
        resetText.color = pallete[index].ResetTextColor;
        resetDefeatText.color = pallete[index].ResetDefeatTextColor;
    }
}
