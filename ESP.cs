using UnityEngine;

namespace AimXR
{
    public class ESPMod : MonoBehaviour
    {
        void OnGUI()
        {
            GUI.Label(new Rect(10, 10, 200, 20), "ESP Loaded");
            
            GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject player in players)
            {
                Vector3 pos = Camera.main.WorldToScreenPoint(player.transform.position);
                if (pos.z > 0)
                {
                    GUI.color = Color.red;
                    GUI.Box(new Rect(pos.x - 10, Screen.height - pos.y - 10, 20, 20), "Target");
                }
            }
        }
    }
}
