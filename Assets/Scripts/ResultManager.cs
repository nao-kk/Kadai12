using TMPro;
using UnityEngine;

public class ResultManager : MonoBehaviour
{
    [Header("結果を表示するテキスト（例：GAME CLEAR! / GAME OVER）")]
    [SerializeField] private TextMeshProUGUI statusText;

    [Header("獲得した数を表示するテキスト")]
    [SerializeField] private TextMeshProUGUI resultCountText;

    void Start()
    {
        // 🌟獲得したクリスタル数の表示
        if (resultCountText != null)
        {
            resultCountText.text = "Get Crystals: " + CountData.finalScore.ToString() + " / 6";
        }

        // 🌟ここが最重要！クリアフラグ（isClear）を見て文字を完全に切り替えます
        if (statusText != null)
        {
            if (CountData.isClear)
            {
                statusText.text = "GAME CLEAR!";
                statusText.color = Color.yellow; // クリア時は黄色
            }
            else
            {
                statusText.text = "GAME OVER";
                statusText.color = Color.red; // タイムオーバー（ゲームオーバー）時は赤色
            }
        }
    }
}
