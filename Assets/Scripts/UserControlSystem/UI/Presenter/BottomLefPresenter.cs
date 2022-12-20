using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Abstractions;

public class BottomLefPresenter : MonoBehaviour
{
    [SerializeField] private Image _selectedImage;
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private SelectableValue _selectedValue;


    private void Start()
    {
        _selectedValue.OnSelected += onSelected;
        onSelected(_selectedValue.CurrentValue);
    }

    private void onSelected(ISelectable selected)
    {
        _selectedImage.enabled = selected != null;
        _text.enabled = selected != null;
        if (selected != null)
        {
            _selectedImage.sprite = selected.Icon;
            _text.text = $"{selected.Health}/{selected.MaxHealth}";
            // var color = Color.Lerp(Color.red, Color.green, selected.Health / (float)selected.MaxHealth);
        }
    }
}
