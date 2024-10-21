using UnityEngine;

public class ApplicationExitController : MonoBehaviour
{
    public void TriggerExit()
    {
#if UNITY_EDITOR
        StopEditorPlayMode();
#else
            QuitApplication();
#endif
    }

    private void StopEditorPlayMode()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    private void QuitApplication()
    {
        Application.Quit();
    }
}