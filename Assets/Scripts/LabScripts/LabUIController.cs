using UnityEngine;
using TMPro;

namespace LabScripts
{
    public class UIController : MonoBehaviour
    {
        public GameObject confirmationPanel;
        public TextMeshProUGUI confirmationPanelText;

        [HideInInspector]
        public string currentItemName;

        void Start()
        {
            if (confirmationPanel != null)
            {
                confirmationPanel.SetActive(false);
            }
        }

        public void ShowConfirmationPanel(string itemName)
        {
            currentItemName = itemName;
            confirmationPanelText.text = "Iniciar mistura de solubilidade com " + itemName + "?";

            if (confirmationPanel != null)
            {
                confirmationPanel.SetActive(true);
            }
        }

        public void HideConfirmationPanel()
        {
            if (confirmationPanel != null)
            {
                confirmationPanel.SetActive(false);
            }
        }

        public void OnConfirmAction()
        {
            Debug.Log("Ação Confirmada para o item: " + currentItemName);
            HideConfirmationPanel(); // Oculta o painel após a confirmação
        }

        public void OnCancelAction()
        {
            Debug.Log("Ação Cancelada para o item: " + currentItemName);
            HideConfirmationPanel(); // Oculta o painel após o cancelamento
        }
    }
}