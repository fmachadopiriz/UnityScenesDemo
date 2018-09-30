using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene1GameObjectController : MonoBehaviour
{
	public Button ToScene2;
    public InputField Text;

	// Use this for initialization
	void Start () {
		Button button = ToScene2.GetComponent<Button>();
		button.onClick.AddListener(this.OnScene1ButtonPress);

        InputField inputField = Text.GetComponent<InputField>();
        inputField.onEndEdit.AddListener(this.OnTextEndEdit);
        inputField.text = Singleton<Scene1Model>.Instance.Text;
	}
	
	public void OnScene1ButtonPress()
	{
		SceneManager.LoadScene("Scene2");
	}

    public void OnTextEndEdit(string text)
    {
        Singleton<Scene1Model>.Instance.Text = text;
    }
}
