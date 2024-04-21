using UnityEngine;
using UnityEngine.Video;

namespace AlexKiddMiracleWorldDX.MonoBehaviours;

public class VideoPlayerAspectCorrector : MonoBehaviour
{
    public VideoPlayer VideoPlayer;


    private void Start()
    {
        Plugin.LOG.LogInfo($"Video Player Aspect Corrector started on {gameObject.name}");
        VideoPlayer = GetComponent<VideoPlayer>();
    }


    private void LateUpdate()
    {
        // if (VideoPlayer.isPlaying)
        // {
        if (VideoPlayer)
        {
            VideoPlayer.aspectRatio = VideoAspectRatio.FitVertically;   
        }
         
        // }
    }

}