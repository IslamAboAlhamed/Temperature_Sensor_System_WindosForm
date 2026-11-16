# 🌡️ TEMP MONITOR
### Temperature Sensor System Windos Form
<p align="center">
  <img src="https://img.shields.io/badge/Language-C%23-purple?style=for-the-badge&logo=csharp" />
  <img src="https://img.shields.io/badge/Platform-Windows-blue?style=for-the-badge&logo=windows" />
  <img src="https://img.shields.io/badge/Framework-.NET%204.8-512BD4?style=for-the-badge&logo=dotnet" />
  <img src="https://img.shields.io/badge/Project-Console%20Application-black?style=for-the-badge" />
</p>

### 🔵 LOW TEMPERATURE
<p align="center">
  <img width="1582" height="785" alt="image" src="https://github.com/user-attachments/assets/2762a6f6-cc78-49a0-8764-c28d60dcd7d1" />


</p>

### 🟢 NORMAL TEMPERATURE
<p align="center">
<img width="1582" height="780" alt="image" src="https://github.com/user-attachments/assets/29ee746c-4061-4c27-be72-77c6465bdb67" />


</p>

### 🔴 CRITICAL TEMPERATURE
<p align="center">
 <img width="1577" height="778" alt="image" src="https://github.com/user-attachments/assets/f91b3257-174b-4309-94a6-260f1f007691" />


</p>


---

## 📌 About The Project

**Temperature Sensor System** is a desktop application developed using C# and Windows Forms to demonstrate the concept of **Event-Driven Programming**.

The application simulates a temperature monitoring system where users can set, increase, and decrease temperature values while automatically tracking every temperature change through custom Events and Event Handlers.

## ✨ Features

- 🌡️ Display current temperature.
- 📊 Visual temperature gauge.
- ➕ Increase temperature.
- ➖ Decrease temperature.
- 🎯 Set custom temperature values.
- 📝 Track temperature changes in a history log.
- 🔔 Automatic Event Notification.
- 📉 Calculate the difference between old and new temperatures.

## 🛠️ Technologies & Concepts

| Technology                | Usage                            |
| ------------------------- | -------------------------------- |
| C#                        | Main Programming Language        |
| Windows Forms             | Graphical User Interface         |
| Delegates                 | Event Handling Mechanism         |
| Events                    | Temperature Change Notifications |
| EventHandler\<TEventArgs> | Custom Event Communication       |
| Custom EventArgs          | Passing Temperature Information  |

## 🧠 How It Works

The application follows an Event-Driven Architecture:

1. The user changes the temperature.
2. The `Thermostat` class updates the temperature.
3. The `ThermostatChanged` event is triggered.
4. The Event Handler receives the temperature change information.
5. The UI updates the displayed temperature.
6. The change is recorded in the history log.

## 🏗️ Project Architecture

```text
Temperature Sensor System
│
├── Thermostat
│   ├── CurrentTemperature
│   ├── SetTemperature()
│   └── ThermostatChanged Event
│
├── TemperatureChangedEventArgs
│   ├── OldTemperature
│   ├── NewTemperature
│   └── Difference
│
└── Form1
    ├── Event Subscription
    ├── Event Handler
    ├── Temperature Display
    └── History Log
```

## 📸 Screenshots

\<p align="center">   \<img src="Screenshots/Dashboard.png" alt="Application Dashboard" width="850"/> \</p>

## 🚀 Getting Started

### Prerequisites

- Visual Studio
- C#
- Windows Forms
- Compatible .NET Framework

### Installation

1. Clone the repository:

```bash
git clone https://github.com/IslamAboAlhamed/Temperature_Sensor_System.git
```

2. Open the solution file in Visual Studio.

3. Build the project.

4. Run the application.

## 🎯 Learning Objectives

This project was created to practice and understand:

- Delegates in C#.
- Custom Events.
- Event Subscription.
- Event Handling.
- Custom Event Arguments.
- Separation of UI and Business Logic.

## 🔮 Future Improvements

- Connect a real temperature sensor.
- Add temperature alerts.
- Save temperature history to a database.
- Display temperature statistics.
- Add temperature charts.

## 👨‍💻 Author

**Islam Abo Alhamed**

GitHub: [@IslamAboAlhamed](https://github.com/IslamAboAlhamed)

---

\<p align="center">
&#x20; ⭐ If you find this project useful, consider giving it a star!
\</p>

</p>
