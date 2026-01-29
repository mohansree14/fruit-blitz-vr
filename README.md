# Fruit Blitz VR (Meta Quest 2)

A VR fruit-slicing game built in Unity for **Meta Quest 2**.
This project was developed as a university coursework VR prototype and is inspired by the core feel of Fruit Ninja (slice targets with a fast hand/controller motion).

## Quick Overview

- **Platform:** Meta Quest 2 (Android)
- **Engine:** Unity `2021.3.16f1`
- **XR:** XR Interaction Toolkit + OpenXR (see `ProjectSettings/` and `Packages/`)
- **Scenes in Build:**
  - `Assets/Scenes/Game Menu Scene.unity`
  - `Assets/Scenes/Sword Scene.unity`
  - `Assets/Scenes/Archer Scene.unity`

## Demo Video

- Watch: https://drive.google.com/file/d/1XOF3ttsuJdCYPZf1vPpFGe26T8O0R1tw/view?usp=sharing

## Gameplay

- Slice incoming objects using your controller/weapon.
- Each successful slice increases score (+10).
- Bombs reduce hearts (starts at 3). At 0 hearts you get **Game Over**.

## How Slicing Works (at a glance)

Slicing uses a line-cast between two points on the blade/controller every physics tick. When it intersects a sliceable object, the mesh is cut using **EzySlice**, then the halves are given rigidbodies and pushed apart.

## Run In Editor

1. Open the project folder in **Unity Hub**.
2. Open `Assets/Scenes/Game Menu Scene.unity`.
3. Press Play.

Note: For proper VR input, run using an XR-capable setup (or your preferred XR simulation workflow).

## Build to Meta Quest 2

1. Install Unity Android modules via Unity Hub (Android Build Support + SDK/NDK + OpenJDK).
2. In Unity: **File → Build Settings… → Android → Switch Platform**.
3. Ensure the three gameplay scenes are present/enabled in **Scenes In Build**.
4. Connect your Quest 2 via USB (Developer Mode enabled).
5. **Build And Run**.

## Repo Notes

- This repo intentionally ignores Unity-generated folders like `Library/`, `Temp/`, and `obj/`.
- PDF “reports”/documents are ignored via `.gitignore` (see the bottom of that file).
- If you encounter large-file push issues, consider Git LFS for big binary assets.
