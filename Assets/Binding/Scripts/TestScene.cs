using UnityEngine;
using UnityEngine.UI;

public class TestScene : MonoBehaviour
{    
    void Start()
    {
        GetComponentInChildren<Button>().onClick.AddListener(() => {
            var msg = GetComponentInChildren<InputField>().text;
            AlertBinding.Alert(msg);
        });
    }
}
