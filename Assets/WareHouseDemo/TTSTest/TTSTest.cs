using UnityEngine;
using ReadSpeaker;
public class TTSTest : MonoBehaviour
{
    private TTSSpeaker speaker;
    public void Start()
    {
        TTS.Init();
        //TTS.GetEngine("adam", "N16");
        speaker = GetComponent<TTSSpeaker>();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TTS.SayAsync("Hi This is alok", speaker);
        }
    }
}