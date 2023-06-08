using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVideoStreamingManager
{
    public void PlayVideo(string url, Transform mediaSlotTransform, bool rotationReversal = false);
}
