namespace TheHouseOfTheDead2Remake.Helpers;

public static class Videos
{
    /// <summary>
    /// A list of all video players for updating later if the user changes the resolution.
    /// </summary>
    internal static readonly List<MP_VideoPlayerController> VideoPlayers = [];

    /// <summary>
    /// A list of all video players for updating later if the user changes the resolution.
    /// </summary>
   // internal static readonly List<HD_EndingVideoPlayer> CreditsVideoPlayers = [];
    
    /// <summary>
    /// This is called when the user changes the resolution in the settings window to ensure the video player is updated.
    /// </summary>
    internal static void UpdateAllPlayers()
    {
        foreach (var player in VideoPlayers.Where(player => player))
        {
            UpdatePlayer(player);
        }

        // foreach (var player in CreditsVideoPlayers.Where(player => player))
        // {
        //     UpdateCreditsPlayer(player);
        // }
    }


    // /// <summary>
    // /// Forces VideoPlayer to fit vertically, and scales the raw image accordingly so that the video is maintained to 16:9 and not cut-off.
    // /// </summary>
    // private static void UpdateCreditsPlayer(HD_EndingVideoPlayer player)
    // {
    //     player.player.aspectRatio = VideoAspectRatio.FitVertically;
    //     var newScale = new Vector3( Resolutions.NegativeScaleFactor,  Resolutions.NegativeScaleFactor, 1f);
    //     var rawImage = player.GetComponentInChildren<RawImage>();
    //     if (rawImage)
    //     {
    //         rawImage.transform.localScale = newScale;
    //     }
    // }

    /// <summary>
    /// Forces VideoPlayer to fit vertically, and scales the raw image accordingly so that the video is maintained to 16:9 and not cut-off.
    /// </summary>
    public static void UpdatePlayer(MP_VideoPlayerController player)
    {
        player.videoPlayer.aspectRatio = VideoAspectRatio.FitVertically;
        var newScale = new Vector3(Resolutions.NegativeScaleFactor,  Resolutions.NegativeScaleFactor, 1f);
        if (player.rawImage)
        {
            player.rawImage.transform.localScale = newScale;
        }
    }
}