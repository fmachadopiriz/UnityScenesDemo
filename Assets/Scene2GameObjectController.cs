using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene2GameObjectController : MonoBehaviour
{
	public Button ToScene1;

	public Slider Slider;

	// Use this for initialization
	void Start () {
		Button button = ToScene1.GetComponent<Button>();
		button.onClick.AddListener(this.OnScene1ButtonPress);

		Slider slider = Slider.GetComponent<Slider>();
		slider.onValueChanged.AddListener(this.OnSliderValueChanged);
		slider.value = Singleton<Scene2Model>.Instance.Position;
	}
	
	public void OnScene1ButtonPress()
	{
		SceneManager.LoadScene("Scene1");
	}

	public void OnSliderValueChanged(float value)
	{
		Singleton<Scene2Model>.Instance.Position = value;
	}
}
