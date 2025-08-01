using System.Collections;
using UnityEngine;
using TMPro;

namespace LabScripts
{
    public class UIController : MonoBehaviour
    {
        public GameObject solutionAnimationPanel;
        public GameObject confirmationPanel;
        public TextMeshProUGUI confirmationPanelText;
        public TextMeshProUGUI solutionAnimationText;

        [HideInInspector]
        public string currentItemName;

        // Hide the confirmation panel at the start
        void Start()
        {
            confirmationPanel?.SetActive(false);
            solutionAnimationPanel?.SetActive(false);
        }

        // Confirmation Panel
        public void ShowConfirmationPanel(string itemName)
        {
            currentItemName = itemName;
            confirmationPanelText.text = "Iniciar mistura de solubilidade com " + itemName + "?";

            confirmationPanel?.SetActive(true);
        }

        public void HideConfirmationPanel()
        {
            confirmationPanel?.SetActive(false);
        }

        public void OnConfirmAction()
        {
            Debug.Log("Ação Confirmada para o item: " + currentItemName);
            ShowSolutionAnimationPanel();
        }

        public void OnCancelAction()
        {
            Debug.Log("Ação Cancelada para o item: " + currentItemName);
            HideConfirmationPanel(); // Oculta o painel após o cancelamento
        }

        // Solution Animation Panel
        public void ShowSolutionAnimationPanel()
        {
            solutionAnimationPanel?.SetActive(true);

            HideConfirmationPanel();

            // StartCoroutine(WaitAndCloseSolutionPanel());
        }

        public void HideSolutionAnimationPanel()
        {
            solutionAnimationPanel?.SetActive(false);
        }

        private IEnumerator WaitAndCloseSolutionPanel()
        {
            yield return Utils.Wait(7f);
            HideSolutionAnimationPanel();
        }

    }
}