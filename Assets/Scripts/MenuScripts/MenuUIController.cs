using UnityEngine;
using UnityEngine.UI;

namespace MenuScripts
{
    public class UI_MenuScene : MonoBehaviour
    {

        // Panels
        public GameObject homePanel;
        public GameObject shopPanel;
        public GameObject settingsPanel;
        public GameObject navbarPanel;
        public GameObject loadingPanel;

        // Buttons & Icons
        public Button homeButton;
        public Button shopButton;
        public Button settingsButton;

        public GameObject homeIcon0;
        public GameObject homeIcon1;
        public GameObject shopIcon0;
        public GameObject shopIcon1;
        public GameObject settingsIcon0;
        public GameObject settingsIcon1;

        // Seleção de dificuldade (Images)
        public GameObject easy0Image;
        public GameObject easy1Image;
        public GameObject medium0Image;
        public GameObject medium1Image;
        public GameObject hard0Image;
        public GameObject hard1Image;


        private void Start()
        {
            DeselectAllDifficulties();
            ShowLoadingPanel();
        }

        // Painéis principais
        public void ShowHomePanel()
        {
            homePanel?.SetActive(true);
            shopPanel?.SetActive(false);
            settingsPanel?.SetActive(false);
            loadingPanel?.SetActive(false);

            homeButton.interactable = false;
            shopButton.interactable = true;
            settingsButton.interactable = true;

            OnHomeButtonClick();

        }

        public void ShowShopPanel()
        {
            homePanel?.SetActive(false);
            shopPanel?.SetActive(true);
            settingsPanel?.SetActive(false);
            loadingPanel?.SetActive(false);

            shopButton.interactable = false;
            homeButton.interactable = true;
            settingsButton.interactable = true;

            OnShopButtonClick();
        }

        public void ShowSettingsPanel()
        {
            homePanel?.SetActive(false);
            shopPanel?.SetActive(false);
            settingsPanel?.SetActive(true);
            loadingPanel?.SetActive(false);

            settingsButton.interactable = false;
            homeButton.interactable = true;
            shopButton.interactable = true;

            OnSettingsButtonClick();
        }

        public void ShowLoadingPanel()
        {
            homePanel?.SetActive(false);
            shopPanel?.SetActive(false);
            settingsPanel?.SetActive(false);
            loadingPanel?.SetActive(true);
        }

        // Seleção de dificuldade
        public void SelectEasy()
        {
            easy0Image?.SetActive(false);
            easy1Image?.SetActive(true);

            medium0Image?.SetActive(true);
            medium1Image?.SetActive(false);

            hard0Image?.SetActive(true);
            hard1Image?.SetActive(false);
        }

        public void SelectMedium()
        {
            easy0Image?.SetActive(true);
            easy1Image?.SetActive(false);

            medium0Image?.SetActive(false);
            medium1Image?.SetActive(true);

            hard0Image?.SetActive(true);
            hard1Image?.SetActive(false);
        }

        public void SelectHard()
        {
            easy0Image?.SetActive(true);
            easy1Image?.SetActive(false);

            medium0Image?.SetActive(true);
            medium1Image?.SetActive(false);

            hard0Image?.SetActive(false);
            hard1Image?.SetActive(true);
        }

        // Funções auxiliares
        private void OnHomeButtonClick()
        {
            homeIcon0?.SetActive(false);
            homeIcon1?.SetActive(true);

            shopIcon0?.SetActive(true);
            shopIcon1?.SetActive(false);

            settingsIcon0?.SetActive(true);
            settingsIcon1?.SetActive(false);
        }

        private void OnShopButtonClick()
        {
            shopIcon0?.SetActive(false);
            shopIcon1?.SetActive(true);

            homeIcon0?.SetActive(true);
            homeIcon1?.SetActive(false);

            settingsIcon0?.SetActive(true);
            settingsIcon1?.SetActive(false);
        }

        private void OnSettingsButtonClick()
        {
            settingsIcon0?.SetActive(false);
            settingsIcon1?.SetActive(true);

            homeIcon0?.SetActive(true);
            homeIcon1?.SetActive(false);

            shopIcon0?.SetActive(true);
            shopIcon1?.SetActive(false);
        }

        // Deselect all difficulty highlights
        public void DeselectAllDifficulties()
        {
            easy1Image?.SetActive(false);
            medium1Image?.SetActive(false);
            hard1Image?.SetActive(false);
        }
    }
}