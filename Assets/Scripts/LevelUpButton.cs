using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelUpButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI buttonText;
    [SerializeField] private Button button;

    private IBalanceController balanceController;
    private IBuildingController buildingController;
    private string name;
    private int basicCost;
    private int level;
    
    
    
    public void Init(IBuildingController buildingCtrl, IBalanceController balanceCtrl)
    {
        buildingController = buildingCtrl;
        balanceController = balanceCtrl;
    }

    public void DrawLevel(int lvl, int cost, string Name)
    {
        level = lvl;
        basicCost = cost;
        name = Name;
        
        buttonText.text = $"Level Up\n{(level + 1) * basicCost}";
        
        button.onClick.AddListener(OnClick);
    }
    
    private void OnClick()
    {
        DrawLevel(level + 1, basicCost, name);
        buildingController.ChangeLevel(name);
        balanceController.WithdrawFromBalance(buildingController.LevelCost(level, basicCost));
    }
}