using UnityEngine;

[CreateAssetMenu(fileName = "RoomNodeType_", menuName = "Scriptable Objects/RoomNodeTypeSO")]
public class RoomNodeTypeSO : ScriptableObject
{
    public string roomNodeTypeName;

    #region Header
    [Header("Only flag the RoomNodeTypes that should be visible in the editor")]
    #endregion Header
    public bool displayInNodeGraphEditor = true;
    #region Header
    [Header("One Type Should Be Corridor")]
    #endregion Header
    public bool isCorridor;
    #region Header
    [Header("One Type Should Be CorridoNSr")]
    #endregion Header
    public bool isCorridorNS;
    #region Header
    [Header("One Type Should Be CorridorEW")]
    #endregion Header
    public bool isCorridorEW;
    #region Header
    [Header("One Type Should Be Entrance")]
    #endregion Header
    public bool isEntrance;

    #region Header
    [Header("One Type Should Be Boss Room")]
    #endregion Header
    public bool isBossRoom;
    #region Header
    [Header("One Type Should Be None (Unaddigned)")]
    #endregion Header
    public bool isNone;

    #region Validation
#if UNITY_EDITOR
    private void OnValidate()
    {
        HelperUltilities.ValidateCheckEmptyString(this, nameof(roomNodeTypeName), roomNodeTypeName);
    }
#endif

    #endregion Validation

}
