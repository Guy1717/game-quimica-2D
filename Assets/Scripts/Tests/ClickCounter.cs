using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ClickCounter : MonoBehaviour
{

    private int clickCount = 0;
    public TextMeshProUGUI clickCountText;

    void Start()
    {
        UpdateCountText();
        Debug.Log("Contador de cliques iniciado: " + clickCount);
    }

    public void IncrementCount()
    {
        clickCount++;
        UpdateCountText();
        Debug.Log("Cliques atualizados: " + clickCount);
    }

    private void UpdateCountText()
    {
        clickCountText.text = clickCount.ToString();
    }

}
