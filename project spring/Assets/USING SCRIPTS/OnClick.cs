using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class OnClick : MonoBehaviour
{
	public Button yourButton;
	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}
}