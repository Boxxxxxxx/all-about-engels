using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAvatarSpawner
{
    bool WorldRandomSpawnPositionDisabled { get; set; }

    GameObject GetPlayerRig();

}
