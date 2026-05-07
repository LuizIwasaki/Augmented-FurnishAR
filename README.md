# FurnishAR: Augmented Reality Interior Design

![Unity](https://img.shields.io/badge/Unity-2021.3.30f1-blueviolet?logo=unity)
![AR Foundation](https://img.shields.io/badge/AR_Foundation-Ready-blue?logo=google-ar)
![Platform](https://img.shields.io/badge/Platform-Android%20%7C%20iOS-lightgrey)

**FurnishAR** is a high-fidelity Augmented Reality (AR) application built with Unity and AR Foundation. It allows users to visualize furniture and decor in their real-world environment before making a purchase. By leveraging advanced surface detection and spatial tracking, FurnishAR provides a seamless "try before you buy" experience.

---
---

## 🌟 Key Features

- **Real-time Surface Detection**: Automatically identifies horizontal planes (floors, tables) for stable object placement.
- **Dynamic Furniture Placement**: Interactive placement of 3D models with accurate scaling and rotation.
- **Multi-Object Management**: Place multiple items in the same scene to design entire rooms.
- **Furniture Catalog**: Easy-to-use UI to switch between different furniture types (Sofas, Chairs, Tables, etc.).
- **Smart Removal**: Clear specific objects or reset the entire scene with a single tap.
- **Responsive UI**: Modern, glassmorphic interface designed for optimal mobile UX.

---

## 🛠️ Tech Stack

- **Engine**: Unity 2021.3.30f1 (LTS)
- **Framework**: AR Foundation (ARCore / ARKit)
- **Scripting**: C# (Asynchronous logic for smooth tracking)
- **UI System**: Unity UI (uGUI) with TextMesh Pro

---

## 🚀 Getting Started

### Prerequisites

- **Unity Hub** installed.
- **Unity 2021.3.30f1** or newer.
- An AR-compatible device:
  - **Android**: ARCore supported device.
  - **iOS**: ARKit supported device (iPhone 6s or newer).

### Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/LuizIwasaki/Augmented-FurnishAR.git
   cd Augmented-FurnishAR/FurnishAR
   ```

2. **Open in Unity**:
   - Open Unity Hub.
   - Click **Add** and select the `FurnishAR` folder.
   - Wait for the project to resolve dependencies and import assets.

3. **Build & Run**:
   - Go to `File > Build Settings`.
   - Select your target platform (**Android** or **iOS**).
   - Ensure the main scene in `Assets/Scenes/` is added to the build.
   - Click **Build and Run**.

---

## 📱 How to Use

1. **Scan your Environment**: Move your phone around to allow AR Foundation to detect floor planes (indicated by visual grids).
2. **Select Furniture**: Use the bottom menu to choose a furniture item.
3. **Place**: Tap on any detected plane to instantiate the model.
4. **Interact**: Use touch gestures to reposition or rotate objects (if supported by active scripts).
5. **Clear**: Use the "Clear" button to remove all placed items and start over.

---

## 📂 Project Structure

- `Assets/Scripts/`: Core C# logic for AR interactions.
  - `FurniturePlacementManager.cs`: Handles raycasting and object spawning.
  - `ObjectRemovalManager.cs`: Manages the lifecycle of placed objects.
- `Assets/Prefabs/`: Optimized 3D models for mobile AR.
- `Assets/Scenes/`: Pre-configured AR scenes.
- `Assets/XR/`: Configuration for ARCore/ARKit providers.

---

## 🤝 Contributing

Contributions are welcome! If you'd like to improve FurnishAR, please:
1. Fork the repository.
2. Create a feature branch (`git checkout -b feature/NewAwesomeFeature`).
3. Commit your changes (`git commit -m 'Add some NewAwesomeFeature'`).
4. Push to the branch (`git push origin feature/NewAwesomeFeature`).
5. Open a Pull Request.

---

## 📜 License

Distributed under the MIT License. See `LICENSE` for more information.

---

*Developed with ❤️ by [Luiz Iwasaki](https://github.com/LuizIwasaki)*
