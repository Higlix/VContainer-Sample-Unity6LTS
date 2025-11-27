# VContainer Boot System Unity Template

A professional, scalable Unity game template designed for efficiency and clean architecture.

## Tech Stack

*   **VContainer:** Fast, "Solid" Dependency Injection.
*   **UniTask:** High-performance async/await for Unity.

## Architecture: Boot System

The project uses a robust **Single Entry Point** architecture to ensure all services are initialized before the game starts, regardless of which scene you press "Play" in.

### Boot Flow
1.  **RootLifetimeScope:** The global container. Holds singleton services (Analytics, Ads, SceneLoader).
2.  **EditorBootStrapper:** (Editor Only) Intercepts Play Mode to force-load the "Boot" scene if you start from a level, ensuring initialization always happens.
3.  **SingleEntryPoint:** The main orchestrator.
    *   Creates a temporary **BootLifetimeScope** (child scope).
    *   Runs `AppBootstrapper.BootAsync()` to initialize services sequentially (Analytics -> Ads -> Payments).
    *   Disposes the Boot scope.
    *   Uses `SceneLoaderService` to load the target scene (MainMenu or the level you tried to play).
