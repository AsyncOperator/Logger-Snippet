using UnityEngine;

public static class Logger {
    private const string CONDITIONAL_DEFINE = "ENABLE_LOGGER";

    #region Log

    /// <inheritdoc cref="Debug.Log(object)"/>
    [System.Diagnostics.Conditional(CONDITIONAL_DEFINE)]
    public static void Log(object message) => Debug.Log(message);

    /// <inheritdoc cref="Debug.Log(object, Object)"/>
    [System.Diagnostics.Conditional(CONDITIONAL_DEFINE)]
    public static void Log(object message, Object context) => Debug.Log(message, context);

    /// <inheritdoc cref="Debug.LogWarning(object)"/>
    [System.Diagnostics.Conditional(CONDITIONAL_DEFINE)]
    public static void LogWarning(object message) => Debug.LogWarning(message);

    /// <inheritdoc cref="Debug.LogWarning(object, Object)"/>
    [System.Diagnostics.Conditional(CONDITIONAL_DEFINE)]
    public static void LogWarning(object message, Object context) => Debug.LogWarning(message, context);

    /// <inheritdoc cref="Debug.LogError(object)"/>
    [System.Diagnostics.Conditional(CONDITIONAL_DEFINE)]
    public static void LogError(object message) => Debug.LogError(message);

    /// <inheritdoc cref="Debug.LogError(object,Object)"/>
    [System.Diagnostics.Conditional(CONDITIONAL_DEFINE)]
    public static void LogError(object message, Object context) => Debug.LogError(message, context);

    #endregion

    #region DrawLine

    /// <inheritdoc cref="Debug.DrawLine(Vector3, Vector3)"/>
    [System.Diagnostics.Conditional(CONDITIONAL_DEFINE)]
    public static void DrawLine(Vector3 start, Vector3 end) => Debug.DrawLine(start, end);

    /// <inheritdoc cref="Debug.DrawLine(Vector3, Vector3, Color)"/>
    [System.Diagnostics.Conditional(CONDITIONAL_DEFINE)]
    public static void DrawLine(Vector3 start, Vector3 end, Color color) => Debug.DrawLine(start, end, color);

    /// <inheritdoc cref="Debug.DrawLine(Vector3, Vector3, Color, float)"/>
    [System.Diagnostics.Conditional(CONDITIONAL_DEFINE)]
    public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration) => Debug.DrawLine(start, end, color, duration);

    /// <inheritdoc cref="Debug.DrawLine(Vector3, Vector3, Color, float, bool)"/>
    [System.Diagnostics.Conditional(CONDITIONAL_DEFINE)]
    public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration, bool depthTest) => Debug.DrawLine(start, end, color, duration, depthTest);

    #endregion

    #region DrawRay

    /// <inheritdoc cref="Debug.DrawRay(Vector3, Vector3)"/>
    [System.Diagnostics.Conditional(CONDITIONAL_DEFINE)]
    public static void DrawRay(Vector3 start, Vector3 dir) => Debug.DrawRay(start, dir);

    /// <inheritdoc cref="Debug.DrawRay(Vector3, Vector3, Color)"/>
    [System.Diagnostics.Conditional(CONDITIONAL_DEFINE)]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color) => Debug.DrawRay(start, dir, color);

    /// <inheritdoc cref="Debug.DrawRay(Vector3, Vector3, Color, float)"/>
    [System.Diagnostics.Conditional(CONDITIONAL_DEFINE)]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration) => Debug.DrawRay(start, dir, color, duration);

    /// <inheritdoc cref="Debug.DrawRay(Vector3, Vector3, Color, float, bool)"/>
    [System.Diagnostics.Conditional(CONDITIONAL_DEFINE)]
    public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest) => Debug.DrawRay(start, dir, color, duration, depthTest);

    #endregion
}