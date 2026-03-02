using UnityEngine;

public class AimXRESP : MonoBehaviour
{
    private GUIStyle labelStyle = new GUIStyle();

    void Start() {
        labelStyle.normal.textColor = Color.red;
        labelStyle.fontSize = 20;
    }

    void OnGUI()
    {
        // Aim XRのプレイヤーオブジェクトを探す（一般的な設定）
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject player in players)
        {
            // 自分自身は除外（必要に応じて）
            
            Vector3 screenPos = Camera.main.WorldToScreenPoint(player.transform.position);

            if (screenPos.z > 0)
            {
                float x = screenPos.x;
                float y = Screen.height - screenPos.y;

                // 敵の位置に「赤枠」と「距離」を表示
                GUI.color = Color.red;
                GUI.Box(new Rect(x - 25, y - 25, 50, 50), ""); 
                GUI.Label(new Rect(x - 25, y - 45, 100, 20), "ENEMY [" + Mathf.Round(screenPos.z) + "m]", labelStyle);
            }
        }
    }
}
