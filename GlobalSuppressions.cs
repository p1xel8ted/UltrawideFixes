using System.Diagnostics.CodeAnalysis;

// Global suppressions for analyzer warnings that conflict with Harmony naming conventions

[assembly: SuppressMessage("Naming", "IDE1006:Naming Styles", Justification = "Harmony uses special parameter names like __instance, __state and __result for patches.")]
[assembly: SuppressMessage("Style", "SA1300:Element should begin with an upper-case letter", Justification = "Harmony patch parameter names intentionally use underscores and lower-case to match community conventions.")]
[assembly: SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "Harmony patch parameters intentionally use underscores (e.g. __instance) to be explicit about their purpose.")]

