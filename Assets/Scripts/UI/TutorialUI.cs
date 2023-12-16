using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TutorialUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI kb_moveUpText;
    [SerializeField] private TextMeshProUGUI kb_moveDownText;
    [SerializeField] private TextMeshProUGUI kb_moveLeftText;
    [SerializeField] private TextMeshProUGUI kb_moveRightText;
    [SerializeField] private TextMeshProUGUI kb_interactText;
    [SerializeField] private TextMeshProUGUI kb_interactAlternateText;
    [SerializeField] private TextMeshProUGUI kb_pauseText;
    [SerializeField] private TextMeshProUGUI gamepad_interactText;
    [SerializeField] private TextMeshProUGUI gamepad_interactAlternateText;
    [SerializeField] private TextMeshProUGUI gamepad_pauseText;


    private void Start()
    {
        GameInput.Instance.OnBindingRebind += GameInput_OnBindingRebind;
        KitchenGameManager.Instance.OnStateChanged += GameInput_OnStateChanged;
        UpdateVisual();
        Show();
    }

    private void GameInput_OnStateChanged(object sender, System.EventArgs e)
    {
        if (KitchenGameManager.Instance.IsCountdownToStartActive())
        {
            Hide();
        }
    }

    private void GameInput_OnBindingRebind(object sender, System.EventArgs e)
    {
       UpdateVisual();
    }

    private void UpdateVisual()
    {
        kb_moveUpText.text = GameInput.Instance.GetBindingText(GameInput.Binding.Move_Up);
        kb_moveDownText.text = GameInput.Instance.GetBindingText(GameInput.Binding.Move_Down);
        kb_moveLeftText.text = GameInput.Instance.GetBindingText(GameInput.Binding.Move_Left);
        kb_moveRightText.text = GameInput.Instance.GetBindingText(GameInput.Binding.Move_Right);
        kb_interactText.text = GameInput.Instance.GetBindingText(GameInput.Binding.Interact);
        kb_interactAlternateText.text = GameInput.Instance.GetBindingText(GameInput.Binding.InteractAlternate);
        kb_pauseText.text = GameInput.Instance.GetBindingText(GameInput.Binding.Pause);
        gamepad_interactText.text = GameInput.Instance.GetBindingText(GameInput.Binding.Gamepad_Interact);
        gamepad_interactAlternateText.text = GameInput.Instance.GetBindingText(GameInput.Binding.Gamepad_InteractAlternate);
        gamepad_pauseText.text = GameInput.Instance.GetBindingText(GameInput.Binding.Gamepad_Pause);
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }
    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
